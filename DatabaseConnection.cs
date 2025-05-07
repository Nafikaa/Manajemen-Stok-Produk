using MySql.Data.MySqlClient;
using System;

namespace ManajemenStokProduk
{
    // Kelas DatabaseConnection untuk mengelola koneksi ke database MySQL
    public class DatabaseConnection
    {
        private string connectionString = "server=localhost;database=crud;uid=root;pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Metode untuk memeriksa apakah username dan password valid
        public bool CheckLogin(string username, string password)
        {
            try
            {
                // Membuat koneksi ke database
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM tbl_user WHERE Username = @username AND Password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Mengeksekusi query dan mendapatkan jumlah baris yang cocok
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memeriksa login: " + ex.Message);
            }
        }

        // Metode untuk mendaftarkan user baru
        public bool RegisterUser(string username, string password)
        {
            try
            {
                // Membuat koneksi ke database
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Periksa apakah username sudah digunakan
                    string checkQuery = "SELECT COUNT(*) FROM tbl_user WHERE Username = @username";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (exists > 0)
                    {
                        return false; // Username sudah ada
                    }

                    // Simpan user baru
                    string insertQuery = "INSERT INTO tbl_user (Username, Password) VALUES (@username, @password)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch
            {
                throw;
            }
        }

        // Metode untuk mendapatkan semua user
        public bool DeleteUser(string username)
        {
            try
            {
                // Membuat koneksi ke database
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM tbl_user WHERE Username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    int affectedRows = cmd.ExecuteNonQuery();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus user: " + ex.Message);
            }
        }
    }
}
