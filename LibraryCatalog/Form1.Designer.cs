namespace LibraryCatalog
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
            groupBox1 = new GroupBox();
            bntClear = new Button();
            bntAdd = new Button();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtYear = new TextBox();
            txtCopies = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtISBN = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtDetails = new TextBox();
            groupBox3 = new GroupBox();
            bntReturn = new Button();
            bntborrow = new Button();
            bntRemove = new Button();
            lstBooks = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bntClear);
            groupBox1.Controls.Add(bntAdd);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtCopies);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Details";
            // 
            // bntClear
            // 
            bntClear.BackColor = Color.LightGray;
            bntClear.FlatStyle = FlatStyle.Flat;
            bntClear.Location = new Point(193, 194);
            bntClear.Name = "bntClear";
            bntClear.Size = new Size(136, 38);
            bntClear.TabIndex = 11;
            bntClear.Text = "Clear Fields";
            bntClear.UseVisualStyleBackColor = false;
            bntClear.Click += bntClear_Click;
            // 
            // bntAdd
            // 
            bntAdd.BackColor = Color.LightGreen;
            bntAdd.FlatStyle = FlatStyle.Flat;
            bntAdd.Location = new Point(26, 194);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(136, 38);
            bntAdd.TabIndex = 10;
            bntAdd.Text = "Add Book";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += button1_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(136, 56);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(249, 23);
            txtTitle.TabIndex = 9;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(136, 85);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(249, 23);
            txtAuthor.TabIndex = 8;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(136, 114);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(249, 23);
            txtYear.TabIndex = 7;
            // 
            // txtCopies
            // 
            txtCopies.Location = new Point(136, 143);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(249, 23);
            txtCopies.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 146);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 5;
            label5.Text = "Copies Available";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 117);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 4;
            label4.Text = "Year Published:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Book Title:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(136, 27);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(249, 23);
            txtISBN.TabIndex = 1;
            txtISBN.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDetails);
            groupBox2.Location = new Point(12, 309);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(859, 168);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Details";
            // 
            // txtDetails
            // 
            txtDetails.Location = new Point(6, 22);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.Size = new Size(847, 140);
            txtDetails.TabIndex = 12;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bntReturn);
            groupBox3.Controls.Add(bntborrow);
            groupBox3.Controls.Add(bntRemove);
            groupBox3.Controls.Add(lstBooks);
            groupBox3.Location = new Point(410, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(461, 283);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "List Book";
            // 
            // bntReturn
            // 
            bntReturn.BackColor = Color.LightBlue;
            bntReturn.FlatStyle = FlatStyle.Flat;
            bntReturn.Location = new Point(319, 227);
            bntReturn.Name = "bntReturn";
            bntReturn.Size = new Size(136, 38);
            bntReturn.TabIndex = 14;
            bntReturn.Text = "Return Copy";
            bntReturn.UseVisualStyleBackColor = false;
            bntReturn.Click += bntReturn_Click;
            // 
            // bntborrow
            // 
            bntborrow.BackColor = Color.Bisque;
            bntborrow.FlatStyle = FlatStyle.Flat;
            bntborrow.Location = new Point(162, 227);
            bntborrow.Name = "bntborrow";
            bntborrow.Size = new Size(136, 38);
            bntborrow.TabIndex = 13;
            bntborrow.Text = "Borrow Copy";
            bntborrow.UseVisualStyleBackColor = false;
            bntborrow.Click += bntborrow_Click;
            // 
            // bntRemove
            // 
            bntRemove.BackColor = Color.Red;
            bntRemove.FlatStyle = FlatStyle.Flat;
            bntRemove.Location = new Point(6, 227);
            bntRemove.Name = "bntRemove";
            bntRemove.Size = new Size(136, 38);
            bntRemove.TabIndex = 12;
            bntRemove.Text = "Remove Book";
            bntRemove.UseVisualStyleBackColor = false;
            bntRemove.Click += bntRemove_Click;
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.Location = new Point(6, 22);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(449, 169);
            lstBooks.TabIndex = 0;
            lstBooks.SelectedIndexChanged += lstbook_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 489);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Library Book Management System";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtISBN;
        private Label label1;
        private Button bntAdd;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtYear;
        private TextBox txtCopies;
        private Button bntClear;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button bntReturn;
        private Button bntborrow;
        private Button bntRemove;
        private ListBox lstBooks;
        private TextBox txtDetails;
    }
}
