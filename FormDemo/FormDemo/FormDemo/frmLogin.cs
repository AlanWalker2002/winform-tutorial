using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string account = "PhucLoc";
                string password = "123";

                if (txtAc.Text == account && txtPwd.Text == password)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                    this.Hide();
                    /* Form1 _form1 = new Form1();
                     _form1.Show();*/
                    Form2 _form2 = new Form2();
                    _form2.Show();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
