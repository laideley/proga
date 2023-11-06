using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace labor_exchange
{
    public partial class add_vacancy : Form
    {
        public add_vacancy()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)//add
        {
            if (this.name.Text != "" && this.stack.Text != "" && this.city.Text != "" && this.salary.Text != "" && this.company.Text != "")
            {
                string[] row = { name.Text, company.Text, stack.Text, city.Text, salary.Text };
                ListViewItem listViewItem1 = new ListViewItem(row);
                listView1.Items.Add(listViewItem1);
                Labor.addElem(name.Text, company.Text, stack.Text, city.Text, salary.Text);
                name.Text = company.Text = stack.Text = city.Text = salary.Text = "";
            }
            else
            {
                MessageBox.Show("Проверьте пожалуйста поля");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                string selectedText = this.listView1.SelectedItems[0].Text;
                Labor.removeV(selectedText);
                this.listView1.Items.Remove(this.listView1.SelectedItems[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_form home_Form = new Home_form();
            home_Form.Show();
            this.Close();
        }

        private void add_vacancy_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Labor.name_get().Length; i++)
            {
                string[] row = { Labor.name_get()[i], Labor.company_get()[i], Labor.stack_get()[i], Labor.city_get()[i], Labor.salary_get()[i] };
                ListViewItem listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }
        private void KeyPressRUS_NUM(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 127 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void KeyPressRUS(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 127 && e.KeyChar != ' ' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }
        private void KeyPressNUM(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
