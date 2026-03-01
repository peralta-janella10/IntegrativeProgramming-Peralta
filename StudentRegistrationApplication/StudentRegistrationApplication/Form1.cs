using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            for (int d = 1; d <= 31; d++)
            {
                cbDay.Items.Add(d.ToString());
            }
            for (int m = 1; m <= 12; m++)
            {
                cbMonth.Items.Add(m.ToString());
            }
            int currentYear = DateTime.Now.Year;
            for (int y = 1900; y <= currentYear; y++)
            {
                cbYear.Items.Add(y.ToString());

        {
            }
        }
    }
        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;

            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }

            string day = cbDay.Text;
            string month = cbMonth.Text;
            string year = cbYear.Text;

            MessageBox.Show(
                "Student name: " + firstName + " " + middleName + " " + lastName + "\nGender: " + gender + "\nDate of birth: " + day + "/" + month + "/" + year
            );
        }
    }
}
