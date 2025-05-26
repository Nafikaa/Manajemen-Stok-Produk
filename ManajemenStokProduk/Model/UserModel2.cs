using MySql.Data.MySqlClient;
using System;

namespace ManajemenStokProduk.Models
{
    public class UserModel2
    {
        private readonly MySqlConnection conn;

        public UserModel2(MySqlConnection connection)
        {
            conn = connection;
        }

        public bool CheckLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM tbl_user WHERE username = @username AND password = @password";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
