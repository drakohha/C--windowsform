using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFlab06
{
    public partial class Form2 : Form
    {
        public Form1 fm_1;
        UserU u_2 = new UserU();
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uC_dostup1.flag_index == 1)
            {
                panel1.Show();
                panel2.Hide();
                button1.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            u_2.FIO = uC_person1.textBox1.Text;
            u_2.age = Convert.ToInt32(uC_person1.textBox2.Text);
            u_2.email = uC_person1.textBox3.Text;


            fm_1.li.Add(u_2);

            this.Hide();
            
        }
    }
}
