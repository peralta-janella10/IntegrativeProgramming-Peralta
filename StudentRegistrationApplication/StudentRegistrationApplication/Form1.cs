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
            string[] month = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (string m in month)
            {
                cbMonth.Items.Add(m.ToString());
            }
            int currentYear = DateTime.Now.Year;
            for (int y = 1900; y <= currentYear; y++)
            {
                cbYear.Items.Add(y.ToString());

                {
                }
                cbProgram.Items.Add("Select Program");
                string[] program = { "Bachelor of Science in Computer Science", "Bacherlor of Science in Information Technology", "Bachelor Science in Information Systems ", "Bachelor Science in Computer Engineering" };

                foreach (string course in program)
                {
                    cbProgram.Items.Add(course);
                }
                cbProgram.SelectedIndex = 0;

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
            string program = cbProgram.Text;

            MessageBox.Show(
                "Student name: " + firstName + " " + middleName + " " + lastName + "\nGender: " + gender + "\nDate of birth: " + day + "/" + month + "/" + year + "\nProgram:" + program);
        }
    }
}