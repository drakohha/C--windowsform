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
   
    public partial class Form1 : Form
    {
        public  List<UserU> li = new List<UserU>();
        UserU u_now = new UserU();
        //UserU u_2;
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //OpenFileDialog op = new OpenFileDialog();
            //op.ShowDialog();

            li.Add(new UserU() { age = 22, FIO = "Петорв", email = "tr@tut.by" });
            li.Add(new UserU() { age = 33, FIO = "Веторв", email = "tr1@tut.by" });
            li.Add(new UserU() { age = 44, FIO = "Иванов", email = "tr2@tut.by" });

            for (int i = 0; i < li.Count; i++)
                comboBox1.Items.Add(li[i]);
            //comboBox1.DataSource = li;
            comboBox1.Refresh();
            comboBox1.SelectedIndex = 0;


            comboBox1.DisplayMember = "FIO";
            comboBox1.ValueMember = "email";

            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();

            timer1.Enabled = true;
            timer1.Start();







        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
            for(int i = 0; i < li.Count; i++)
            {
                if (li[i].FIO == comboBox1.Text)
                {
                     u_now.FIO = li[i].FIO;
                     u_now.age = li[i].age;
                     u_now.email = li[i].email;
                    break;
                }
            }
            
            

            tb_age.Text = u_now.age.ToString();
            tb_fio.Text = u_now.FIO;
            tb_email.Text = u_now.email;


            
            




        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_start_redact_Click(object sender, EventArgs e)
        {
            tb_fio.Enabled = true;
            tb_age.Enabled = true;
            tb_email.Enabled = true;
        }

        private void bt_end_redact_Click(object sender, EventArgs e)
        {

            u_now.FIO = tb_fio.Text;
            u_now.age = Convert.ToInt32(tb_age.Text) ;
            u_now.email = tb_email.Text;
            //li.Insert(comboBox1.SelectedIndex, u_now);
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].FIO == tb_fio.Text)
                {
                    li[i].FIO=u_now.FIO;
                   li[i].age=u_now.age;
                   li[i].email=u_now.email;
                    break;
                }
            }

            tb_fio.Enabled = false;
            tb_age.Enabled = false;
            tb_email.Enabled = false;

          

            

        }

        private void bt_dell_item_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].FIO == comboBox1.Text)
                {
                    li.RemoveAt(i);
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    break;
                }
            }

            comboBox1.Refresh();
            comboBox1.SelectedIndex = 0;
        }

        private void bt_load_items_Click(object sender, EventArgs e)
        {
            li.Add(new UserU() { age = 22, FIO = "Петорв", email = "tr@tut.by" });
            li.Add(new UserU() { age = 33, FIO = "Веторв", email = "tr1@tut.by" });
            li.Add(new UserU() { age = 44, FIO = "Иванов", email = "tr2@tut.by" });

            for(int i=0;i<li.Count;i++)
                comboBox1.Items.Add(li[i]);
            //comboBox1.DataSource = li;
            comboBox1.Refresh();
            comboBox1.SelectedIndex = 0;


            comboBox1.DisplayMember = "FIO";
            comboBox1.ValueMember = "email";

            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();

            timer1.Enabled = true;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void bt_save_item_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные были сохранены!");
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные были сохранены!");
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            tb_fio.Enabled = true;
            tb_age.Enabled = true;
            tb_email.Enabled = true;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].FIO == comboBox1.Text)
                {
                    li.RemoveAt(i);
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    break;
                }
            }

            comboBox1.Refresh();
            comboBox1.SelectedIndex = 0;
        }

        private void bt_new_item_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            fm.fm_1 = this;
            
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            listView1.Hide();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uC_dostup1.flag_index == 1)
            {
                panel1.Show();
                panel2.Show();
                panel3.Show();
                listView1.Show();
                uC_dostup1.Hide();
                button1.Hide();
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            fm.fm_1 = this;

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут есть подробная инфаааа обовсеммм!!!");
        }
    }
}
