namespace Program2
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_create = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(260, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(302, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Black;
            this.btn_create.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(57, 328);
            this.btn_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(171, 67);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Створити\r\n";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxInput.Location = new System.Drawing.Point(34, 36);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(226, 210);
            this.textBoxInput.TabIndex = 2;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxOutput.Location = new System.Drawing.Point(538, 36);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(226, 210);
            this.textBoxOutput.TabIndex = 3;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Black;
            this.btnRun.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(356, 61);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(171, 67);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Зашифрувати";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnDec
            // 
            this.btnDec.BackColor = System.Drawing.Color.Black;
            this.btnDec.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDec.ForeColor = System.Drawing.Color.White;
            this.btnDec.Location = new System.Drawing.Point(356, 162);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(171, 67);
            this.btnDec.TabIndex = 5;
            this.btnDec.Text = "Розшифрувати";
            this.btnDec.UseVisualStyleBackColor = false;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.Black;
            this.btn_change.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_change.ForeColor = System.Drawing.Color.White;
            this.btn_change.Location = new System.Drawing.Point(593, 328);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(171, 67);
            this.btn_change.TabIndex = 6;
            this.btn_change.Text = "Зберегти зміни";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Black;
            this.btn_load.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(538, 253);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(171, 67);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Завантажити";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Black;
            this.btn_save.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(538, 162);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(171, 67);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Зберегти";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Resize += new System.EventHandler(this.Form2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_create;
        private string dataFromColumn1="";
        private string dataFromColumn2="";
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
    }
}