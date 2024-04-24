using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap12
{
    public partial class Form1 : Form
    {
        Image img;
        int x0, y0;
        public Form1()
        {
            InitializeComponent();
            img = new Bitmap(pct1.Width, pct1.Height);
            Graphics g = Graphics.FromImage(img);
            g.Clear(Color.White);            
        }

        private void pct1_MouseMove(object sender, MouseEventArgs e)
        {
            txtData.Text = $"X={e.X}, Y={e.Y}, Buttons={e.Button}";     
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(img);
                g.DrawLine(new Pen(Color.Black, 1), x0, y0, e.X, e.Y);
                pct1.Image = img;
                x0 = e.X;
                y0 = e.Y;
            }
        }
        private void btnLine_Click(object sender, EventArgs e)
        {           
            Graphics g = Graphics.FromImage(img);
            g.DrawLine(new Pen(Color.Blue, 1), 10, 10, 110, 110);
            pct1.Image = img;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(img);
            g.DrawRectangle(new Pen(Color.Green, 2), 10, 10, 100, 100);
            pct1.Image = img; 
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(img);
            g.DrawEllipse(new Pen(Color.Red, 1), 10, 10, 100, 100);
            pct1.Image = img;
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(img);
            g.DrawString("Hello", new Font("Arial", 12), new SolidBrush(Color.Black), 10, 10);
            pct1.Image = img;
        }

        private void pct1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            img.Save(@"C:\temp\image.jpg");
            MessageBox.Show("存檔完畢", "存檔", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
