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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 _frm1 = new Form1();
            _frm1.Show();
            _frm1.MdiParent = this;
            _frm1.WindowState = FormWindowState.Maximized;
        }
    }
}
