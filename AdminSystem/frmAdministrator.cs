using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSystem
{
    public partial class frmAdministrator : Form
    {
        Administrator admin;

        public frmAdministrator()
        {
            InitializeComponent();

            btnUpdatePassword.Enabled = false;
            btnUpdateName.Enabled = false;
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pass = txtPassword.Text;

            if (id == "" || pass == "")
            {
                MessageBox.Show("Please enter ID and Password.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            admin = new Administrator(id, id, pass);

            MessageBox.Show("Login Successful! Welcome " + id,
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            btnUpdatePassword.Enabled = true;
            btnUpdateName.Enabled = true;
            lblStatus.Text = "Logged in as: " + id;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPass = txtNewPassword.Text;

            if (newPass == "")
            {
                MessageBox.Show("Please enter new password.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            admin.updatePassword(newPass);
            MessageBox.Show("Password updated successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            txtNewPassword.Clear();
        }

        private void btnAdminName_Click(object sender, EventArgs e)
        {
            string newName = txtNewName.Text;

            if (newName == "")
            {
                MessageBox.Show("Please enter new admin name.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            admin.updateAdminName(newName);
            MessageBox.Show("Admin name updated to: " + newName,
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            lblStatus.Text = "Logged in as: " + newName;
            txtNewName.Clear();
        }

        private void chkPass1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '•';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
    }
