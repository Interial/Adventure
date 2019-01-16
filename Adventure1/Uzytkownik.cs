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
    public partial class Uzytkownik : Form
    {
        public Uzytkownik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String output = "";
            output += "Imię: " + Name.Text;
            output += "Nazwisko: " + Surname.Text;
            output += "Wiek: " + Age.Text;

            output += "\nPłeć: " + Gender.Text;
        }
    }
}
