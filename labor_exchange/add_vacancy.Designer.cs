namespace labor_exchange
{
    partial class add_vacancy
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name = new TextBox();
            stack = new TextBox();
            city = new TextBox();
            salary = new TextBox();
            label4 = new Label();
            label5 = new Label();
            company = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(0, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(473, 348);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Название";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Компания";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Стек";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Город";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Зарплата";
            columnHeader5.Width = 80;
            // 
            // button1
            // 
            button1.Location = new Point(479, 285);
            button1.Name = "button1";
            button1.Size = new Size(58, 41);
            button1.TabIndex = 1;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(543, 285);
            button2.Name = "button2";
            button2.Size = new Size(61, 41);
            button2.TabIndex = 2;
            button2.Text = "Удалить элемент";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(479, 239);
            button3.Name = "button3";
            button3.Size = new Size(125, 36);
            button3.TabIndex = 3;
            button3.Text = "Добавить элемент";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(520, 3);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(520, 96);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Навыки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 138);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Город";
            // 
            // name
            // 
            name.Location = new Point(494, 21);
            name.MaxLength = 10;
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 7;
            name.KeyPress += KeyPressRUS_NUM;
            // 
            // stack
            // 
            stack.Location = new Point(494, 114);
            stack.MaxLength = 30;
            stack.Name = "stack";
            stack.Size = new Size(100, 23);
            stack.TabIndex = 8;
            stack.KeyPress += KeyPress;
            // 
            // city
            // 
            city.Location = new Point(494, 156);
            city.MaxLength = 10;
            city.Name = "city";
            city.Size = new Size(100, 23);
            city.TabIndex = 9;
            city.KeyPress += KeyPressRUS;
            // 
            // salary
            // 
            salary.Location = new Point(494, 200);
            salary.MaxLength = 10;
            salary.Name = "salary";
            salary.Size = new Size(100, 23);
            salary.TabIndex = 10;
            salary.KeyPress += KeyPressNUM;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(511, 182);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 11;
            label4.Text = "Зарплата";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(513, 47);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 12;
            label5.Text = "Компания";
            // 
            // company
            // 
            company.Location = new Point(494, 70);
            company.MaxLength = 10;
            company.Name = "company";
            company.Size = new Size(100, 23);
            company.TabIndex = 13;
            company.KeyPress += KeyPressRUS_NUM;
            // 
            // add_vacancy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 363);
            ControlBox = false;
            Controls.Add(company);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(salary);
            Controls.Add(city);
            Controls.Add(stack);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            MinimumSize = new Size(554, 282);
            Name = "add_vacancy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add_vacancy";
            Load += add_vacancy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox stack;
        private TextBox city;
        private TextBox salary;
        private Label label4;
        private Label label5;
        private ColumnHeader columnHeader5;
        private TextBox company;
    }
}