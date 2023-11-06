namespace labor_exchange
{
    partial class Home_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            главнаяToolStripMenuItem = new ToolStripMenuItem();
            входToolStripMenuItem = new ToolStripMenuItem();
            регистрацияToolStripMenuItem = new ToolStripMenuItem();
            vak = new ToolStripMenuItem();
            addvk = new ToolStripMenuItem();
            поискПоФильтрамToolStripMenuItem = new ToolStripMenuItem();
            выйтиИзПриложенияToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            listBox_home = new ListBox();
            listBox2 = new ListBox();
            Вакансии = new Label();
            label2 = new Label();
            name = new Label();
            stak = new Label();
            salary = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            com = new Label();
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // главнаяToolStripMenuItem
            // 
            главнаяToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { входToolStripMenuItem, регистрацияToolStripMenuItem });
            главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            главнаяToolStripMenuItem.Size = new Size(138, 19);
            главнаяToolStripMenuItem.Text = "Главная";
            // 
            // входToolStripMenuItem
            // 
            входToolStripMenuItem.Name = "входToolStripMenuItem";
            входToolStripMenuItem.Size = new Size(143, 22);
            входToolStripMenuItem.Text = "Вход";
            входToolStripMenuItem.Click += входToolStripMenuItem_Click;
            // 
            // регистрацияToolStripMenuItem
            // 
            регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            регистрацияToolStripMenuItem.Size = new Size(143, 22);
            регистрацияToolStripMenuItem.Text = "Регистрация";
            регистрацияToolStripMenuItem.Click += регистрацияToolStripMenuItem_Click;
            // 
            // vak
            // 
            vak.DropDownItems.AddRange(new ToolStripItem[] { addvk, поискПоФильтрамToolStripMenuItem });
            vak.Name = "vak";
            vak.Size = new Size(138, 19);
            vak.Text = "Вакансии";
            // 
            // addvk
            // 
            addvk.Name = "addvk";
            addvk.Size = new Size(185, 22);
            addvk.Text = "Добавить вакансию";
            addvk.Click += добавитьВакансиюToolStripMenuItem_Click;
            // 
            // поискПоФильтрамToolStripMenuItem
            // 
            поискПоФильтрамToolStripMenuItem.Name = "поискПоФильтрамToolStripMenuItem";
            поискПоФильтрамToolStripMenuItem.Size = new Size(185, 22);
            поискПоФильтрамToolStripMenuItem.Text = "Поиск по фильтрам";
            поискПоФильтрамToolStripMenuItem.Click += поискПоФильтрамToolStripMenuItem_Click;
            // 
            // выйтиИзПриложенияToolStripMenuItem
            // 
            выйтиИзПриложенияToolStripMenuItem.Name = "выйтиИзПриложенияToolStripMenuItem";
            выйтиИзПриложенияToolStripMenuItem.Size = new Size(138, 19);
            выйтиИзПриложенияToolStripMenuItem.Text = "Выйти из приложения";
            выйтиИзПриложенияToolStripMenuItem.Click += выйтиИзПриложенияToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { главнаяToolStripMenuItem, vak, выйтиИзПриложенияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(145, 551);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.MouseMove += menuStrip1_MouseMove;
            // 
            // listBox_home
            // 
            listBox_home.FormattingEnabled = true;
            listBox_home.ItemHeight = 15;
            listBox_home.Location = new Point(148, 38);
            listBox_home.Name = "listBox_home";
            listBox_home.Size = new Size(354, 364);
            listBox_home.TabIndex = 2;
            listBox_home.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(549, 43);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(349, 364);
            listBox2.TabIndex = 3;
            // 
            // Вакансии
            // 
            Вакансии.AutoSize = true;
            Вакансии.Location = new Point(196, 20);
            Вакансии.Name = "Вакансии";
            Вакансии.Size = new Size(59, 15);
            Вакансии.TabIndex = 4;
            Вакансии.Text = "Вакансии";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(563, 20);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Отклики";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(321, 405);
            name.Name = "name";
            name.Size = new Size(0, 15);
            name.TabIndex = 6;
            // 
            // stak
            // 
            stak.AutoSize = true;
            stak.Location = new Point(321, 469);
            stak.Name = "stak";
            stak.Size = new Size(0, 15);
            stak.TabIndex = 7;
            // 
            // salary
            // 
            salary.AutoSize = true;
            salary.Location = new Point(321, 498);
            salary.Name = "salary";
            salary.Size = new Size(0, 15);
            salary.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(397, 440);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 9;
            button1.Text = "Откликнуться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += add_v;
            // 
            // button2
            // 
            button2.Location = new Point(632, 414);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 10;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(632, 440);
            button3.Name = "button3";
            button3.Size = new Size(109, 23);
            button3.TabIndex = 11;
            button3.Text = "Удалить все";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(632, 469);
            button4.Name = "button4";
            button4.Size = new Size(109, 23);
            button4.TabIndex = 12;
            button4.Text = "Экспорт";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // com
            // 
            com.AutoSize = true;
            com.Location = new Point(321, 440);
            com.Name = "com";
            com.Size = new Size(0, 15);
            com.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 405);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 14;
            label1.Text = "Название вакансии";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 440);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 15;
            label3.Text = "Название комппании";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 469);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 16;
            label4.Text = "Навыки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 498);
            label5.Name = "label5";
            label5.Size = new Size(163, 15);
            label5.TabIndex = 17;
            label5.Text = "Зарплата в месяц (в рублях)";
            // 
            // panel1
            // 
            panel1.Location = new Point(397, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 100);
            panel1.TabIndex = 18;
            // 
            // Home_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(929, 551);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(com);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(salary);
            Controls.Add(stak);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(Вакансии);
            Controls.Add(listBox2);
            Controls.Add(listBox_home);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Home_form_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem главнаяToolStripMenuItem;
        private ToolStripMenuItem входToolStripMenuItem;
        private ToolStripMenuItem регистрацияToolStripMenuItem;
        private ToolStripMenuItem vak;
        private ToolStripMenuItem addvk;
        private ToolStripMenuItem выйтиИзПриложенияToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label Вакансии;
        private Label label2;
        private Label name;
        private Label stak;
        private Label salary;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        public ListBox listBox_home;
        private Label com;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ToolStripMenuItem поискПоФильтрамToolStripMenuItem;
        private Panel panel1;
    }
}