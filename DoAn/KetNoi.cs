using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class KetNoi
    {
        SqlConnection _conn;
        public SqlConnection conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public KetNoi()
        {
            conn = new SqlConnection("Data Source=DESKTOP-HHM5LAU;Initial Catalog=DW_CHOLON1;User= sa;Password=sa2012;Integrated Security=True");
        }
    }
}
