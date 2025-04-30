using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Library untuk koneksi ke Mysql.

namespace ManajemenStokProduk
{
    public partial class Form2 : Form
    {   
        // String koneksi ke database MySQL (pastikan MySQL aktif dan database/username/password benar)
        private string connectionString = "server=localhost;database=crud1;uid=root;pwd=;";

        public Form2()
        {
            InitializeComponent();  // Inisialisasi komponen form
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt_username.Focus();   // Fokus kursor ke textbox username saat form dibuka
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Ambil input dari pengguna
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            // Validasi: cek apakah username atau password kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Buat koneksi ke database menggunakan connection string
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();    // Buka koneksi ke database

                    // Query untuk cek apakah username dan password cocok di database
                    string query = "SELECT COUNT(*) FROM tbl_user WHERE Username = @username AND Password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Jalankan query dan ambil jumlah hasil yang cocok
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Jika ada user yang cocok
                    if (count > 0)
                    {
                        MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1 mainForm = new Form1();   // Panggil Form1 (halaman utama)
                        mainForm.Show();
                        this.Hide();    // Sembunyikan form login
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error jika gagal koneksi atau query error
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkbox_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            // Jika checkbox dicentang, tampilkan karakter password
            if (checkbox_showpassword.Checked)
            {
                txt_password.UseSystemPasswordChar = false; // Tampilkan password
            }
            else
            {
                txt_password.UseSystemPasswordChar = true; // Sembunyikan password
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Keluar dari aplikasi
        }
    }
}
