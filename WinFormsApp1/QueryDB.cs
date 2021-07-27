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
    public partial class QueryDB : Form
    {
        public QueryDB()
        {
            InitializeComponent();
        }

        private void QueryDB_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("30234242", "300", "12/05/2022", "Valid");
            dataGridView1.Rows.Add("12321313", "1000", "27/03/2023", "Valid");
            dataGridView1.Rows.Add("23223232", "-300", "04/11/2018", "Not Valid");
            dataGridView1.Rows.Add("45454545", "200", "12/05/2021", "Not Valid");
            dataGridView1.Rows.Add("09019432", "100", "12/08/2022", "Valid");
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow a in dataGridView1.SelectedRows)
            {
                a.Cells[1].Value = txtAmount.Text;
            }
            
        }
    }
}
