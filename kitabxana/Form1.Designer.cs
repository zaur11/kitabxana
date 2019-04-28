namespace kitabxana
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oxucuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muellifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnqebul = new System.Windows.Forms.Button();
            this.cmboxucu = new System.Windows.Forms.ComboBox();
            this.txtkitab_adi = new System.Windows.Forms.TextBox();
            this.txtkateqoriya = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtsehife = new System.Windows.Forms.TextBox();
            this.txtqiymet = new System.Windows.Forms.TextBox();
            this.txtmuellif = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanimlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanimlamaToolStripMenuItem
            // 
            this.tanimlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oxucuToolStripMenuItem,
            this.muellifToolStripMenuItem,
            this.kitabToolStripMenuItem});
            this.tanimlamaToolStripMenuItem.Name = "tanimlamaToolStripMenuItem";
            this.tanimlamaToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.tanimlamaToolStripMenuItem.Text = "Tanimlama";
            // 
            // oxucuToolStripMenuItem
            // 
            this.oxucuToolStripMenuItem.Name = "oxucuToolStripMenuItem";
            this.oxucuToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.oxucuToolStripMenuItem.Text = "Oxucu";
            this.oxucuToolStripMenuItem.Click += new System.EventHandler(this.oxucuToolStripMenuItem_Click);
            // 
            // muellifToolStripMenuItem
            // 
            this.muellifToolStripMenuItem.Name = "muellifToolStripMenuItem";
            this.muellifToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.muellifToolStripMenuItem.Text = "Muellif";
            this.muellifToolStripMenuItem.Click += new System.EventHandler(this.muellifToolStripMenuItem_Click);
            // 
            // kitabToolStripMenuItem
            // 
            this.kitabToolStripMenuItem.Name = "kitabToolStripMenuItem";
            this.kitabToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.kitabToolStripMenuItem.Text = "Kitab";
            this.kitabToolStripMenuItem.Click += new System.EventHandler(this.kitabToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(530, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 186);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CHECK";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "KITAB_AD";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "KATEQORIYA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "QIYMET";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SEHIFE";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "STOK";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "MUELLIF_AD";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // btnqebul
            // 
            this.btnqebul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnqebul.Location = new System.Drawing.Point(1042, 73);
            this.btnqebul.Name = "btnqebul";
            this.btnqebul.Size = new System.Drawing.Size(121, 28);
            this.btnqebul.TabIndex = 2;
            this.btnqebul.Text = "QEBUL";
            this.btnqebul.UseVisualStyleBackColor = true;
            this.btnqebul.Click += new System.EventHandler(this.btnqebul_Click);
            // 
            // cmboxucu
            // 
            this.cmboxucu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxucu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmboxucu.FormattingEnabled = true;
            this.cmboxucu.Location = new System.Drawing.Point(115, 140);
            this.cmboxucu.Name = "cmboxucu";
            this.cmboxucu.Size = new System.Drawing.Size(179, 21);
            this.cmboxucu.TabIndex = 3;
            // 
            // txtkitab_adi
            // 
            this.txtkitab_adi.Location = new System.Drawing.Point(115, 183);
            this.txtkitab_adi.Name = "txtkitab_adi";
            this.txtkitab_adi.Size = new System.Drawing.Size(179, 20);
            this.txtkitab_adi.TabIndex = 5;
            // 
            // txtkateqoriya
            // 
            this.txtkateqoriya.Location = new System.Drawing.Point(115, 223);
            this.txtkateqoriya.Name = "txtkateqoriya";
            this.txtkateqoriya.Size = new System.Drawing.Size(179, 20);
            this.txtkateqoriya.TabIndex = 6;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(115, 340);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(179, 20);
            this.txtstok.TabIndex = 9;
            // 
            // txtsehife
            // 
            this.txtsehife.Location = new System.Drawing.Point(115, 300);
            this.txtsehife.Name = "txtsehife";
            this.txtsehife.Size = new System.Drawing.Size(179, 20);
            this.txtsehife.TabIndex = 8;
            // 
            // txtqiymet
            // 
            this.txtqiymet.Location = new System.Drawing.Point(115, 261);
            this.txtqiymet.Name = "txtqiymet";
            this.txtqiymet.Size = new System.Drawing.Size(179, 20);
            this.txtqiymet.TabIndex = 7;
            // 
            // txtmuellif
            // 
            this.txtmuellif.Location = new System.Drawing.Point(115, 377);
            this.txtmuellif.Name = "txtmuellif";
            this.txtmuellif.Size = new System.Drawing.Size(179, 20);
            this.txtmuellif.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(115, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "İCARƏYƏ GÖTÜR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "OXUCU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "KİTABIN ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "KATEQORIYA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "QIYMET:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(43, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "SEHIFE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(57, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "STOK:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "MUELLIFI:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(634, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(542, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "AXTARIŞ:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(634, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 19);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kitab adina gore";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(786, 126);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 19);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Muellife gore";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(530, 403);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(645, 184);
            this.dataGridView2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 574);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmuellif);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtsehife);
            this.Controls.Add(this.txtqiymet);
            this.Controls.Add(this.txtkateqoriya);
            this.Controls.Add(this.txtkitab_adi);
            this.Controls.Add(this.cmboxucu);
            this.Controls.Add(this.btnqebul);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanimlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oxucuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muellifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitabToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnqebul;
        private System.Windows.Forms.ComboBox cmboxucu;
        private System.Windows.Forms.TextBox txtkitab_adi;
        private System.Windows.Forms.TextBox txtkateqoriya;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtsehife;
        private System.Windows.Forms.TextBox txtqiymet;
        private System.Windows.Forms.TextBox txtmuellif;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

