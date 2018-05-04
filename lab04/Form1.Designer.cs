namespace WFlab06
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Сотрудники в списке", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Сотрудники в редакторе", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Сотрудники");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "сотрудник",
            "qwerty"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.bt_new_item = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.bt_load_items = new System.Windows.Forms.Button();
            this.bt_save_item = new System.Windows.Forms.Button();
            this.bt_dell_item = new System.Windows.Forms.Button();
            this.bt_start_redact = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_select_item = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_end_redact = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_fio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.uC_dostup1 = new WFlab06.UC_dostup();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem5,
            this.toolStripSeparator1,
            this.toolStripMenuItem6});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem7.Text = "Сохранить";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem5.Text = "Загрузить";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem6.Text = "Выход";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(95, 20);
            this.toolStripMenuItem2.Text = "Инструменты";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem12.Text = "Добавить сотрудника";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem13.Text = "Редактировать";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem14.Text = "Удалить";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem15});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem3.Text = "Справка";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuItem4.Text = "Печать";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuItem9.Text = "Выбор параметров";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuItem10.Text = "Предварительный просмотр";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuItem11.Text = "Печатать";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1040, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Дата последнего сохранения файла";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(204, 17);
            this.toolStripStatusLabel1.Text = "Дата последнего сохранения файла";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel2.Text = "00.00.00";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 51);
            this.contextMenuStrip1.Text = "Контекстное меню";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem8.Text = "Выберете ";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // bt_new_item
            // 
            this.bt_new_item.Location = new System.Drawing.Point(17, 24);
            this.bt_new_item.Name = "bt_new_item";
            this.bt_new_item.Size = new System.Drawing.Size(152, 23);
            this.bt_new_item.TabIndex = 3;
            this.bt_new_item.Text = "Добавить сотрудника";
            this.toolTip1.SetToolTip(this.bt_new_item, "Добавить нового сотрудника");
            this.bt_new_item.UseVisualStyleBackColor = true;
            this.bt_new_item.Click += new System.EventHandler(this.bt_new_item_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.bt_load_items);
            this.panel1.Controls.Add(this.bt_save_item);
            this.panel1.Controls.Add(this.bt_dell_item);
            this.panel1.Controls.Add(this.bt_start_redact);
            this.panel1.Controls.Add(this.bt_new_item);
            this.panel1.Location = new System.Drawing.Point(12, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 285);
            this.panel1.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 26);
            this.button6.TabIndex = 8;
            this.button6.Text = "Выход";
            this.toolTip1.SetToolTip(this.button6, "Закрыть приложение");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bt_load_items
            // 
            this.bt_load_items.Location = new System.Drawing.Point(17, 201);
            this.bt_load_items.Name = "bt_load_items";
            this.bt_load_items.Size = new System.Drawing.Size(151, 29);
            this.bt_load_items.TabIndex = 7;
            this.bt_load_items.Text = "Загрузить";
            this.toolTip1.SetToolTip(this.bt_load_items, "Загрузить список сотрудникоффф");
            this.bt_load_items.UseVisualStyleBackColor = true;
            this.bt_load_items.Click += new System.EventHandler(this.bt_load_items_Click);
            // 
            // bt_save_item
            // 
            this.bt_save_item.Location = new System.Drawing.Point(17, 172);
            this.bt_save_item.Name = "bt_save_item";
            this.bt_save_item.Size = new System.Drawing.Size(152, 23);
            this.bt_save_item.TabIndex = 6;
            this.bt_save_item.Text = "Сохранить";
            this.toolTip1.SetToolTip(this.bt_save_item, "Сохранить текущий прогресс");
            this.bt_save_item.UseVisualStyleBackColor = true;
            this.bt_save_item.Click += new System.EventHandler(this.bt_save_item_Click);
            // 
            // bt_dell_item
            // 
            this.bt_dell_item.Location = new System.Drawing.Point(17, 84);
            this.bt_dell_item.Name = "bt_dell_item";
            this.bt_dell_item.Size = new System.Drawing.Size(152, 23);
            this.bt_dell_item.TabIndex = 5;
            this.bt_dell_item.Text = "Удалить";
            this.toolTip1.SetToolTip(this.bt_dell_item, "Удалить выбраного сотрудника");
            this.bt_dell_item.UseVisualStyleBackColor = true;
            this.bt_dell_item.Click += new System.EventHandler(this.bt_dell_item_Click);
            // 
            // bt_start_redact
            // 
            this.bt_start_redact.Location = new System.Drawing.Point(17, 54);
            this.bt_start_redact.Name = "bt_start_redact";
            this.bt_start_redact.Size = new System.Drawing.Size(152, 23);
            this.bt_start_redact.TabIndex = 4;
            this.bt_start_redact.Text = "Редактировать ";
            this.toolTip1.SetToolTip(this.bt_start_redact, "Редактировать выбраного сотрудника");
            this.bt_start_redact.UseVisualStyleBackColor = true;
            this.bt_start_redact.Click += new System.EventHandler(this.bt_start_redact_Click);
            // 
            // listView1
            // 
            listViewGroup1.Header = "Сотрудники в списке";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Сотрудники в редакторе";
            listViewGroup2.Name = "listViewGroup2";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup2;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(294, 118);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(217, 148);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bt_select_item);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(536, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 276);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбран";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "сотрудник";
            // 
            // bt_select_item
            // 
            this.bt_select_item.Location = new System.Drawing.Point(27, 82);
            this.bt_select_item.Name = "bt_select_item";
            this.bt_select_item.Size = new System.Drawing.Size(173, 32);
            this.bt_select_item.TabIndex = 1;
            this.bt_select_item.Text = "Выбрать";
            this.toolTip1.SetToolTip(this.bt_select_item, "Закрепить выбор сотрудника");
            this.bt_select_item.UseVisualStyleBackColor = true;
            this.bt_select_item.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBox1, "Выберете сотрудника из списка");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_end_redact);
            this.panel3.Controls.Add(this.tb_email);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tb_age);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tb_fio);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(807, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 274);
            this.panel3.TabIndex = 7;
            // 
            // bt_end_redact
            // 
            this.bt_end_redact.Location = new System.Drawing.Point(27, 226);
            this.bt_end_redact.Name = "bt_end_redact";
            this.bt_end_redact.Size = new System.Drawing.Size(173, 23);
            this.bt_end_redact.TabIndex = 6;
            this.bt_end_redact.Text = "Закончить редактирование";
            this.bt_end_redact.UseVisualStyleBackColor = true;
            this.bt_end_redact.Click += new System.EventHandler(this.bt_end_redact_Click);
            // 
            // tb_email
            // 
            this.tb_email.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_email.Enabled = false;
            this.tb_email.Location = new System.Drawing.Point(27, 181);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 20);
            this.tb_email.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tb_email, "Введите емаил сотрудника");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "email";
            // 
            // tb_age
            // 
            this.tb_age.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_age.Enabled = false;
            this.tb_age.Location = new System.Drawing.Point(27, 110);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(100, 20);
            this.tb_age.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tb_age, "Введите возраст сотрудника");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "AGE";
            // 
            // tb_fio
            // 
            this.tb_fio.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_fio.Enabled = false;
            this.tb_fio.Location = new System.Drawing.Point(24, 46);
            this.tb_fio.Name = "tb_fio";
            this.tb_fio.Size = new System.Drawing.Size(100, 20);
            this.tb_fio.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tb_fio, "Введите имя сотрудника");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "FIO";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Начать работать!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // uC_dostup1
            // 
            this.uC_dostup1.Location = new System.Drawing.Point(319, 241);
            this.uC_dostup1.Name = "uC_dostup1";
            this.uC_dostup1.Size = new System.Drawing.Size(261, 218);
            this.uC_dostup1.TabIndex = 8;
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem15.Text = "Справка ";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uC_dostup1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Учет сотрудников";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button bt_new_item;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bt_load_items;
        private System.Windows.Forms.Button bt_save_item;
        private System.Windows.Forms.Button bt_dell_item;
        private System.Windows.Forms.Button bt_start_redact;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_select_item;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_end_redact;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_fio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolTip toolTip1;
        private UC_dostup uC_dostup1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
    }
}

