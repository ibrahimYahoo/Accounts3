using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Code
{
    class DBConn
    {
        public static SqlConnection GetInstance()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ibrahim-01\\accounts2.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            return conn;
        }

    }
}
