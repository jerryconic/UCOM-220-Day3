using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yes or No", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
                txtAns.Text = "Yep!";
            else if (result == DialogResult.No)
                txtAns.Text = "Noooooooooooo!!!";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要離開", "離開", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}
