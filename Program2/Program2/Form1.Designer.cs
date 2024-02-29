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
            this.Lab1textBox = new System.Windows.Forms.TextBox();
            this.Lab1buttonRun = new System.Windows.Forms.Button();
            this.Lab1btnSave = new System.Windows.Forms.Button();
            this.Lab1dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lab1btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lab1dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab1textBox
            // 
            this.Lab1textBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lab1textBox.Location = new System.Drawing.Point(14, 36);
            this.Lab1textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab1textBox.Multiline = true;
            this.Lab1textBox.Name = "Lab1textBox";
            this.Lab1textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Lab1textBox.Size = new System.Drawing.Size(342, 359);
            this.Lab1textBox.TabIndex = 1;
            // 
            // Lab1buttonRun
            // 
            this.Lab1buttonRun.BackColor = System.Drawing.Color.Black;
            this.Lab1buttonRun.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lab1buttonRun.ForeColor = System.Drawing.Color.White;
            this.Lab1buttonRun.Location = new System.Drawing.Point(406, 36);
            this.Lab1buttonRun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab1buttonRun.Name = "Lab1buttonRun";
            this.Lab1buttonRun.Size = new System.Drawing.Size(171, 67);
            this.Lab1buttonRun.TabIndex = 2;
            this.Lab1buttonRun.Text = "Виконати";
            this.Lab1buttonRun.UseVisualStyleBackColor = false;
            this.Lab1buttonRun.Click += Lab1Run;
            // 
            // Lab1btnSave
            // 
            this.Lab1btnSave.BackColor = System.Drawing.Color.Black;
            this.Lab1btnSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lab1btnSave.ForeColor = System.Drawing.Color.White;
            this.Lab1btnSave.Location = new System.Drawing.Point(406, 111);
            this.Lab1btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab1btnSave.Name = "Lab1btnSave";
            this.Lab1btnSave.Size = new System.Drawing.Size(171, 67);
            this.Lab1btnSave.TabIndex = 3;
            this.Lab1btnSave.Text = "Зберегти";
            this.Lab1btnSave.UseVisualStyleBackColor = false;
            this.Lab1btnSave.Click += Lab1btnSave_Click;
            // 
            // Lab1dataGridView1
            // 
            this.Lab1dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Lab1dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Lab1dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lab1dataGridView1.Location = new System.Drawing.Point(625, 34);
            this.Lab1dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab1dataGridView1.Name = "Lab1dataGridView1";
            this.Lab1dataGridView1.RowHeadersWidth = 51;
            this.Lab1dataGridView1.Size = new System.Drawing.Size(403, 380);
            this.Lab1dataGridView1.TabIndex = 4;
            // 
            // Lab1btnLoad
            // 
            this.Lab1btnLoad.BackColor = System.Drawing.Color.Black;
            this.Lab1btnLoad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lab1btnLoad.ForeColor = System.Drawing.Color.White;
            this.Lab1btnLoad.Location = new System.Drawing.Point(406, 111);
            this.Lab1btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab1btnLoad.Name = "Lab1btnLoad";
            this.Lab1btnLoad.Size = new System.Drawing.Size(171, 67);
            this.Lab1btnLoad.TabIndex = 3;
            this.Lab1btnLoad.Text = "Завантажити";
            this.Lab1btnLoad.UseVisualStyleBackColor = false;
            this.Lab1btnLoad.Click += Lab1ReadFrequenciesFromFile;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.Lab1textBox);
            this.Controls.Add(this.Lab1btnSave);
            this.Controls.Add(this.Lab1btnLoad);
            this.Controls.Add(this.Lab1buttonRun);
            this.Controls.Add(this.Lab1dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Lab1dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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