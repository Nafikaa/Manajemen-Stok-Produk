using MySql.Data.MySqlClient;
using System;

namespace ManajemenStokProduk.Models
{
    public class UserModel3
    {
        private MySqlConnection conn;

        public UserModel3(MySqlConnection connection)
        {
            this.conn = connection;
        }

        public bool RegisterUser(string username, string password)
        {
            string query = "INSERT INTO tbl_user (username, password) VALUES (@username, @password)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) 
                        return false;
                    throw;
                }
            }
        }

        public bool DeleteUser(string username)
        {
            string query = "DELETE FROM tbl_user WHERE username = @username";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
