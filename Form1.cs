using System.Diagnostics;

namespace AndroidApkSignHelper
{
    public partial class Form1 : Form
    {
        const string CONFIG_FILE = "config.ini";
        const string SECTION = "Config";
        const string DEFAULT_SIGN_FILE_PATH = "default_sign_file_path";
        const string DEFAULT_OUTPUT_APK_PATH = "default_output_apk_path";

        public Form1()
        {
            InitializeComponent();
            this.Text = Application.ProductName;
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
            tbSignFilePath.Text = folderBrowserDialog.SelectedPath;
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
            Utils.GetCmdResult($"keytool -printcert -jarfile {tbApkFilePath.Text}", (e) =>
            {
                BeginInvoke(() =>
                {
                    rtbOutput.Text = e;
                });
            });
        }

        private void btnApkSignedVersion_Click(object sender, EventArgs e)
        {
            Utils.GetCmdResult($"java -jar apksigner.jar verify -v --print-certs {tbApkFilePath.Text}", (e) =>
            {
                BeginInvoke(() =>
                {
                    rtbOutput.Text = e;
                });
            });
        }

        private void btnSignApk_Click(object sender, EventArgs e)
        {
            string pk8 = Path.Combine(tbSignFilePath.Text, "platform.pk8");
            string pem = Path.Combine(tbSignFilePath.Text, "platform.x509.pem");
            string outApk = Path.Combine(tbApkOutputPath.Text, Path.GetFileNameWithoutExtension(tbApkFilePath.Text) + "-signed.apk");
            string inApk = tbApkFilePath.Text;
            string zipAlginApk = Path.Combine(tbApkOutputPath.Text, Path.GetFileNameWithoutExtension(tbApkFilePath.Text) + "-zipalign.apk");


            string zipCmd = $"zipalign.exe -v 4 \"{inApk}\" \"{zipAlginApk}\"";
            string cmd = $"java -jar apksigner.jar sign --key \"{pk8}\" --cert \"{pem}\" --out \"{outApk}\" --in \"{zipAlginApk}\"";

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

            Utils.GetCmdResult(zipCmd, (e) => {
                BeginInvoke(() =>
                {
                    rtbOutput.Text = e;

                    Utils.GetCmdResult(cmd, (ee) =>
                    {
                        BeginInvoke(() =>
                        {
                            rtbOutput.Text += ee;
                            File.Delete(zipAlginApk);
                            File.Delete(Path.Combine(tbApkOutputPath.Text, Path.GetFileNameWithoutExtension(tbApkFilePath.Text) + "-signed.apk.idsig"));

                            Process.Start("explorer", tbApkOutputPath.Text);
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
                switch(checkBox.Name)
                {
                    case "cbDefaultSignFilePath":
                        {
                            key = DEFAULT_SIGN_FILE_PATH;
                            value = tbSignFilePath.Text;
                        }
                        break;
                    case "cbDefaultSignedOutput":
                        {
                            key = DEFAULT_OUTPUT_APK_PATH;
                            value = tbApkOutputPath.Text;
                        }
                        break;
                }
                IniFileHelper.WriteIniFile(CONFIG_FILE, SECTION, key, value);
            }
        }
    }
}