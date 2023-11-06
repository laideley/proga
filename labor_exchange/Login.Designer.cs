namespace labor_exchange
{
    partial class Login
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
            log = new TextBox();
            pass = new TextBox();
            code = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(196, 173);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Далее";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(63, 173);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // log
            // 
            log.Location = new Point(171, 23);
            log.MaxLength = 10;
            log.Name = "log";
            log.Size = new Size(100, 23);
            log.TabIndex = 2;
            // 
            // pass
            // 
            pass.Location = new Point(171, 71);
            pass.MaxLength = 10;
            pass.Name = "pass";
            pass.Size = new Size(100, 23);
            pass.TabIndex = 3;
            pass.UseSystemPasswordChar = true;
            // 
            // code
            // 
            code.Location = new Point(171, 114);
            code.MaxLength = 10;
            code.Name = "code";
            code.Size = new Size(100, 23);
            code.TabIndex = 4;
            code.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 5;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 79);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 122);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 7;
            label3.Text = "Секретный ключ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(307, 80);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 8;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 137);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 257);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(code);
            Controls.Add(pass);
            Controls.Add(log);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox log;
        private TextBox pass;
        private TextBox code;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Label label4;
    }
}