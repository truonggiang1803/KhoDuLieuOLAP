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
    public partial class DATETIME : DevExpress.XtraEditors.XtraForm
    {
        KetNoi kn;
        public DATETIME()
        {
            InitializeComponent();
            kn = new KetNoi();
        }
        void load_grid()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from D_DATETIME", kn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_fact.DataSource = dt;
        }
        private void DATETIME_Load(object sender, EventArgs e)
        {
            load_grid();

        }
    }
}