﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortalama_Hesaplama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mat, ing, ed, biyo, coğ, kim, fiz, tar, alm, din, bed, sağ, müz, com1, com2, sonuç1, sonuç2;

            mat = Convert.ToDouble(textBox1.Text);
            ing = Convert.ToDouble(textBox2.Text);
            ed = Convert.ToDouble(textBox3.Text);
            biyo = Convert.ToDouble(textBox4.Text);
            coğ = Convert.ToDouble(textBox5.Text);
            kim = Convert.ToDouble(textBox6.Text);
            fiz = Convert.ToDouble(textBox7.Text);
            tar = Convert.ToDouble(textBox8.Text);
            alm = Convert.ToDouble(textBox9.Text);
            din = Convert.ToDouble(textBox10.Text);
            bed = Convert.ToDouble(textBox11.Text);
            sağ = Convert.ToDouble(textBox12.Text);
            müz = Convert.ToDouble(textBox13.Text);
            com1 = Convert.ToDouble(textBox14.Text);
            com2 = Convert.ToDouble(textBox15.Text);

            sonuç1 = (mat * 6) + (ing * 6) + (ed * 5) + (biyo * 3) + (coğ * 2) + (kim * 2) + (fiz * 2) + (tar * 2) + (alm * 2) + (din * 1) + (bed * 2) + (sağ * 1) + (müz * 1) + (com1 * 2) + (com2 * 2);
            sonuç2 = sonuç1 / 39;

            MessageBox.Show("Ortalamanız:" + " "+ sonuç2.ToString(), "Ortalama");

            if (textBox1.Text==" " && textBox2.Text==" " && textBox3.Text==" ")
            {
                MessageBox.Show("Hiçbir Değer Girmediniz.");
            }
        }
    }
}
