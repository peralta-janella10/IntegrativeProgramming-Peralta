namespace Peralta_StudentGradeAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct Student
        {
            public string number;
            public string name;
            public double prelim;
            public double midterm;
            public double final;
            public double average;
            public string remarks;
        }

        double Average(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }

        double Average(double a, double b)
        {
            return (a + b) / 2;
        }

        static string CheckRemarks(double avg)
        {
            if (avg >= 75)
                return "Passed";
            else
                return "Failed";
        }

        void ShowData(Student s)
        {
            listBox1.Items.Add("Student No: " + s.number);
            listBox1.Items.Add("Name: " + s.name);
            listBox1.Items.Add("Average: " + s.average);
            listBox1.Items.Add("Remarks: " + s.remarks);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void bntCompute_Click(object sender, EventArgs e)
        {
            if (txtStudentNo.Text == "")
            {
                MessageBox.Show("Enter student number");
                txtStudentNo.Focus();
                return;
            }
            if (!long.TryParse(txtStudentNo.Text, out _))
            {
                MessageBox.Show("Numbers only for student number");
                txtStudentNo.Clear();
                txtStudentNo.Focus();
                return;
            }
            try
            {
                Student s;

                s.number = txtStudentNo.Text;
                s.name = txtName.Text;
                s.prelim = Convert.ToDouble(txtPrelim.Text);
                s.midterm = Convert.ToDouble(txtMidterm.Text);
                s.final = Convert.ToDouble(txtFinal.Text);
                s.average = Average(s.prelim, s.midterm, s.final);
                s.remarks = CheckRemarks(s.average);
                ShowData(s);
            }
            catch
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void bntCLear_Click(object sender, EventArgs e)
        {
            txtStudentNo.Text = "";
            txtName.Text = "";
            txtPrelim.Text = "";
            txtMidterm.Text = "";
            txtFinal.Text = "";

            listBox1.Items.Clear();
            txtStudentNo.Focus();
        }

        private void txtStudentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
