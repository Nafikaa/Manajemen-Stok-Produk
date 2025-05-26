using System;
using System.Windows.Forms;
using ManajemenStokProduk.Controllers;
using MySql.Data.MySqlClient;

namespace ManajemenStokProduk
{
    public partial class Form3 : Form
    {
        private UserController3 userController;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txt_username1.Focus();
            DatabaseConnection db = new DatabaseConnection();
            MySqlConnection conn = db.GetConnection();
            conn.Open();
            userController = new UserController3(conn);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_username1.Text.Trim();
            string password = txt_password1.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (userController.Register(username, password))
                {
                    MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username sudah digunakan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal registrasi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete1_Click(object sender, EventArgs e)
        {
            string username = txt_username1.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Masukkan username yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menghapus user ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (userController.Delete(username))
                    {
                        MessageBox.Show("User berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_username1.Clear();
                        txt_password1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("User tidak ditemukan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_showpassword1_CheckedChanged(object sender, EventArgs e)
        {
            txt_password1.UseSystemPasswordChar = !checkBox_showpassword1.Checked;
        }
    }
}
