using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ManajemenStokProduk.Models
{
    // Kelas Product untuk merepresentasikan produk
    public class Product
    {
        public string NoProduk { get; set; }
        public string NamaProduk { get; set; }
        public decimal HargaPerBiji { get; set; }
        public decimal HargaPerKardus { get; set; }
        public int IsiPerKardus { get; set; }
        public string Grup { get; set; }
        public DateTime ExpDate { get; set; }
        public bool Status { get; set; }
    }

    public class FormModel4
    {
        private DatabaseConnection db = new DatabaseConnection();

        // Produk yang sudah expired
        public List<Product> GetExpiredProducts()
        {
            var list = new List<Product>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_crud WHERE EXPDATE < CURDATE()";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(ReadProduct(reader));
                    }
                }
            }
            return list;
        }

        // Produk yang belum kadaluarsa (ExpDate >= hari ini)
        public List<Product> GetAllNonExpiredProducts()
        {
            var list = new List<Product>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_crud WHERE EXPDATE >= CURDATE()";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(ReadProduct(reader));
                    }
                }
            }
            return list;
        }

        // Produk berdasarkan grup, hanya yang belum kadaluarsa
        public List<Product> GetProductsByGroupNonExpired(string group)
        {
            var list = new List<Product>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_crud WHERE GRUP = @group AND EXPDATE >= CURDATE()";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@group", group);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(ReadProduct(reader));
                        }
                    }
                }
            }
            return list;
        }

        public List<string> GetGroups()
        {
            var groups = new List<string>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT DISTINCT GRUP FROM tbl_crud";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        groups.Add(reader["GRUP"].ToString());
                    }
                }
            }
            return groups;
        }

        private Product ReadProduct(MySqlDataReader reader)
        {
            return new Product
            {
                NoProduk = reader["NOPRODUK"].ToString(),
                NamaProduk = reader["NAMAPRODUK"].ToString(),
                HargaPerBiji = Convert.ToDecimal(reader["HARGA_PER_BIJI"]),
                HargaPerKardus = Convert.ToDecimal(reader["HARGA_PER_KARDUS"]),
                IsiPerKardus = Convert.ToInt32(reader["ISI_PER_KARDUS"]),
                Grup = reader["GRUP"].ToString(),
                ExpDate = Convert.ToDateTime(reader["EXPDATE"]),
                // Jika STATUS bertipe string, misal "aktif" berarti true, selain itu false
                Status = reader["STATUS"].ToString().ToLower() == "aktif"
            };
        }
    }
}
