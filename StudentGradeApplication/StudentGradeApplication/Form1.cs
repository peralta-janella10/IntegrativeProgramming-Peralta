using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentGradeApplication
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
         
        private void genbox_Click(object sender, EventArgs e)
        {
            double english, math, science, filipino, history;

            if ( namebox.Text == "" ||
       !double.TryParse(englishbox.Text, out english) ||
       !double.TryParse(mathbox.Text, out math) ||
       !double.TryParse(sciencebox.Text, out science) ||
       !double.TryParse(filipinobox.Text, out filipino) ||
       !double.TryParse(historybox.Text, out history))

            {
                MessageBox.Show("Please enter valid numeric grades.");
                return;
            }
            double genbox = (english + math + science + filipino + history) / 5;

            string status = (genbox >= 75) ? "The student passed." : "The student failed.";


            display.Text = status + Environment.NewLine + "The general average of " + namebox.Text + " is " + genbox.ToString("F2");
        }

    }
}

