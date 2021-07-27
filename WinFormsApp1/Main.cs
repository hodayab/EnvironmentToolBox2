using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuerySearchForm win = new QuerySearchForm();
            win.Show();
        }

        private void button_openCommonTools_Click(object sender, EventArgs e)
        {
            CommonTools win = new CommonTools();
            win.Show();
        }

        private void ConnectToPulseButton_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (s, e) =>
            {
                string _username = ConfigurationManager.AppSettings["Username"];
                string _password = ConfigurationManager.AppSettings["Password"];

                Process p = new Process();
                p.StartInfo.FileName = ConfigurationManager.AppSettings["PulseSecurePath"];
                p.StartInfo.Arguments = $"-u {_username} -p {_password} -url pulsesecure.ncr.com -r NCR";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.Start();
                //var output = pulseLauncherProcess.StandardOutput.ReadToEnd();
                var outputErr = p.StandardError.ReadToEnd();
                p.WaitForExit();

                MessageBox.Show(outputErr);
            };
            worker.RunWorkerAsync();
        }
    }
}
