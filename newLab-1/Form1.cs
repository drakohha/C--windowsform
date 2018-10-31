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
       
        DateTime date1 = new DateTime();
        int select_index;
        int index_of_row;
        List<Persone> Per_list = new List<Persone>();
        
        void file_load()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Persone>));
            // десериализация
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                List<Persone> newPerson = (List<Persone>)formatter.Deserialize(fs);
               

                Per_list = newPerson;
               
            }
        }

        void file_save()
        {
           

            XmlSerializer formatter = new XmlSerializer(typeof(List<Persone>));
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Per_list);
               


            }
        }

        
        // Сохранение записи в файл
        void save_progress()
        {
            file_save();
            
            date1 = DateTime.Now;
            toolStripStatusLabel3.Text = date1.ToString();
            toolStripProgressBar1.Value = 100;


        }
       
        // Загрузка инфы из файла
        void load_progress()
        {
           
            file_load();
            Persone tek_persone = new Persone();

            if (tabPage1.Focus() == true)
            {
                

                foreach( var x in Per_list)
                {
                     ListViewItem li_01 = new ListViewItem();
                     li_01.Text = x.Name_persone;
                     li_01.SubItems.Add(x.WorkeType_persone);
                     li_01.SubItems.Add(x.Age_persone.ToString());
                     listView1.Items.Add(li_01);
                }

                
                


            }
            else if (tabPage2.Focus() == true)
            {
                foreach (var x in Per_list)
                {
                   
                    this.dataGridView1.Rows.Add(x.Name_persone, x.WorkeType_persone, x.Age_persone);
                }
                
            }
            else if (tabPage3.Focus() == true)
            {
                foreach (var x in Per_list)
                {

                    TreeNode tr = new TreeNode(x.Name_persone);


                    treeView1.Nodes[0].Nodes.Add(tr);
                }
            }

            toolStripProgressBar1.Value = 0;
        }

        // Удаление записи
        void remove_progress()
        {
            if (tabPage1.Focus() == true)
            {
                listView1.SelectedItems[0].Remove();
                Per_list.RemoveAt(select_index);
                
            }
            else if (tabPage2.Focus() == true)
            {
                
                this.dataGridView1.Rows.Remove(dataGridView1.Rows[select_index]);
                Per_list.RemoveAt(index_of_row);

               
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
            Persone tek_persone = new Persone();


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
