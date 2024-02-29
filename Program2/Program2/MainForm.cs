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
    }
}
