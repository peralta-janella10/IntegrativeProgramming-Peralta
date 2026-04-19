namespace StudentInfoApplication
{
    partial class Form1
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
            txtStudentNumber = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lstLastName = new ListBox();
            lstFirstName = new ListBox();
            lstStudentID = new ListBox();
            bntSubmit = new Button();
            bntClear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Number*";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(130, 54);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(210, 23);
            txtStudentNumber.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(130, 85);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 23);
            txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 2;
            label2.Text = "Student Last Name*";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(130, 120);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 23);
            txtFirstName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 4;
            label3.Text = "Student First Name*";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lstLastName);
            groupBox1.Controls.Add(lstFirstName);
            groupBox1.Controls.Add(lstStudentID);
            groupBox1.Location = new Point(12, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(734, 239);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.ForeColor = Color.DarkOliveGreen;
            label6.Location = new Point(589, 18);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 11;
            label6.Text = "Last Name List";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.ForeColor = Color.DarkOliveGreen;
            label5.Location = new Point(326, 18);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 10;
            label5.Text = "First Name List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(56, 18);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 9;
            label4.Text = "Student Number List";
            // 
            // lstLastName
            // 
            lstLastName.FormattingEnabled = true;
            lstLastName.Location = new Point(517, 36);
            lstLastName.Name = "lstLastName";
            lstLastName.Size = new Size(210, 184);
            lstLastName.TabIndex = 2;
            // 
            // lstFirstName
            // 
            lstFirstName.FormattingEnabled = true;
            lstFirstName.Location = new Point(262, 36);
            lstFirstName.Name = "lstFirstName";
            lstFirstName.Size = new Size(210, 184);
            lstFirstName.TabIndex = 1;
            // 
            // lstStudentID
            // 
            lstStudentID.FormattingEnabled = true;
            lstStudentID.Location = new Point(7, 36);
            lstStudentID.Name = "lstStudentID";
            lstStudentID.Size = new Size(210, 184);
            lstStudentID.TabIndex = 0;
            // 
            // bntSubmit
            // 
            bntSubmit.BackColor = Color.Green;
            bntSubmit.FlatStyle = FlatStyle.Flat;
            bntSubmit.ForeColor = Color.White;
            bntSubmit.Location = new Point(648, 124);
            bntSubmit.Name = "bntSubmit";
            bntSubmit.Size = new Size(96, 28);
            bntSubmit.TabIndex = 7;
            bntSubmit.Text = "Submit";
            bntSubmit.UseVisualStyleBackColor = false;
            bntSubmit.Click += bntSubmit_Click;
            // 
            // bntClear
            // 
            bntClear.BackColor = Color.Red;
            bntClear.FlatStyle = FlatStyle.Flat;
            bntClear.ForeColor = Color.White;
            bntClear.Location = new Point(546, 122);
            bntClear.Name = "bntClear";
            bntClear.Size = new Size(96, 28);
            bntClear.TabIndex = 8;
            bntClear.Text = "Clear";
            bntClear.UseVisualStyleBackColor = false;
            bntClear.Click += bntClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            BackgroundImage = Properties.Resources.d98011cf0aed1a101b1a36e2843a8537;
            ClientSize = new Size(759, 397);
            Controls.Add(bntClear);
            Controls.Add(bntSubmit);
            Controls.Add(groupBox1);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtStudentNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Info";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentNumber;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private GroupBox groupBox1;
        private ListBox lstLastName;
        private ListBox lstFirstName;
        private ListBox lstStudentID;
        private Button bntSubmit;
        private Button bntClear;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
