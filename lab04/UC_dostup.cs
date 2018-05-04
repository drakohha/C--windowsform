using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFlab06
{
    public partial class UC_dostup : UserControl
    {
       
        public int flag_index = 0;
        public UC_dostup()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                flag_index = 1;
                MessageBox.Show("Все ок!");
                
            }
                
        }
    }
}
