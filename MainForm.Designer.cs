namespace OdrabiamyDownloaderForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.checkBox_Premium = new System.Windows.Forms.CheckBox();
            this.button_Download = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_End = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Start = new System.Windows.Forms.NumericUpDown();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider_Login = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_ID = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox_DownloadStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_SaveHTML = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_SaveImages = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sAMPLETEXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_End)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Cancel);
            this.groupBox1.Controls.Add(this.checkBox_Premium);
            this.groupBox1.Controls.Add(this.button_Download);
            this.groupBox1.Controls.Add(this.textBox_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_End);
            this.groupBox1.Controls.Add(this.numericUpDown_Start);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.textBox_Login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(196, 141);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(101, 23);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "Anuluj";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // checkBox_Premium
            // 
            this.checkBox_Premium.AutoSize = true;
            this.checkBox_Premium.Checked = true;
            this.checkBox_Premium.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Premium.Location = new System.Drawing.Point(222, 87);
            this.checkBox_Premium.Name = "checkBox_Premium";
            this.checkBox_Premium.Size = new System.Drawing.Size(75, 19);
            this.checkBox_Premium.TabIndex = 11;
            this.checkBox_Premium.Text = "Premium";
            this.checkBox_Premium.UseVisualStyleBackColor = true;
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(196, 112);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(101, 23);
            this.button_Download.TabIndex = 10;
            this.button_Download.Text = "Pobierz";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(110, 83);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(70, 23);
            this.textBox_ID.TabIndex = 9;
            this.textBox_ID.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ID_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID Cionszki:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Strona Końcowa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Strona Startowa:";
            // 
            // numericUpDown_End
            // 
            this.numericUpDown_End.Location = new System.Drawing.Point(110, 141);
            this.numericUpDown_End.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_End.Name = "numericUpDown_End";
            this.numericUpDown_End.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown_End.TabIndex = 5;
            this.numericUpDown_End.ValueChanged += new System.EventHandler(this.numericUpDown_End_ValueChanged);
            // 
            // numericUpDown_Start
            // 
            this.numericUpDown_Start.Location = new System.Drawing.Point(110, 112);
            this.numericUpDown_Start.Name = "numericUpDown_Start";
            this.numericUpDown_Start.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown_Start.TabIndex = 4;
            this.numericUpDown_Start.ValueChanged += new System.EventHandler(this.numericUpDown_Start_ValueChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(110, 54);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(187, 23);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Password_Validating);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(110, 25);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(187, 23);
            this.textBox_Login.TabIndex = 2;
            this.textBox_Login.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Login_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // errorProvider_Login
            // 
            this.errorProvider_Login.ContainerControl = this;
            // 
            // errorProvider_Password
            // 
            this.errorProvider_Password.ContainerControl = this;
            // 
            // errorProvider_ID
            // 
            this.errorProvider_ID.ContainerControl = this;
            // 
            // textBox_DownloadStatus
            // 
            this.textBox_DownloadStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_DownloadStatus.Location = new System.Drawing.Point(11, 332);
            this.textBox_DownloadStatus.Multiline = true;
            this.textBox_DownloadStatus.Name = "textBox_DownloadStatus";
            this.textBox_DownloadStatus.ReadOnly = true;
            this.textBox_DownloadStatus.Size = new System.Drawing.Size(319, 76);
            this.textBox_DownloadStatus.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Status Pobierania";
            // 
            // button_SaveHTML
            // 
            this.button_SaveHTML.Enabled = false;
            this.button_SaveHTML.Location = new System.Drawing.Point(6, 36);
            this.button_SaveHTML.Name = "button_SaveHTML";
            this.button_SaveHTML.Size = new System.Drawing.Size(91, 23);
            this.button_SaveHTML.TabIndex = 11;
            this.button_SaveHTML.Text = "HTML";
            this.button_SaveHTML.UseVisualStyleBackColor = true;
            this.button_SaveHTML.Click += new System.EventHandler(this.button_SaveHTML_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_SaveImages);
            this.groupBox2.Controls.Add(this.button_SaveHTML);
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 86);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zapisywanie";
            // 
            // button_SaveImages
            // 
            this.button_SaveImages.Enabled = false;
            this.button_SaveImages.Location = new System.Drawing.Point(103, 36);
            this.button_SaveImages.Name = "button_SaveImages";
            this.button_SaveImages.Size = new System.Drawing.Size(91, 23);
            this.button_SaveImages.TabIndex = 12;
            this.button_SaveImages.Text = "Obrazki";
            this.button_SaveImages.UseVisualStyleBackColor = true;
            this.button_SaveImages.Click += new System.EventHandler(this.button_SaveImages_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAMPLETEXTToolStripMenuItem,
            this.gitHubToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sAMPLETEXTToolStripMenuItem
            // 
            this.sAMPLETEXTToolStripMenuItem.Name = "sAMPLETEXTToolStripMenuItem";
            this.sAMPLETEXTToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.sAMPLETEXTToolStripMenuItem.Text = "Licencja";
            this.sAMPLETEXTToolStripMenuItem.Click += new System.EventHandler(this.sAMPLETEXTToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsFormsToolStripMenuItem,
            this.consoleToolStripMenuItem,
            this.bibliotekaToolStripMenuItem});
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // windowsFormsToolStripMenuItem
            // 
            this.windowsFormsToolStripMenuItem.Name = "windowsFormsToolStripMenuItem";
            this.windowsFormsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.windowsFormsToolStripMenuItem.Text = "Windows Forms";
            this.windowsFormsToolStripMenuItem.Click += new System.EventHandler(this.windowsFormsToolStripMenuItem_Click);
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // bibliotekaToolStripMenuItem
            // 
            this.bibliotekaToolStripMenuItem.Name = "bibliotekaToolStripMenuItem";
            this.bibliotekaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bibliotekaToolStripMenuItem.Text = "Biblioteka";
            this.bibliotekaToolStripMenuItem.Click += new System.EventHandler(this.bibliotekaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_DownloadStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odrabiamy Downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_End)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_Password;
        private TextBox textBox_Login;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown_End;
        private NumericUpDown numericUpDown_Start;
        private TextBox textBox_ID;
        private Label label5;
        private ErrorProvider errorProvider_Login;
        private ErrorProvider errorProvider_Password;
        private ErrorProvider errorProvider_ID;
        private Button button_Download;
        private CheckBox checkBox_Premium;
        private TextBox textBox_DownloadStatus;
        private Label label6;
        private Button button_Cancel;
        private GroupBox groupBox2;
        private Button button_SaveHTML;
        private FolderBrowserDialog folderBrowserDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sAMPLETEXTToolStripMenuItem;
        private Button button_SaveImages;
        private ToolStripMenuItem gitHubToolStripMenuItem;
        private ToolStripMenuItem windowsFormsToolStripMenuItem;
        private ToolStripMenuItem consoleToolStripMenuItem;
        private ToolStripMenuItem bibliotekaToolStripMenuItem;
    }
}