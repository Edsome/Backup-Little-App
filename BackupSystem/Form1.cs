using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace BackupSystem
{
    public enum Commands { help, exit, clear, backup };
    public partial class FormMain : Form
    {
        //------------------------------------------------------------------------------------
        string Version = "1.3"; //The version of this application
        string FromPath, ToPath; //To save the path user selected
        string sPath, FolderName;
        int Frequency = 0; //Backup Frequency
        int sFrequency, sHrs, sMin, sSec; //For next backup countdown
        int MsToS = 1000; //Convert Microsecond to second
        bool IfPathPassed = false; //To know if user finish the form
        //------------------------------------------------------------------------------------
        public FormMain()
        {
            InitializeComponent();
            //把裝置代碼加入ListBox裡  
            List<string> list = get_all_logic_driver();
            foreach (string drive in list)
                ListboxCommand.Items.Add(drive);
        }
        private List<string> get_all_logic_driver()
        {
            List<string> list = new List<string>();
            list.Add("Drive(s) Detected : ");
            foreach (string drive in Environment.GetLogicalDrives())
            {
                list.Add(drive);
            }
            return list;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = "HsinLink Data Backup System " + Version;
            ButtonStopBackup.Enabled = false;
            ButtonFastBackup.Enabled = false;
            ComboBoxFreq.Items.Add("每6小時");
            ComboBoxFreq.Items.Add("每12小時");
            ComboBoxFreq.Items.Add("每天");
            ComboBoxFreq.Items.Add("每兩天");
            ComboBoxFreq.Items.Add("每禮拜");
            ComboBoxFreq.Items.Add("自訂");
            ComboBoxFreq.SelectedIndex = 2;
        }
        private string getPath()
        {
            FolderBrowserDialogFromnTo.ShowDialog();
            return FolderBrowserDialogFromnTo.SelectedPath;
        } //To get the path that user selected
        private void DetectIfExist() //To detect if the file(s) or folder(s) exist
        {
            if (Directory.Exists(TextBoxFrom.Text))
            {
                if (Directory.Exists(TextBoxTo.Text))
                {
                    switch (ComboBoxFreq.SelectedIndex)
                    {
                        case 0:
                            Frequency = 21600 * MsToS; //Every 6 hrs
                            break;
                        case 1:
                            Frequency = 43200 * MsToS; //Every 12 hrs
                            break;
                        case 2:
                            Frequency = 86400 * MsToS; //Every day
                            break;
                        case 3:
                            Frequency = 172800 * MsToS; //Every 2 days
                            break;
                        case 4:
                            Frequency = 604800 * MsToS; //Every week
                            break;
                        case 5:
                            int i;
                            if (int.TryParse(TextBoxCustomize.Text, out i) == true)
                            {
                                Frequency = Convert.ToInt32(TextBoxCustomize.Text) * MsToS;//Customize
                                //MessageBox.Show("test done!");
                            }
                            else
                            {
                                MessageBox.Show("請輸入整數(Integer Only)。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        default:
                            Frequency = 86400 * MsToS;
                            MessageBox.Show("您尚未設定備份頻率。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                    }
                }
                else
                {
                    MessageBox.Show("您尚未設定備份的路徑或設定的路徑有誤。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("您尚未設定要備份的資料夾或設定的路徑有誤。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IfPathPassed = true;
        }
        private void Finished()
        {
            TimerFreq.Enabled = true;
            TimerFreq.Interval = Frequency;
            TimerFreq.Start();
            TimerCountDown.Enabled = true;
            TimerCountDown.Interval = 1000;
            TimerCountDown.Start();

            ButtonStopBackup.Enabled = true;
            sFrequency = Frequency / 1000;
            FromPath = TextBoxFrom.Text;
            ToPath = TextBoxTo.Text;
            MessageBox.Show("已完成設定，目前會以「" + ComboBoxFreq.SelectedItem + "」的頻率備份。", "完成");
        }//Run this after backup setup
        public void exit()
        {
            System.Environment.Exit(System.Environment.ExitCode);
        } //To exit
        public void showlog(string x)
        {
            ListboxCommand.Items.Add(x);
            this.ListboxCommand.SelectedIndex = this.ListboxCommand.Items.Count - 1;
        }//Show the log on the listbox
        private void ShowAllCommands()
        {
            showlog("Available Commands :");
            //Commands cmds = new Commands();
            foreach (string str in Enum.GetNames(typeof(Commands)))
            {
                showlog(str);
            }
            showlog("");
        }//Funtion
        private void ClearCommands()
        {
            ListboxCommand.Items.Clear();
        }
        private void ReadyToBackup()
        {
            showlog("Command accessed.");
            showlog("Please wait...");
            showlog("Please enter the folder you want to backup:");
            showlog("Sorry, this function is currenly unavailable.");
        }
        public void InputCommands()
        {
            string cmd = TextboxCommand.Text;
            switch (cmd)
            {
                case "exit":
                    exit();
                    break;
                case "help":
                    ShowAllCommands();
                    break;
                case "clear":
                    ClearCommands();
                    break;
                case "backup":
                    ReadyToBackup();
                    break;
                default:
                    showlog("This command is not exist in the library.");
                    showlog("If you don't know the available commands, type \"help\" in the console.");
                    showlog("");
                    break;
            }
            TextboxCommand.Text = "";
        }
        //-------------------------------Backup Code---------------------------------------
        private void Backup() //To start backup folder(s)
        {
            FolderName = DateTime.Now.ToString("yyyyMMdd-HHmmss"); //Set backup folder's name
            sPath = ToPath + "\\" + FolderName;
            System.IO.Directory.CreateDirectory(sPath);

            LabelLastBackupPath.Text = "上次備份路徑: " + sPath;
            DirectoryCopy(FromPath, sPath, true);
        }
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
        //-------------------------------------------------------------------------------------
        private void ButtonBrowse1_Click(object sender, EventArgs e)
        {
            TextBoxFrom.Text = getPath();
        }
        private void ButtonBrowse2_Click(object sender, EventArgs e)
        {
            TextBoxTo.Text = getPath();
        }
        private void ButtonBrowse3_Click(object sender, EventArgs e)
        {
            TextBoxLog.Text = getPath();
        }
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            DetectIfExist();
            if (IfPathPassed == true)
            {
                Finished();
                ButtonFastBackup.Enabled = true;
                if (CheckBoxFastBackup.Checked == true)
                {
                    Backup();
                }
            }
        }
        private void ButtonFastBackup_Click(object sender, EventArgs e)
        {
            DetectIfExist();
            Backup();
        }
        private void ButtonStopBackup_Click(object sender, EventArgs e)
        {
            if (ButtonStopBackup.Text == "停止備份")
            {
                ButtonStopBackup.Text = "繼續備份";
                TimerFreq.Stop();
                TimerCountDown.Stop();
            }
            else
            {
                ButtonStopBackup.Text = "停止備份";
                TimerFreq.Start();
                TimerCountDown.Start();
            }
        }
        private void ButtonBackGround_Click(object sender, EventArgs e)
        {
            this.BackgroundWorkerBackup.RunWorkerAsync();
        }
        private void ButtonOpenLastPath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(sPath))
            {
                System.Diagnostics.Process.Start(sPath);
            }
            else
            {
                MessageBox.Show("該路徑不存在。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TextBoxFrom_Click(object sender, EventArgs e)
        {
            TextBoxFrom.Text = "";
        }
        private void TextBoxTo_Click(object sender, EventArgs e)
        {
            TextBoxTo.Text = "";
        }
        private void ButtonInputCommand_Click(object sender, EventArgs e)
        {
            InputCommands();
        }
        private void TextBoxCustomize_Click(object sender, EventArgs e)
        {
            TextBoxCustomize.Text = "";
        }
        private void TextboxCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InputCommands();
            }
        }
        private void TimerFreq_Tick(object sender, EventArgs e)
        {
            Backup();
        }
        private void TimerCountDown_Tick(object sender, EventArgs e)
        {
            sFrequency -= 1;
            if (sFrequency == 0)
            {
                sFrequency = Frequency / 1000;
            }
            sHrs = sFrequency / 3600;
            sMin = (sFrequency %3600) / 60;
            sSec = (sFrequency % 60) % 60;

            LabelNextBackup.Text = "下次備份時間: " + sHrs + " 小時 " + sMin + " 分鐘 " + sSec + " 秒 ";
        }
        private void BackgroundWorkerBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }
        private void BackgroundWorkerBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                MessageBox.Show("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // The operation completed normally.
                string msg = String.Format("Result = {0}", e.Result);
                MessageBox.Show(msg);
            }
        }
    }
}