using MySql.Data.MySqlClient;
using ManajemenStokProduk.Models;

namespace ManajemenStokProduk.Controllers
{
    public class UserController2
    {
        private readonly UserModel2 userModel;

        public UserController2(MySqlConnection conn)
        {
            userModel = new UserModel2(conn);
        }

        public bool Login(string username, string password)
        {
            return userModel.CheckLogin(username, password);
        }
    }
}
