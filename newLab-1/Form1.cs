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
using System.Xml.Serialization;

namespace drakohha_01
{
    public partial class Form1 : Form
    {
        Persone tek_persone = new Persone();
        DateTime date1 = new DateTime();
        int select_index;
        int index_of_row;
        List<Persone> Per_list = new List<Persone>();
        
        void file_load()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Persone));
            // десериализация
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                Persone newPerson = (Persone)formatter.Deserialize(fs);
               

                tek_persone = newPerson;
                MessageBox.Show("файл открыт");
            }
        }

        void file_save()
        {
            Persone per = new Persone();
            per = tek_persone;
            XmlSerializer formatter = new XmlSerializer(typeof(Persone));
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, per);
                MessageBox.Show("файл сохранен");


            }
        }

        
        // Сохранение записи в файл
        void save_progress()
        {
            if (tabPage1.Focus() == true)
            {
                foreach (ListViewItem x in listView1.Items)
                {
                    tek_persone.Name_persone = x.SubItems[0].Text;
                    tek_persone.WorkeType_persone = x.SubItems[1].Text;

                    tek_persone.Age_persone = Convert.ToInt32(x.SubItems[2].Text);
                    file_save();



                }


            }
            else if (tabPage2.Focus() == true)
            {
                tek_persone.Name_persone = dataGridView1.Rows[0].Cells[0].Value.ToString();
                tek_persone.WorkeType_persone = dataGridView1.Rows[0].Cells[1].Value.ToString();

                tek_persone.Age_persone = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value.ToString());
                MessageBox.Show(tek_persone.Name_persone);

                file_save();
            }
            else if (tabPage3.Focus() == true)
            {

            }

            date1 = DateTime.Now;
            toolStripStatusLabel3.Text = date1.ToString();
            toolStripProgressBar1.Value = 100;


        }
       
        // Загрузка инфы из файла
        void load_progress()
        {
            file_load();


            if (tabPage1.Focus() == true)
            {


                ListViewItem li_01 = new ListViewItem();
                li_01.Text = (tek_persone.Name_persone);
                li_01.SubItems.Add(tek_persone.WorkeType_persone);
                li_01.SubItems.Add(tek_persone.Age_persone.ToString());
                listView1.Items.Add(li_01);


            }
            else if (tabPage2.Focus() == true)
            {
                this.dataGridView1.Rows.Add(tek_persone.Name_persone, tek_persone.WorkeType_persone, tek_persone.Age_persone);
            }
            else if (tabPage3.Focus() == true)
            {
                TreeNode tr = new TreeNode(tek_persone.Name_persone);
                 
                
                treeView1.Nodes[0].Nodes.Add(tr);
            }

            toolStripProgressBar1.Value = 0;
        }

        // Удаление записи
        void remove_progress()
        {
            if (tabPage1.Focus() == true)
            {
                listView1.SelectedItems[0].Remove();
                
            }
            else if (tabPage2.Focus() == true)
            {
                
                this.dataGridView1.Rows.Remove(dataGridView1.Rows[select_index]);


               
            }
            else if (tabPage3.Focus() == true)
            {
                treeView1.Nodes.Remove(this.treeView1.SelectedNode);
               
            }


        }
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
     

            tek_persone.Name_persone = Name_TB_01.Text;
            tek_persone.WorkeType_persone = WorkeType_TB_01.Text;
            tek_persone.Age_persone = Convert.ToInt32(Age_TB_01.Text);
            Per_list.Add(tek_persone);
            


            if (tabPage1.Focus() == true)
            {
                ListViewItem li_tek = new ListViewItem();
                li_tek.Text= (tek_persone.Name_persone);
                li_tek.SubItems.Add(tek_persone.WorkeType_persone);
                li_tek.SubItems.Add(tek_persone.Age_persone.ToString());
                listView1.Items.Add(li_tek);
                
            }
            else if (tabPage2.Focus() == true)
            {
                
                this.dataGridView1.Rows.Add(tek_persone.Name_persone, tek_persone.WorkeType_persone, tek_persone.Age_persone);
               
            }
            else if (tabPage3.Focus() == true)
            {
                TreeNode tr = new TreeNode(tek_persone.Name_persone);
                

                treeView1.Nodes[0].Nodes.Add(tr);
               // MessageBox.Show("сработал варинт 3");
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
            remove_progress();



        }

     

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            remove_progress();
            
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
            select_index = listView1.SelectedItems[0].Index;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {


            save_progress();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            load_progress();


        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            load_progress();




        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            save_progress();

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

            save_progress();

        }

        private void TM_01_Tick(object sender, EventArgs e)
        {
            save_progress();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
            index_of_row = dataGridView1.SelectedCells[0].RowIndex;
        }
    }
}
