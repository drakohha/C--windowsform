using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFlab01
{
    public partial class Form2 : Form
    {
        Form1 mf;
        public Form2(Form1 mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if ((this.textBox1.Text == "") ||
             (this.textBox2.Text == "") ||
             (this.textBox4.Text == "") ||
             (this.text_loc_x.Text == "") ||
            (this.text_loc_y.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены!!!!!!!!!!!!");

            }
            else
            {


                SaveFileDialog fd = new SaveFileDialog();
                fd.ShowDialog();
                
                FileStream file = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), fd.FileName), FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file, Encoding.UTF8);
                writer.Write(this.textBox1.Text);
                writer.Write(this.textBox2.Text);
                writer.Write(this.textBox4.Text);
                writer.Write(this.text_loc_x.Text);
                writer.Write(this.text_loc_y.Text);
                writer.Close();


                

                Form3 fm_3 = new Form3(mf);

                fm_3.Text = this.textBox2.Text;
                fm_3.Width = Convert.ToInt32(this.textBox1.Text);
                fm_3.Height = Convert.ToInt32(this.textBox4.Text);
                fm_3.Location = new Point(Convert.ToInt32(this.text_loc_x.Text), Convert.ToInt32(this.text_loc_y.Text));
                fm_3.MaximumSize = new Size(fm_3.Width, fm_3.Height);



                fm_3.Show();
                int id = 0;
                id = Convert.ToInt32(mf.label2.Text);
                id++;
                mf.label2.Text = Convert.ToString(id);
            }
            
        }
    }
}
