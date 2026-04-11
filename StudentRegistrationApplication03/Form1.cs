using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRegistrationApplication03;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        OpenFileDialog OPF = new OpenFileDialog();

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
                    ArrayList program = new ArrayList();
                    program.Add("Bachelor of Science in Computer Science");
                    program.Add("Bachelor of Science in Information Technology");
                    program.Add("Bachelor of Science in Information System");
                    program.Add("Bachelor of Science in Computer Engineering");

                    foreach (string prog in program)
                        {
                            cbProgram.Items.Add(prog);
                        }
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
            string program = cbProgram.Text;

            MessageBox.Show(
                "Student name: " + firstName + " " + middleName + " " + lastName + "\nGender: " + gender + "\nDate of birth: " + day + "/" + month + "/" + year + "\nProgram:" + program, "Student Information");
        }

        private void bntBrowse_Click(object sender, EventArgs e)
        {
            OPF.Filter = "Image Files (*.jpg;*.png;*.bmp)|*jpg;*.png:*.bmp";

            if (OPF.ShowDialog() == DialogResult.OK)
            {
                pbStudent.Image = new Bitmap(OPF.FileName);
                pbStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

    }
}

          