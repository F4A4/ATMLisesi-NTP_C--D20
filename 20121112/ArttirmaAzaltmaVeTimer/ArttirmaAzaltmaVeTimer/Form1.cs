using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArttirmaAzaltmaVeTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(label1.Text);
            int artis = Convert.ToInt32(textBox1.Text);
            sayı += artis;
            label1.Text = sayı.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(label1.Text);
            int artis = Convert.ToInt32(textBox1.Text);
            sayı -= artis;
            label1.Text = sayı.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(label1.Text);
            //int artis = Convert.ToInt32(textBox1.Text);
            int artis = 1;
            sayı += artis;
            label1.Text = sayı.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
