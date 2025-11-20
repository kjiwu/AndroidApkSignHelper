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
            btnSignFilePath = new Button();
            btnApkOutputPath = new Button();
            tbApkOutputPath = new TextBox();
            label3 = new Label();
            rbV1 = new RadioButton();
            rbV1V2 = new RadioButton();
            rbV1V2V3 = new RadioButton();
            groupBox1 = new GroupBox();
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
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            btnImportPwdAndAlias = new Button();
            btnCheckKeyStoreSign = new Button();
            tbKeyPassword = new TextBox();
            label5 = new Label();
            tbStorePassword = new TextBox();
            label4 = new Label();
            tbAlias = new TextBox();
            label2 = new Label();
            tbKeystore = new TextBox();
            btnKeystorePath = new Button();
            groupBox3 = new GroupBox();
            rbKeystore = new RadioButton();
            rbPem = new RadioButton();
            btnCheckRelease = new Button();
            cbDeleteAfterSign = new CheckBox();
            groupBox5 = new GroupBox();
            label8 = new Label();
            btnExtractApkPath = new Button();
            btnExtract = new Button();
            tbExtractApkPath = new TextBox();
            label6 = new Label();
            btnExtractPath = new Button();
            tbExtractPath = new TextBox();
            groupBox7 = new GroupBox();
            btnTimeChange = new Button();
            btnPackTime = new Button();
            btnVersionChange = new Button();
            lbTimeResult = new Label();
            label7 = new Label();
            tbTime = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            groupBox6 = new GroupBox();
            rtbOutput = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // tbApkFilePath
            // 
            tbApkFilePath.AllowDrop = true;
            tbApkFilePath.Location = new Point(15, 36);
            tbApkFilePath.Name = "tbApkFilePath";
            tbApkFilePath.Size = new Size(441, 23);
            tbApkFilePath.TabIndex = 0;
            tbApkFilePath.DragDrop += control_DragDrop;
            tbApkFilePath.DragEnter += control_DragEnter;
            // 
            // btnApkFilePath
            // 
            btnApkFilePath.Location = new Point(462, 36);
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
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 2;
            label1.Text = "Apk文件路径";
            // 
            // btnSignFilePath
            // 
            btnSignFilePath.Location = new Point(427, 30);
            btnSignFilePath.Name = "btnSignFilePath";
            btnSignFilePath.Size = new Size(26, 23);
            btnSignFilePath.TabIndex = 5;
            btnSignFilePath.Text = "...";
            btnSignFilePath.UseVisualStyleBackColor = true;
            btnSignFilePath.Click += btnSignFilePath_Click;
            // 
            // btnApkOutputPath
            // 
            btnApkOutputPath.Location = new Point(462, 476);
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
            tbApkOutputPath.Location = new Point(15, 476);
            tbApkOutputPath.Name = "tbApkOutputPath";
            tbApkOutputPath.Size = new Size(441, 23);
            tbApkOutputPath.TabIndex = 7;
            tbApkOutputPath.DragDrop += control_DragDrop;
            tbApkOutputPath.DragEnter += control_DragEnter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 456);
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
            groupBox1.Location = new Point(15, 617);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 79);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "签名方式";
            // 
            // btnSignApk
            // 
            btnSignApk.Location = new Point(15, 714);
            btnSignApk.Name = "btnSignApk";
            btnSignApk.Size = new Size(117, 34);
            btnSignApk.TabIndex = 14;
            btnSignApk.Text = "Apk签名";
            btnSignApk.UseVisualStyleBackColor = true;
            btnSignApk.Click += btnSignApk_Click;
            // 
            // btnPrintCert
            // 
            btnPrintCert.Location = new Point(185, 714);
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
            btnApkSignedVersion.Location = new Point(361, 714);
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
            cbDefaultSignedOutput.Location = new Point(15, 505);
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
            cbDefaultSignFilePath.Location = new Point(6, 61);
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
            combSignFilePath.Location = new Point(6, 30);
            combSignFilePath.Name = "combSignFilePath";
            combSignFilePath.Size = new Size(415, 25);
            combSignFilePath.TabIndex = 19;
            combSignFilePath.DragDrop += control_DragDrop;
            combSignFilePath.DragEnter += control_DragEnter;
            // 
            // BtnViewApkInfo
            // 
            BtnViewApkInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnViewApkInfo.Location = new Point(15, 754);
            BtnViewApkInfo.Name = "BtnViewApkInfo";
            BtnViewApkInfo.Size = new Size(117, 34);
            BtnViewApkInfo.TabIndex = 20;
            BtnViewApkInfo.Text = "查看Apk信息";
            BtnViewApkInfo.UseVisualStyleBackColor = true;
            BtnViewApkInfo.Click += BtnViewApkInfo_Click;
            // 
            // BtnInstallApk
            // 
            BtnInstallApk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnInstallApk.Location = new Point(185, 754);
            BtnInstallApk.Name = "BtnInstallApk";
            BtnInstallApk.Size = new Size(127, 34);
            BtnInstallApk.TabIndex = 21;
            BtnInstallApk.Text = "安装Apk";
            BtnInstallApk.UseVisualStyleBackColor = true;
            BtnInstallApk.Click += BtnInstallApk_Click;
            // 
            // btnGetChecksum
            // 
            btnGetChecksum.Location = new Point(361, 754);
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
            cbOpenAfterSign.Location = new Point(15, 565);
            cbOpenAfterSign.Name = "cbOpenAfterSign";
            cbOpenAfterSign.Size = new Size(159, 21);
            cbOpenAfterSign.TabIndex = 23;
            cbOpenAfterSign.Text = "签名完毕打开相应文件夹";
            cbOpenAfterSign.UseVisualStyleBackColor = true;
            cbOpenAfterSign.CheckedChanged += cbDefaultSignedOutput_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(rbKeystore);
            groupBox2.Controls.Add(rbPem);
            groupBox2.Location = new Point(15, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 363);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "签名类型";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnImportPwdAndAlias);
            groupBox4.Controls.Add(btnCheckKeyStoreSign);
            groupBox4.Controls.Add(tbKeyPassword);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(tbStorePassword);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(tbAlias);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(tbKeystore);
            groupBox4.Controls.Add(btnKeystorePath);
            groupBox4.Location = new Point(8, 182);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(459, 173);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "keystore/jks文件配置";
            // 
            // btnImportPwdAndAlias
            // 
            btnImportPwdAndAlias.Location = new Point(301, 107);
            btnImportPwdAndAlias.Name = "btnImportPwdAndAlias";
            btnImportPwdAndAlias.Size = new Size(128, 36);
            btnImportPwdAndAlias.TabIndex = 11;
            btnImportPwdAndAlias.Text = "导入密码和别名";
            btnImportPwdAndAlias.UseVisualStyleBackColor = true;
            btnImportPwdAndAlias.Click += btnImportPwdAndAlias_Click;
            // 
            // btnCheckKeyStoreSign
            // 
            btnCheckKeyStoreSign.Location = new Point(301, 65);
            btnCheckKeyStoreSign.Name = "btnCheckKeyStoreSign";
            btnCheckKeyStoreSign.Size = new Size(128, 36);
            btnCheckKeyStoreSign.TabIndex = 10;
            btnCheckKeyStoreSign.Text = "查看签名文件信息";
            btnCheckKeyStoreSign.UseVisualStyleBackColor = true;
            btnCheckKeyStoreSign.Click += btnCheckKeyStoreSign_Click;
            // 
            // tbKeyPassword
            // 
            tbKeyPassword.Location = new Point(111, 132);
            tbKeyPassword.Name = "tbKeyPassword";
            tbKeyPassword.Size = new Size(146, 23);
            tbKeyPassword.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 135);
            label5.Name = "label5";
            label5.Size = new Size(89, 17);
            label5.TabIndex = 8;
            label5.Text = "Key Password";
            // 
            // tbStorePassword
            // 
            tbStorePassword.Location = new Point(111, 96);
            tbStorePassword.Name = "tbStorePassword";
            tbStorePassword.Size = new Size(146, 23);
            tbStorePassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 6;
            label4.Text = "Store Password";
            // 
            // tbAlias
            // 
            tbAlias.Location = new Point(111, 62);
            tbAlias.Name = "tbAlias";
            tbAlias.Size = new Size(146, 23);
            tbAlias.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 65);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 4;
            label2.Text = "Alias";
            // 
            // tbKeystore
            // 
            tbKeystore.AllowDrop = true;
            tbKeystore.Location = new Point(6, 31);
            tbKeystore.Name = "tbKeystore";
            tbKeystore.Size = new Size(415, 23);
            tbKeystore.TabIndex = 2;
            tbKeystore.DragDrop += control_DragDrop;
            tbKeystore.DragEnter += control_DragEnter;
            // 
            // btnKeystorePath
            // 
            btnKeystorePath.Location = new Point(427, 31);
            btnKeystorePath.Name = "btnKeystorePath";
            btnKeystorePath.Size = new Size(26, 23);
            btnKeystorePath.TabIndex = 3;
            btnKeystorePath.Text = "...";
            btnKeystorePath.UseVisualStyleBackColor = true;
            btnKeystorePath.Click += btnKeystorePath_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(combSignFilePath);
            groupBox3.Controls.Add(btnSignFilePath);
            groupBox3.Controls.Add(cbDefaultSignFilePath);
            groupBox3.Location = new Point(8, 79);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(459, 86);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "系统签名文件路径";
            // 
            // rbKeystore
            // 
            rbKeystore.AutoSize = true;
            rbKeystore.Location = new Point(136, 38);
            rbKeystore.Name = "rbKeystore";
            rbKeystore.Size = new Size(121, 21);
            rbKeystore.TabIndex = 21;
            rbKeystore.Text = "keystore/jks文件";
            rbKeystore.UseVisualStyleBackColor = true;
            // 
            // rbPem
            // 
            rbPem.AutoSize = true;
            rbPem.Checked = true;
            rbPem.Location = new Point(8, 38);
            rbPem.Name = "rbPem";
            rbPem.Size = new Size(100, 21);
            rbPem.TabIndex = 20;
            rbPem.TabStop = true;
            rbPem.Text = "PEM签名文件";
            rbPem.UseVisualStyleBackColor = true;
            // 
            // btnCheckRelease
            // 
            btnCheckRelease.Location = new Point(15, 794);
            btnCheckRelease.Name = "btnCheckRelease";
            btnCheckRelease.Size = new Size(117, 34);
            btnCheckRelease.TabIndex = 25;
            btnCheckRelease.Text = "验证APK包的类型";
            btnCheckRelease.UseVisualStyleBackColor = true;
            btnCheckRelease.Click += btnCheckRelease_Click;
            // 
            // cbDeleteAfterSign
            // 
            cbDeleteAfterSign.AutoSize = true;
            cbDeleteAfterSign.Location = new Point(187, 565);
            cbDeleteAfterSign.Name = "cbDeleteAfterSign";
            cbDeleteAfterSign.Size = new Size(135, 21);
            cbDeleteAfterSign.TabIndex = 26;
            cbDeleteAfterSign.Text = "签名完毕删除原文件";
            cbDeleteAfterSign.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(btnExtractApkPath);
            groupBox5.Controls.Add(btnExtract);
            groupBox5.Controls.Add(tbExtractApkPath);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(btnExtractPath);
            groupBox5.Controls.Add(tbExtractPath);
            groupBox5.Location = new Point(6, 16);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(488, 215);
            groupBox5.TabIndex = 27;
            groupBox5.TabStop = false;
            groupBox5.Text = "提取APK内容";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 36);
            label8.Name = "label8";
            label8.Size = new Size(79, 17);
            label8.TabIndex = 30;
            label8.Text = "Apk文件路径";
            // 
            // btnExtractApkPath
            // 
            btnExtractApkPath.Location = new Point(456, 56);
            btnExtractApkPath.Name = "btnExtractApkPath";
            btnExtractApkPath.Size = new Size(26, 23);
            btnExtractApkPath.TabIndex = 29;
            btnExtractApkPath.Text = "...";
            btnExtractApkPath.UseVisualStyleBackColor = true;
            btnExtractApkPath.Click += btnExtractApkPath_Click;
            // 
            // btnExtract
            // 
            btnExtract.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExtract.Location = new Point(15, 157);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(127, 34);
            btnExtract.TabIndex = 22;
            btnExtract.Text = "提取";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // tbExtractApkPath
            // 
            tbExtractApkPath.AllowDrop = true;
            tbExtractApkPath.Location = new Point(15, 56);
            tbExtractApkPath.Name = "tbExtractApkPath";
            tbExtractApkPath.Size = new Size(435, 23);
            tbExtractApkPath.TabIndex = 28;
            tbExtractApkPath.DragDrop += control_DragDrop;
            tbExtractApkPath.DragEnter += control_DragEnter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 95);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 11;
            label6.Text = "提取目录";
            // 
            // btnExtractPath
            // 
            btnExtractPath.Location = new Point(456, 115);
            btnExtractPath.Name = "btnExtractPath";
            btnExtractPath.Size = new Size(26, 23);
            btnExtractPath.TabIndex = 10;
            btnExtractPath.Text = "...";
            btnExtractPath.UseVisualStyleBackColor = true;
            btnExtractPath.Click += btnExtractPath_Click;
            // 
            // tbExtractPath
            // 
            tbExtractPath.AllowDrop = true;
            tbExtractPath.Location = new Point(15, 115);
            tbExtractPath.Name = "tbExtractPath";
            tbExtractPath.Size = new Size(435, 23);
            tbExtractPath.TabIndex = 9;
            tbExtractPath.DragDrop += control_DragDrop;
            tbExtractPath.DragEnter += control_DragEnter;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btnTimeChange);
            groupBox7.Controls.Add(btnPackTime);
            groupBox7.Controls.Add(btnVersionChange);
            groupBox7.Controls.Add(lbTimeResult);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(tbTime);
            groupBox7.Location = new Point(6, 17);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(492, 166);
            groupBox7.TabIndex = 29;
            groupBox7.TabStop = false;
            groupBox7.Text = "时间转化相关";
            // 
            // btnTimeChange
            // 
            btnTimeChange.Location = new Point(220, 75);
            btnTimeChange.Name = "btnTimeChange";
            btnTimeChange.Size = new Size(101, 38);
            btnTimeChange.TabIndex = 5;
            btnTimeChange.Text = "时间戳转化";
            btnTimeChange.UseVisualStyleBackColor = true;
            btnTimeChange.Click += btnTimeChange_Click;
            // 
            // btnPackTime
            // 
            btnPackTime.Location = new Point(113, 75);
            btnPackTime.Name = "btnPackTime";
            btnPackTime.Size = new Size(101, 38);
            btnPackTime.TabIndex = 4;
            btnPackTime.Text = "打包时间转化";
            btnPackTime.UseVisualStyleBackColor = true;
            btnPackTime.Click += btnPackTime_Click;
            // 
            // btnVersionChange
            // 
            btnVersionChange.Location = new Point(6, 75);
            btnVersionChange.Name = "btnVersionChange";
            btnVersionChange.Size = new Size(101, 38);
            btnVersionChange.TabIndex = 3;
            btnVersionChange.Text = "版本号转化";
            btnVersionChange.UseVisualStyleBackColor = true;
            btnVersionChange.Click += btnVersionChange_Click;
            // 
            // lbTimeResult
            // 
            lbTimeResult.AutoSize = true;
            lbTimeResult.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimeResult.Location = new Point(6, 126);
            lbTimeResult.Name = "lbTimeResult";
            lbTimeResult.Size = new Size(0, 22);
            lbTimeResult.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 26);
            label7.Name = "label7";
            label7.Size = new Size(92, 17);
            label7.TabIndex = 1;
            label7.Text = "输入待转换时间";
            // 
            // tbTime
            // 
            tbTime.Location = new Point(6, 46);
            tbTime.Name = "tbTime";
            tbTime.Size = new Size(480, 23);
            tbTime.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(512, 867);
            tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(tbApkOutputPath);
            tabPage1.Controls.Add(btnApkOutputPath);
            tabPage1.Controls.Add(cbDeleteAfterSign);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnCheckRelease);
            tabPage1.Controls.Add(btnSignApk);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(btnPrintCert);
            tabPage1.Controls.Add(cbOpenAfterSign);
            tabPage1.Controls.Add(btnApkSignedVersion);
            tabPage1.Controls.Add(btnGetChecksum);
            tabPage1.Controls.Add(cbDefaultSignedOutput);
            tabPage1.Controls.Add(BtnInstallApk);
            tabPage1.Controls.Add(btnApkFilePath);
            tabPage1.Controls.Add(BtnViewApkInfo);
            tabPage1.Controls.Add(tbApkFilePath);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(504, 837);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "APK签名";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(504, 837);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "APK提取";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox7);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(504, 837);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "其他功能";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.Control;
            groupBox6.Controls.Add(rtbOutput);
            groupBox6.Location = new Point(530, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(528, 863);
            groupBox6.TabIndex = 31;
            groupBox6.TabStop = false;
            groupBox6.Text = "输出";
            // 
            // rtbOutput
            // 
            rtbOutput.BackColor = SystemColors.Control;
            rtbOutput.BorderStyle = BorderStyle.None;
            rtbOutput.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rtbOutput.Location = new Point(6, 26);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(516, 828);
            rtbOutput.TabIndex = 13;
            rtbOutput.Text = "";
            rtbOutput.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 890);
            Controls.Add(groupBox6);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbApkFilePath;
        private Button btnApkFilePath;
        private Label label1;
        private Button btnSignFilePath;
        private Button btnApkOutputPath;
        private TextBox tbApkOutputPath;
        private Label label3;
        private RadioButton rbV1;
        private RadioButton rbV1V2;
        private RadioButton rbV1V2V3;
        private GroupBox groupBox1;
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
        private GroupBox groupBox2;
        private RadioButton rbKeystore;
        private RadioButton rbPem;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox tbKeyPassword;
        private Label label5;
        private TextBox tbStorePassword;
        private Label label4;
        private TextBox tbAlias;
        private Label label2;
        private TextBox tbKeystore;
        private Button btnKeystorePath;
        private Button btnCheckKeyStoreSign;
        private Button btnCheckRelease;
        private Button btnImportPwdAndAlias;
        private CheckBox cbDeleteAfterSign;
        private GroupBox groupBox5;
        private Label label6;
        private Button btnExtractPath;
        private TextBox tbExtractPath;
        private Button btnExtract;
        private GroupBox groupBox7;
        private Label label7;
        private TextBox tbTime;
        private Label lbTimeResult;
        private Button btnVersionChange;
        private Button btnPackTime;
        private Button btnTimeChange;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label8;
        private Button btnExtractApkPath;
        private TextBox tbExtractApkPath;
        private GroupBox groupBox6;
        private RichTextBox rtbOutput;
    }
}