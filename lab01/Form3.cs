using System;
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
    public partial class Form3 : Form
    {
        Form1 mf;
        Form3 fm_3;
        int cord_x = 0;
        int index =3;


        public Form3(Form1 mf)
        {
            InitializeComponent();
            this.mf = mf;
            fm_3 = this;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = Convert.ToInt32(mf.label2.Text);
            id--;
            mf.label2.Text = Convert.ToString( id);
            fm_3.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Button bt = new Button();
            bt.Text = "конпка";
            bt.Location = new Point(cord_x,0);
            cord_x += 75;
            if (cord_x >= fm_3.Width) 
            {
                MessageBox.Show("Достигнут предел кнопок!!!");
                button2.Hide();
            }
            this.Controls.Add(bt);
            bt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (index >= this.Controls.Count - 1)
            {
                MessageBox.Show("Все кнопки удалены!");
                button3.Hide();
            }
            
            
            this.Controls[index].Hide();
            index++;

            /*
            for(int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Hide();
            }
            */
        }
    }
}
