using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank___Week_5_class
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        DAO dao = new DAO();
        SqlDataReader dr;

        private void Withdraw_Load(object sender, EventArgs e)
        {
            PopCombo();
        }

        private void cboAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accNum = cboAcc.SelectedItem.ToString();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspGetBalance";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@acNo", accNum);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string fn = dr["FirstName"].ToString();
                string sn = dr["Surname"].ToString();
                string cy = dr["County"].ToString();
                string bal = dr["Balance"].ToString();

                lblDisplay.Text = fn + " " + sn + " from " + cy;
                txtBal.Text = bal;
            }
            dao.CloseCon();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string accNum = cboAcc.SelectedItem.ToString();
            decimal bal = decimal.Parse(txtBal.Text);
            decimal amt = decimal.Parse(txtAmt.Text);
            //if the transaction fails, it will be set back to the initial balance
            decimal nb = bal;

            if (amt <= bal)
            {
                nb = bal - amt;
                MessageBox.Show("Transaction Completed\n you withdrew: " + amt + " euro" + "\nYour balance is now: " + nb, "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Insufficient Funds\n Max withdraw: " + bal, "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspUpdateBalance";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@acNo", accNum);
            cmd.Parameters.AddWithValue("@nb", nb);

            cmd.ExecuteNonQuery();
            dao.CloseCon();

            txtAmt.Clear();
            txtBal.Clear();
        }

        void PopCombo()
        {
            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspPopCombo";
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string acc = dr["AccNum"].ToString();
                cboAcc.Items.Add(acc);
            }
            dao.CloseCon();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
