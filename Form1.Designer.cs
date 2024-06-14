namespace AndroidApkSignHelper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbApkFilePath = new TextBox();
            btnApkFilePath = new Button();
            label1 = new Label();
            label2 = new Label();
            btnSignFilePath = new Button();
            btnApkOutputPath = new Button();
            tbApkOutputPath = new TextBox();
            label3 = new Label();
            rbV1 = new RadioButton();
            rbV1V2 = new RadioButton();
            rbV1V2V3 = new RadioButton();
            groupBox1 = new GroupBox();
            rtbOutput = new RichTextBox();
            btnSignApk = new Button();
            btnPrintCert = new Button();
            btnApkSignedVersion = new Button();
            cbDefaultSignedOutput = new CheckBox();
            cbDefaultSignFilePath = new CheckBox();
            combSignFilePath = new ComboBox();
            BtnViewApkInfo = new Button();
            BtnInstallApk = new Button();
            btnGetChecksum = new Button();
            cbOpenAfterSign = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbApkFilePath
            // 
            tbApkFilePath.AllowDrop = true;
            tbApkFilePath.Location = new Point(12, 29);
            tbApkFilePath.Name = "tbApkFilePath";
            tbApkFilePath.Size = new Size(441, 23);
            tbApkFilePath.TabIndex = 0;
            tbApkFilePath.DragDrop += control_DragDrop;
            tbApkFilePath.DragEnter += control_DragEnter;
            // 
            // btnApkFilePath
            // 
            btnApkFilePath.Location = new Point(459, 29);
            btnApkFilePath.Name = "btnApkFilePath";
            btnApkFilePath.Size = new Size(26, 23);
            btnApkFilePath.TabIndex = 1;
            btnApkFilePath.Text = "...";
            btnApkFilePath.UseVisualStyleBackColor = true;
            btnApkFilePath.Click += btnApkFilePath_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 2;
            label1.Text = "Apk文件路径";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 3;
            label2.Text = "系统签名文件路径";
            // 
            // btnSignFilePath
            // 
            btnSignFilePath.Location = new Point(459, 100);
            btnSignFilePath.Name = "btnSignFilePath";
            btnSignFilePath.Size = new Size(26, 23);
            btnSignFilePath.TabIndex = 5;
            btnSignFilePath.Text = "...";
            btnSignFilePath.UseVisualStyleBackColor = true;
            btnSignFilePath.Click += btnSignFilePath_Click;
            // 
            // btnApkOutputPath
            // 
            btnApkOutputPath.Location = new Point(459, 194);
            btnApkOutputPath.Name = "btnApkOutputPath";
            btnApkOutputPath.Size = new Size(26, 23);
            btnApkOutputPath.TabIndex = 8;
            btnApkOutputPath.Text = "...";
            btnApkOutputPath.UseVisualStyleBackColor = true;
            btnApkOutputPath.Click += btnApkOutputPath_Click;
            // 
            // tbApkOutputPath
            // 
            tbApkOutputPath.AllowDrop = true;
            tbApkOutputPath.Location = new Point(12, 194);
            tbApkOutputPath.Name = "tbApkOutputPath";
            tbApkOutputPath.Size = new Size(441, 23);
            tbApkOutputPath.TabIndex = 7;
            tbApkOutputPath.DragDrop += control_DragDrop;
            tbApkOutputPath.DragEnter += control_DragEnter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(139, 17);
            label3.TabIndex = 6;
            label3.Text = "Apk文件签名后输出路径";
            // 
            // rbV1
            // 
            rbV1.AutoSize = true;
            rbV1.Location = new Point(21, 34);
            rbV1.Name = "rbV1";
            rbV1.Size = new Size(63, 21);
            rbV1.TabIndex = 9;
            rbV1.TabStop = true;
            rbV1.Text = "v1签名";
            rbV1.UseVisualStyleBackColor = true;
            // 
            // rbV1V2
            // 
            rbV1V2.AutoSize = true;
            rbV1V2.Checked = true;
            rbV1V2.Location = new Point(111, 34);
            rbV1V2.Name = "rbV1V2";
            rbV1V2.Size = new Size(85, 21);
            rbV1V2.TabIndex = 10;
            rbV1V2.TabStop = true;
            rbV1V2.Text = "v1+v2签名";
            rbV1V2.UseVisualStyleBackColor = true;
            // 
            // rbV1V2V3
            // 
            rbV1V2V3.AutoSize = true;
            rbV1V2V3.Location = new Point(224, 34);
            rbV1V2V3.Name = "rbV1V2V3";
            rbV1V2V3.Size = new Size(107, 21);
            rbV1V2V3.TabIndex = 11;
            rbV1V2V3.TabStop = true;
            rbV1V2V3.Text = "v1+v2+v3签名";
            rbV1V2V3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbV1);
            groupBox1.Controls.Add(rbV1V2V3);
            groupBox1.Controls.Add(rbV1V2);
            groupBox1.Location = new Point(12, 335);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 79);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "签名方式";
            // 
            // rtbOutput
            // 
            rtbOutput.BackColor = SystemColors.ButtonFace;
            rtbOutput.BorderStyle = BorderStyle.FixedSingle;
            rtbOutput.Location = new Point(512, 12);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(569, 582);
            rtbOutput.TabIndex = 13;
            rtbOutput.Text = "";
            // 
            // btnSignApk
            // 
            btnSignApk.Location = new Point(12, 429);
            btnSignApk.Name = "btnSignApk";
            btnSignApk.Size = new Size(84, 34);
            btnSignApk.TabIndex = 14;
            btnSignApk.Text = "Apk签名";
            btnSignApk.UseVisualStyleBackColor = true;
            btnSignApk.Click += btnSignApk_Click;
            // 
            // btnPrintCert
            // 
            btnPrintCert.Location = new Point(123, 429);
            btnPrintCert.Name = "btnPrintCert";
            btnPrintCert.Size = new Size(127, 34);
            btnPrintCert.TabIndex = 15;
            btnPrintCert.Text = "查看Apk签名信息";
            btnPrintCert.UseVisualStyleBackColor = true;
            btnPrintCert.Click += btnPrintCert_Click;
            // 
            // btnApkSignedVersion
            // 
            btnApkSignedVersion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApkSignedVersion.Location = new Point(277, 429);
            btnApkSignedVersion.Name = "btnApkSignedVersion";
            btnApkSignedVersion.Size = new Size(127, 34);
            btnApkSignedVersion.TabIndex = 16;
            btnApkSignedVersion.Text = "验证Apk签名版本";
            btnApkSignedVersion.UseVisualStyleBackColor = true;
            btnApkSignedVersion.Click += btnApkSignedVersion_Click;
            // 
            // cbDefaultSignedOutput
            // 
            cbDefaultSignedOutput.AutoSize = true;
            cbDefaultSignedOutput.Location = new Point(12, 223);
            cbDefaultSignedOutput.Name = "cbDefaultSignedOutput";
            cbDefaultSignedOutput.Size = new Size(135, 21);
            cbDefaultSignedOutput.TabIndex = 17;
            cbDefaultSignedOutput.Text = "保存为默认输出路径";
            cbDefaultSignedOutput.UseVisualStyleBackColor = true;
            cbDefaultSignedOutput.CheckedChanged += cbDefaultSignedOutput_CheckedChanged;
            // 
            // cbDefaultSignFilePath
            // 
            cbDefaultSignFilePath.AutoSize = true;
            cbDefaultSignFilePath.Location = new Point(12, 129);
            cbDefaultSignFilePath.Name = "cbDefaultSignFilePath";
            cbDefaultSignFilePath.Size = new Size(111, 21);
            cbDefaultSignFilePath.TabIndex = 18;
            cbDefaultSignFilePath.Text = "保存为默认路径";
            cbDefaultSignFilePath.UseVisualStyleBackColor = true;
            cbDefaultSignFilePath.CheckedChanged += cbDefaultSignedOutput_CheckedChanged;
            // 
            // combSignFilePath
            // 
            combSignFilePath.AllowDrop = true;
            combSignFilePath.FormattingEnabled = true;
            combSignFilePath.Items.AddRange(new object[] { "item1", "item2" });
            combSignFilePath.Location = new Point(12, 100);
            combSignFilePath.Name = "combSignFilePath";
            combSignFilePath.Size = new Size(441, 25);
            combSignFilePath.TabIndex = 19;
            combSignFilePath.DragDrop += control_DragDrop;
            combSignFilePath.DragEnter += control_DragEnter;
            // 
            // BtnViewApkInfo
            // 
            BtnViewApkInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnViewApkInfo.Location = new Point(12, 483);
            BtnViewApkInfo.Name = "BtnViewApkInfo";
            BtnViewApkInfo.Size = new Size(111, 34);
            BtnViewApkInfo.TabIndex = 20;
            BtnViewApkInfo.Text = "查看Apk信息";
            BtnViewApkInfo.UseVisualStyleBackColor = true;
            BtnViewApkInfo.Click += BtnViewApkInfo_Click;
            // 
            // BtnInstallApk
            // 
            BtnInstallApk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnInstallApk.Location = new Point(139, 483);
            BtnInstallApk.Name = "BtnInstallApk";
            BtnInstallApk.Size = new Size(111, 34);
            BtnInstallApk.TabIndex = 21;
            BtnInstallApk.Text = "安装Apk";
            BtnInstallApk.UseVisualStyleBackColor = true;
            BtnInstallApk.Click += BtnInstallApk_Click;
            // 
            // btnGetChecksum
            // 
            btnGetChecksum.Location = new Point(277, 483);
            btnGetChecksum.Name = "btnGetChecksum";
            btnGetChecksum.Size = new Size(127, 34);
            btnGetChecksum.TabIndex = 22;
            btnGetChecksum.Text = "生成Checksum";
            btnGetChecksum.UseVisualStyleBackColor = true;
            btnGetChecksum.Click += btnGetChecksum_Click;
            // 
            // cbOpenAfterSign
            // 
            cbOpenAfterSign.AutoSize = true;
            cbOpenAfterSign.Location = new Point(12, 283);
            cbOpenAfterSign.Name = "cbOpenAfterSign";
            cbOpenAfterSign.Size = new Size(159, 21);
            cbOpenAfterSign.TabIndex = 23;
            cbOpenAfterSign.Text = "签名完毕打开相应文件夹";
            cbOpenAfterSign.UseVisualStyleBackColor = true;
            cbOpenAfterSign.CheckedChanged += cbDefaultSignedOutput_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 606);
            Controls.Add(cbOpenAfterSign);
            Controls.Add(btnGetChecksum);
            Controls.Add(BtnInstallApk);
            Controls.Add(BtnViewApkInfo);
            Controls.Add(combSignFilePath);
            Controls.Add(label1);
            Controls.Add(tbApkFilePath);
            Controls.Add(btnApkFilePath);
            Controls.Add(cbDefaultSignFilePath);
            Controls.Add(cbDefaultSignedOutput);
            Controls.Add(btnApkSignedVersion);
            Controls.Add(btnPrintCert);
            Controls.Add(btnSignApk);
            Controls.Add(rtbOutput);
            Controls.Add(groupBox1);
            Controls.Add(btnApkOutputPath);
            Controls.Add(tbApkOutputPath);
            Controls.Add(label3);
            Controls.Add(btnSignFilePath);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbApkFilePath;
        private Button btnApkFilePath;
        private Label label1;
        private Label label2;
        private Button btnSignFilePath;
        private Button btnApkOutputPath;
        private TextBox tbApkOutputPath;
        private Label label3;
        private RadioButton rbV1;
        private RadioButton rbV1V2;
        private RadioButton rbV1V2V3;
        private GroupBox groupBox1;
        private RichTextBox rtbOutput;
        private Button btnSignApk;
        private Button btnPrintCert;
        private Button btnApkSignedVersion;
        private CheckBox cbDefaultSignedOutput;
        private CheckBox cbDefaultSignFilePath;
        private ComboBox combSignFilePath;
        private Button BtnViewApkInfo;
        private Button BtnInstallApk;
        private Button btnGetChecksum;
        private CheckBox cbOpenAfterSign;
    }
}