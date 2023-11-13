using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SwitchWhileDoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cevap = "";
            if (radioButton1.Checked)
            {
                cevap = "A";
            }
            else if (radioButton2.Checked)
            {
                cevap = "B";
            }
            else if (radioButton3.Checked)
            {
                cevap = "C";
            }
            else if (radioButton4.Checked)
            {
                cevap = "D";
            }
            else
            {
                cevap = "yok";
            }

            switch (cevap)
            {
                case "A":
                    label1.Text = "Doğru";
                    break;
                case "B":
                    label1.Text = "Yanlış";
                    break;
                case "C":
                    label1.Text = "Yanlış";
                    break;
                case "D":
                    label1.Text = "Yanlış";
                    break;
                case "yok":
                    label1.Text = "Seçim Yap";
                    break;
                default:
                    label1.Text = "Hata";
                    break;
            }
        }

        //string dogruCevap;

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Türkiye'nin başkenti neresidir?";
            textBox1.Text = "Ankara";
            textBox2.Text = "Paris";
            textBox3.Text = "Muş";
            textBox4.Text = "Hong Kong";
            //dogruCevap = "A";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox5.Text);
            int sayi2 = Convert.ToInt32(textBox6.Text);
            int sonuc = sayi;
            while (sayi<sayi2)
            {
                if (sonuc * sayi < 1000)
                {
                sayi++;
                sonuc = sonuc * sayi;
                }
                else
                {
                    MessageBox.Show("Sonuç 1000'den büyük olduğu için yazdırılamaz");
                    break;
                }
                
            }
            label5.Text = Convert.ToString(sonuc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int baslangic = Int32.Parse(textBox7.Text);
            int toplam = 0;
            int artis = Int32.Parse(textBox8.Text);
            int bitis = Int32.Parse(textBox9.Text);

            do
            {
                toplam += baslangic;
                listBox1.Items.Add(String.Format("Sayı = {0}, - Toplam = {1}", baslangic.ToString(), toplam.ToString()));
                baslangic += artis;
                if (toplam + baslangic >= bitis)
                {
                    break;
                }
            } while (true);
        }
    }
}
