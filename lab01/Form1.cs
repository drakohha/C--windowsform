﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFlab01
{
    public partial class Form1 : Form
    {
        Form2 mf_2;
        public Form1()
        {
            InitializeComponent();
            mf_2= new Form2(this);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            mf_2.Show();
        }
    }
}
