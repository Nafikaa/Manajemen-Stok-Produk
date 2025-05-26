using MySql.Data.MySqlClient;
using ManajemenStokProduk.Models;

namespace ManajemenStokProduk.Controllers
{
    public class UserController3
    {
        private UserModel3 userModel;

        public UserController3(MySqlConnection connection)
        {
            userModel = new UserModel3(connection);
        }

        public bool Register(string username, string password)
        {
            return userModel.RegisterUser(username, password);
        }

        public bool Delete(string username)
        {
            return userModel.DeleteUser(username);
        }
    }
}
