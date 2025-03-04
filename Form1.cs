using System.Diagnostics;

namespace AndroidApkSignHelper
{
    public partial class Form1 : Form
    {
        const string CONFIG_FILE = "config.ini";
        const string SECTION = "Config";
        const string DEFAULT_SIGN_FILE_PATH = "default_sign_file_path";
        const string DEFAULT_OUTPUT_APK_PATH = "default_output_apk_path";
        const string DEFAULT_OPEN_FOLDER_AFTER_SIGN = "default_open_folder_after_sign";

        const string DEFAULT_JRE_PATH = "jre";

        Dictionary<string, string> ConfigSignPaths;

        public Form1()
        {
            InitializeComponent();
            this.Text = Application.ProductName;

            ConfigSignPaths = DefaultSignFilesHelper.GetSignConfigItems();
            combSignFilePath.Items.Clear();
            combSignFilePath.Items.AddRange(ConfigSignPaths.Keys.ToArray());

            tbApkOutputPath.Text = IniFileHelper.ReadIniFileValue(CONFIG_FILE, SECTION, DEFAULT_OUTPUT_APK_PATH);
            combSignFilePath.Text = IniFileHelper.ReadIniFileValue(CONFIG_FILE, SECTION, DEFAULT_SIGN_FILE_PATH);
            string? isOpenFolderAfterSgin = IniFileHelper.ReadIniFileValue(CONFIG_FILE, SECTION, DEFAULT_OPEN_FOLDER_AFTER_SIGN);
            cbOpenAfterSign.Checked = true.ToString().Equals(isOpenFolderAfterSgin);
        }

        private void btnApkFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            tbApkFilePath.Text = ofd.FileName;
        }

        private void btnSignFilePath_Click(object sender, EventArgs e)
        {
            string? defaultSignFilePath = IniFileHelper.ReadIniFileValue(CONFIG_FILE, SECTION, DEFAULT_SIGN_FILE_PATH);
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (null != defaultSignFilePath)
            {
                folderBrowserDialog.SelectedPath = defaultSignFilePath;
            }
            folderBrowserDialog.ShowDialog();
            combSignFilePath.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnApkOutputPath_Click(object sender, EventArgs e)
        {
            string? defaultOutputApkPath = IniFileHelper.ReadIniFileValue(CONFIG_FILE, SECTION, DEFAULT_OUTPUT_APK_PATH);
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (null != defaultOutputApkPath)
            {
                folderBrowserDialog.SelectedPath = defaultOutputApkPath;
            }
            folderBrowserDialog.ShowDialog();
            tbApkOutputPath.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnPrintCert_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(DEFAULT_JRE_PATH))
            {
                Utils.GetCmdResultByArguments($"{Path.Combine(DEFAULT_JRE_PATH, "bin", "keytool.exe")} -printcert -jarfile \"{tbApkFilePath.Text}\"", (e) =>
                {
                    BeginInvoke(() =>
                    {
                        rtbOutput.Text = e;
                    });
                });
            }
            else
            {
                Utils.GetCmdResultByArguments($"keytool -printcert -jarfile \"{tbApkFilePath.Text}\"", (e) =>
                {
                    BeginInvoke(() =>
                    {
                        rtbOutput.Text = e;
                    });
                });
            }
        }

