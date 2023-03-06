using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label
{
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Magenta;
            label1.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Magenta;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            score++;
            this.Text = score.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "Tack för att du besökte oss!";
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "Välkommen till vår webbplats!";
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            int x, y;
            Random random = new Random();
            x = random.Next(0, 500);
            y = random.Next(0, 300);

            label6.Left = x;
            label6.Top = y;
        }
    }
}
