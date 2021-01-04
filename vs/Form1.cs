using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        bool right = false;
        bool left = true;
        bool up = true;
        bool down = false;
        bool up2 = false;
        bool down2 = true;
        bool stop = false;
        bool stop2 = false;
        int tonyTime = 0;
        int turkTime = 0;
        int Score1 = 0;
        int Score2 = 0;
        bool hit = false;
        bool hit2 = false;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Q)
            {
                stop = true;
            }
            if (key.KeyCode == Keys.P)
            {
                stop2 = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void Tennesesse_Tick(object sender, EventArgs e)
        {
            if (stop == false) // code for first player
            {
                if (up == true)
                {
                    pictureBox1.Top -= 5;

                    if (pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds) == true)
                    {
                        up = false;
                        down = true;
                    }
                }
                if (down == true)
                {
                    pictureBox1.Top += 5;

                    if (pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds) == true)
                    {
                        down = false;
                        up = true;
                    }
                }
            }

            if (stop2 == false) // code for second player
            {
                if (up2 == true) // if they are going up
                {
                    pictureBox2.Top -= 5;

                    if (pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds) == true)
                    {
                        up2 = false;
                        down2 = true;
                    }
                }
                if (down2 == true) // if they are going down
                {
                    pictureBox2.Top += 5;

                    if (pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds) == true)
                    {
                        down2 = false;
                        up2 = true;
                    }
                }
            }

            if (left == true)
            {
                pictureBox3.Left -= 5;

                if (pictureBox3.Bounds.IntersectsWith(pictureBox1.Bounds) == true)
                {
                    left = false;
                    right = true;
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox6.Bounds) == true)
                {
                    pictureBox3.Left += 300;
                    Score1 += 1;
                    hit = true;
                }
            }
            if (right == true)
            {
                pictureBox3.Left += 5;

                if (pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds) == true)
                {
                    left = true;
                    right = false;
                }
                if (pictureBox3.Bounds.IntersectsWith(pictureBox7.Bounds) == true)
                {
                    pictureBox3.Left -= 300;
                    Score2 += 1;
                    hit2 = true;
                }
            }
        }

        private void Tony_Tick(object sender, EventArgs e)
        {
            if (stop == true)
            {
                tonyTime += 1;

                if (tonyTime >= 5)
                {
                    stop = false;
                    tonyTime = 0;
                }
            }
        }

        private void Turk_Tick(object sender, EventArgs e)
        {
            if (stop2 == true)
            {
                turkTime += 1;

                if (turkTime >= 5)
                {
                    stop2 = false;
                    turkTime = 0;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (hit == true)
            {
                Score.Text = "Score: " + Score1.ToString();
                hit = false;
            }
        }

        private void scoree_Click(object sender, EventArgs e)
        {
            if (hit == true)
            {
                scoree.Text = "Score: " + Score2.ToString();
                hit = false;
            }
        }

        private void Teddy_Tick(object sender, EventArgs e)
        {
            if (hit2 == true)
            {
                Score.Text = "Score: " + Score2.ToString();
                hit2 = false;

                if (Score2 == 3)
                {
                    string msg = "Player 1 WIN!";
                    MessageBox.Show(msg);
                    Application.Exit();

                }
            }
            if (hit == true)
            {
                scoree.Text = "Score: " + Score1.ToString();
                hit = false;

                if (Score1 == 3)
                {
                    string msgs = "Player 2 WIN!";
                    MessageBox.Show(msgs);
                    Application.Exit();

                }
            }
        }
    }
}
