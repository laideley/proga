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

namespace labor_exchange
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Гость(object sender, EventArgs e)
        {
            Acc.access = "Гость";
            Home_form home_Form = new Home_form();
            this.Hide();
            home_Form.Show();
        }

        private void Логин(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void Рег(object sender, EventArgs e)
        {
            Reg_form reg_Form = new Reg_form();
            reg_Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
