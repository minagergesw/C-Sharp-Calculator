﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        double num = Convert.ToDouble(txt1.Text);
            label2.Text =Convert.ToString( Math.Sqrt(num));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txt1.Text);
            label2.Text = Convert.ToString(num*num);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt2.Text);
            double num2 = Convert.ToDouble(txt3.Text);
            label2.Text = Convert.ToString(num1/ num2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt2.Text);
            double num2 = Convert.ToDouble(txt3.Text);
            label2.Text = Convert.ToString(num1 + num2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt2.Text);
            double num2 = Convert.ToDouble(txt3.Text);
            label2.Text = Convert.ToString(num1 -num2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt2.Text);
            double num2 = Convert.ToDouble(txt3.Text);
            label2.Text = Convert.ToString(num1 * num2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt2.Text);
            double num2 = Convert.ToDouble(txt3.Text);
            double result= num1 % num2;
            if (num1<num2) {
                result = 0;
            }

            label2.Text = Convert.ToString(result);
          
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
