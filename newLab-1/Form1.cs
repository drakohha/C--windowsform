using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drakohha_01
{
    public partial class Form1 : Form
    {
        int select_index;
        List<string> list_index_01 = new List<string>();
        List<string> Save_list_01 = new List<string>();
        List<string> Load_list_01 = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem li_01 = new ListViewItem();
            

            li_01.Text = Name_TB_01.Text;
            li_01.SubItems.Add(WorkeType_TB_01.Text);
            li_01.SubItems.Add(Age_TB_01.Text);
           



             
           // listView1.Items.Add(li_01);

            if(tabPage1.Focus() == true)
            {
                listView1.Items.Add(li_01);
                MessageBox.Show("сработал варинт 1");
            }
            else if (tabPage2.Focus() == true)
            {
                
                this.dataGridView1.Rows.Add(Name_TB_01.Text, WorkeType_TB_01.Text, Age_TB_01.Text);
                MessageBox.Show("сработал варинт 2");
            }
            else if (tabPage3.Focus() == true)
            {
                treeView1.Nodes.Add(Name_TB_01.Text, WorkeType_TB_01.Text, Age_TB_01.Text);
                MessageBox.Show("сработал варинт 3");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

     

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (tabPage1.Focus() == true)
            {
                listView1.SelectedItems[0].Remove();
            }
            else if (tabPage2.Focus() == true)
            {
               // dataGridView1.SelectedRows подумать
            }
            else if (tabPage3.Focus() == true)
            {
                //подумать
            }
            
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
            select_index = listView1.SelectedItems[0].Index;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem x in listView1.Items)
            {
                Save_list_01.Add(x.Text);
                Save_list_01.Add(" ");
                Save_list_01.Add(x.SubItems[0].Text);
                Save_list_01.Add(" ");
                Save_list_01.Add(x.SubItems[1].Text);
                Save_list_01.Add(" ");


            }

             toolStripStatusLabel3.Text = "29.10.2018";
            toolStripProgressBar1.Value = 100;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Load_list_01.Add ( "тест");
            Load_list_01.Add("тест2");
            Load_list_01.Add("тест3");
            ListViewItem li_01 = new ListViewItem();
            li_01.Text = Load_list_01[0];
            li_01.SubItems.Add (Load_list_01[1]);
            li_01.SubItems.Add ( Load_list_01[2]);
            listView1.Items.Add(li_01);

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string file_name;
            OpenFileDialog fpp = new OpenFileDialog();
            fpp.ShowDialog();

            file_name = fpp.FileName;
            //MessageBox.Show(file_name);
            //fpp.OpenFile();

            

        }
    }
}
