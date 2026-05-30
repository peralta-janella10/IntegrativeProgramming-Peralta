using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void frmComputeSalary_Load(object sender, EventArgs e)
        {

        }

        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string department = txtDepartment.Text;
            string jobtitle = txtJobTitle.Text;

            double ratePerHour = double.Parse(txtRate.Text);
            int hoursWorked = int.Parse(txtTotal.Text);

            PartTimeEmployee emp = new PartTimeEmployee (firstname, lastname, department, jobtitle);

            emp.computeSalary (hoursWorked, hoursWorked);

            lblFirstName.Text =  emp.FirstName;
            lblLastName.Text = emp.LastName;
            lblBasicSalary.Text =  emp.BasicSalary.ToString();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblBasicSalary_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
