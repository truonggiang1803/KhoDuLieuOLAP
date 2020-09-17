using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.DataAccess.Excel;
using System.Data.OleDb;

namespace DoAn
{
    public partial class FACT_SALES : DevExpress.XtraEditors.XtraForm
    {
        KetNoi kn;
        KetNoiCsdl kncsdl;
        public FACT_SALES()
        {
            InitializeComponent();
            kn = new KetNoi();
            kncsdl = new KetNoiCsdl();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void load_grid()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from FACT_SALES", kn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_fact.DataSource = dt;
        }
        private void btn_Nap_Click(object sender, EventArgs e)
        {

        }

        private void FACT_SALES_Load(object sender, EventArgs e)
        {
            load_grid();
        }

        private void btn_NapSQL_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_NapExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Nap_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("Delete from FACT_SALES", kn.conn);
                kn.conn.Open();
                cmd1.ExecuteNonQuery();
                kn.conn.Close();
                //
                string fileName = "";
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {


                    fileName = dlg.FileName;
                    MessageBox.Show(fileName);
                }
                //
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx", ValidateNames = true })
                {
                    //String filename = @"E:\KH2-NAM3\CSDL_OLAP\Fact.xlsx";
                    String connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;\"";
                    String Command = "Select * from [Sheet1$]";
                    OleDbConnection con = new OleDbConnection(connection);
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(Command, con);
                    OleDbDataAdapter db = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    db.Fill(dt);
                    con.Close();
                    ///
                    SqlCommand cmd2 = new SqlCommand("dbo.InsertFACT", kn.conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlParameter tvparam = cmd2.Parameters.AddWithValue("@dt", dt);
                    tvparam.SqlDbType = SqlDbType.Structured;
                    kn.conn.Open();
                    cmd2.ExecuteNonQuery();
                    kn.conn.Close();
                    ////
                    dgv_fact.DataSource = "";
                    load_grid();

                }
            }
            catch
            {
                MessageBox.Show("Bạn cần nhập bản Dimension trước");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("Delete from FACT_SALES", kn.conn);
                kn.conn.Open();
                cmd1.ExecuteNonQuery();
                kn.conn.Close();
                ///
                SqlDataAdapter da = new SqlDataAdapter("Select * from FACT_SALES", kncsdl.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlCommand cmd = new SqlCommand("dbo.InsertFACT", kn.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter tvparam = cmd.Parameters.AddWithValue("@dt", dt);
                tvparam.SqlDbType = SqlDbType.Structured;
                //cmd.Parameters.Add(tvparam);
                kn.conn.Open();
                cmd.ExecuteNonQuery();
                kn.conn.Close();
                dgv_fact.DataSource = "";
                load_grid();
            }
            catch
            {
                MessageBox.Show("Bạn cần nhập bản Dimension trước");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Delete from FACT_SALES", kn.conn);
            kn.conn.Open();
            cmd1.ExecuteNonQuery();
            kn.conn.Close();
            load_grid();
        }
    }
}