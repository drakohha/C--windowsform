namespace WFlab06
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.uC_person1 = new WFlab06.UC_person();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_dostup1 = new WFlab06.UC_dostup();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.uC_person1);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 345);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "отправить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uC_person1
            // 
            this.uC_person1.Location = new System.Drawing.Point(14, 3);
            this.uC_person1.Name = "uC_person1";
            this.uC_person1.Size = new System.Drawing.Size(245, 270);
            this.uC_person1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_dostup1);
            this.panel2.Location = new System.Drawing.Point(317, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 284);
            this.panel2.TabIndex = 1;
            // 
            // uC_dostup1
            // 
            this.uC_dostup1.Location = new System.Drawing.Point(18, 15);
            this.uC_dostup1.Name = "uC_dostup1";
            this.uC_dostup1.Size = new System.Drawing.Size(274, 214);
            this.uC_dostup1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Начать работать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UC_dostup uC_dostup1;
        private System.Windows.Forms.Button button1;
        private UC_person uC_person1;
        private System.Windows.Forms.Button button2;
    }
}