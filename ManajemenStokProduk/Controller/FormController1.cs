using System;
using System.Data;

namespace ManajemenStokProduk
{
    public class FormController1
    {
        private FormModel1 produkModel;

        public FormController1()
        {
            produkModel = new FormModel1();
        }

        // Ambil semua produk
        public DataTable GetAllProduk()
        {
            return produkModel.GetAll();
        }

        // Cari produk berdasarkan keyword
        public DataTable Search(string keyword)
        {
            return produkModel.Search(keyword);
        }

        // Simpan produk baru
        public void SimpanProduk(string noProduk, string namaProduk, decimal hargaPerBiji, decimal hargaPerKardus, int isiKardus, string grup, DateTime expDate, bool status)
        {
            produkModel.Insert(noProduk, namaProduk, hargaPerBiji, hargaPerKardus, isiKardus, grup, expDate, status);
        }

        // Update data produk
        public void Update(string noProduk, string namaProduk, decimal hargaPerBiji, decimal hargaPerKardus, int isiPerKardus, string grup, DateTime expDate, bool status)
        {
            produkModel.Update(noProduk, namaProduk, hargaPerBiji, hargaPerKardus, isiPerKardus, grup, expDate, status);
        }

        // Hapus produk berdasarkan NoProduk
        public int Delete(string noProduk)
        {
            return produkModel.Delete(noProduk);
        }
    }
}
