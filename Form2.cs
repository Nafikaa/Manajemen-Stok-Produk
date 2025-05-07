using System;
using System.Windows.Forms;

namespace ManajemenStokProduk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();  // Inisialisasi komponen Form2 (Login Form)
        }

        // Event saat Form2 pertama kali dimuat
        private void Form2_Load(object sender, EventArgs e)
        {
            txt_username.Focus();   // Fokus langsung ke textbox username
        }

        // Event saat tombol Login diklik
        private void btn_login_Click(object sender, EventArgs e)

        {   // Input username dan password dari TextBox
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            // Validasi: pastikan tidak ada kolom kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseConnection db = new DatabaseConnection();
                if (db.CheckLogin(username, password))
                {
                    MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 mainForm = new Form1();   // Jika login sukses, tampilkan Form1 (form home)
                    mainForm.Show();
                    this.Hide();    // Sembunyikan form login (Form2)
                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {   
                // Tangani jika terjadi kesalahan saat login (misal koneksi DB error)
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event saat checkbox Show Password dicentang/dikosongkan
        private void checkbox_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            // Jika dicentang, password akan ditampilkan; jika tidak, akan disembunyikan
            txt_password.UseSystemPasswordChar = !checkbox_showpassword.Checked;
        }

        // Event saat tombol Exit diklik
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event saat tombol Register diklik (untuk membuka form registrasi)
        private void btn_register2_Click(object sender, EventArgs e)
        {
            Form3 registerForm = new Form3();   // Tampilkan form registrasi (Form3)
            registerForm.ShowDialog();
        }
    }
}
