using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
            
        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            label16.Visible = false;


            
        }
        double mat, ing, ed, biyo, coğ, kim, fiz, tar, alm, din, bed, sağ, müz, com1, com2, sonuç1, sonuç2, com3, com4;
        double d1, d2, d3, d4;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "" && textBox9.Text == "" && textBox10.Text == "" && textBox11.Text == "" && textBox12.Text == "" && textBox13.Text == "" && textBox14.Text == "" && textBox15.Text == "" && textBox16.Text == "" && textBox17.Text == "" && textBox18.Text == "" && textBox19.Text == "" && textBox20.Text == "" && textBox21.Text == "")
            {
                MessageBox.Show("Hiçbir Değer Girmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
            com3 = Convert.ToDouble(textBox19.Text);
            com4 = Convert.ToDouble(textBox21.Text);

            d1 = Convert.ToDouble(textBox17.Text);
            d2 = Convert.ToDouble(textBox16.Text);
            d3 = Convert.ToDouble(textBox18.Text);
            d4 = Convert.ToDouble(textBox20.Text);


            sonuç1 = (mat * 6) + (ing * 6) + (ed * 5) + (biyo * 3) + (coğ * 2) + (kim * 2) + (fiz * 2) + (tar * 2) + (alm * 2) + (din * 1) + (bed * 2) + (sağ * 1) + (müz * 1) + (com1 * d1) + (com2 * d2) + (com3 * d3) + (com4 * d4);
            sonuç2 = sonuç1 / 39;

            MessageBox.Show("Ortalamanız:" + " " + sonuç2.ToString(), "Ortalama");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
            
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
            
            comboBox3.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;
            label16.Visible = true;
            label15.Visible = false;
            
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            textBox20.Visible = true;
            textBox21.Visible = true;
            comboBox4.Visible = true;
            label16.Visible = false;
        }
    }
}
