using System.Windows.Forms;

namespace Program2
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Lab1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифрПростоїЗаміниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.частотнийАналізToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифрВіженераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проСистемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lab1ToolStripMenuItem,
            this.шифрПростоїЗаміниToolStripMenuItem,
            this.частотнийАналізToolStripMenuItem,
            this.шифрВіженераToolStripMenuItem,
            this.проСистемуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1065, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Lab1ToolStripMenuItem
            // 
            this.Lab1ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Lab1ToolStripMenuItem.Name = "Lab1ToolStripMenuItem";
            this.Lab1ToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.Lab1ToolStripMenuItem.Text = "Частотні таблиці";
            this.Lab1ToolStripMenuItem.Click += new System.EventHandler(this.openForm1ToolStripMenuItem_Click);
            // 
            // шифрПростоїЗаміниToolStripMenuItem
            // 
            this.шифрПростоїЗаміниToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.шифрПростоїЗаміниToolStripMenuItem.Name = "шифрПростоїЗаміниToolStripMenuItem";
            this.шифрПростоїЗаміниToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.шифрПростоїЗаміниToolStripMenuItem.Text = "Шифр простої заміни";
            this.шифрПростоїЗаміниToolStripMenuItem.Click += new System.EventHandler(this.openForm2ToolStripMenuItem_Click);
            // 
            // частотнийАналізToolStripMenuItem
            // 
            this.частотнийАналізToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.частотнийАналізToolStripMenuItem.Name = "частотнийАналізToolStripMenuItem";
            this.частотнийАналізToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.частотнийАналізToolStripMenuItem.Text = "Частотний аналіз";
            this.частотнийАналізToolStripMenuItem.Click += new System.EventHandler(this.openForm3ToolStripMenuItem_Click);
            // 
            // шифрВіженераToolStripMenuItem
            // 
            this.шифрВіженераToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.шифрВіженераToolStripMenuItem.Name = "шифрВіженераToolStripMenuItem";
            this.шифрВіженераToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.шифрВіженераToolStripMenuItem.Text = "Шифр Віженера";
            this.шифрВіженераToolStripMenuItem.Click += new System.EventHandler(this.openForm4ToolStripMenuItem_Click);
            // 
            // проСистемуToolStripMenuItem
            // 
            this.проСистемуToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.проСистемуToolStripMenuItem.Name = "проСистемуToolStripMenuItem";
            this.проСистемуToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.проСистемуToolStripMenuItem.Text = "Про систему";
            this.проСистемуToolStripMenuItem.Click += new System.EventHandler(this.openForm1ToolStripMenuItem_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 30);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1065, 420);
            this.panelContainer.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
       
        private Panel panelContainer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Lab1ToolStripMenuItem;
        private ToolStripMenuItem проСистемуToolStripMenuItem;
        private ToolStripMenuItem шифрПростоїЗаміниToolStripMenuItem;
        private ToolStripMenuItem частотнийАналізToolStripMenuItem;
        private ToolStripMenuItem шифрВіженераToolStripMenuItem;
    }
}