using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double r = 2;
        int n = 300;
        double aa = 2;
        Complex z0 = new Complex(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int x = 0; x < pictureBox1.Width; ++x)
            {
                double a = z0.a +  (double)(x - (pictureBox1.Width / 2)) / (double)(pictureBox1.Width / (aa * 2));
                for (int y = 0; y < pictureBox1.Height; ++y)
                {
                    double b = z0.b + (double)(y - (pictureBox1.Height / 2)) / (double)(pictureBox1.Height / (aa*2));
                    Complex c = new Complex(a, b);
                    Complex z = new Complex(z0.a,z0.b);
                    int it = 0;
                    while (it < n)
                    {
                        ++it;
                        z.square();
                        z.add(c);

                        if (z.mod() > r) break;
                    }
                    bmp.SetPixel(x, y, it < 100 ? Color.FromArgb(it%2 * 132, it%4 * 30, it%2 * 77) : Color.FromArgb(it%8, it%8, it%8));
                }
            }
            pictureBox1.Image = bmp;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            if (rTextBox.TextLength!=0)
            {
                r = Convert.ToDouble(rTextBox.Text);
            }
            if (nTextBox.TextLength!=0)
            {
                n = Convert.ToInt32(nTextBox.Text);
            }
            if (aTextBox.TextLength != 0)
            {
                aa = 2 * Convert.ToDouble(aTextBox.Text);
            }
            if (zTextBox.TextLength!=0)
            {
                z0 = new Complex(zTextBox.Text);
            }
            Draw();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case (MouseButtons.Left):
                    z0.a += (double)(e.X - (pictureBox1.Width / 2)) / (double)(pictureBox1.Width / (2 * aa));
                    z0.b += (double)(e.Y - (pictureBox1.Height / 2)) / (double)(pictureBox1.Height / aa);
                    aa /= 1.3;
                    Draw();
                    break;
                case (MouseButtons.Right):
                    z0.a += (double)(e.X - (pictureBox1.Width / 2)) / (double)(pictureBox1.Width / (2 * aa));
                    z0.b += (double)(e.Y - (pictureBox1.Height / 2)) / (double)(pictureBox1.Height / (2 * aa));
                    aa *= 1.3;
                    Draw();
                    break;
                case (MouseButtons.Middle):
                    z0.a = 0;
                    z0.b = 0;
                    aa = 2;
                    Draw();
                    break;
                default:
                    break;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("123.png");
        }

        private void zoom_Click(object sender, EventArgs e)
        {
            z0.a += 0.01;
            aa /= 1.1;
            Draw();
        }
    }
}
