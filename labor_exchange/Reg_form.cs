using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labor_exchange
{
    public partial class Reg_form : Form
    {
        public Reg_form()
        {
            InitializeComponent();
        }
        private new void KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 97 || e.KeyChar >= 122) && (e.KeyChar <= 65 || e.KeyChar >= 90) && number != 8 && number != 'A' && number != 'a' && number != 'Z' && number != 'z' && number != '_' && number != '.' && number != '-') e.Handled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string logText = log.Text;
            string pass1Text = pass1.Text;
            string pass2Text = pass2.Text;

            if (log.Text.Length < 2 || pass1.Text.Length < 2 || pass2.Text.Length < 2)
            {
                MessageBox.Show("Текстовые поля меньше двух символов");
            }
            else
            {
                string path = @"C:\labor_exchange_database";
                string logFile = Path.Combine(path, "log.txt");
                string passFile = Path.Combine(path, "pass.txt");
                string userFile = Path.Combine(path, "user.txt");

                string[] login = File.ReadAllLines(logFile);
                if (login.Contains(logText))
                {
                    MessageBox.Show("Логин уже занят");
                }
                else if (pass1Text == pass2Text)
                {
                    File.AppendAllText(logFile, logText + "\n");
                    File.AppendAllText(passFile, pass1Text + "\n");
                    File.AppendAllText(userFile, user.Text + "\n");
                    MessageBox.Show("Регистрация успешна");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }

        }

        private void назад_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

