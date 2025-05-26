using ManajemenStokProduk.Models;
using System;
using System.Collections.Generic;

namespace ManajemenStokProduk.Controllers
{
    public class FormController4
    {
        private FormModel4 model = new FormModel4();

        // Mengambil semua produk yang belum kadaluarsa
        public List<Product> GetAllNonExpiredProducts()
        {
            return model.GetAllNonExpiredProducts();
        }

        // Mengambil produk berdasarkan grup, hanya yang belum kadaluarsa
        public List<Product> GetProductsByGroupNonExpired(string group)
        {
            return model.GetProductsByGroupNonExpired(group);
        }

        // Mengambil daftar grup
        public List<string> GetGroups()
        {
            return model.GetGroups();
        }
    }
}
