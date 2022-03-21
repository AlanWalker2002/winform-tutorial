using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xep_Loai_Hoc_Luc_Froms
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
            txbKetQua.Enabled = false;
            txbXepLoai.Enabled = false;
        }







        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txbName.Text = " ";
            txb_Diem1.Text = " ";
            txb_Diem2.Text = " ";
            txb_Diem3.Text = " ";
            txb_Diem4.Text = " ";
            txb_stc1.Text = " ";
            txb_stc2.Text = " ";
            txb_stc3.Text = " ";
            txb_stc4.Text = " ";
            txbKetQua.Text = " ";
            txbXepLoai.Text = " ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                double ValueA = 0;
                double ValueB = 0;
                double ValueC = 0;
                double ValueD = 0;
                double ValueE = 0;
                double ValueF = 0;
                double ValueG = 0;
                double ValueH = 0;
                if (txb_stc1.Text == "") { MessageBox.Show("Chưa nhập Số tín chỉ môn C#", "Thông Báo"); txb_stc1.Focus(); }
                if (txb_stc2.Text == "") { MessageBox.Show("Chưa nhập Số tín chỉ môn Web", "Thông Báo"); txb_stc2.Focus(); }
                if (txb_stc3.Text == "") { MessageBox.Show("Chưa nhập Số tín chỉ môn Dữ liệu và giải thuật", "Thông Báo"); txb_stc3.Focus(); }
                if (txb_stc4.Text == "") { MessageBox.Show("Chưa nhập Số tín chỉ môn Java", "Thông Báo"); txb_stc4.Focus(); }
                if (txb_Diem1.Text == "") { MessageBox.Show("Chưa nhập Điểm môn C#", "Thông Báo"); txb_Diem1.Focus(); }
                if (txb_Diem2.Text == "") { MessageBox.Show("Chưa nhập Điểm môn Web", "Thông Báo"); txb_Diem2.Focus(); }
                if (txb_Diem3.Text == "") { MessageBox.Show("Chưa nhập Điểm môn Dữ liệu và giải thuật", "Thông Báo"); txb_Diem3.Focus(); }
                if (txb_Diem4.Text == "") { MessageBox.Show("Chưa nhập Điểm môn Java", "Thông Báo"); txb_Diem4.Focus(); }

                if (double.TryParse(txb_stc1.Text, out ValueA) == false)
                {
                    MessageBox.Show("Số tín chỉ môn C# không phải là số", "Thông Báo"); txb_stc1.Focus();
                }
                
                if (double.TryParse(txb_stc2.Text, out ValueB) == false)
                {
                    MessageBox.Show("Số tín chỉ môn Web không phải là số", "Thông Báo"); txb_stc2.Focus();
                }

                if (double.TryParse(txb_stc3.Text, out ValueC) == false)
                {
                    MessageBox.Show("Số tín chỉ môn Dữ liệu và giải thuật không phải là số", "Thông Báo"); txb_stc3.Focus();
                }

                if (double.TryParse(txb_stc4.Text, out ValueD) == false)
                {
                    MessageBox.Show("Số tín chỉ môn Java không phải là số", "Thông Báo"); txb_stc4.Focus();
                }
                
                if (double.TryParse(txb_Diem1.Text, out ValueE) == false)
                {
                    MessageBox.Show("Điểm môn C# không phải là số", "Thông Báo"); txb_Diem1.Focus();
                }
                
                if (double.TryParse(txb_Diem2.Text, out ValueF) == false)
                {
                    MessageBox.Show("Điểm môn Web không phải là số", "Thông Báo"); txb_Diem2.Focus();
                }
                
                if (double.TryParse(txb_Diem3.Text, out ValueG) == false)
                {
                    MessageBox.Show("Điểm môn Dữ liệu và giải thuật không phải là số", "Thông Báo"); txb_Diem3.Focus();
                }
                
                if (double.TryParse(txb_Diem4.Text, out ValueH) == false)
                {
                    MessageBox.Show("Điểm môn Java không phải là số", "Thông Báo"); txb_Diem4.Focus();
                }

                 double TongStc = ValueA + ValueB + ValueC + ValueD;
                 double TongDiem = (ValueA *ValueE) + (ValueB *ValueF) + (ValueC *ValueG)+(ValueD*ValueH);
                double DiemTB = Math.Round((TongDiem / TongStc),2);
                txbKetQua.Text = " " + Math.Round( DiemTB,2);

                if(DiemTB > 9 && DiemTB <= 10)
                {
                    txbXepLoai.Text = "Xếp loại Xuất Xắc";
                }
                else if(DiemTB > 8 && DiemTB <= 9)
                {
                    txbXepLoai.Text =  "Xếp Loại Giỏi ";
                }
                else if (DiemTB > 6.5 && DiemTB <=8 )
                {
                    txbXepLoai.Text = "Xếp Loại Khá ";
                }
                else if (DiemTB > 5 && DiemTB <= 6.5)
                {
                    txbXepLoai.Text = "Xếp Loại Trung Bình ";
                }
                else
                {
                    txbXepLoai.Text = "Xếp Loại Yếu";
                }


            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
