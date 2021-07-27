using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button_log_Click(object sender, EventArgs e)
        {
            ShowLogs win = new ShowLogs();
            win.Show();
        }
    }
}
