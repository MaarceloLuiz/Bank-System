using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank___Week_5_class
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        DAO dao = new DAO();
        SqlDataReader dr;

        private void Transfer_Load(object sender, EventArgs e)
        {
            PopCombo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTransfer_Click_1(object sender, EventArgs e)
        {
            MoneyTransfer();
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
                cboFromAcc.Items.Add(acc);
                cboToAcc.Items.Add(acc);
            }
            dao.CloseCon();
        }

        private void cboFromAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accNum = cboFromAcc.SelectedItem.ToString();

            GetData(accNum, lblDisplayFrom, txtBalFrom);
        }

        private void cboToAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accNum = cboToAcc.SelectedItem.ToString();

            GetData(accNum, lblDisplayTo, txtBalanceTo);
        }

        void GetData(string accNum, Label label, TextBox textBox)
        {
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

                label.Text = fn + " " + sn + " from " + cy;
                textBox.Text = bal;
            }
            dao.CloseCon();
        }
        void MoneyTransfer()
        {
            string accFrom = cboFromAcc.SelectedItem.ToString();
            string accTo = cboToAcc.SelectedItem.ToString();

            decimal balFrom = decimal.Parse(txtBalFrom.Text);
            decimal balTo = decimal.Parse(txtBalanceTo.Text);

            decimal amt = decimal.Parse(txtAmtFrom.Text);

            //if the transaction fails, it will be set back to the initial balance
            decimal nbFrom = balFrom;
            decimal nbTo = balTo;

            if (amt <= balFrom)
            {
                nbFrom = balFrom - amt;
                nbTo = balTo + amt;
                MessageBox.Show("Transaction Completed\n you tranfered: " + amt + " euro" + "\nYour balance is now: " + nbFrom, "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Transaction Completed\n the recepient received: " + amt + " euro" + "\nTheir balance is now: " + nbTo, "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Insufficient Funds\n Max withdraw: " + balFrom, "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspTransfer";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@acNoFrom", accFrom);
            cmd.Parameters.AddWithValue("@nbFrom", nbFrom);

            cmd.Parameters.AddWithValue("@acNoTo", accTo);
            cmd.Parameters.AddWithValue("@nbTo", nbTo);

            cmd.ExecuteNonQuery();
            dao.CloseCon();

            txtBalFrom.Clear();
        }
    }
}
