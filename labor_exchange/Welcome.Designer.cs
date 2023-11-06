namespace labor_exchange
{
    partial class Welcome
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label122 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(481, 301);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 0;
            button1.Text = "Вход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Логин;
            // 
            // button2
            // 
            button2.Location = new Point(204, 301);
            button2.Name = "button2";
            button2.Size = new Size(115, 43);
            button2.TabIndex = 1;
            button2.Text = "Регистрация";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Рег;
            // 
            // button3
            // 
            button3.Location = new Point(368, 311);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Гость";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Гость;
            // 
            // label122
            // 
            label122.AutoSize = true;
            label122.BackColor = Color.Transparent;
            label122.Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label122.ForeColor = Color.DarkSlateGray;
            label122.Location = new Point(149, 124);
            label122.Name = "label122";
            label122.Size = new Size(553, 78);
            label122.TabIndex = 3;
            label122.Text = "Работа Мечты";
            // 
            // button4
            // 
            button4.Location = new Point(368, 384);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Выход";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button4);
            Controls.Add(label122);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label122;
        private Button button4;
    }
}