using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap09
{
    public partial class Form1 : Form
    {
        int ans, guess;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int.TryParse(txtGuess.Text, out guess);
            if (guess < ans)
                MessageBox.Show("高一點", "猜數字", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (guess > ans)
                MessageBox.Show("低一點", "猜數字", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("猜對了", "猜數字", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpGuess.Enabled = false;
                btnGuess.Enabled = false;
                btnStart.Enabled = true;

            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ans = rnd.Next(1, 100);

            Text = ans.ToString();
            grpGuess.Enabled = true;
            btnGuess.Enabled = true;
            btnStart.Enabled = false;
            txtGuess.Clear();
            txtGuess.Select();
            

        }
    }
}
