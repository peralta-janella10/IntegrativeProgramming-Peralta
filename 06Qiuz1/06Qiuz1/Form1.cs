using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Qiuz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] classmates = { "Carel", "Gilbert", "Yaz", "Danica", "Bien", "Nicole" };

            foreach (string name in classmates)
            {
                listBox1.Items.Add(name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string word = "Hello everyone";

            if (word.ToLower().Contains("hello"))
            {
                MessageBox.Show("The message contains the word 'hello'.");
            }
            else
            {
                MessageBox.Show("The message does not contain 'hello'.");
            }
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] table =
            {
                { "a", "b", "c" },
                { "d", "e", "f" }
            };

            int row, col;

            if (!int.TryParse(textBox2.Text, out row) || !int.TryParse(textBox3.Text, out col))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            if (row < 0 || row > 1 || col < 0 || col > 2)
            {
                MessageBox.Show("Row must be 0 or 1, Column must be 0, 1, or 2.");
                return;
            }

            MessageBox.Show("table[" + row + "," + col + "] = " + table[row, col]);
        }
    }
}
