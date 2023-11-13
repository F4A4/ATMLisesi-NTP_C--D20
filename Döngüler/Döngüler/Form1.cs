using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Döngüler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Aşağıdakilerden hangisi tanzimat döneminde ilk gazeteyi çıkaran kişidir? ";
            textBox5.Text = " Şinasi";
            textBox4.Text = "Ahmet Mithat Efendi";
            textBox2.Text = "Namık Kemal";
            textBox3.Text = "Ziya Paşa";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cvp = "";
            if (radioButton1.Checked)
            {
                cvp = "Cevap A şıkkıdır.";
            }
            else if (radioButton2.Checked)
            {
                cvp = "Cevap B şıkkıdır.";
            }
            else if (radioButton3.Checked)
            {
                cvp = "Cevap C şıkkıdır.";
            }
            else if (radioButton4.Checked)
            {
                cvp = "Cevap D şıkkıdır.";
            }
            else
            {
                cvp = "Şıkkı boş Bırakmayınız!";
            }
             

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Int32.Parse(textBox6.Text);
            int sayi2 = Int32.Parse(textBox7.Text);
            int sonuc = sayi;
            while (sayi<sayi2)
            {
                if (sonuc*sayi2<1000)
                {
                  
                    sayi++;
                    sonuc = sonuc * sayi;
                }
                else
                {
                    MessageBox.Show("Sayı Degerlerini kontrol ediniz.");
                    break;
                }
                 textBox8.Text = sonuc.ToString();
                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Int32.Parse(textBox9.Text);
            int aralık = Int32.Parse(textBox10.Text);
            int enson = Int32.Parse(textBox13.Text);
            int tpl = 0;
            do
            { 
                
                sayi += aralık;
                tpl += sayi;
                //Bu işlemi yaptığımızda CEVAP =1035 çıkar.
                //if (tpl>=1000)
                //{
                //    break;
                //}
                //Eğer Böyle yapmak istemiyorsak alttaki işlemi yapınız. 
                if (tpl+sayi>=enson)
                {
                    break;
                }
                 
            } while (true);
            textBox11.Text = tpl.ToString();
            textBox12.Text = sayi.ToString();

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            int artıs = Int32.Parse(textBox15.Text);
            int sayi = Int32.Parse(textBox14.Text); 
            sayi += artıs;
            textBox14.Text = sayi.ToString();
 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int artıs = Int32.Parse(textBox15.Text);
            int sayi = Int32.Parse(textBox14.Text);
            sayi -= artıs;
            textBox14.Text = sayi.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Interval = 60 * 1000;// BİR DAKİKA ATAR 
            label11.Text = timer1.Interval.ToString();
            timer1.Interval = 1000;//MİLİ SANİYE ATAR
            timer1.Interval = 60 * 60 * 1000;//BİR SAAT ATAR
            timer1.Interval = 24 * 60 * 60 * 1000;//BİR GÜNDE ATAR
            timer1.Start();
            

        }
    }
}
