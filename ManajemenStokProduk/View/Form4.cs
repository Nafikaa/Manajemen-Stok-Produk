using ManajemenStokProduk.Controllers;
using ManajemenStokProduk.Models;
using System;
using System.Windows.Forms;

namespace ManajemenStokProduk.Views
{
    public partial class Form4 : Form
    {
        private FormController4 controller = new FormController4();

        public Form4()
        {
            InitializeComponent();
            combo_grupproduk1.SelectedIndexChanged += combo_grupproduk1_SelectedIndexChanged;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                SetupDataGridView();
                LoadComboGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void SetupDataGridView()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("NOPRODUK", "No Produk");
            dataGridView2.Columns.Add("NAMAPRODUK", "Nama Produk");
            dataGridView2.Columns.Add("HARGA_PER_BIJI", "Harga Per Biji");
            dataGridView2.Columns.Add("HARGA_PER_KARDUS", "Harga Per Kardus");
            dataGridView2.Columns.Add("ISI_PER_KARDUS", "Isi Per Kardus");
            dataGridView2.Columns.Add("GRUP", "Grup Produk");
            dataGridView2.Columns.Add("EXPDATE", "Expired Date");

            DataGridViewCheckBoxColumn chkStatus = new DataGridViewCheckBoxColumn
            {
                Name = "STATUS",
                HeaderText = "Status",
                TrueValue = true,
                FalseValue = false
            };
            dataGridView2.Columns.Add(chkStatus);
        }

        // Memuat grup produk ke dalam ComboBox
        private void LoadComboGroups()
        {
            combo_grupproduk1.Items.Clear();
            combo_grupproduk1.Items.Add("-- Silahkan pilih grup --"); // Tambahkan placeholder (teks petunjuk sementara dalam input yang memberi tahu pengguna apa yang harus diisi atau dipilih)

            var groups = controller.GetGroups();
            foreach (var group in groups)
            {
                combo_grupproduk1.Items.Add(group);
            }

            combo_grupproduk1.SelectedIndex = 0; // Set default ke placeholder
        }

        // Event handler untuk ComboBox grup produk
        private void combo_grupproduk1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_grupproduk1.SelectedIndex <= 0) // Jangan tampilkan apa pun jika placeholder terpilih
            {
                dataGridView2.Rows.Clear();
                txt_jumlahproduk.Text = "0";
                return;
            }

            string selectedGroup = combo_grupproduk1.SelectedItem.ToString();

            try
            {
                dataGridView2.Rows.Clear();
                var products = controller.GetProductsByGroupNonExpired(selectedGroup); 
                foreach (var p in products)
                {
                    dataGridView2.Rows.Add(
                        p.NoProduk,
                        p.NamaProduk,
                        p.HargaPerBiji,
                        p.HargaPerKardus,
                        p.IsiPerKardus,
                        p.Grup,
                        p.ExpDate.ToString("yyyy-MM-dd"),
                        p.Status
                    );
                }
                
                UpdateJumlahProduk();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memfilter grup: " + ex.Message);
            }
        }

        // Event handler untuk tombol kembali
        private void btn_back1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }

        private void UpdateJumlahProduk()
        {
            int jumlah = dataGridView2.AllowUserToAddRows ? dataGridView2.Rows.Count - 1 : dataGridView2.Rows.Count;
            txt_jumlahproduk.Text = jumlah.ToString();
        }
    }
}
