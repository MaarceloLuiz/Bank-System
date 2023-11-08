using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Bank___Week_5_class
{
    internal class DAO
    {
        SqlConnection conn;

        public DAO()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString);
        }

        public SqlConnection OpenCon()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }

            return conn;
        }

        public void CloseCon()
        {
            if (conn != null) //it means that the connection exists
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            //if it doesnt exist, nothing will happen
        }
    }
}
