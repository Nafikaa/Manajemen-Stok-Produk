namespace ManajemenStokProduk
{
    partial class Form3
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
            this.txt_username1 = new System.Windows.Forms.TextBox();
            this.txt_password1 = new System.Windows.Forms.TextBox();
            this.lbl_registrasi = new System.Windows.Forms.Label();
            this.lbl_username1 = new System.Windows.Forms.Label();
            this.lbl_password1 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.checkBox_showpassword1 = new System.Windows.Forms.CheckBox();
            this.lbl_Naf = new System.Windows.Forms.Label();
            this.btn_delete1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username1
            // 
            this.txt_username1.Location = new System.Drawing.Point(181, 153);
            this.txt_username1.Name = "txt_username1";
            this.txt_username1.Size = new System.Drawing.Size(235, 26);
            this.txt_username1.TabIndex = 0;
            // 
            // txt_password1
            // 
            this.txt_password1.Location = new System.Drawing.Point(181, 209);
            this.txt_password1.Name = "txt_password1";
            this.txt_password1.Size = new System.Drawing.Size(235, 26);
            this.txt_password1.TabIndex = 1;
            this.txt_password1.UseSystemPasswordChar = true;
            // 
            // lbl_registrasi
            // 
            this.lbl_registrasi.AutoSize = true;
            this.lbl_registrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registrasi.Location = new System.Drawing.Point(107, 48);
            this.lbl_registrasi.Name = "lbl_registrasi";
            this.lbl_registrasi.Size = new System.Drawing.Size(276, 36);
            this.lbl_registrasi.TabIndex = 2;
            this.lbl_registrasi.Text = "FORM REGISTER";
            // 
            // lbl_username1
            // 
            this.lbl_username1.AutoSize = true;
            this.lbl_username1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username1.Location = new System.Drawing.Point(73, 153);
            this.lbl_username1.Name = "lbl_username1";
            this.lbl_username1.Size = new System.Drawing.Size(91, 20);
            this.lbl_username1.TabIndex = 3;
            this.lbl_username1.Text = "Username";
            // 
            // lbl_password1
            // 
            this.lbl_password1.AutoSize = true;
            this.lbl_password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password1.Location = new System.Drawing.Point(78, 209);
            this.lbl_password1.Name = "lbl_password1";
            this.lbl_password1.Size = new System.Drawing.Size(86, 20);
            this.lbl_password1.TabIndex = 4;
            this.lbl_password1.Text = "Password";
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(308, 294);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(108, 43);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(80, 294);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 43);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // checkBox_showpassword1
            // 
            this.checkBox_showpassword1.AutoSize = true;
            this.checkBox_showpassword1.Location = new System.Drawing.Point(181, 250);
            this.checkBox_showpassword1.Name = "checkBox_showpassword1";
            this.checkBox_showpassword1.Size = new System.Drawing.Size(148, 24);
            this.checkBox_showpassword1.TabIndex = 7;
            this.checkBox_showpassword1.Text = "Show Password";
            this.checkBox_showpassword1.UseVisualStyleBackColor = true;
            this.checkBox_showpassword1.CheckedChanged += new System.EventHandler(this.checkBox_showpassword1_CheckedChanged);
            // 
            // lbl_Naf
            // 
            this.lbl_Naf.AutoSize = true;
            this.lbl_Naf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Naf.Location = new System.Drawing.Point(12, 377);
            this.lbl_Naf.Name = "lbl_Naf";
            this.lbl_Naf.Size = new System.Drawing.Size(108, 20);
            this.lbl_Naf.TabIndex = 24;
            this.lbl_Naf.Text = "By Nafika S.M";
            this.lbl_Naf.UseMnemonic = false;
            // 
            // btn_delete1
            // 
            this.btn_delete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete1.ForeColor = System.Drawing.Color.White;
            this.btn_delete1.Location = new System.Drawing.Point(194, 294);
            this.btn_delete1.Name = "btn_delete1";
            this.btn_delete1.Size = new System.Drawing.Size(108, 43);
            this.btn_delete1.TabIndex = 25;
            this.btn_delete1.Text = "Delete";
            this.btn_delete1.UseVisualStyleBackColor = false;
            this.btn_delete1.Click += new System.EventHandler(this.btn_delete1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 406);
            this.Controls.Add(this.btn_delete1);
            this.Controls.Add(this.lbl_Naf);
            this.Controls.Add(this.checkBox_showpassword1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lbl_password1);
            this.Controls.Add(this.lbl_username1);
            this.Controls.Add(this.lbl_registrasi);
            this.Controls.Add(this.txt_password1);
            this.Controls.Add(this.txt_username1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username1;
        private System.Windows.Forms.TextBox txt_password1;
        private System.Windows.Forms.Label lbl_registrasi;
        private System.Windows.Forms.Label lbl_username1;
        private System.Windows.Forms.Label lbl_password1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.CheckBox checkBox_showpassword1;
        private System.Windows.Forms.Label lbl_Naf;
        private System.Windows.Forms.Button btn_delete1;
    }
}