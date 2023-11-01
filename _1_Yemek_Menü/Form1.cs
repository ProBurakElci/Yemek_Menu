using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Yemek_Menü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double i = 0;
            if (abPizza.Checked)
            {
                i = i + 16;
            }

            if (abSpagetti.Checked)
            {
                i = i + 12;
                
            }

            if (abPilav.Checked)
            {
                i = i + 14;
            }

            if (abTarhana.Checked)
            {
                i = i + 7;
            }

            if (abBıtbıt.Checked)
            {
                i = i + 6;
            }

            if (abToyga.Checked)
            {
                i = i + 10;
            }

            if (abCocacola.Checked)
            {
                i = i + 4;
            }

            if (abSu.Checked)
            {
                i = i + 2;
            }

            if (abFanta.Checked)
            {
                i = i + 3;
            }

            if (abAyran.Checked)
            {
                i = i + 2;
            }



            txtTutar.Text = i.ToString();
        }

        private void btnTutarSifirla_Click(object sender, EventArgs e)
        {
            {
                txtTutar.Text = "00";
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
