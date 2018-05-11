using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GDI_lab01
{
    public partial class Form1 : Form
    {
        public int my_mousu_pos_x { get; set; }
        public  int my_mouse_pos_y { get; set; }

        public int my_mousu_pos_x_up { get; set; }
        public int my_mouse_pos_y_up { get; set; }
        int counter = 0;

        List<Point> myPts = new List<Point>();

        public Form1()
        {
            InitializeComponent();
          //  Graphics g = panel1.CreateGraphics();
        }

        void DrowMyLine()
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(new Pen(Color.Red, 2), my_mousu_pos_x, my_mouse_pos_y, my_mousu_pos_x_up, my_mouse_pos_y_up);
        }

        void DrowMyRentangle()
        {
            Graphics g = panel1.CreateGraphics();

            if(MousePosition.X< my_mousu_pos_x_up)
            {
                g.DrawRectangle(new Pen(Color.Red, 1), my_mousu_pos_x, my_mouse_pos_y, Math.Abs(my_mousu_pos_x_up - my_mousu_pos_x), Math.Abs(my_mouse_pos_y_up - my_mouse_pos_y));
                return;
            }
            if (MousePosition.X > my_mousu_pos_x_up)
            {
                g.DrawRectangle(new Pen(Color.Red, 2), my_mousu_pos_x, my_mouse_pos_y, Math.Abs(my_mousu_pos_x_up - my_mousu_pos_x), Math.Abs(my_mouse_pos_y_up - my_mouse_pos_y));
                return;
            }

            if(MousePosition.Y < my_mouse_pos_y_up)
            {
                g.DrawRectangle(new Pen(Color.Red,3), my_mousu_pos_x, my_mouse_pos_y, Math.Abs(my_mousu_pos_x_up - my_mousu_pos_x), Math.Abs(my_mouse_pos_y_up - my_mouse_pos_y));
                return;
            }
            if(MousePosition.Y > my_mouse_pos_y_up)
            {
                g.DrawRectangle(new Pen(Color.Red, 4), my_mousu_pos_x, my_mouse_pos_y, Math.Abs(my_mousu_pos_x_up - my_mousu_pos_x), Math.Abs(my_mouse_pos_y_up - my_mouse_pos_y));
                return;
            }

            
        }


        void DrowMyElips()
        {
            Graphics g = panel1.CreateGraphics();
            g.FillEllipse(Brushes.Red, my_mousu_pos_x, my_mouse_pos_y, Math.Abs(my_mousu_pos_x_up - my_mousu_pos_x), Math.Abs(my_mouse_pos_y_up - my_mouse_pos_y));



        }


        void DrowMyText()
        {
            Graphics g = panel1.CreateGraphics();
            string str="123";
            
            g.DrawString(str, new Font("Times New Roman", 20), Brushes.Green, my_mousu_pos_x_up, my_mouse_pos_y_up);

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
            if (rb_03.Checked == true || rb_01.Checked==true || rb_02.Checked==true)
            {
                my_mouse_pos_y = e.Y;
                my_mousu_pos_x = e.X;
                



            }

            if (rb_04.Checked == true)
            {
                textBox1.Show();
                textBox1.Enabled = true;
                
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
    }
}
