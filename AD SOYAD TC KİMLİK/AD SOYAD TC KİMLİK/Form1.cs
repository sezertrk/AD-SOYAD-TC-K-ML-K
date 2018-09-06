using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AD_SOYAD_TC_KİMLİK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {
                case "Oturma Grubu": { textBox3.Text = "2250"; break; }
                case "Salon Takımı": { textBox3.Text = "2000"; break; }
                case "Köşe Takımı": { textBox3.Text = "1750"; break; }
                case "Yatak Odası Takımı": { textBox3.Text = "3000"; break; }
                case "Çocuk Takımı": { textBox3.Text = "2075"; break; }
                case "Yemek Odası Takımı": { textBox3.Text = "3500"; break; }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label11.Visible = true;
            listBox1.Visible = true;
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = true;
            textBox6.Visible = true;
            button3.Visible = true;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text); listBox2.Items.Add(textBox2.Text); listBox4.Items.Add(comboBox1.Text); listBox3.Items.Add(textBox5.Text);
            comboBox1.Text = "Lütfen Malı Seçiniz...";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int top = 0;
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                top = top + Convert.ToInt32(listBox3.Items[i].ToString());
            }
            textBox6.Text = top.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = (int.Parse(textBox3.Text) * int.Parse(textBox4.Text)).ToString();
                textBox5.Text = (int.Parse(textBox5.Text)).ToString();
            }
            catch (Exception)
            {
                textBox4.Text = "0";
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            textBox6.Visible = false;
            button3.Visible = false;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.TextLength < 11) ;
                {
                    MessageBox.Show("Hatalı Tc Kimlik No Girdiniz");
                    textBox2.Focus();
                }
            }
            catch (Exception)
            { 
            
            }
        }
    }
}
