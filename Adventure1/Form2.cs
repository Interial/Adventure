using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adventure1
{
    public partial class Form2 : Form
    {
        int wygrana = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Pohulanka 6/12")
            {
                wygrana++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Leszek")
            {
                wygrana++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox4.Text=="Ula" )
            {
                wygrana++;
            }
        }



        private void wygran()
        {
            if(wygrana == 3 )
            {
                Form3 Forma = new Form3();
;                Forma.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wygran();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dzwiek.playLekSound();
        }
    }
}
