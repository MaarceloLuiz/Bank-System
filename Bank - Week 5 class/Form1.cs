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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            Account ac  = new Account();
            ac.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit dp = new Deposit();
            dp.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw w = new Withdraw();
            w.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Transfer t = new Transfer();
            t.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            Transactions ts = new Transactions();
            ts.ShowDialog();
        }
    }
}
