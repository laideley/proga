namespace labor_exchange
{
    partial class Reg_form
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
            log = new TextBox();
            pass1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pass2 = new TextBox();
            назад = new Button();
            user = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(133, 187);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 0;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // log
            // 
            log.Location = new Point(133, 62);
            log.Name = "log";
            log.Size = new Size(100, 23);
            log.TabIndex = 1;
            log.KeyPress += KeyPress;
            // 
            // pass1
            // 
            pass1.Location = new Point(133, 103);
            pass1.Name = "pass1";
            pass1.Size = new Size(100, 23);
            pass1.TabIndex = 2;
            pass1.KeyPress += KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 65);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 103);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 142);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 5;
            label3.Text = "Снова пароль";
            // 
            // pass2
            // 
            pass2.Location = new Point(133, 139);
            pass2.Name = "pass2";
            pass2.Size = new Size(100, 23);
            pass2.TabIndex = 6;
            pass2.KeyPress += KeyPress;
            // 
            // назад
            // 
            назад.Location = new Point(10, 187);
            назад.Name = "назад";
            назад.Size = new Size(75, 23);
            назад.TabIndex = 7;
            назад.Text = "Назад";
            назад.UseVisualStyleBackColor = true;
            назад.Click += назад_Click;
            // 
            // user
            // 
            user.Location = new Point(133, 22);
            user.Name = "user";
            user.Size = new Size(100, 23);
            user.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 24);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 9;
            label4.Text = "Имя";
            // 
            // Reg_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 243);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(user);
            Controls.Add(назад);
            Controls.Add(pass2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pass1);
            Controls.Add(log);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(304, 282);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(304, 282);
            Name = "Reg_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Зарегистрироваться";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox log;
        private TextBox pass1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox pass2;
        private Button назад;
        private TextBox user;
        private Label label4;
    }
}