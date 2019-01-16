using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure1
{
    public partial class Form1 : Form
    {
        private bool goleft = false;
        private bool goright = false;
        private bool jump = false;

        private int jumpspeed = 10;
        private int force = 5;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jump)
            {
                jump = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jump)
            {
                jump = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top += jumpspeed;

            if (jump && force < 0)
            {
                jump = false;
            }

            if (goleft)
            {
                player.Left -= 5;
            }
            if (goright)
            {
                player.Left += 5;
            }

            if (jump)
            {
                jumpspeed = -12;
                force -= 1;
            }
            else
            {
                jumpspeed = 3;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }
                }

                if (x is PictureBox && x.Tag == "word")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        Dzwiek.PlayMojDom();
                        this.Controls.Remove(x);
                        score++;
                    }
                }

                if (x is PictureBox && x.Tag == "Tata")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        Dzwiek.PlayTata();
                        this.Controls.Remove(x);
                        score++;
                    }
                }

                if (x is PictureBox && x.Tag == "Mama")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        Dzwiek.PlayMama();
                        this.Controls.Remove(x);
                        score++;
                    }
                }

                if (x is PictureBox && x.Tag == "Pamiec")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        Dzwiek.PlayPamiec();
                        this.Controls.Remove(x);
                        score++;
                    }
                }


                if (x is PictureBox && x.Tag == "NextLVL")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        Dzwiek.PlayPamiec();
                        this.Controls.Remove(x);
                        if(score >=4)
                        {
                            Form2 next = new Form2();
                            this.Hide();
                            next.Show();

                        }
                    }
                }

            }


        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
            Dzwiek.playSimpleSound();
        }

        private void player_Click(object sender, EventArgs e)
        {
            Dzwiek.playImieSound();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Dzwiek.playDrzewoSound();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Dzwiek.playDrzewoSound();
        }

        private void word_Click(object sender, EventArgs e)
        {
            Dzwiek.PlayMama();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Dzwiek.PlayTata();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
         const int SCORE_INCREMENT = 0;
            

            if (true == int.TryParse(txtScore.Text, out score))
            {
                txtScore.Text = (score + SCORE_INCREMENT).ToString();
            }
            txtScore.Text = score.ToString();
        }

        private void NextLVL_Click(object sender, EventArgs e)
        {

        }







    


    }
}
