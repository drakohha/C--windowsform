namespace WF_GDI_lab01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_01 = new System.Windows.Forms.RadioButton();
            this.rb_02 = new System.Windows.Forms.RadioButton();
            this.rb_03 = new System.Windows.Forms.RadioButton();
            this.rb_04 = new System.Windows.Forms.RadioButton();
            this.rb_05 = new System.Windows.Forms.RadioButton();
            this.rb_06 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(119, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 333);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(120, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 105);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Цвет";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Заливка";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Шрифт";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rb_06);
            this.panel3.Controls.Add(this.rb_05);
            this.panel3.Controls.Add(this.rb_04);
            this.panel3.Controls.Add(this.rb_03);
            this.panel3.Controls.Add(this.rb_02);
            this.panel3.Controls.Add(this.rb_01);
            this.panel3.Location = new System.Drawing.Point(261, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 52);
            this.panel3.TabIndex = 2;
            // 
            // rb_01
            // 
            this.rb_01.AutoSize = true;
            this.rb_01.Location = new System.Drawing.Point(23, 22);
            this.rb_01.Name = "rb_01";
            this.rb_01.Size = new System.Drawing.Size(62, 17);
            this.rb_01.TabIndex = 0;
            this.rb_01.Text = "Эллипс";
            this.rb_01.UseVisualStyleBackColor = true;
            // 
            // rb_02
            // 
            this.rb_02.AutoSize = true;
            this.rb_02.Location = new System.Drawing.Point(105, 21);
            this.rb_02.Name = "rb_02";
            this.rb_02.Size = new System.Drawing.Size(105, 17);
            this.rb_02.TabIndex = 1;
            this.rb_02.Text = "Прямоугольник";
            this.rb_02.UseVisualStyleBackColor = true;
            // 
            // rb_03
            // 
            this.rb_03.AutoSize = true;
            this.rb_03.Location = new System.Drawing.Point(225, 21);
            this.rb_03.Name = "rb_03";
            this.rb_03.Size = new System.Drawing.Size(57, 17);
            this.rb_03.TabIndex = 2;
            this.rb_03.Text = "Линия";
            this.rb_03.UseVisualStyleBackColor = true;
            this.rb_03.CheckedChanged += new System.EventHandler(this.rb_03_CheckedChanged);
            // 
            // rb_04
            // 
            this.rb_04.AutoSize = true;
            this.rb_04.Location = new System.Drawing.Point(297, 21);
            this.rb_04.Name = "rb_04";
            this.rb_04.Size = new System.Drawing.Size(55, 17);
            this.rb_04.TabIndex = 3;
            this.rb_04.Text = "Текст";
            this.rb_04.UseVisualStyleBackColor = true;
            // 
            // rb_05
            // 
            this.rb_05.AutoSize = true;
            this.rb_05.Location = new System.Drawing.Point(367, 21);
            this.rb_05.Name = "rb_05";
            this.rb_05.Size = new System.Drawing.Size(62, 17);
            this.rb_05.TabIndex = 4;
            this.rb_05.Text = "Ластик";
            this.rb_05.UseVisualStyleBackColor = true;
            // 
            // rb_06
            // 
            this.rb_06.AutoSize = true;
            this.rb_06.Checked = true;
            this.rb_06.Location = new System.Drawing.Point(456, 21);
            this.rb_06.Name = "rb_06";
            this.rb_06.Size = new System.Drawing.Size(80, 17);
            this.rb_06.TabIndex = 5;
            this.rb_06.TabStop = true;
            this.rb_06.Text = "Указатель";
            this.rb_06.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(263, 478);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 40);
            this.panel4.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 34);
            this.button4.TabIndex = 0;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(124, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 34);
            this.button5.TabIndex = 1;
            this.button5.Text = "Загрузить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(245, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 34);
            this.button6.TabIndex = 2;
            this.button6.Text = "Выход";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(366, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Назат";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(447, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "Вперед";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(528, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "Очистить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(327, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 567);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rb_06;
        private System.Windows.Forms.RadioButton rb_05;
        private System.Windows.Forms.RadioButton rb_04;
        private System.Windows.Forms.RadioButton rb_03;
        private System.Windows.Forms.RadioButton rb_02;
        private System.Windows.Forms.RadioButton rb_01;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
    }
}

