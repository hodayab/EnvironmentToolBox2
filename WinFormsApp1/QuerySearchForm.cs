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
    public partial class QuerySearchForm : Form
    {
        public QuerySearchForm()
        {
            InitializeComponent();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            LoadListBox(checkedListBox1.CheckedItems, e.Index, e.NewValue);
        }

        private void LoadListBox(CheckedListBox.CheckedItemCollection checkedItems, int index, CheckState newValue)
        {
            listBox1.Items.Clear();

            if (checkedItems.Count > 1 || newValue == CheckState.Checked)
            {
                listBox1.Items.Add("Available Cards");
            }
        }

        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                QueryDB queryDB = new QueryDB();
                queryDB.ShowDialog();
            }
        }
    }
}
