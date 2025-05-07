using System;
using System.Windows.Forms;

namespace ManajemenStokProduk
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Event saat Form3 pertama kali dimuat
        private void Form3_Load(object sender, EventArgs e)
        {
            txt_username1.Focus();
        }

        // Event klik tombol Register
        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_username1.Text.Trim();
            string password = txt_password1.Text.Trim();

            // Validasi input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DatabaseConnection db = new DatabaseConnection();
                if (db.RegisterUser(username, password))    // Coba registrasi user
                {
                    MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Tutup form registrasi
                }
                else
                {
                    MessageBox.Show("Username sudah digunakan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal registrasi: " + ex.Message);
            }
        }

        // Event klik tombol kembali ke form login (Form2)
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close(); // Menutup Form3 dan kembali ke Form2
        }

        // Event checkbox untuk menampilkan/menyembunyikan password
        private void checkBox_showpassword1_CheckedChanged(object sender, EventArgs e)
        {
            // Jika checkbox dicentang, password akan ditampilkan; jika tidak, akan disembunyikan
            txt_password1.UseSystemPasswordChar = !checkBox_showpassword1.Checked;
        }

        // Event klik tombol hapus user
        private void btn_delete1_Click(object sender, EventArgs e)
        {
            string username = txt_username1.Text.Trim();
            // Validasi input
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Masukkan username yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi penghapusan
            DialogResult result = MessageBox.Show("Yakin ingin menghapus user ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DatabaseConnection db = new DatabaseConnection();
                    if (db.DeleteUser(username))    // Proses penghapusan user
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
                    MessageBox.Show("Gagal menghapus user: " + ex.Message);
                }
            }
        }
    }
}
