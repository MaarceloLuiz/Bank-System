using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank___Week_5_class
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        AddData ad = new AddData();

        private void Account_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(County));
            cboType.DataSource = Enum.GetValues(typeof(AccType));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string fn = txtFn.Text;
            string sn = txtSn.Text;
            string dob = dtpDOB.Text;
            string cy = cboCounty.SelectedItem.ToString();
            string ge = "Male";
            if (rbFemale.Checked) ge = "Female";
            string type = cboType.SelectedItem.ToString();
            decimal deposit = decimal.Parse(txtDeposit.Text);

            ad.AddNewAccount(fn, sn, dob, cy, ge, deposit, type);

            MessageBox.Show("Data Added", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFn.Clear();
            txtSn.Clear();
            txtDeposit.Clear();
        }
    }
}
