using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializePanelContainer();
        }
        private void InitializePanelContainer()
        {
            // Створення нового екземпляру Panel
            panelContainer = new Panel();
            // Налаштування розміщення та розміру
            panelContainer.Dock = DockStyle.Fill;
            
            // Додавання на форму
            Controls.Add(panelContainer);
        }
        private void openForm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Відкриваємо форму 1 в контейнері panelContainer
            Form1 form1 = new Form1();
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form1);
            form1.Show();
        }

        private void openForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form2);
            form2.Show();
        }
        private void openForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.TopLevel = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form3);
            form3.Show();
        }
        private void openForm4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            form4.TopLevel = false;
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form4);
            form4.Show();
        }
        private void openForm5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            form5.TopLevel = false;
            form5.FormBorderStyle = FormBorderStyle.None;
            form5.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form5);
            form5.Show();
        }
        private void openForm6ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form6 form6 = new Form6();
            form6.TopLevel = false;
            form6.FormBorderStyle = FormBorderStyle.None;
            form6.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form6);
            form6.Show();
        }
        private void openForm7ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form7 form7 = new Form7();
            form7.TopLevel = false;
            form7.FormBorderStyle = FormBorderStyle.None;
            form7.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form7);
            form7.Show();
        }
        private void openForm8ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form8 form8 = new Form8();
            form8.TopLevel = false;
            form8.FormBorderStyle = FormBorderStyle.None;
            form8.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form8);
            form8.Show();
        }
    }
}
