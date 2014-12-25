using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAccountPraacticeApp
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        AccountClass accounts = new AccountClass();
        private void createButton_Click(object sender, EventArgs e)
        {
            //AccountClass accounts = new AccountClass();
            accounts.accountNo = accountNoTextBox.Text;
            accounts.customerName = customerNameTextBox.Text;

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
      
            Double tempAmount = Convert.ToDouble(amountTextBox.Text);
          accounts.amount=  accounts.GetDeposit(tempAmount);
           // string tempDeposit= Convert.ToString(accounts.GetDeposit(amountTextBox.Text));

        }

        private void withDrawButton_Click(object sender, EventArgs e)
        {
            if (accounts.amount != 0)
            {
                Double tempAmount = Convert.ToDouble(amountTextBox.Text);
                accounts.amount = accounts.GetWithdraw(tempAmount);
            }
            else {

                MessageBox.Show("Overflow Your amount");
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account No is  :" + accounts.accountNo + " and Cuurent Balance is : " + accounts.amount);
        }
    }
}
