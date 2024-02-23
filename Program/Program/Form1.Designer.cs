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
            частотніТаблиціToolStripMenuItem = new ToolStripMenuItem();
            шифрПростоїЗаміниToolStripMenuItem = new ToolStripMenuItem();
            частотніТаблиціtextBox = new TextBox();
            частотніТаблиціbuttonRun = new Button();
            частотніТаблиціbtnSave = new Button();
            частотніТаблиціdataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)частотніТаблиціdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { частотніТаблиціToolStripMenuItem, шифрПростоїЗаміниToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1065, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // частотніТаблиціToolStripMenuItem
            // 
            частотніТаблиціToolStripMenuItem.ForeColor = Color.White;
            частотніТаблиціToolStripMenuItem.Name = "частотніТаблиціToolStripMenuItem";
            частотніТаблиціToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F;
            частотніТаблиціToolStripMenuItem.Size = new Size(169, 24);
            частотніТаблиціToolStripMenuItem.Text = "Частотні таблиці";
            частотніТаблиціToolStripMenuItem.Click += частотніТаблиціToolStripMenuItem_Click;
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
            частотніТаблиціtextBox.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            частотніТаблиціtextBox.Location = new Point(14, 36);
            частотніТаблиціtextBox.Margin = new Padding(3, 4, 3, 4);
            частотніТаблиціtextBox.Multiline = true;
            частотніТаблиціtextBox.Name = "частотніТаблиціtextBox";
            частотніТаблиціtextBox.ScrollBars = ScrollBars.Vertical;
            частотніТаблиціtextBox.Size = new Size(342, 359);
            частотніТаблиціtextBox.TabIndex = 1;
            частотніТаблиціtextBox.Visible = false;
            // 
            // частотніТаблиціbuttonRun
            // 
            частотніТаблиціbuttonRun.BackColor = Color.White;
            частотніТаблиціbuttonRun.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            частотніТаблиціbuttonRun.ForeColor = Color.Black;
            частотніТаблиціbuttonRun.Location = new Point(406, 36);
            частотніТаблиціbuttonRun.Margin = new Padding(3, 4, 3, 4);
            частотніТаблиціbuttonRun.Name = "частотніТаблиціbuttonRun";
            частотніТаблиціbuttonRun.Size = new Size(171, 67);
            частотніТаблиціbuttonRun.TabIndex = 2;
            частотніТаблиціbuttonRun.Text = "Виконати";
            частотніТаблиціbuttonRun.UseVisualStyleBackColor = false;
            частотніТаблиціbuttonRun.Visible = false;
            частотніТаблиціbuttonRun.Click += частотніТаблиціRun;
            // 
            // частотніТаблиціbtnSave
            // 
            частотніТаблиціbtnSave.BackColor = Color.White;
            частотніТаблиціbtnSave.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            частотніТаблиціbtnSave.ForeColor = Color.Black;
            частотніТаблиціbtnSave.Location = new Point(406, 111);
            частотніТаблиціbtnSave.Margin = new Padding(3, 4, 3, 4);
            частотніТаблиціbtnSave.Name = "частотніТаблиціbtnSave";
            частотніТаблиціbtnSave.Size = new Size(171, 67);
            частотніТаблиціbtnSave.TabIndex = 3;
            частотніТаблиціbtnSave.Text = "Зберегти";
            частотніТаблиціbtnSave.UseVisualStyleBackColor = false;
            частотніТаблиціbtnSave.Visible = false;
            частотніТаблиціbtnSave.Click += частотніТаблиціbtnSave_Click;
            // 
            // частотніТаблиціdataGridView1
            // 
            частотніТаблиціdataGridView1.BackgroundColor = SystemColors.ButtonFace;
            частотніТаблиціdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            частотніТаблиціdataGridView1.Location = new Point(625, 34);
            частотніТаблиціdataGridView1.Margin = new Padding(3, 4, 3, 4);
            частотніТаблиціdataGridView1.Name = "частотніТаблиціdataGridView1";
            частотніТаблиціdataGridView1.RowHeadersWidth = 51;
            частотніТаблиціdataGridView1.Size = new Size(403, 380);
            частотніТаблиціdataGridView1.TabIndex = 4;
            частотніТаблиціdataGridView1.CellContentClick += частотніТаблиціdataGridView1_CellContentClick;
            частотніТаблиціdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



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
            ((System.ComponentModel.ISupportInitialize)частотніТаблиціdataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem частотніТаблиціToolStripMenuItem;
        private ToolStripMenuItem шифрПростоїЗаміниToolStripMenuItem;
        private System.Windows.Forms.TextBox частотніТаблиціtextBox;
        private Button частотніТаблиціbuttonRun;
        private DataGridView частотніТаблиціdataGridView1;
        private Button частотніТаблиціbtnSave;




    }
}