using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giai_Phuong_Trinh_Froms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetControl();
        }

        public void SetControl()
        {
            rdbPhuongTrinhBac1.Checked = true;
            txbc.Enabled = false;
            txbKetQua.Enabled = false;
        }

        private void rdbPhuongTrinhBac1_CheckedChanged_1(object sender, EventArgs e)
        {
            txbc.Enabled = false;
        }

        private void rdbPhuongTrinhBac2_CheckedChanged_1(object sender, EventArgs e)
        {
            txbc.Enabled = true;
        }

        //nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        //nút Xoá
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txba.Text = " ";
            txbb.Text = " ";
            txbc.Text = " ";
            txbKetQua.Text = " ";
        }

        //nút giải
        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                double ValueA = 0;
                double ValueB = 0;
                double ValueC = 0;

                if(txba.Text == "") { MessageBox.Show("Chưa nhập giá trị a", "Thông Báo");txba.Focus(); }
                if(txbb.Text == "") { MessageBox.Show("Chưa nhập giá trị b", "Thông Báo");txbb.Focus(); }

                if(double.TryParse(txba.Text,out ValueA) == false)
                {
                    MessageBox.Show("Giá trị a không phải là số", "Thông Báo");txba.Focus();
                } 
                if(double.TryParse(txbb.Text,out ValueB) == false)
                {
                    MessageBox.Show("Giá trị b không phải là số", "Thông Báo");txbb.Focus(); return;
                }

                if(rdbPhuongTrinhBac1.Checked == true)
                {
                    // Giải PT bậc 1
                    if(ValueA == 0)
                    {
                        if (ValueB == 0)
                        {
                            txbKetQua.Text = "PT có vô số nghiệm";
                        }
                        else
                        {
                            txbKetQua.Text = "PT vô nghiệm";
                        }
                    }
                    else
                    {
                        txbKetQua.Text = "PT co nghiệm x= " + Math.Round((-ValueB/ValueA),2);
                    }
                }
                else
                {
                    if (txbc.Text == "") { MessageBox.Show("Chưa nhập giá trị c", "Thông Báo"); txbc.Focus(); }
                    if (double.TryParse(txba.Text, out ValueC) == false)
                    {
                        MessageBox.Show("Giá trị c không phải là số", "Thông Báo"); txbc.Focus();
                    }
                    double delta = ValueB * ValueB - 4 * ValueA * ValueC;
                     if(delta < 0)
                    {
                        txbKetQua.Text = "PT vô nghiệm";
                    }
                    else if(delta == 0)
                    {
                        txbKetQua.Text = " PT có nghiệm kép x= " + Math.Round((-ValueB / (2 * ValueA)), 2);
                    }
                    else
                    {
                        txbKetQua.Text = "PT có 2 nghiệm x1= " + Math.Round((-ValueB + Math.Sqrt(delta)/2*ValueA)) 
                            +",x2=" + Math.Round((-ValueB - Math.Sqrt(delta) / 2 * ValueA));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }











        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
    
}
