using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            string[] files = { "dices/d1.png", "dices/d2.png", "dices/d3.png", "dices/d4.png", "dices/d5.png", "dices/d6.png" };
            int[] ar = new int[4];
            Random rnd = new Random();

            for (int i = 0; i<4; i++)
                ar[i] = rnd.Next(0, 6);

            Array.Sort(ar);
            
            pct1.Image = Image.FromFile(files[ar[0]]);
            pct2.Image = Image.FromFile(files[ar[1]]);
            pct3.Image = Image.FromFile(files[ar[2]]);
            pct4.Image = Image.FromFile(files[ar[3]]);

            if (ar[0] == ar[3])
                lblPoint.Text = "Congratulations! Royal Points!!!";
            else if (ar[0] == ar[2] || ar[1] == ar[3])
                lblPoint.Text = "Sorry! No Points(3)!!!";
            else if (ar[0] == ar[1])
                lblPoint.Text = $"{ar[2] + ar[3] + 2} Points";
            else if (ar[1] == ar[2])
                lblPoint.Text = $"{ar[0] + ar[3] + 2} Points";
            else if (ar[2] == ar[3])
                lblPoint.Text = $"{ar[0] + ar[1] + 2} Points";
            else
                lblPoint.Text = "Sorry! No Points(1)!!!";

        }
    }
}
