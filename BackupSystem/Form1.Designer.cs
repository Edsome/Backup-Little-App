namespace BackupSystem
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FolderBrowserDialogFromnTo = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxFrom = new System.Windows.Forms.TextBox();
            this.TextBoxTo = new System.Windows.Forms.TextBox();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.ButtonBrowse1 = new System.Windows.Forms.Button();
            this.ButtonBrowse2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonBrowse3 = new System.Windows.Forms.Button();
            this.TextBoxCustomize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelLastBackupPath = new System.Windows.Forms.Label();
            this.LabelNextBackup = new System.Windows.Forms.Label();
            this.ComboBoxFreq = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.ButtonBackGround = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CheckBoxFastBackup = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonOpenLastPath = new System.Windows.Forms.Button();
            this.ButtonStopBackup = new System.Windows.Forms.Button();
            this.ButtonFastBackup = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GroupTest = new System.Windows.Forms.GroupBox();
            this.ButtonInputCommand = new System.Windows.Forms.Button();
            this.ListboxCommand = new System.Windows.Forms.ListBox();
            this.TextboxCommand = new System.Windows.Forms.TextBox();
            this.TimerFreq = new System.Windows.Forms.Timer(this.components);
            this.BackgroundWorkerBackup = new System.ComponentModel.BackgroundWorker();
            this.TimerCountDown = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.TabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GroupTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "備份路徑:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "備份資料夾:";
            // 
            // TextBoxFrom
            // 
            this.TextBoxFrom.Location = new System.Drawing.Point(92, 20);
            this.TextBoxFrom.Name = "TextBoxFrom";
            this.TextBoxFrom.Size = new System.Drawing.Size(451, 22);
            this.TextBoxFrom.TabIndex = 1;
            this.TextBoxFrom.Text = "輸入想要備份的資料夾";
            this.TextBoxFrom.Click += new System.EventHandler(this.TextBoxFrom_Click);
            // 
            // TextBoxTo
            // 
            this.TextBoxTo.Location = new System.Drawing.Point(92, 48);
            this.TextBoxTo.Name = "TextBoxTo";
            this.TextBoxTo.Size = new System.Drawing.Size(451, 22);
            this.TextBoxTo.TabIndex = 2;
            this.TextBoxTo.Text = "輸入備份的目的地";
            this.TextBoxTo.Click += new System.EventHandler(this.TextBoxTo_Click);
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Location = new System.Drawing.Point(6, 264);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(300, 35);
            this.ButtonConfirm.TabIndex = 4;
            this.ButtonConfirm.Text = "完成設定";
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // ButtonBrowse1
            // 
            this.ButtonBrowse1.Location = new System.Drawing.Point(549, 20);
            this.ButtonBrowse1.Name = "ButtonBrowse1";
            this.ButtonBrowse1.Size = new System.Drawing.Size(46, 22);
            this.ButtonBrowse1.TabIndex = 6;
            this.ButtonBrowse1.Text = "瀏覽";
            this.ButtonBrowse1.UseVisualStyleBackColor = true;
            this.ButtonBrowse1.Click += new System.EventHandler(this.ButtonBrowse1_Click);
            // 
            // ButtonBrowse2
            // 
            this.ButtonBrowse2.Location = new System.Drawing.Point(549, 48);
            this.ButtonBrowse2.Name = "ButtonBrowse2";
            this.ButtonBrowse2.Size = new System.Drawing.Size(46, 22);
            this.ButtonBrowse2.TabIndex = 7;
            this.ButtonBrowse2.Text = "瀏覽";
            this.ButtonBrowse2.UseVisualStyleBackColor = true;
            this.ButtonBrowse2.Click += new System.EventHandler(this.ButtonBrowse2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonBrowse2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ButtonBrowse1);
            this.groupBox1.Controls.Add(this.TextBoxLog);
            this.groupBox1.Controls.Add(this.TextBoxFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TextBoxTo);
            this.groupBox1.Controls.Add(this.ButtonBrowse3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "路徑設定";
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.Enabled = false;
            this.TextBoxLog.Location = new System.Drawing.Point(92, 76);
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.Size = new System.Drawing.Size(451, 22);
            this.TextBoxLog.TabIndex = 10;
            this.TextBoxLog.Text = "目前不可用，請待日後更新";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "備份資訊路徑:";
            // 
            // ButtonBrowse3
            // 
            this.ButtonBrowse3.Enabled = false;
            this.ButtonBrowse3.Location = new System.Drawing.Point(549, 76);
            this.ButtonBrowse3.Name = "ButtonBrowse3";
            this.ButtonBrowse3.Size = new System.Drawing.Size(46, 22);
            this.ButtonBrowse3.TabIndex = 11;
            this.ButtonBrowse3.Text = "瀏覽";
            this.ButtonBrowse3.UseVisualStyleBackColor = true;
            this.ButtonBrowse3.Click += new System.EventHandler(this.ButtonBrowse3_Click);
            // 
            // TextBoxCustomize
            // 
            this.TextBoxCustomize.Location = new System.Drawing.Point(80, 50);
            this.TextBoxCustomize.Name = "TextBoxCustomize";
            this.TextBoxCustomize.Size = new System.Drawing.Size(463, 22);
            this.TextBoxCustomize.TabIndex = 13;
            this.TextBoxCustomize.Text = "輸入自訂數值(單位 : 秒)";
            this.TextBoxCustomize.Click += new System.EventHandler(this.TextBoxCustomize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "自定義參數:";
            // 
            // LabelLastBackupPath
            // 
            this.LabelLastBackupPath.AutoSize = true;
            this.LabelLastBackupPath.Location = new System.Drawing.Point(7, 213);
            this.LabelLastBackupPath.Name = "LabelLastBackupPath";
            this.LabelLastBackupPath.Size = new System.Drawing.Size(80, 12);
            this.LabelLastBackupPath.TabIndex = 9;
            this.LabelLastBackupPath.Text = "上次備份路徑:";
            // 
            // LabelNextBackup
            // 
            this.LabelNextBackup.AutoSize = true;
            this.LabelNextBackup.Location = new System.Drawing.Point(7, 239);
            this.LabelNextBackup.Name = "LabelNextBackup";
            this.LabelNextBackup.Size = new System.Drawing.Size(80, 12);
            this.LabelNextBackup.TabIndex = 9;
            this.LabelNextBackup.Text = "下次備份時間:";
            // 
            // ComboBoxFreq
            // 
            this.ComboBoxFreq.FormattingEnabled = true;
            this.ComboBoxFreq.Location = new System.Drawing.Point(80, 22);
            this.ComboBoxFreq.Name = "ComboBoxFreq";
            this.ComboBoxFreq.Size = new System.Drawing.Size(143, 20);
            this.ComboBoxFreq.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "備份頻率:";
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.tabPage1);
            this.TabControlMain.Controls.Add(this.tabPage2);
            this.TabControlMain.Location = new System.Drawing.Point(1, 1);
            this.TabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(624, 411);
            this.TabControlMain.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonTest);
            this.tabPage1.Controls.Add(this.ButtonBackGround);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.ButtonOpenLastPath);
            this.tabPage1.Controls.Add(this.ButtonStopBackup);
            this.tabPage1.Controls.Add(this.ButtonFastBackup);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.LabelLastBackupPath);
            this.tabPage1.Controls.Add(this.ButtonConfirm);
            this.tabPage1.Controls.Add(this.LabelNextBackup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "備份";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtonTest
            // 
            this.ButtonTest.Enabled = false;
            this.ButtonTest.Location = new System.Drawing.Point(310, 264);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(300, 35);
            this.ButtonTest.TabIndex = 15;
            this.ButtonTest.Text = "TEST";
            this.ButtonTest.UseVisualStyleBackColor = true;
            // 
            // ButtonBackGround
            // 
            this.ButtonBackGround.Enabled = false;
            this.ButtonBackGround.Location = new System.Drawing.Point(310, 305);
            this.ButtonBackGround.Name = "ButtonBackGround";
            this.ButtonBackGround.Size = new System.Drawing.Size(300, 35);
            this.ButtonBackGround.TabIndex = 14;
            this.ButtonBackGround.Text = "背景執行";
            this.ButtonBackGround.UseVisualStyleBackColor = true;
            this.ButtonBackGround.Click += new System.EventHandler(this.ButtonBackGround_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CheckBoxFastBackup);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ComboBoxFreq);
            this.groupBox3.Controls.Add(this.TextBoxCustomize);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(6, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 81);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "時間設定";
            // 
            // CheckBoxFastBackup
            // 
            this.CheckBoxFastBackup.AutoSize = true;
            this.CheckBoxFastBackup.Location = new System.Drawing.Point(229, 24);
            this.CheckBoxFastBackup.Name = "CheckBoxFastBackup";
            this.CheckBoxFastBackup.Size = new System.Drawing.Size(132, 16);
            this.CheckBoxFastBackup.TabIndex = 17;
            this.CheckBoxFastBackup.Text = "完成設定後立即備份";
            this.CheckBoxFastBackup.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(549, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "瀏覽";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ButtonOpenLastPath
            // 
            this.ButtonOpenLastPath.Location = new System.Drawing.Point(310, 346);
            this.ButtonOpenLastPath.Name = "ButtonOpenLastPath";
            this.ButtonOpenLastPath.Size = new System.Drawing.Size(300, 35);
            this.ButtonOpenLastPath.TabIndex = 12;
            this.ButtonOpenLastPath.Text = "開啟上次備份資料夾";
            this.ButtonOpenLastPath.UseVisualStyleBackColor = true;
            this.ButtonOpenLastPath.Click += new System.EventHandler(this.ButtonOpenLastPath_Click);
            // 
            // ButtonStopBackup
            // 
            this.ButtonStopBackup.Location = new System.Drawing.Point(6, 346);
            this.ButtonStopBackup.Name = "ButtonStopBackup";
            this.ButtonStopBackup.Size = new System.Drawing.Size(300, 35);
            this.ButtonStopBackup.TabIndex = 12;
            this.ButtonStopBackup.Text = "停止備份";
            this.ButtonStopBackup.UseVisualStyleBackColor = true;
            this.ButtonStopBackup.Click += new System.EventHandler(this.ButtonStopBackup_Click);
            // 
            // ButtonFastBackup
            // 
            this.ButtonFastBackup.Location = new System.Drawing.Point(6, 305);
            this.ButtonFastBackup.Name = "ButtonFastBackup";
            this.ButtonFastBackup.Size = new System.Drawing.Size(300, 35);
            this.ButtonFastBackup.TabIndex = 13;
            this.ButtonFastBackup.Text = "立即備份";
            this.ButtonFastBackup.UseVisualStyleBackColor = true;
            this.ButtonFastBackup.Click += new System.EventHandler(this.ButtonFastBackup_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GroupTest);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Command Center";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GroupTest
            // 
            this.GroupTest.Controls.Add(this.ButtonInputCommand);
            this.GroupTest.Controls.Add(this.ListboxCommand);
            this.GroupTest.Controls.Add(this.TextboxCommand);
            this.GroupTest.Location = new System.Drawing.Point(7, 6);
            this.GroupTest.Name = "GroupTest";
            this.GroupTest.Size = new System.Drawing.Size(600, 373);
            this.GroupTest.TabIndex = 0;
            this.GroupTest.TabStop = false;
            this.GroupTest.Text = "開發測試";
            // 
            // ButtonInputCommand
            // 
            this.ButtonInputCommand.Location = new System.Drawing.Point(407, 345);
            this.ButtonInputCommand.Name = "ButtonInputCommand";
            this.ButtonInputCommand.Size = new System.Drawing.Size(41, 22);
            this.ButtonInputCommand.TabIndex = 2;
            this.ButtonInputCommand.Text = "Input";
            this.ButtonInputCommand.UseVisualStyleBackColor = true;
            this.ButtonInputCommand.Click += new System.EventHandler(this.ButtonInputCommand_Click);
            // 
            // ListboxCommand
            // 
            this.ListboxCommand.FormattingEnabled = true;
            this.ListboxCommand.ItemHeight = 12;
            this.ListboxCommand.Location = new System.Drawing.Point(6, 21);
            this.ListboxCommand.Name = "ListboxCommand";
            this.ListboxCommand.Size = new System.Drawing.Size(442, 316);
            this.ListboxCommand.TabIndex = 1;
            // 
            // TextboxCommand
            // 
            this.TextboxCommand.Location = new System.Drawing.Point(6, 345);
            this.TextboxCommand.Name = "TextboxCommand";
            this.TextboxCommand.Size = new System.Drawing.Size(395, 22);
            this.TextboxCommand.TabIndex = 0;
            this.TextboxCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxCommand_KeyDown);
            // 
            // TimerFreq
            // 
            this.TimerFreq.Tick += new System.EventHandler(this.TimerFreq_Tick);
            // 
            // BackgroundWorkerBackup
            // 
            this.BackgroundWorkerBackup.WorkerSupportsCancellation = true;
            this.BackgroundWorkerBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerBackup_DoWork);
            this.BackgroundWorkerBackup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerBackup_RunWorkerCompleted);
            // 
            // TimerCountDown
            // 
            this.TimerCountDown.Tick += new System.EventHandler(this.TimerCountDown_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 414);
            this.Controls.Add(this.TabControlMain);
            this.Name = "FormMain";
            this.Text = "HsinLink Data Backup System";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.GroupTest.ResumeLayout(false);
            this.GroupTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogFromnTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxFrom;
        private System.Windows.Forms.TextBox TextBoxTo;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Button ButtonBrowse1;
        private System.Windows.Forms.Button ButtonBrowse2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox ComboBoxFreq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer TimerFreq;
        private System.Windows.Forms.Label LabelNextBackup;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerBackup;
        private System.Windows.Forms.Label LabelLastBackupPath;
        private System.Windows.Forms.Timer TimerCountDown;
        private System.Windows.Forms.GroupBox GroupTest;
        private System.Windows.Forms.Button ButtonStopBackup;
        private System.Windows.Forms.Button ButtonFastBackup;
        private System.Windows.Forms.Button ButtonBrowse3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxLog;
        private System.Windows.Forms.Button ButtonOpenLastPath;
        private System.Windows.Forms.TextBox TextBoxCustomize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CheckBoxFastBackup;
        private System.Windows.Forms.Button ButtonTest;
        private System.Windows.Forms.Button ButtonBackGround;
        private System.Windows.Forms.ListBox ListboxCommand;
        private System.Windows.Forms.TextBox TextboxCommand;
        private System.Windows.Forms.Button ButtonInputCommand;
    }
}

