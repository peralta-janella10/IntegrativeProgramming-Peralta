using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        private string secretWord = "Computer";
        private int maxAttempts = 5;
        private int attempts = 0;

        StringBuilder wrongGuesses = new StringBuilder();

        public frmGuessWord()
        {
            InitializeComponent();
            ResetGame();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string userGuess = txtGuess.Text.Trim();

            if (string.IsNullOrEmpty(userGuess))
            {
                MessageBox.Show("Please enter a word!");
                return;
            }
            foreach (var item in lstWrong.Items)
            {
                if (string.Equals(item.ToString(), userGuess, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("You already tried that word!");
                    txtGuess.Clear();
                    return;
                }
                attempts++;

                if (string.Equals(userGuess, secretWord, StringComparison.OrdinalIgnoreCase))
                {
                    lblWord.Text = secretWord;
                    MessageBox.Show("🎉 Correct! You guessed the word!");
                    txtGuess.Clear();
                    return;
                }
                }
            attempts++;

            if (string.Equals(userGuess, secretWord, StringComparison.OrdinalIgnoreCase))
            {
                lblWord.Text = secretWord;
                MessageBox.Show("🎉 Correct! You guessed the word!");
                DisableGame();
            }
            else
            {
                MessageBox.Show("❌ Wrong guess! Try again.");

                wrongGuesses.AppendLine(userGuess);
                lstWrong.Items.Add(userGuess);

                if (attempts >= maxAttempts)
                {
                    MessageBox.Show("Game Over! The word was: " + secretWord);
                    lblWord.Text = secretWord;
                    DisableGame();
                }
            }
            txtGuess.Clear();
            txtGuess.Focus();
        }
        private void ResetGame()
        {
            lblWord.Text = new string('?', secretWord.Length);
            txtGuess.Clear();
            lstWrong.Items.Clear();

            wrongGuesses.Clear();
            attempts = 0;

            btnCheck.Enabled = true;
            txtGuess.Enabled = true;
        }
        private void DisableGame()
        {
            btnCheck.Enabled = false;
            txtGuess.Enabled = false;
        }
    }
}


