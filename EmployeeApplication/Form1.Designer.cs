namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtEmployeeID = new TextBox();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtPosition = new TextBox();
            label5 = new Label();
            bntSubmit = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colPosition = new DataGridViewTextBoxColumn();
            bntDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(156, 36);
            label1.TabIndex = 0;
            label1.Text = "Add Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 1;
            label2.Text = "Employee ID*";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(12, 105);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(190, 23);
            txtEmployeeID.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 170);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(190, 23);
            txtFirstName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(83, 24);
            label3.TabIndex = 3;
            label3.Text = "First Name*";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 235);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(190, 23);
            txtLastName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(81, 24);
            label4.TabIndex = 5;
            label4.Text = "Last Name*";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(12, 301);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(190, 23);
            txtPosition.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 271);
            label5.Name = "label5";
            label5.Size = new Size(67, 24);
            label5.TabIndex = 7;
            label5.Text = "Position*";
            // 
            // bntSubmit
            // 
            bntSubmit.BackColor = Color.SteelBlue;
            bntSubmit.FlatStyle = FlatStyle.Flat;
            bntSubmit.ForeColor = Color.White;
            bntSubmit.Location = new Point(12, 347);
            bntSubmit.Name = "bntSubmit";
            bntSubmit.Size = new Size(90, 30);
            bntSubmit.TabIndex = 9;
            bntSubmit.Text = "Submit";
            bntSubmit.UseVisualStyleBackColor = false;
            bntSubmit.Click += bntSubmit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Myanmar Text", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(250, 68);
            label6.Name = "label6";
            label6.Size = new Size(151, 36);
            label6.TabIndex = 10;
            label6.Text = "Employee List:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colFirstName, colLastName, colPosition });
            dataGridView1.Location = new Point(250, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 219);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            // 
            // colFirstName
            // 
            colFirstName.HeaderText = "First Name";
            colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            colLastName.HeaderText = "Last Name";
            colLastName.Name = "colLastName";
            // 
            // colPosition
            // 
            colPosition.HeaderText = "Position";
            colPosition.Name = "colPosition";
            // 
            // bntDelete
            // 
            bntDelete.BackColor = Color.Red;
            bntDelete.FlatStyle = FlatStyle.Flat;
            bntDelete.ForeColor = Color.White;
            bntDelete.Location = new Point(112, 347);
            bntDelete.Name = "bntDelete";
            bntDelete.Size = new Size(90, 30);
            bntDelete.TabIndex = 12;
            bntDelete.Text = "Delete";
            bntDelete.UseVisualStyleBackColor = false;
            bntDelete.Click += bntDelete_Click;
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(706, 409);
            Controls.Add(bntDelete);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(bntSubmit);
            Controls.Add(txtPosition);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtEmployeeID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEmployeeDatabase";
            Text = "Employee Database";
            Load += frmEmployeeDatabase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmployeeID;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button bntSubmit;
        private Label label6;
        private TextBox txtPosition;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colPosition;
        private Button bntDelete;
    }
}
