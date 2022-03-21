using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_Conected
{
    public partial class Form1 : Form
    {
        public string State = "";
        public string connectionString = @"Data Source= ;Initial Catalog=;User ID= ;Password= ;";
        public Form1()
        {
            InitializeComponent();
            State = "Reset";
            SetControl(State);
            GetData();
        }

        #region Public functions
        public void GetData()
        {
            try 
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM tblKhoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count >0 )
                {
                    lblTotal.Text = "Tổng số: " + ds.Tables[0].Rows.Count + "bản ghi";
                    dgvKhoa.DataSource = ds.Tables[0];
                }
                else
                {
                    dgvKhoa.DataSource = new object[0];
                    lblTotal.Text = "Tổng số: 0 bản ghi";
                }


                conn.Close();
            }
            catch(Exception ex) 
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }


        #region Manager Interface
        public void SetControl(string State)
        {
            switch (State)
            {
                case "Reset":
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuyBo.Enabled = false;
                    
                    
                    
                    break;
                default:
                    break;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
