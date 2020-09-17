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

namespace DoAn
{
    public partial class CHUNGLOAI : DevExpress.XtraEditors.XtraForm
    {
        KetNoi kn;
        KetNoiCsdl kncsdl;
        public CHUNGLOAI()
        {
            InitializeComponent();
            kn = new KetNoi();
            kncsdl = new KetNoiCsdl();
        }
        void load_grid()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from D_CHUNGLOAI", kn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_fact.DataSource = dt;
        }
        private void CHUNGLOAI_Load(object sender, EventArgs e)
        {
            load_grid();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("Delete from D_CHUNGLOAI", kn.conn);
                kn.conn.Open();
                cmd1.ExecuteNonQuery();
                kn.conn.Close();
                ///
                SqlDataAdapter da = new SqlDataAdapter("Select * from D_CHUNGLOAI", kncsdl.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlCommand cmd = new SqlCommand("dbo.InsertCHUNGLOAI", kn.conn);
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
                MessageBox.Show("Bạn Chưa xóa bản Fact");
            }
        }
    }
}