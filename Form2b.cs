﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class Form2b : Form
    {
        public Form2b()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            Hide();
            f6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            Hide();
            f7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Hide();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            Hide();
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            Hide();
            f5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            Hide();
            f9.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            Hide();
            f8.ShowDialog();
        }
    }
}
