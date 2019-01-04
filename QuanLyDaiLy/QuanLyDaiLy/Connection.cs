using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    class Connection
    {
        public SqlConnection GetConnect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UA1M0MG\SQLEXPRESS2008;Initial Catalog=DaiLy2;Integrated Security=True");
            return con;
        }
    }
}
