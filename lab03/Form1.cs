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

namespace WFlab03
{
    public partial class Form1 : Form
    {
        int time = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            if(tb_pass.Text.Count()>=5 && tb_login.Text.Count()>=5)
                bt_enter.Enabled = true;
            else
            {
                bt_enter.Enabled = false;
            }
        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            UserU u = new UserU();
            FileStream file = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "logins.txt"), FileMode.Open, FileAccess.Read);
            //StreamWriter writer = new StreamWriter(file, Encoding.UTF8);
            StreamReader reader = new StreamReader(file, Encoding.UTF8);
            u.login = reader.ReadLine();
            u.Password = reader.ReadLine();
            reader.Close();
            if(tb_login.Text==u.login && tb_pass.Text == u.Password)
            {
                MessageBox.Show("Правельно!!!");
                panel1.Hide();
                PB_progress_test.Show();
                TB_pages_test.Show();
                lb_progress.Show();
                lb_trak_pages.Show();
                tabc_test.Show();
                bt_end_test.Show();

                timer1.Enabled = true;
                timer1.Start();

            }
            else
            {
                MessageBox.Show("Неверно повторите еше раз!!");

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_end_test.Hide();
            PB_progress_test.Hide();
            TB_pages_test.Hide();
            lb_progress.Hide();
            lb_trak_pages.Hide();
            tabc_test.Hide();
            panel1.Show();

        }

        private void bt_end_test_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show(PB_progress_test.Value.ToString() + " тестов закончено правельно за время "+ time +" !! всего хорошего!!");

            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lb_time_progress.Text = time.ToString();
            time++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb_test01_01.Enabled = false;
            cb_test01_02.Enabled = false;
            cb_test01_03.Enabled = false;
            cb_test01_no01.Enabled = false;
            cb_test01_no02.Enabled = false;
            cb_test01_no03.Enabled = false;

            if(cb_test01_01.Checked==true && cb_test01_02.Checked==true && cb_test01_03.Checked == true)
            {
                PB_progress_test.Value += 1;
            }
            bt_test01.Enabled = false;
        }

        private void TB_pages_test_Scroll(object sender, EventArgs e)
        {
            tabc_test.SelectTab(TB_pages_test.Value );
            
            
        }

        private void bt_test02_Click(object sender, EventArgs e)
        {
           
            if (listBox_test02.SelectedIndices.Contains(0) && listBox_test02.SelectedIndices.Contains(2) &&
                listBox_test02.SelectedIndices.Contains(5) && listBox_test02.SelectedIndices.Contains(6) &&
                listBox_test02.SelectedIndices.Contains(7) && listBox_test02.SelectedIndices.Contains(8) &&
                comboBox_test02.SelectedIndex==1)
            {
                PB_progress_test.Value += 1;
            }
            
                

            listBox_test02.Enabled = false;
            comboBox_test02.Enabled = false;
            bt_test02.Enabled = false;
        }

        private void bt_test03_Click(object sender, EventArgs e)
        {
            int index = 2;
            if (maskedTextBox_test03.Text == index.ToString())
            {
                PB_progress_test.Value += 1;
            }
            maskedTextBox_test03.Enabled = false;
            bt_test03.Enabled = false;
        }

        private void bt_test04_Click(object sender, EventArgs e)
        {
            if (radbt_test04_05.Checked == true)
            {
                PB_progress_test.Value += 1;
            }
            radbt_test04_01.Enabled = false;
            radbt_test04_02.Enabled = false;
            radbt_test04_03.Enabled = false;
            radbt_test04_04.Enabled = false;
            radbt_test04_05.Enabled = false;
            radbt_test04_06.Enabled = false;
            bt_test04.Enabled = false;
        }

        private void bt_test05_Click(object sender, EventArgs e)
        {
            int index = 3;
            if (maskedTextBox_test05.Text == index.ToString())
            {
                PB_progress_test.Value += 1;
            }
            maskedTextBox_test05.Enabled = false;
            bt_test05.Enabled = false;
        }

        private void bt_test06_Click(object sender, EventArgs e)
        {
            if (comboBox_test06.SelectedIndex == 0)
            {
                PB_progress_test.Value += 1;
            }
            comboBox_test06.Enabled = false;
            bt_test06.Enabled = false;
        }

        private void bt_test07_Click(object sender, EventArgs e)
        {
            if (listBox_test07.SelectedIndices.Contains(0) && listBox_test07.SelectedIndices.Contains(1) &&
                listBox_test07.SelectedIndices.Contains(2) && listBox_test07.SelectedIndices.Contains(3))
                PB_progress_test.Value += 1;

            listBox_test07.Enabled = false;
            bt_test07.Enabled = false;
        }

        private void bt_test08_Click(object sender, EventArgs e)
        {
            if (radbt_test08_05.Checked == true)
            {
                PB_progress_test.Value += 1;
            }
            radbt_test08_01.Enabled = false;
            radbt_test08_02.Enabled = false;
            radbt_test08_03.Enabled = false;
            radbt_test08_04.Enabled = false;
            radbt_test08_05.Enabled = false;
            bt_test08.Enabled = false;
        }

        private void bt_test09_Click(object sender, EventArgs e)
        {
            if(cb_test09_01.Checked==true && cb_test09_02.Checked == true)
            {
                PB_progress_test.Value += 1;
            }
            cb_test09_01.Enabled = false;
            cb_test09_02.Enabled = false;
            cb_test09_03.Enabled = false;
            cb_test09_04.Enabled = false;
            cb_test09_05.Enabled = false;
            bt_test09.Enabled = false;
        }

        private void bt_test10_Click(object sender, EventArgs e)
        {
            if (comboBox_test10.SelectedIndex == 0)
            {
                PB_progress_test.Value += 1;
            }
            comboBox_test10.Enabled = false;
            linklb_test10_04.Enabled = true;
            bt_test10.Enabled = false;
        }

        private void linklb_test10_04_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Здесь должен быть сайт с правельными ответами... да да !!");
        }
    }
}
