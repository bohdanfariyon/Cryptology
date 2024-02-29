using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Program2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Resize += new EventHandler(Form1_Resize);
            Lab1textBox = new TextBox();
            Lab1buttonRun = new Button();
            Lab1btnSave = new Button();
            Lab1dataGridView1 = new DataGridView();
            Lab1btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)Lab1dataGridView1).BeginInit();
            

            this.SuspendLayout();

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
           
            Lab1btnLoad.Click += Lab1ReadFrequenciesFromFile;

            // 
            // Form1
            //
            
            Controls.Add(Lab1textBox);
            Controls.Add(Lab1btnSave);
            Controls.Add(Lab1btnLoad);
            Controls.Add(Lab1buttonRun);
            Controls.Add(Lab1dataGridView1);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Lab1dataGridView1).EndInit();

        }

        #endregion
        private System.Windows.Forms.TextBox Lab1textBox;
        private Button Lab1buttonRun;
        private DataGridView Lab1dataGridView1;
        private Button Lab1btnSave;
        private Dictionary<char, double> Lab1frequencies = new Dictionary<char, double>();
        private Button Lab1btnLoad;
    }
}