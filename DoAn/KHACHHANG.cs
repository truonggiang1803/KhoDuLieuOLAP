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
    
    public partial class KHACHHANG : DevExpress.XtraEditors.XtraForm
    {
        KetNoi kn;
        public KHACHHANG()
        {
            InitializeComponent();
            kn = new KetNoi();
        }
        void load_grid()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from D_KHACHHANG", kn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_fact.DataSource = dt;
        }
        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            load_grid();
        }
    }
}