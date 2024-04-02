namespace Program2
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 210);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(555, 48);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(226, 210);
            this.textBox2.TabIndex = 1;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.BackColor = System.Drawing.Color.Black;
            this.btn_encrypt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_encrypt.ForeColor = System.Drawing.Color.White;
            this.btn_encrypt.Location = new System.Drawing.Point(372, 82);
            this.btn_encrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(171, 67);
            this.btn_encrypt.TabIndex = 2;
            this.btn_encrypt.Text = "Зашифрувати";
            this.btn_encrypt.UseVisualStyleBackColor = false;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.BackColor = System.Drawing.Color.Black;
            this.btn_decrypt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_decrypt.ForeColor = System.Drawing.Color.White;
            this.btn_decrypt.Location = new System.Drawing.Point(343, 213);
            this.btn_decrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(171, 67);
            this.btn_decrypt.TabIndex = 3;
            this.btn_decrypt.Text = "Розшифрувати";
            this.btn_decrypt.UseVisualStyleBackColor = false;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxKey.Location = new System.Drawing.Point(316, 275);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxKey.Size = new System.Drawing.Size(194, 91);
            this.textBoxKey.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Black;
            this.btn_save.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(242, 388);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(171, 67);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Зберегти";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Black;
            this.btn_load.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(435, 387);
            this.btn_load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(171, 67);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Завантажити";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Black;
            this.btn_create.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(316, 416);
            this.btn_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(171, 67);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "Створити";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Resize += new System.EventHandler(this.Form4_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_create;
    }
}