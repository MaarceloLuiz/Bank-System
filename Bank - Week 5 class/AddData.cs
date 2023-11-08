using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Bank___Week_5_class
{
    internal class AddData : DAO
    {
        public void AddNewAccount(string fn, string sn, string dob, string cy, string ge, decimal bal, string acty)
        {
            SqlCommand cmd = OpenCon().CreateCommand();

            //collecting the information we inserted in the StoredProcedure
            cmd.CommandText = "uspAddAcc";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@ge", ge);
            cmd.Parameters.AddWithValue("@bal", bal);
            cmd.Parameters.AddWithValue("@acty", acty);

            cmd.ExecuteNonQuery();
            CloseCon();
        }
    }
}

