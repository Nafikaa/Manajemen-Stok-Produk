using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ManajemenStokProduk
{
    public class FormModel1
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        // Kelas ini bertanggung jawab untuk mengelola operasi CRUD pada 'tbl_crud' di database
        public DataTable GetAll()
        {
            DataTable dt = new DataTable(); // Membuat DataTable untuk menyimpan hasil query
            using (var conn = db.GetConnection())   // Membuat koneksi ke database
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT NOPRODUK, NAMAPRODUK, HARGA_PER_BIJI, HARGA_PER_KARDUS, ISI_PER_KARDUS, GRUP, EXPDATE, STATUS FROM tbl_crud", conn))
                using (var adapter = new MySqlDataAdapter(cmd)) // Menggunakan MySqlDataAdapter untuk mengeksekusi query dan mengisi DataTable
                {
                    // Mengisi DataTable dengan hasil query
                    adapter.Fill(dt);
                }
            }
            return dt;  // Mengembalikan DataTable yang berisi semua data produk
        }

        // Metode untuk mencari produk berdasarkan keyword 'NoProduk' atau 'NamaProduk'
        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT NOPRODUK, NAMAPRODUK, HARGA_PER_BIJI, HARGA_PER_KARDUS, ISI_PER_KARDUS, GRUP, EXPDATE, STATUS FROM tbl_crud WHERE NOPRODUK LIKE @search OR NAMAPRODUK LIKE @search", conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + keyword + "%");
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;  // Mengembalikan DataTable yang berisi hasil pencarian produk
        }
        // Metode untuk mendapatkan produk berdasarkan 'NoProduk'
        public void Insert(string noProduk, string namaProduk, decimal hargaPerBiji, decimal hargaPerKardus, int isiKardus, string grup, DateTime expDate, bool status)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(
                "INSERT INTO tbl_crud (NOPRODUK, NAMAPRODUK, HARGA_PER_BIJI, HARGA_PER_KARDUS, ISI_PER_KARDUS, GRUP, EXPDATE, STATUS) " +
                "VALUES (@NOPRODUK, @NAMAPRODUK, @HARGA_PER_BIJI, @HARGA_PER_KARDUS, @ISI_PER_KARDUS, @GRUP, @EXPDATE, @STATUS)", conn))
                {
                    cmd.Parameters.AddWithValue("@NOPRODUK", noProduk);
                    cmd.Parameters.AddWithValue("@NAMAPRODUK", namaProduk);
                    cmd.Parameters.AddWithValue("@HARGA_PER_BIJI", hargaPerBiji);
                    cmd.Parameters.AddWithValue("@HARGA_PER_KARDUS", hargaPerKardus);
                    cmd.Parameters.AddWithValue("@ISI_PER_KARDUS", isiKardus);
                    cmd.Parameters.AddWithValue("@GRUP", grup);
                    cmd.Parameters.AddWithValue("@EXPDATE", expDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@STATUS", status ? "Aktif" : "Tidak Aktif");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Metode untuk memperbarui produk berdasarkan 'NoProduk'
        public void Update(string noProduk, string namaProduk, decimal hargaPerBiji, decimal hargaPerKardus, int isiPerKardus, string grup, DateTime expDate, bool status)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(
                    "UPDATE tbl_crud SET NAMAPRODUK = @NAMAPRODUK, HARGA_PER_BIJI = @HARGA_PER_BIJI, HARGA_PER_KARDUS = @HARGA_PER_KARDUS, ISI_PER_KARDUS = @ISI_PER_KARDUS, GRUP = @GRUP, EXPDATE = @EXPDATE, STATUS = @STATUS WHERE NOPRODUK = @NOPRODUK", conn))
                {
                    cmd.Parameters.AddWithValue("@NAMAPRODUK", namaProduk);
                    cmd.Parameters.AddWithValue("@HARGA_PER_BIJI", hargaPerBiji);
                    cmd.Parameters.AddWithValue("@HARGA_PER_KARDUS", hargaPerKardus);
                    cmd.Parameters.AddWithValue("@ISI_PER_KARDUS", isiPerKardus);
                    cmd.Parameters.AddWithValue("@GRUP", grup);
                    cmd.Parameters.AddWithValue("@EXPDATE", expDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@STATUS", status ? "Aktif" : "Tidak Aktif");
                    cmd.Parameters.AddWithValue("@NOPRODUK", noProduk);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Metode untuk menghapus produk berdasarkan 'NoProduk'
        public int Delete(string noProduk)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("DELETE FROM tbl_crud WHERE NOPRODUK = @NOPRODUK", conn))
                {
                    cmd.Parameters.AddWithValue("@NOPRODUK", noProduk);
                    return cmd.ExecuteNonQuery();   // Mengembalikan jumlah baris yang terpengaruh oleh operasi delete
                }
            }
        }
    }
}
