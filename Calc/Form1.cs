﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.ResetText();
            this.label2.ResetText();
            this.label3.ResetText();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "1";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "2";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.label2.Text = "+";
            this.label3.Text = this.label1.Text;
            this.label1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label2.Text = "-";
            this.label3.Text = this.label1.Text;
            this.label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label2.Text = "*";
            this.label3.Text = this.label1.Text;
            this.label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label2.Text = "%";
            this.label3.Text = this.label1.Text;
            this.label1.Text = "";
        }
    }
}