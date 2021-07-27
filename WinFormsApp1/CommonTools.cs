using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class CommonTools : Form
    {

        string spookyPath;
        string devToolPath;
        string migrationDbPath;
        string officePath;
        string tfsPath;

        private NameValueCollection appConfig;

        public NameValueCollection AppConfig
        {
            get
            {
                if (appConfig == null)
                    appConfig = ConfigurationManager.AppSettings;
                return appConfig;
            }
            set { appConfig = value; }
        }


        public CommonTools()
        {
            InitializeComponent();

            readAppSettings();

        }


        void readAppSettings()
        {
            try
            {                 
                if (AppConfig.Count > 0)
                {
                    spookyPath = readAppSetting("spookyPath");
                    devToolPath = readAppSetting("devToolPath");
                    migrationDbPath = readAppSetting("migrationDbPath");
                    officePath = readAppSetting("officePath");
                    tfsPath = readAppSetting("tfsPath");
                }
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[ReadAppSettings: {0}]", e.ToString());
            }
        }

        private string readAppSetting(string key)
        {
            if (AppConfig.AllKeys.Contains(key))
                return AppConfig[key];
            else
                return String.Empty;
        }

        private void button_openSpooky_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(spookyPath);
        }

        private void button_devTool_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(devToolPath);
        }

        private void button_office_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = officePath,
                UseShellExecute = true
            });
        }

        private void button_tfs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = tfsPath,
                UseShellExecute = true
            });
        }
    }
}
