using System.Windows.Forms;
using static labor_exchange.Program;

namespace labor_exchange
{
    public partial class Home_form : Form
    {
        public Home_form()
        {
            InitializeComponent();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            //this.Hide();
            this.Close();
            Login.ShowDialog();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reg_form reg_Form = new Reg_form();
            this.Close();
            reg_Form.ShowDialog();
        }


        private void Home_form_Load(object sender, EventArgs e)
        {
            updateList();
            if (Acc.access == "Гость")
            {
                panel1.Visible = true;
                vak.Visible = false;
                addvk.Visible = false;
            }
            else if (Acc.access == "worker")
            {
                panel1.Visible = false;
                vak.Visible = true;
                addvk.Visible = false;
            }
            else if (Acc.access == "admin")
            {
                panel1.Visible = false;
                vak.Visible = true;
                addvk.Visible = true;
            }
        }
        public void updateList()
        {
            foreach (string vakant in Labor.name_get())
            {
                this.listBox_home.Items.Add(vakant);
            }
        }

        private void добавитьВакансиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_vacancy add_Vacancy = new add_vacancy();
            add_Vacancy.ShowDialog();
            this.Hide();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_home.SelectedItem != null)
            {

                int index = listBox_home.SelectedIndices[0];
                this.name.Text = this.listBox_home.SelectedItem.ToString();
                this.com.Text = Labor.company_get()[index];
                this.salary.Text = Labor.salary_get()[index];
                this.stak.Text = Labor.stack_get()[index];

            }
        }

        private void add_v(object sender, EventArgs e)
        {
            if (listBox_home.SelectedItem != null)
            {
                int index = Labor.name_get().ToList().IndexOf(listBox_home.SelectedItem.ToString());
                string itemText = $"{Acc.name} отклинкулся на \"{Labor.name_get()[index]}\" {Labor.company_get()[index]}";

                if (!listBox2.Items.Contains(itemText))
                {
                    listBox2.Items.Add(itemText);
                }
                else
                {
                    MessageBox.Show("Вы уже откликнулись");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент из списка");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.listBox2.Items.Count > 0)
            {
                this.listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Labor.responses_clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName))
                {
                    streamWriter.WriteLine("Список откликов");
                    foreach (object item in listBox2.Items)
                    {
                        streamWriter.WriteLine(item.ToString());
                    }
                }
            }
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Acc.access == "Гость")
            {
                panel1.Visible = true;
                vak.Visible = false;
                addvk.Visible = false;
            }
            else if (Acc.access == "worker")
            {
                panel1.Visible = false;
                vak.Visible = true;
                addvk.Visible = false;
            }
            else if (Acc.access == "admin")
            {
                panel1.Visible = false;
                vak.Visible = true;
                addvk.Visible = true;
            }
        }

        private void поискПоФильтрамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtr filtr = new filtr();
            this.Hide();
            filtr.ShowDialog();
        }

        private void выйтиИзПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}