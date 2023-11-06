using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static labor_exchange.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace labor_exchange
{
    public partial class Login : Form
    {
        public Login()
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
            string[] login = File.ReadAllLines(@"C:\labor_exchange_database\log.txt");
            string[] password = File.ReadAllLines(@"C:\labor_exchange_database\pass.txt");
            string[] user_name = File.ReadAllLines(@"C:\labor_exchange_database\user.txt");
            string logText = log.Text;
            string passText = pass.Text;
            Home_form home_Form = new Home_form();
            if (logText.Length <= 2 || passText.Length <= 2)
            {
                MessageBox.Show("Текстовые поля меньше двух символов");
            }
            else
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (logText == "admin" && passText == "admin" && code.Text == "")
                    {
                        Acc.access = "admin";
                        Acc.name = "admin";
                        label4.Text = "";
                        MessageBox.Show("Добро пожаловать Админ");
                        this.Close();
                        home_Form.Show();
                        break;
                    }
                    else if (code.Text == "1" && logText == login[i] && passText == password[i])
                    {
                        Acc.access = "admin";
                        Acc.name = user_name[i];
                        label4.Text = "";
                        MessageBox.Show("Добро пожаловать Админ");
                        this.Close();
                        home_Form.Show();
                        break;
                    }
                    else if (logText == login[i] && passText == password[i] && code.Text == "")
                    {
                        Acc.access = "worker";
                        Acc.name = user_name[i];
                        label4.Text = "";
                        MessageBox.Show("Работник здрайствуйте");
                        this.Close();
                        home_Form.Show();
                        break;
                    }
                    else
                    {
                        label4.Text = "Неверный логин или пароль";
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass.UseSystemPasswordChar = false;
                code.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
                code.UseSystemPasswordChar = true;
            }
        }
    }
}
