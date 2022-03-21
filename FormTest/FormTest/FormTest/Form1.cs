using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] arr = new string[2];
            arr[0] = txbName.Text;
            arr[1] = dtpBirthday.Text;

            var item = new ListViewItem(arr);
            lsbUser.Items.Add(item);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (lsbUser.Items.Count > 0)
            {
                var item = lsbUser.SelectedItems;
                lsbUser.Items.Remove(item[0]);
            }
        }

        private void lsbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbUser.SelectedItems.Count > 0)
            {
                txbName.Text = lsbUser.SelectedItems[0].SubItems[0].Text;
                var birthday = lsbUser.SelectedItems[0].SubItems[1].Text;
                dtpBirthday.Value = Convert.ToDateTime(birthday);

            }
        }
    }
}
