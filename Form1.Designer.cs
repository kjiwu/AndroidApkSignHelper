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
            tbSignFilePath = new TextBox();
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbApkFilePath
            // 
            tbApkFilePath.Location = new Point(12, 29);
            tbApkFilePath.Name = "tbApkFilePath";
            tbApkFilePath.Size = new Size(597, 23);
            tbApkFilePath.TabIndex = 0;
            // 
            // btnApkFilePath
            // 
            btnApkFilePath.Location = new Point(615, 29);
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
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 3;
            label2.Text = "系统签名文件路径";
            // 
            // tbSignFilePath
            // 
            tbSignFilePath.Location = new Point(12, 94);
            tbSignFilePath.Name = "tbSignFilePath";
            tbSignFilePath.Size = new Size(597, 23);
            tbSignFilePath.TabIndex = 4;
            // 
            // btnSignFilePath
            // 
            btnSignFilePath.Location = new Point(615, 94);
            btnSignFilePath.Name = "btnSignFilePath";
            btnSignFilePath.Size = new Size(26, 23);
            btnSignFilePath.TabIndex = 5;
            btnSignFilePath.Text = "...";
            btnSignFilePath.UseVisualStyleBackColor = true;
            btnSignFilePath.Click += btnSignFilePath_Click;
            // 
            // btnApkOutputPath
            // 
            btnApkOutputPath.Location = new Point(615, 180);
            btnApkOutputPath.Name = "btnApkOutputPath";
            btnApkOutputPath.Size = new Size(26, 23);
            btnApkOutputPath.TabIndex = 8;
            btnApkOutputPath.Text = "...";
            btnApkOutputPath.UseVisualStyleBackColor = true;
            btnApkOutputPath.Click += btnApkOutputPath_Click;
            // 
            // tbApkOutputPath
            // 
            tbApkOutputPath.Location = new Point(12, 180);
            tbApkOutputPath.Name = "tbApkOutputPath";
            tbApkOutputPath.Size = new Size(597, 23);
            tbApkOutputPath.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 160);
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
            groupBox1.Location = new Point(12, 263);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 79);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "签名方式";
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(12, 427);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(597, 334);
            rtbOutput.TabIndex = 13;
            rtbOutput.Text = "";
            // 
            // btnSignApk
            // 
            btnSignApk.Location = new Point(12, 357);
            btnSignApk.Name = "btnSignApk";
            btnSignApk.Size = new Size(84, 34);
            btnSignApk.TabIndex = 14;
            btnSignApk.Text = "Apk签名";
            btnSignApk.UseVisualStyleBackColor = true;
            btnSignApk.Click += btnSignApk_Click;
            // 
            // btnPrintCert
            // 
            btnPrintCert.Location = new Point(123, 357);
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
            btnApkSignedVersion.Location = new Point(277, 357);
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
            cbDefaultSignedOutput.Location = new Point(12, 209);
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
            cbDefaultSignFilePath.Location = new Point(12, 123);
            cbDefaultSignFilePath.Name = "cbDefaultSignFilePath";
            cbDefaultSignFilePath.Size = new Size(111, 21);
            cbDefaultSignFilePath.TabIndex = 18;
            cbDefaultSignFilePath.Text = "保存为默认路径";
            cbDefaultSignFilePath.UseVisualStyleBackColor = true;
            cbDefaultSignFilePath.CheckedChanged += cbDefaultSignedOutput_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 774);
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
            Controls.Add(tbSignFilePath);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnApkFilePath);
            Controls.Add(tbApkFilePath);
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
        private TextBox tbSignFilePath;
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
    }
}