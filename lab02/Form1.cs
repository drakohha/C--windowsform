using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFlab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splitContainer1.Hide();
            groupBox1.Show();

            flowLayoutPanel1.Hide();
            tabControl1.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            splitContainer1.Show();
            flowLayoutPanel1.Hide();
            tabControl1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Hide();
            groupBox1.Show();

            flowLayoutPanel1.Hide();
            tabControl1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Hide();
            groupBox1.Hide();
            tabControl1.Hide();
            flowLayoutPanel1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            splitContainer1.Hide();
            groupBox1.Hide();
            flowLayoutPanel1.Hide();
            tabControl1.Show();
            

        }
    }
}
