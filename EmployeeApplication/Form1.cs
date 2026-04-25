namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        List<Employee> employeeList = new List<Employee>();

        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }
        public class Employee
        {
            private int id;
            private string firstName = "";
            private string lastName = "";
            private string position = "";
            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }
            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }
            public string Position
            {
                get { return position; }
                set { position = value; }
            }
            public Employee(int id, string firstName, string lastName, string position)
            {
                this.id = id;
                this.firstName = firstName;
                this.lastName = lastName;
                this.position = position;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "First Name";
            dataGridView1.Columns[2].Name = "Last Name";
            dataGridView1.Columns[3].Name = "Position";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            txtEmployeeID.Focus();
        }
        private void bntSubmit_Click(object sender, EventArgs e)
        {
            int id;

            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("All fields are required.", "Input Error");
                return;
            }
            if (!int.TryParse(txtEmployeeID.Text, out id))
            {
                MessageBox.Show("Employee ID must be numbers only.", "Invalid Input");
                txtEmployeeID.Clear();
                txtEmployeeID.Focus();
                return;
            }
            foreach (Employee emp in employeeList)
            {
                if (emp.Id == id)
                {
                    MessageBox.Show("Employee ID already exists.", "Duplicate Error");
                    txtEmployeeID.Focus();
                    return;
                }
            }
            string fname = txtFirstName.Text.Trim();
            string lname = txtLastName.Text.Trim();

            fname = char.ToUpper(fname[0]) + fname.Substring(1).ToLower();
            lname = char.ToUpper(lname[0]) + lname.Substring(1).ToLower();

            string pos = txtPosition.Text.Trim();
            Employee newEmp = new Employee(id, fname, lname, pos);

            employeeList.Add(newEmp);

            dataGridView1.Rows.Add(newEmp.Id, newEmp.FirstName, newEmp.LastName, newEmp.Position);
            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPosition.Clear();

            txtEmployeeID.Focus();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtEmployeeID.Text = row.Cells[0].Value.ToString();
                txtFirstName.Text = row.Cells[1].Value.ToString();
                txtLastName.Text = row.Cells[2].Value.ToString();
                txtPosition.Text = row.Cells[3].Value.ToString();
            }
        }
        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int index = dataGridView1.CurrentRow.Index;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this employee?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                employeeList.RemoveAt(index);

                dataGridView1.Rows.RemoveAt(index);

                MessageBox.Show("Employee deleted successfully.");

                txtEmployeeID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPosition.Clear();

                txtEmployeeID.Focus();
            }
        }
    }
}

    

        