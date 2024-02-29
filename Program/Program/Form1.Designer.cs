using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;

namespace Program
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Resize += new EventHandler(Form1_Resize);

            menuStrip1 = new MenuStrip();
            Lab1ToolStripMenuItem = new ToolStripMenuItem();
            шифрПростоїЗаміниToolStripMenuItem = new ToolStripMenuItem();
            Lab1textBox = new TextBox();
            Lab1buttonRun = new Button();
            Lab1btnSave = new Button();
            Lab1dataGridView1 = new DataGridView();
            Lab1btnLoad = new Button();
            проСистемуToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Lab1dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Lab1ToolStripMenuItem, шифрПростоїЗаміниToolStripMenuItem, проСистемуToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1065, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";

            проСистемуToolStripMenuItem.ForeColor = Color.White;
            проСистемуToolStripMenuItem.Name = "проСистемуToolStripMenuItem";
            проСистемуToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F;
            проСистемуToolStripMenuItem.Size = new Size(169, 24);
            проСистемуToolStripMenuItem.Text = "Про розробника";
            проСистемуToolStripMenuItem.Click += Lab1ToolStripMenuItem_Click;
            проСистемуToolStripMenuItem.Click += проРозробникаToolStripMenuItem_Click;
            // 
            // частотніТаблиціToolStripMenuItem
            // 
            Lab1ToolStripMenuItem.ForeColor = Color.White;
            Lab1ToolStripMenuItem.Name = "частотніТаблиціToolStripMenuItem";
            Lab1ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F;
            Lab1ToolStripMenuItem.Size = new Size(169, 24);
            Lab1ToolStripMenuItem.Text = "Частотні таблиці";
            Lab1ToolStripMenuItem.Click += Lab1ToolStripMenuItem_Click;
            // 
            // шифрПростоїЗаміниToolStripMenuItem
            // 
            шифрПростоїЗаміниToolStripMenuItem.ForeColor = Color.White;
            шифрПростоїЗаміниToolStripMenuItem.Name = "шифрПростоїЗаміниToolStripMenuItem";
            шифрПростоїЗаміниToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F;
            шифрПростоїЗаміниToolStripMenuItem.Size = new Size(209, 24);
            шифрПростоїЗаміниToolStripMenuItem.Text = "Шифр простої заміни";
            шифрПростоїЗаміниToolStripMenuItem.Click += шифрПростоїЗаміниToolStripMenuItem_Click;
            // 
            // частотніТаблиціtextBox
            // 
            Lab1textBox.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lab1textBox.Location = new Point(14, 36);
            Lab1textBox.Margin = new Padding(3, 4, 3, 4);
            Lab1textBox.Multiline = true;
            Lab1textBox.Name = "частотніТаблиціtextBox";
            Lab1textBox.ScrollBars = ScrollBars.Vertical;
            Lab1textBox.Size = new Size(342, 359);
            Lab1textBox.TabIndex = 1;
            Lab1textBox.Visible = false;
            // 
            // частотніТаблиціbuttonRun
            // 
            Lab1buttonRun.BackColor = Color.Black;
            Lab1buttonRun.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lab1buttonRun.ForeColor = Color.White;
            Lab1buttonRun.Location = new Point(406, 36);
            Lab1buttonRun.Margin = new Padding(3, 4, 3, 4);
            Lab1buttonRun.Name = "частотніТаблиціbuttonRun";
            Lab1buttonRun.Size = new Size(171, 67);
            Lab1buttonRun.TabIndex = 2;
            Lab1buttonRun.Text = "Виконати";
            Lab1buttonRun.UseVisualStyleBackColor = false;
            Lab1buttonRun.Visible = false;
            Lab1buttonRun.Click += Lab1Run;
            // 
            // частотніТаблиціbtnSave
            // 
            Lab1btnSave.BackColor = Color.Black;
            Lab1btnSave.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lab1btnSave.ForeColor = Color.White;
            Lab1btnSave.Location = new Point(406, 111);
            Lab1btnSave.Margin = new Padding(3, 4, 3, 4);
            Lab1btnSave.Name = "частотніТаблиціbtnSave";
            Lab1btnSave.Size = new Size(171, 67);
            Lab1btnSave.TabIndex = 3;
            Lab1btnSave.Text = "Зберегти";
            Lab1btnSave.UseVisualStyleBackColor = false;
            Lab1btnSave.Visible = false;
            Lab1btnSave.Click += Lab1btnSave_Click;
            // 
            // частотніТаблиціdataGridView1
            // 
            Lab1dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            Lab1dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Lab1dataGridView1.Location = new Point(625, 34);
            Lab1dataGridView1.Margin = new Padding(3, 4, 3, 4);
            Lab1dataGridView1.Name = "частотніТаблиціdataGridView1";
            Lab1dataGridView1.RowHeadersWidth = 51;
            Lab1dataGridView1.Size = new Size(403, 380);
            Lab1dataGridView1.TabIndex = 4;
            Lab1dataGridView1.CellContentClick += Lab1dataGridView1_CellContentClick;
            Lab1dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            Lab1btnLoad.BackColor = Color.Black;
            Lab1btnLoad.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lab1btnLoad.ForeColor = Color.White;
            Lab1btnLoad.Location = new Point(406, 111);
            Lab1btnLoad.Margin = new Padding(3, 4, 3, 4);
            Lab1btnLoad.Name = "частотніТаблиціbtnSave";
            Lab1btnLoad.Size = new Size(171, 67);
            Lab1btnLoad.TabIndex = 3;
            Lab1btnLoad.Text = "Завантажити";
            Lab1btnLoad.UseVisualStyleBackColor = false;
            Lab1btnLoad.Visible = false;
            Lab1btnLoad.Click += Lab1ReadFrequenciesFromFile;



            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1065, 600);
            
            Controls.Add(menuStrip1);
           
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Меню";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Lab1dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Lab1ToolStripMenuItem;
        private ToolStripMenuItem шифрПростоїЗаміниToolStripMenuItem;
        private System.Windows.Forms.TextBox Lab1textBox;
        private Button Lab1buttonRun;
        private DataGridView Lab1dataGridView1;
        private Button Lab1btnSave;
        private Dictionary<char, double> Lab1frequencies = new Dictionary<char, double>();
        private Button Lab1btnLoad;
        private ToolStripMenuItem проСистемуToolStripMenuItem;





    }
}