        private void btnApkSignedVersion_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(DEFAULT_JRE_PATH))
            {
                Utils.GetCmdResultByArguments($"{Path.Combine(DEFAULT_JRE_PATH, "bin", "java.exe")} -jar apksigner.jar verify -v --print-certs \"{tbApkFilePath.Text}\"", (e) =>
                {
                    BeginInvoke(() =>
                    {
                        rtbOutput.Text = e;
                    });
                });
            }
            else
            {
                Utils.GetCmdResultByArguments($"java -jar apksigner.jar verify -v --print-certs \"{tbApkFilePath.Text}\"", (e) =>
                {
                    BeginInvoke(() =>
                    {
                        rtbOutput.Text = e;
                    });
                });
            }
        }

        private void btnSignApk_Click(object sender, EventArgs e)
        {
            string signFilePath = GetSignFilePath();
            string pk8 = Path.Combine(signFilePath, "platform.pk8");
            string pem = Path.Combine(signFilePath, "platform.x509.pem");
            string outApkPath = string.IsNullOrEmpty(tbApkOutputPath.Text) ? Path.GetDirectoryName(tbApkFilePath.Text) : tbApkOutputPath.Text;

            if (!Directory.Exists(outApkPath))
            {
                Directory.CreateDirectory(outApkPath);
            }

            string outApk = Path.Combine(outApkPath, Path.GetFileNameWithoutExtension(tbApkFilePath.Text) + "-signed.apk");
            string inApk = tbApkFilePath.Text;
            string zipAlginApk = Path.Combine(outApkPath, Path.GetFileNameWithoutExtension(tbApkFilePath.Text) + "-zipalign.apk");


            string zipCmd = $"zipalign.exe -v 4 \"{inApk}\" \"{zipAlginApk}\"";
            string cmd;

            if (rbPem.Checked)
            {
                cmd = $"java -jar apksigner.jar sign --key \"{pk8}\" --cert \"{pem}\" --out \"{outApk}\" --in \"{zipAlginApk}\"";
                if (Directory.Exists(DEFAULT_JRE_PATH))
                {
                    cmd = $"{Path.Combine(DEFAULT_JRE_PATH, "bin", "java.exe")} -jar apksigner.jar sign --key \"{pk8}\" --cert \"{pem}\" --out \"{outApk}\" --in \"{zipAlginApk}\"";
                }
            }
            else
            {
                cmd = $"java -jar apksigner.jar sign --ks \"{tbKeystore.Text}\" --ks-key-alias {tbAlias.Text} --key-pass pass:{tbKeyPassword.Text} --ks-pass pass:{tbStorePassword.Text} --out \"{outApk}\" --in \"{zipAlginApk}\"";
                if (Directory.Exists(DEFAULT_JRE_PATH))
                {
                    cmd = $"{Path.Combine(DEFAULT_JRE_PATH, "bin", "java.exe")} -jar apksigner.jar sign --ks \"{tbKeystore.Text}\" --ks-key-alias {tbAlias.Text} --key-pass pass:{tbKeyPassword.Text} --ks-pass pass:{tbStorePassword.Text} --out \"{outApk}\" --in \"{zipAlginApk}\"";
                }
            }

            if (rbV1.Checked)
            {
                cmd += " --v1-signing-enabled true --v2-signing-enabled false --v3-signing-enabled false";
            }

            if (rbV1V2.Checked)
            {
                cmd += " --v1-signing-enabled true --v2-signing-enabled true --v3-signing-enabled false";
            }

            if (rbV1V2V3.Checked)
            {
                cmd += " --v1-signing-enabled true --v2-signing-enabled true --v3-signing-enabled true";
            }

            Utils.GetCmdResultByArguments(zipCmd, (e) =>
            {
                BeginInvoke(() =>
                {
                    rtbOutput.Text = e;

                    Utils.GetCmdResultByArguments(cmd, (ee) =>
                    {
                        BeginInvoke(() =>
                        {
                            rtbOutput.Text += ee;
                            File.Delete(zipAlginApk);
                            File.Delete(Path.Combine(outApkPath, Path.GetFileNameWithoutExtension(tbApkFilePath.Text) + "-signed.apk.idsig"));

                            if (cbDeleteAfterSign.Checked)
                            {
                                File.Delete(inApk);
                            }

                            if (cbOpenAfterSign.Checked)
                            {
                                Process.Start("explorer", outApkPath);
                            }
                        });
                    });
                });
            });
        }

        private void cbDefaultSignedOutput_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.Checked)
            {
                string key = "", value = "";
                switch (checkBox.Name)
                {
                    case "cbDefaultSignFilePath":
                        {
                            key = DEFAULT_SIGN_FILE_PATH;
                            value = GetSignFilePath();
                        }
                        break;
                    case "cbDefaultSignedOutput":
                        {
                            key = DEFAULT_OUTPUT_APK_PATH;
                            value = tbApkOutputPath.Text;
                        }
                        break;
                    case "cbOpenAfterSign":
                        {
                            key = DEFAULT_OPEN_FOLDER_AFTER_SIGN;
                            value = checkBox.Checked.ToString();
                        }
                        break;
                }
                IniFileHelper.WriteIniFile(CONFIG_FILE, SECTION, key, value);
            }
        }

        private void control_DragDrop(object sender, DragEventArgs e)
        {
            Control? control = sender as Control;
            Array items = (Array)e.Data.GetData(DataFormats.FileDrop, true);
            string value = items.GetValue(0).ToString();
            switch (control.Name)
            {
                case "tbApkFilePath":
                    {
                        tbApkFilePath.Text = value;
                    }
                    break;
                case "combSignFilePath":
                    {
                        combSignFilePath.Text = value;
                    }
                    break;
                case "tbApkOutputPath":
                    {
                        tbApkOutputPath.Text = value;
                    }
                    break;
                case "tbKeystore":
                    {
                        tbKeystore.Text = value;
                    }
                    break;
            }
        }

        private void control_DragEnter(object sender, DragEventArgs e)
        {
            Control? control = sender as Control;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Array items = (Array)e.Data.GetData(DataFormats.FileDrop, true);
                string value = items.GetValue(0).ToString();
                switch (control.Name)
                {
                    case "tbApkFilePath":
                    case "tbKeystore":
                        {
                            if (File.Exists(value))
                            {
                                e.Effect = DragDropEffects.Link;
                            }
                        }
                        break;
                    case "combSignFilePath":
                    case "tbApkOutputPath":
                        {
                            if (Directory.Exists(value))
                            {
                                e.Effect = DragDropEffects.Link;
                            }
                        }
                        break;
                }
            }
        }


        string GetSignFilePath()
        {
            string signFilePath = combSignFilePath.Text;
            if (ConfigSignPaths.ContainsKey(signFilePath))
            {
                signFilePath = ConfigSignPaths[signFilePath];
            }
            return signFilePath;
        }

        private void BtnViewApkInfo_Click(object sender, EventArgs e)
        {
            Utils.GetCmdResultByArguments($"aapt.exe dump badging \"{tbApkFilePath.Text}\"", (e) =>
            {
                BeginInvoke(() =>
                {
                    rtbOutput.Text = e;
                });
            });
        }

        private void BtnInstallApk_Click(object sender, EventArgs e)
        {
            Utils.GetCmdResultByArguments($"adb install \"{tbApkFilePath.Text}\"", (e) =>
            {
                BeginInvoke(() =>
                {
                    rtbOutput.Text = e;
                });
            });
        }

        private void btnGetChecksum_Click(object sender, EventArgs e)
        {
            string cmd = $"type {tbApkFilePath.Text} | openssl dgst -binary -sha256 | openssl base64";
            Utils.GetCmdResultByArguments(cmd, (e) =>
            {
                BeginInvoke(() =>
                {
                    rtbOutput.Clear();
                    string checksum = e.Replace("+", "-").Replace("/", "_").Replace("=", "");
                    rtbOutput.Text = checksum;
                    Clipboard.SetText(checksum);
                });
            });
        }

        private void btnKeystorePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            tbKeystore.Text = ofd.FileName;
        }

        private void btnCheckKeyStoreSign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKeystore.Text))
            {
                MessageBox.Show("请选择证书文件");
                tbKeystore.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbStorePassword.Text))
            {
                MessageBox.Show("请输入证书文件密码");
                tbStorePassword.Focus();
                return;
            }

            if (Directory.Exists(DEFAULT_JRE_PATH))
            {
                Utils.GetCmdResultByArguments($"{Path.Combine(DEFAULT_JRE_PATH, "bin", "keytool.exe")}  -list -v -keystore \"{tbKeystore.Text}\" -storepass {tbStorePassword.Text}", (e) =>
                {
                    BeginInvoke(() =>
                    {
                        rtbOutput.Text = e;
                    });
                });
            }
            else
            {
                Utils.GetCmdResultByArguments($"keytool  -list -v -keystore \"{tbKeystore.Text}\" -storepass {tbStorePassword.Text}", (e) =>
                {
                    BeginInvoke(() =>
                    {
                        rtbOutput.Text = e;
                    });
                });
            }
        }

        private void btnCheckRelease_Click(object sender, EventArgs e)
        {
            Utils.GetCmdResultByArguments($"aapt dump badging \"{tbApkFilePath.Text}\"  | adb shell grep -c application-debuggable", (e) =>
            {
                BeginInvoke(() =>
                {
                    rtbOutput.Text = e.Trim().Equals("0") ? "release" : "debug";
                });
            });
        }

        private void btnImportPwdAndAlias_Click(object sender, EventArgs e)
        {
            const string keystoreInfoFileName = "info.ini";
            string keystorePath = tbKeystore.Text;
            if (!string.IsNullOrEmpty(keystorePath))
            {
                FileInfo fileInfo = new FileInfo(keystorePath);
                if (fileInfo.Exists)
                {
                    try
                    {
                        if (null != fileInfo.Directory)
                        {
                            string path = Path.Combine(fileInfo.DirectoryName.ToString(), keystoreInfoFileName);

                            tbAlias.Text = IniFileHelper.ReadIniFileValue(path, fileInfo.Name, "alias");
                            tbStorePassword.Text = IniFileHelper.ReadIniFileValue(path, fileInfo.Name, "store");
                            tbKeyPassword.Text = IniFileHelper.ReadIniFileValue(path, fileInfo.Name, "key");
                        }                        
                    }
                    catch { 
                    }
                }
            }
        }
    }
}