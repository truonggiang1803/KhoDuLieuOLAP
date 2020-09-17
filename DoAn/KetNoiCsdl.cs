using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class KetNoiCsdl
    {
        SqlConnection _conn;
        public SqlConnection conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public KetNoiCsdl()
        {
            conn = new SqlConnection("Data Source=DESKTOP-HHM5LAU;Initial Catalog=QLBANHANGCHOLON_OLAP;User= sa;Password=sa2012;Integrated Security=True");
        }
    }
}
