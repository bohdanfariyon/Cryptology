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
            this.шифрВерманаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.евклідБінарнийВибірToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проСистемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.Lab7 = new System.Windows.Forms.ToolStripMenuItem();
            this.Lab8 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.шифрВерманаToolStripMenuItem,
            this.евклідБінарнийВибірToolStripMenuItem,
            this.Lab7,
            this.Lab8,
            this.проСистемуToolStripMenuItem,
            });

            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1420, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Lab1ToolStripMenuItem
            // 
            this.Lab1ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Lab1ToolStripMenuItem.Name = "Lab1ToolStripMenuItem";
            this.Lab1ToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.Lab1ToolStripMenuItem.Text = "Лаб1";
            this.Lab1ToolStripMenuItem.Click += new System.EventHandler(this.openForm1ToolStripMenuItem_Click);
            // 
            // шифрПростоїЗаміниToolStripMenuItem
            // 
            this.шифрПростоїЗаміниToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.шифрПростоїЗаміниToolStripMenuItem.Name = "шифрПростоїЗаміниToolStripMenuItem";
            this.шифрПростоїЗаміниToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.шифрПростоїЗаміниToolStripMenuItem.Text = "Лаб2";
            this.шифрПростоїЗаміниToolStripMenuItem.Click += new System.EventHandler(this.openForm2ToolStripMenuItem_Click);
            // 
            // частотнийАналізToolStripMenuItem
            // 
            this.частотнийАналізToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.частотнийАналізToolStripMenuItem.Name = "частотнийАналізToolStripMenuItem";
            this.частотнийАналізToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.частотнийАналізToolStripMenuItem.Text = "Лаб3";
            this.частотнийАналізToolStripMenuItem.Click += new System.EventHandler(this.openForm3ToolStripMenuItem_Click);
            // 
            // шифрВіженераToolStripMenuItem
            // 
            this.шифрВіженераToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.шифрВіженераToolStripMenuItem.Name = "шифрВіженераToolStripMenuItem";
            this.шифрВіженераToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.шифрВіженераToolStripMenuItem.Text = "Лаб4";
            this.шифрВіженераToolStripMenuItem.Click += new System.EventHandler(this.openForm4ToolStripMenuItem_Click);
            // 
            // шифрВерманаToolStripMenuItem
            // 
            this.шифрВерманаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.шифрВерманаToolStripMenuItem.Name = "шифрВерманаToolStripMenuItem";
            this.шифрВерманаToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.шифрВерманаToolStripMenuItem.Text = "Лаб5";
            this.шифрВерманаToolStripMenuItem.Click += new System.EventHandler(this.openForm5ToolStripMenuItem_Click);
            // 
            // евклідБінарнийВибірToolStripMenuItem
            // 
            this.евклідБінарнийВибірToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.евклідБінарнийВибірToolStripMenuItem.Name = "евклідБінарнийВибірToolStripMenuItem";
            this.евклідБінарнийВибірToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.евклідБінарнийВибірToolStripMenuItem.Text = "Лаб6";
            this.евклідБінарнийВибірToolStripMenuItem.Click += new System.EventHandler(this.openForm6ToolStripMenuItem_Click);
            // 
            // Lab7
            // 
            this.Lab7.ForeColor = System.Drawing.Color.White;
            this.Lab7.Name = "Lab7";
            this.Lab7.Size = new System.Drawing.Size(224, 24);
            this.Lab7.Text = "Lab7";
            this.Lab7.Click += new System.EventHandler(this.openForm7ToolStripMenuItem_Click);
            // 
            // Lab7
            // 
            this.Lab8.ForeColor = System.Drawing.Color.White;
            this.Lab8.Name = "Lab8";
            this.Lab8.Size = new System.Drawing.Size(224, 24);
            this.Lab8.Text = "Lab8";
            this.Lab8.Click += new System.EventHandler(this.openForm8ToolStripMenuItem_Click);
            // 
            // проСистемуToolStripMenuItem
            // 
            this.проСистемуToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.проСистемуToolStripMenuItem.Name = "проСистемуToolStripMenuItem";
            this.проСистемуToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
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
        private ToolStripMenuItem шифрВерманаToolStripMenuItem;
        private ToolStripMenuItem евклідБінарнийВибірToolStripMenuItem;
        private ToolStripMenuItem Lab7;
        private ToolStripMenuItem Lab8;

    }
}