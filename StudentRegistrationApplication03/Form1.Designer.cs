namespace StudentRegistrationApplication
{
    partial class frmStudentRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtMiddleName = new TextBox();
            label5 = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label6 = new Label();
            cbDay = new ComboBox();
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            bntRegister = new Button();
            label7 = new Label();
            cbProgram = new ComboBox();
            pbStudent = new PictureBox();
            bntBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)pbStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 16);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 16);
            label2.TabIndex = 7;
            label2.Text = "Last name*";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(42, 87);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(227, 23);
            txtLastName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 16);
            label3.TabIndex = 9;
            label3.Text = "First name*";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(42, 135);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(227, 23);
            txtFirstName.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 162);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 16);
            label4.TabIndex = 11;
            label4.Text = "Middle name*";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(42, 183);
            txtMiddleName.Margin = new Padding(4, 3, 4, 3);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(227, 23);
            txtMiddleName.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 215);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 13;
            label5.Text = "Gender*";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(47, 237);
            rbFemale.Margin = new Padding(4, 3, 4, 3);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(72, 20);
            rbFemale.TabIndex = 14;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(138, 237);
            rbMale.Margin = new Padding(4, 3, 4, 3);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(55, 20);
            rbMale.TabIndex = 15;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 267);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 16);
            label6.TabIndex = 16;
            label6.Text = "Date of birth*";
            // 
            // cbDay
            // 
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(42, 288);
            cbDay.Margin = new Padding(4, 3, 4, 3);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(70, 23);
            cbDay.TabIndex = 17;
            cbDay.Text = "Day";
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(120, 288);
            cbMonth.Margin = new Padding(4, 3, 4, 3);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(70, 23);
            cbMonth.TabIndex = 18;
            cbMonth.Text = "Month";
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(198, 288);
            cbYear.Margin = new Padding(4, 3, 4, 3);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(70, 23);
            cbYear.TabIndex = 19;
            cbYear.Text = "Year";
            // 
            // bntRegister
            // 
            bntRegister.BackColor = Color.Crimson;
            bntRegister.FlatStyle = FlatStyle.Flat;
            bntRegister.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntRegister.ForeColor = Color.White;
            bntRegister.Location = new Point(42, 381);
            bntRegister.Margin = new Padding(4, 3, 4, 3);
            bntRegister.Name = "bntRegister";
            bntRegister.Size = new Size(149, 30);
            bntRegister.TabIndex = 20;
            bntRegister.Text = "Registration Student";
            bntRegister.UseVisualStyleBackColor = false;
            bntRegister.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 327);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(134, 16);
            label7.TabIndex = 21;
            label7.Text = "Program to apply*";
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(42, 348);
            cbProgram.Margin = new Padding(4, 3, 4, 3);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(227, 23);
            cbProgram.TabIndex = 22;
            cbProgram.Text = "Select program";
            // 
            // pbStudent
            // 
            pbStudent.BackColor = SystemColors.AppWorkspace;
            pbStudent.Location = new Point(330, 65);
            pbStudent.Name = "pbStudent";
            pbStudent.Size = new Size(178, 141);
            pbStudent.TabIndex = 23;
            pbStudent.TabStop = false;
            // 
            // bntBrowse
            // 
            bntBrowse.Location = new Point(381, 215);
            bntBrowse.Name = "bntBrowse";
            bntBrowse.Size = new Size(85, 30);
            bntBrowse.TabIndex = 24;
            bntBrowse.Text = "Browse";
            bntBrowse.UseVisualStyleBackColor = true;
            bntBrowse.Click += bntBrowse_Click;
            // 
            // frmStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(560, 438);
            Controls.Add(bntBrowse);
            Controls.Add(pbStudent);
            Controls.Add(cbProgram);
            Controls.Add(label7);
            Controls.Add(bntRegister);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Controls.Add(cbDay);
            Controls.Add(label6);
            Controls.Add(rbMale);
            Controls.Add(rbFemale);
            Controls.Add(label5);
            Controls.Add(txtMiddleName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmStudentRegistration";
            Text = "Student Registration";
            Load += frmStudentRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)pbStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button bntRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbProgram;
        private PictureBox pbStudent;
        private Button bntBrowse;
    }
}