using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integer_variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num , num2 ,sum;
            num = 24;
            num2 = 15;
            sum = num + num2;
            label1.Text = sum.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a , area ,around ;
            a = 13;
            around = a*4;
            area = a * a;
            label2.Text= area.ToString();
            label3.Text = " Area "+around;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b, c, rarea, raround;
            b = 19;
            c = 98;
            rarea = b * c;
            raround = 2 * b + 2 * c;
            label4.Text="Rectangular around :" + raround;
            label5.Text= rarea.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int e1, e2, e3,avarege ;
            e1 = 85;
            e2 = 90;
            e3 = 100;
            avarege = (e1 + e2 + e3) / 3;
            label6.Text="Your Avarege :"+ avarege;

        }
    }
}
