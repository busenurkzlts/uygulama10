﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.bolum10.uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            private void radioButton1_CheckedChanged(object sender, EventArgs e)
            { 
            pictureBox1.Visible = radioButton1.Checked;
            pictureBox2.Visible = radioButton2.Checked;
            pictureBox3.Visible = radioButton3.Checked;
            pictureBox4.Visible = radioButton4.Checked;

        }
            private void radioButton2_CheckedChanged(object sender, EventArgs e)
            {
            pictureBox1.Visible = radioButton1.Checked;
            pictureBox2.Visible = radioButton2.Checked;
            pictureBox3.Visible = radioButton3.Checked;
            pictureBox4.Visible = radioButton4.Checked;
        }
            private void radioButton3_CheckedChanged(object sender, EventArgs e)
            {
            
        }
            private void radioButton4_CheckedChanged(object sender, EventArgs e)
            {
            
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = radioButton1.Checked;
            pictureBox2.Visible = radioButton2.Checked;
            pictureBox3.Visible = radioButton3.Checked;
            pictureBox4.Visible = radioButton4.Checked;
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = radioButton1.Checked;
            pictureBox2.Visible = radioButton2.Checked;
            pictureBox3.Visible = radioButton3.Checked;
            pictureBox4.Visible = radioButton4.Checked;
        }
    }
}
