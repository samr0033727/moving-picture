using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
        }

        private async void square_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 20);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 20, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 20);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y);
        }

        private async void triangle_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 40, pictureBox1.Location.Y + 40);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 80, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 40, pictureBox1.Location.Y - 40);
        }
    }
}
      
   