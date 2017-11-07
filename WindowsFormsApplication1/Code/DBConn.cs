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
            string path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "DbAccounts.mdf";
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=" +path+@"\"+databaseName+";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            return conn;
        }

    }
}
