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
    public partial class filtr : Form
    {
        public filtr()
        {
            InitializeComponent();
        }

        private void filtr_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Labor.salary_get().Length; i++)
            {
                string[] row = { Labor.name_get()[i], Labor.company_get()[i], Labor.stack_get()[i], Labor.city_get()[i], Labor.salary_get()[i] };
                ListViewItem listViewItem = new ListViewItem(row);
                ListViewItem listViewItem2 = new ListViewItem(row);
                listViewit.Items.Add(listViewItem);
                listView12.Items.Add(listViewItem2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_form home_Form = new Home_form();
            home_Form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Название":
                    if (textBox1.Text.Length == 0)
                    {
                        listViewit.Items.Clear();
                        for (int i = 0; i < Labor.salary_get().Length; i++)
                        {
                            string[] row = { Labor.name_get()[i], Labor.company_get()[i], Labor.stack_get()[i], Labor.city_get()[i], Labor.salary_get()[i] };
                            ListViewItem listViewItem = new ListViewItem(row);
                            listViewit.Items.Add(listViewItem);
                        }
                    }
                    else
                    {
                        listViewit.Items.Clear();
                        for (int i = 0; i < Labor.salary_get().Length; i++)
                        {
                            if (Labor.name_get()[i].Contains(this.textBox1.Text))
                            {
                                string[] row = { Labor.name_get()[i], Labor.company_get()[i], Labor.stack_get()[i], Labor.city_get()[i], Labor.salary_get()[i] };
                                ListViewItem listViewItem = new ListViewItem(row);
                                listViewit.Items.Add(listViewItem);
                            }
                        }
                    }
                    break;
                case "Компания":
                    if (textBox1.Text.Length == 0)
                    {
                        listViewit.Items.Clear();
                        for (int i = 0; i < Labor.name_get().Length; i++)
                        {
                            string[] row = { Labor.name_get()[i], Labor.company_get()[i], Labor.stack_get()[i], Labor.city_get()[i], Labor.salary_get()[i] };
                            ListViewItem listViewItem = new ListViewItem(row);
                            listViewit.Items.Add(listViewItem);
                        }
                    }
                    else
                    {
                        listViewit.Items.Clear();
                        for (int i = 0; i < Labor.name_get().Length; i++)
                        {
                            if (Labor.company_get()[i].Contains(this.textBox1.Text))
                            {
                                string[] row = { Labor.name_get()[i], Labor.company_get()[i], Labor.stack_get()[i], Labor.city_get()[i], Labor.salary_get()[i] };
                                ListViewItem listViewItem = new ListViewItem(row);
                                listViewit.Items.Add(listViewItem);
                            }
                        }
                    }
                    break;
                case "Город":
                    if (textBox1.Text.Length == 0)
                    {
                        listViewit.Items.Clear();
                        for (int i = 0; i < Labor.name_get().Length; i++)
                        {
                            string[] row = { Labor.name_get()[i], Labor.company_get()[i], Labor.stack_get()[i], Labor.city_get()[i], Labor.salary_get()[i] };
                            ListViewItem listViewItem = new ListViewItem(row);
                            listViewit.Items.Add(listViewItem);
                        }
                    }
                    else
                    {
                        listViewit.Items.Clear();
                        for (int i = 0; i < Labor.name_get().Length; i++)
                        {
                            if (Labor.city_get()[i].Contains(this.textBox1.Text))
                            {
                                string[] row = { Labor.name_get()[i], Labor.company_get()[i], Labor.stack_get()[i], Labor.city_get()[i], Labor.salary_get()[i] };
                                ListViewItem listViewItem = new ListViewItem(row);
                                listViewit.Items.Add(listViewItem);
                            }
                        }
                    }
                    break;
                default:
                    listViewit.Items.Clear();
                    for (int i = 0; i < Labor.salary_get().Length; i++)
                    {
                        string[] row = { Labor.name_get()[i], Labor.company_get()[i], Labor.stack_get()[i], Labor.city_get()[i], Labor.salary_get()[i] };
                        ListViewItem listViewItem = new ListViewItem(row);
                        listViewit.Items.Add(listViewItem);
                    }
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Labor.name_get().Length; i++)
            {
                string[] row = { Labor.name_get()[i], Labor.company_get()[i], Labor.stack_get()[i], Labor.city_get()[i], Labor.salary_get()[i] };
                ListViewItem listViewItem = new ListViewItem(row);
                listViewit.Items.Add(listViewItem);
            }
        }
    }
}
