using System.Diagnostics;
using System.Text;

namespace AndroidApkSignHelper
{
    internal class Utils
    {
        public delegate void GetCmdResultHandler(string e);


        public static void GetCmdResult(string cmd, GetCmdResultHandler handler)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;

                StringBuilder stringBuilder = new StringBuilder();
                p.OutputDataReceived += (sender, e) =>
                {
                    if (e.Data != null && !e.Data.Contains(cmd) && !e.Data.Contains("exit"))
                    {
                        stringBuilder.AppendLine(e.Data);
                        
                    }

                    if (null == e.Data)
                    {                     
                        if (null != handler)
                        {                                       
                            handler(stringBuilder.ToString());
                        }
                    }
                };
                p.Start();

                p.StandardInput.WriteLine(cmd);
                p.StandardInput.WriteLine("exit");

                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Close();
            }
        }
    }
}
