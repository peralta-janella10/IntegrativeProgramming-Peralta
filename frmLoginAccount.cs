using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uName = txtUserName.Text;
            string pass = txtPassword.Text;

            if (uName == "" || pass == "")
            {
                MessageBox.Show("Please enter username and password.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Cashier cashier = new Cashier(uName, uName, pass);

            MessageBox.Show("Welcome " + cashier.getFullName() + " of " + cashier.getDepartment(),
                            "Login Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            frmPurchaseDiscountedItem frm = new frmPurchaseDiscountedItem();
            frm.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }
    }
}
