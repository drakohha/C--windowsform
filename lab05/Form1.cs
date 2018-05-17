using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WF_GDI_lab01
{
    public partial class Form1 : Form
    {
        public int my_mousu_pos_x { get; set; }
        public  int my_mouse_pos_y { get; set; }

        public int my_mousu_pos_x_up { get; set; }
        public int my_mouse_pos_y_up { get; set; }
        int counter = 0;
        public void Undo(Form1 fm) { }
        public void Redo(Form1 fm) { }

        List<Point> myPts = new List<Point>();
        Color cl;
        Brushes brh;
        Brush brsh;
        Font myfont;
        Form1 fm;
        XDocument dc= new XDocument();
        History HSS;
        public Form1()
        {
            InitializeComponent();
            fm = this;
            
            History HS = new History(fm);
            this.HSS = HS;
        }



        void DrowMyLine()
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(new Pen(cl, 2), my_mousu_pos_x, my_mouse_pos_y, my_mousu_pos_x_up, my_mouse_pos_y_up);
        }

        void DrowMyRentangle()
        {
            Graphics g = panel1.CreateGraphics();

            if(MousePosition.X< my_mousu_pos_x_up)
            {
                g.DrawRectangle(new Pen(cl, 1), my_mousu_pos_x, my_mouse_pos_y, Math.Abs(my_mousu_pos_x_up - my_mousu_pos_x), Math.Abs(my_mouse_pos_y_up - my_mouse_pos_y));
                return;
            }
            if (MousePosition.X > my_mousu_pos_x_up)
            {
                g.DrawRectangle(new Pen(cl, 2), my_mousu_pos_x, my_mouse_pos_y, Math.Abs(my_mousu_pos_x_up - my_mousu_pos_x), Math.Abs(my_mouse_pos_y_up - my_mouse_pos_y));
                return;
            }

            if(MousePosition.Y < my_mouse_pos_y_up)
            {
                g.DrawRectangle(new Pen(cl,3), my_mousu_pos_x, my_mouse_pos_y, Math.Abs(my_mousu_pos_x_up - my_mousu_pos_x), Math.Abs(my_mouse_pos_y_up - my_mouse_pos_y));
                return;
            }
            if(MousePosition.Y > my_mouse_pos_y_up)
            {
                g.DrawRectangle(new Pen(cl, 4), my_mousu_pos_x, my_mouse_pos_y, Math.Abs(my_mousu_pos_x_up - my_mousu_pos_x), Math.Abs(my_mouse_pos_y_up - my_mouse_pos_y));
                return;
            }

            
        }


        void DrowMyElips()
        {
            Graphics g = panel1.CreateGraphics();
            g.FillEllipse(brsh, my_mousu_pos_x, my_mouse_pos_y, Math.Abs(my_mousu_pos_x_up - my_mousu_pos_x), Math.Abs(my_mouse_pos_y_up - my_mouse_pos_y));



        }


        void DrowMyText()
        {
            Graphics g = panel1.CreateGraphics();
            string str=textBox1.Text;
            
            g.DrawString(str, myfont, brsh, my_mousu_pos_x_up, my_mouse_pos_y_up);

        }


        void ChengeColor()
        {
            ColorDialog cld = new ColorDialog();
            cld.ShowDialog();
            cl = cld.Color;
        }

        void ChengeBrush()
        {
            ColorDialog cld = new ColorDialog();
            cld.ShowDialog();
            Brush solidBeigeBrush = new SolidBrush(cld.Color);
            brsh = solidBeigeBrush;

            
        }


        void ChengeText()
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();

            myfont = font.Font;
            
        }


        void UnChenge()
        {
            Graphics g = panel1.CreateGraphics();
            
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rb_03_CheckedChanged(object sender, EventArgs e)
        {
            //Graphics g = button1.CreateGraphics();
            //g.DrawLine(new Pen(Color.Red, 2), 20, 20, 80, 100);

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (brsh == null)
            {
                MessageBox.Show("Выберете заливку");
                return;
            }
            if (myfont == null)
            {
                MessageBox.Show("Выберете параметры текста");
                return;
            }
            if (rb_03.Checked == true || rb_01.Checked==true || rb_02.Checked==true)
            {
                my_mouse_pos_y = e.Y;
                my_mousu_pos_x = e.X;
                



            }

            if (rb_04.Checked == true)
            {
                textBox1.Show();
                textBox1.Enabled = true;
                textBox1.Focus();
                textBox1.Text = "";
                          }
            else if(rb_04.Checked==false)
            {
                textBox1.Hide();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {


            if (rb_03.Checked == true )
            {
                DrowMyLine();
                Invalidate();
            }
            if (rb_02.Checked == true)
            {
                DrowMyRentangle();
               Invalidate();
            }
            if (rb_01.Checked==true)
            {
                DrowMyElips();
                Invalidate();
            }
            HSS.Add(fm);

        }




        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            // Color.FromArgb()
            //   g.PageUnit = GraphicsUnit.Inch;
           // g.DrawRectangle(new Pen(Color.Red, 5), 0, 0, 100, 100);
            //g.FillEllipse(Brushes.Aqua,Rectangle);
           // String str = "Привет ";

            //g.DrawString(str + counter++, new Font("Times New Roman", 20), Brushes.Green, 0, 10);
           // foreach (var p in myPts)
           // {

          //      g.FillEllipse(Brushes.Red, p.X, p.Y, 10, 10);
          //  }


        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            my_mouse_pos_y_up = e.Y;
            my_mousu_pos_x_up = e.X;
            Invalidate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DrowMyText();
            Invalidate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChengeColor();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChengeBrush();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChengeText();
            Invalidate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HSS.Undo(fm);
            fm.panel1.Parent = HSS.items[HSS.currentIndex].panel1.Parent;
            Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
