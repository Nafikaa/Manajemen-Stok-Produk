namespace ManajemenStokProduk
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
            this.txt_noproduk = new System.Windows.Forms.TextBox();
            this.txt_namaproduk = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.combo_grupproduk = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_expdate = new System.Windows.Forms.DateTimePicker();
            this.checkbox_status = new System.Windows.Forms.CheckBox();
            this.lbl_noproduk = new System.Windows.Forms.Label();
            this.lbl_namaproduk = new System.Windows.Forms.Label();
            this.lbl_harga = new System.Windows.Forms.Label();
            this.lbl_grupproduk = new System.Windows.Forms.Label();
            this.lbl_expireddate = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_checkproduk = new System.Windows.Forms.Button();
            this.lbl_Naf = new System.Windows.Forms.Label();
            this.lbl_isikardus = new System.Windows.Forms.Label();
            this.txt_isikardus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_noproduk
            // 
            this.txt_noproduk.Location = new System.Drawing.Point(63, 190);
            this.txt_noproduk.Name = "txt_noproduk";
            this.txt_noproduk.Size = new System.Drawing.Size(299, 26);
            this.txt_noproduk.TabIndex = 2;
            // 
            // txt_namaproduk
            // 
            this.txt_namaproduk.Location = new System.Drawing.Point(63, 252);
            this.txt_namaproduk.Name = "txt_namaproduk";
            this.txt_namaproduk.Size = new System.Drawing.Size(299, 26);
            this.txt_namaproduk.TabIndex = 3;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(63, 314);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(142, 26);
            this.txt_harga.TabIndex = 4;
            // 
            // combo_grupproduk
            // 
            this.combo_grupproduk.FormattingEnabled = true;
            this.combo_grupproduk.Items.AddRange(new object[] {
            "SWEET",
            "CANDY",
            "DRINK",
            "FOOD",
            "SNACK",
            "COOKIES",
            "BREAD"});
            this.combo_grupproduk.Location = new System.Drawing.Point(63, 376);
            this.combo_grupproduk.Name = "combo_grupproduk";
            this.combo_grupproduk.Size = new System.Drawing.Size(299, 28);
            this.combo_grupproduk.TabIndex = 5;
            // 
            // dateTimePicker_expdate
            // 
            this.dateTimePicker_expdate.Location = new System.Drawing.Point(63, 441);
            this.dateTimePicker_expdate.Name = "dateTimePicker_expdate";
            this.dateTimePicker_expdate.Size = new System.Drawing.Size(299, 26);
            this.dateTimePicker_expdate.TabIndex = 6;
            // 
            // checkbox_status
            // 
            this.checkbox_status.AutoSize = true;
            this.checkbox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_status.Location = new System.Drawing.Point(66, 492);
            this.checkbox_status.Name = "checkbox_status";
            this.checkbox_status.Size = new System.Drawing.Size(98, 24);
            this.checkbox_status.TabIndex = 7;
            this.checkbox_status.Text = "Available";
            this.checkbox_status.UseVisualStyleBackColor = true;
            // 
            // lbl_noproduk
            // 
            this.lbl_noproduk.AutoSize = true;
            this.lbl_noproduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noproduk.Location = new System.Drawing.Point(59, 167);
            this.lbl_noproduk.Name = "lbl_noproduk";
            this.lbl_noproduk.Size = new System.Drawing.Size(83, 20);
            this.lbl_noproduk.TabIndex = 8;
            this.lbl_noproduk.Text = "No.Produk";
            // 
            // lbl_namaproduk
            // 
            this.lbl_namaproduk.AutoSize = true;
            this.lbl_namaproduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namaproduk.Location = new System.Drawing.Point(59, 229);
            this.lbl_namaproduk.Name = "lbl_namaproduk";
            this.lbl_namaproduk.Size = new System.Drawing.Size(105, 20);
            this.lbl_namaproduk.TabIndex = 9;
            this.lbl_namaproduk.Text = "Nama Produk";
            // 
            // lbl_harga
            // 
            this.lbl_harga.AutoSize = true;
            this.lbl_harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_harga.Location = new System.Drawing.Point(59, 291);
            this.lbl_harga.Name = "lbl_harga";
            this.lbl_harga.Size = new System.Drawing.Size(104, 20);
            this.lbl_harga.TabIndex = 10;
            this.lbl_harga.Text = "Harga per Biji";
            // 
            // lbl_grupproduk
            // 
            this.lbl_grupproduk.AutoSize = true;
            this.lbl_grupproduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupproduk.Location = new System.Drawing.Point(59, 353);
            this.lbl_grupproduk.Name = "lbl_grupproduk";
            this.lbl_grupproduk.Size = new System.Drawing.Size(99, 20);
            this.lbl_grupproduk.TabIndex = 11;
            this.lbl_grupproduk.Text = "Grup Produk";
            // 
            // lbl_expireddate
            // 
            this.lbl_expireddate.AutoSize = true;
            this.lbl_expireddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expireddate.Location = new System.Drawing.Point(59, 418);
            this.lbl_expireddate.Name = "lbl_expireddate";
            this.lbl_expireddate.Size = new System.Drawing.Size(101, 20);
            this.lbl_expireddate.TabIndex = 12;
            this.lbl_expireddate.Text = "Expired Date";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(63, 522);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(142, 47);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(226, 522);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(136, 47);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "Update";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(63, 575);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(142, 43);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Gray;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(226, 575);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(136, 43);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(382, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(856, 372);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "No.Produk";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 119;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Nama Produk";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Harga Per Biji";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 112;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Harga Per Kardus";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 157;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Isi Per Kardus";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 132;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Grup Produk";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Expired Date";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 126;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Status";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 92;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(378, 167);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(60, 20);
            this.lbl_search.TabIndex = 19;
            this.lbl_search.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(382, 190);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(402, 26);
            this.txt_search.TabIndex = 18;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(385, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(477, 41);
            this.label7.TabIndex = 20;
            this.label7.Text = "Manajemen Stok Produk";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(1137, 58);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(101, 42);
            this.btn_logout.TabIndex = 21;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_checkproduk
            // 
            this.btn_checkproduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_checkproduk.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_checkproduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkproduk.ForeColor = System.Drawing.Color.White;
            this.btn_checkproduk.Location = new System.Drawing.Point(1071, 180);
            this.btn_checkproduk.Name = "btn_checkproduk";
            this.btn_checkproduk.Size = new System.Drawing.Size(167, 47);
            this.btn_checkproduk.TabIndex = 22;
            this.btn_checkproduk.Text = "Check Product";
            this.btn_checkproduk.UseVisualStyleBackColor = false;
            this.btn_checkproduk.Click += new System.EventHandler(this.btn_checkproduk_Click);
            // 
            // lbl_Naf
            // 
            this.lbl_Naf.AutoSize = true;
            this.lbl_Naf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Naf.Location = new System.Drawing.Point(12, 652);
            this.lbl_Naf.Name = "lbl_Naf";
            this.lbl_Naf.Size = new System.Drawing.Size(108, 20);
            this.lbl_Naf.TabIndex = 23;
            this.lbl_Naf.Text = "By Nafika S.M";
            this.lbl_Naf.UseMnemonic = false;
            // 
            // lbl_isikardus
            // 
            this.lbl_isikardus.AutoSize = true;
            this.lbl_isikardus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isikardus.Location = new System.Drawing.Point(216, 291);
            this.lbl_isikardus.Name = "lbl_isikardus";
            this.lbl_isikardus.Size = new System.Drawing.Size(106, 20);
            this.lbl_isikardus.TabIndex = 25;
            this.lbl_isikardus.Text = "Isi per Kardus";
            // 
            // txt_isikardus
            // 
            this.txt_isikardus.Location = new System.Drawing.Point(220, 314);
            this.txt_isikardus.Name = "txt_isikardus";
            this.txt_isikardus.Size = new System.Drawing.Size(142, 26);
            this.txt_isikardus.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1314, 681);
            this.Controls.Add(this.lbl_isikardus);
            this.Controls.Add(this.txt_isikardus);
            this.Controls.Add(this.lbl_Naf);
            this.Controls.Add(this.btn_checkproduk);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_expireddate);
            this.Controls.Add(this.lbl_grupproduk);
            this.Controls.Add(this.lbl_harga);
            this.Controls.Add(this.lbl_namaproduk);
            this.Controls.Add(this.lbl_noproduk);
            this.Controls.Add(this.checkbox_status);
            this.Controls.Add(this.dateTimePicker_expdate);
            this.Controls.Add(this.combo_grupproduk);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.txt_namaproduk);
            this.Controls.Add(this.txt_noproduk);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_noproduk;
        private System.Windows.Forms.TextBox txt_namaproduk;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.ComboBox combo_grupproduk;
        private System.Windows.Forms.DateTimePicker dateTimePicker_expdate;
        private System.Windows.Forms.CheckBox checkbox_status;
        private System.Windows.Forms.Label lbl_noproduk;
        private System.Windows.Forms.Label lbl_namaproduk;
        private System.Windows.Forms.Label lbl_harga;
        private System.Windows.Forms.Label lbl_grupproduk;
        private System.Windows.Forms.Label lbl_expireddate;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_checkproduk;
        private System.Windows.Forms.Label lbl_Naf;
        private System.Windows.Forms.Label lbl_isikardus;
        private System.Windows.Forms.TextBox txt_isikardus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
    }
}

