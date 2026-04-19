namespace StudentInfoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text) ||
               string.IsNullOrWhiteSpace(txtFirstName.Text) ||
               string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtStudentNumber.Text.Length != 6 || !long.TryParse(txtStudentNumber.Text, out _))
            {
                MessageBox.Show("Student ID must be exactly 6 digits (numbers only).",
                    "Invalid Student ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtStudentNumber.Focus();
                txtStudentNumber.SelectAll();
                return;
            }
            // Create object using overloaded constructor
            StudentInfo student = new StudentInfo(
                txtStudentNumber.Text,
                txtLastName.Text,
                txtFirstName.Text
            );

            // Add to listboxes
            lstStudentID.Items.Add(student.StudentID);
            lstLastName.Items.Add(student.LastName);
            lstFirstName.Items.Add(student.FirstName);

            // Clear input after adding
            txtStudentNumber.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();

            txtStudentNumber.Focus();
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes
            txtStudentNumber.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();

            // Clear listboxes
            lstStudentID.Items.Clear();
            lstLastName.Items.Clear();
            lstFirstName.Items.Clear();

            txtStudentNumber.Focus();
            MessageBox.Show("All data has been cleared.",
           "Cleared",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    public class StudentInfo
    {
        // Private fields
        private string studentnumber;
        private string lastName;
        private string firstName;

        // Default constructor
        public StudentInfo()
        {
            studentnumber = "";
            lastName = "";
            firstName = "";
        }
        public StudentInfo(string studentID, string lastName, string firstName)
        {
            this.studentnumber = studentID;
            this.lastName = lastName;
            this.firstName = firstName;
        }

        // Properties
        public string StudentID
        {
            get { return studentnumber; }
            set { studentnumber = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
    }
}
