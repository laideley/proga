namespace labor_exchange
{
    partial class filtr
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
            listViewit = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button2 = new Button();
            listView12 = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewit
            // 
            listViewit.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewit.Location = new Point(31, 12);
            listViewit.Name = "listViewit";
            listViewit.Size = new Size(473, 348);
            listViewit.TabIndex = 1;
            listViewit.UseCompatibleStateImageBehavior = false;
            listViewit.View = View.Details;
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
            button1.Location = new Point(616, 245);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Название", "Компания", "Город" });
            comboBox1.Location = new Point(593, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(603, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(616, 182);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Далее";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView12
            // 
            listView12.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listView12.Location = new Point(31, 375);
            listView12.Name = "listView12";
            listView12.Size = new Size(473, 348);
            listView12.TabIndex = 7;
            listView12.UseCompatibleStateImageBehavior = false;
            listView12.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Название";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Компания";
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Стек";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Город";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Зарплата";
            columnHeader10.Width = 80;
            // 
            // filtr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 726);
            ControlBox = false;
            Controls.Add(listView12);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(listViewit);
            Name = "filtr";
            Text = "filtr";
            Load += filtr_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewit;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button2;
        private ListView listView12;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}