using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chon_Mon_The_Thao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetControl();
            SetCombobox();
        }

        public void SetCombobox()
        {
            cboName.Items.Add("Nguyễn Đức Phúc Lộc");
            cboName.Items.Add("Nguyễn Đức Hoàng Long");
            cboName.Items.Add("Nguyễn Đức Hoàng Lam");
        }
         
        public void SetControl()
        {
            lsbInfo.Items.Add("Bóng đá");
            lsbInfo.Items.Add("Bóng bàn");
            lsbInfo.Items.Add("Nhảy dù");
            lsbInfo.Items.Add("Bập bênh");
        }












        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInputAll_Click(object sender, EventArgs e)
        {
            for(int i= 0; i<lsbInfo.Items.Count; i++)
            {
                lsbChoose.Items.Add(lsbInfo.Items[i]);
            }
            lsbInfo.Items.Clear();
        }

        private void btnOutputAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbChoose.Items.Count; i++)
            {
                lsbInfo.Items.Add(lsbChoose.Items[i]);
            }
            lsbChoose.Items.Clear();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var item = lsbInfo.SelectedItem;
            if(item != null)
            {
                lsbChoose.Items.Add(item);
                lsbInfo.Items.Remove(item);
            }
            else
            {
                MessageBox.Show("Chưa chọn môn thể thao", "Thông Báo");
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            var item = lsbChoose.SelectedItem;
            if (item != null)
            {
                lsbInfo.Items.Add(item);
                lsbChoose.Items.Remove(item);
            }
            else
            {
                MessageBox.Show("Chưa chọn môn thể thao", "Thông Báo");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtbKetQua.Text = "";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string name = cboName.Text;
            string Time = dtpDate.Text + " " + dtpTime.Text;
            string subject = "";
            for(int i = 0;i< lsbChoose.Items.Count; i++)
            {
                subject += lsbChoose.Items[i].ToString() + ",";

            }
            if(subject == "")
            {
                rtbKetQua.Text = name + "\n" + Time + "\n" + "Chưa có môn nào được chọn";

            }
            else
            {
                rtbKetQua.Text = name + "\n" + Time + "\n" + "Môn thể thao được chọn là:"
                    + subject.Substring(0, subject.Length - 1);
            }
        }
    }
}
