using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using ManajemenStokProduk.Views;

namespace ManajemenStokProduk
{
    public partial class Form1 : Form
    {
        private FormController1 produkController = new FormController1();

        public Form1()
        {
            InitializeComponent();
        }

        // Event saat Form1 pertama kali dimuat
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal koneksi: " + ex.Message);
            }

            LoadRecord();
        }

        // Memuat semua data produk ke dalam DataGridView
        public void LoadRecord()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = produkController.GetAllProduk();
            foreach (DataRow dr in dt.Rows)
            {
                bool status = dr["STATUS"].ToString() == "Aktif";
                decimal hargaPerBiji = Convert.ToDecimal(dr["HARGA_PER_BIJI"]);
                int isiPerKardus = dr.Table.Columns.Contains("ISI_PER_KARDUS") ? Convert.ToInt32(dr["ISI_PER_KARDUS"]) : 0;
                decimal hargaPerKardus = isiPerKardus > 0 ? hargaPerBiji * isiPerKardus : 0;

                dataGridView1.Rows.Add(
                    dr["NOPRODUK"].ToString(),
                    dr["NAMAPRODUK"].ToString(),
                    hargaPerBiji,
                    hargaPerKardus,
                    isiPerKardus,
                    dr["GRUP"].ToString(),
                    Convert.ToDateTime(dr["EXPDATE"]).ToString("yyyy-MM-dd"),
                    status
                );
            }
        }

        // Mengosongkan input
        public void clear()
        {
            txt_noproduk.Clear();
            txt_namaproduk.Clear();
            txt_harga.Clear();
            txt_isikardus.Clear();
            combo_grupproduk.SelectedIndex = -1;
            dateTimePicker_expdate.Value = DateTime.Today;
            checkbox_status.Checked = false;
        }

        // Tombol Simpan
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_noproduk.Text) ||
                string.IsNullOrWhiteSpace(txt_namaproduk.Text) ||
                string.IsNullOrWhiteSpace(txt_harga.Text) ||
                string.IsNullOrWhiteSpace(txt_isikardus.Text) ||
                string.IsNullOrWhiteSpace(combo_grupproduk.Text) ||
                dateTimePicker_expdate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Harap lengkapi semua data dengan benar!");
                return;
            }

            try
            {
                decimal hargaPerBiji = decimal.Parse(txt_harga.Text);
                int isiPerKardus = int.Parse(txt_isikardus.Text);
                decimal hargaPerKardus = hargaPerBiji * isiPerKardus;

                produkController.SimpanProduk(
                    noProduk: txt_noproduk.Text,
                    namaProduk: txt_namaproduk.Text,
                    hargaPerBiji: hargaPerBiji,
                    hargaPerKardus: hargaPerKardus,
                    isiKardus: isiPerKardus,
                    grup: combo_grupproduk.Text,
                    expDate: dateTimePicker_expdate.Value,
                    status: checkbox_status.Checked
                );

                MessageBox.Show("Data berhasil disimpan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }

            LoadRecord();
            clear();
        }

        // Tombol Edit
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_noproduk.Text))
            {
                MessageBox.Show("Pilih data yang mau diedit!");
                return;
            }

            try
            {
                decimal hargaPerBiji = decimal.Parse(txt_harga.Text);
                int isiPerKardus = int.Parse(txt_isikardus.Text);
                decimal hargaPerKardus = hargaPerBiji * isiPerKardus;

                produkController.Update(
                    noProduk: txt_noproduk.Text,
                    namaProduk: txt_namaproduk.Text,
                    hargaPerBiji: hargaPerBiji,
                    hargaPerKardus: hargaPerKardus,
                    isiPerKardus: isiPerKardus,
                    grup: combo_grupproduk.Text,
                    expDate: dateTimePicker_expdate.Value,
                    status: checkbox_status.Checked
                );

                MessageBox.Show("Data berhasil diupdate!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update data: " + ex.Message);
            }

            LoadRecord();
            clear();
        }

        // Tombol Hapus
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_noproduk.Text))
            {
                MessageBox.Show("Pilih data yang mau dihapus!");
                return;
            }

            DialogResult result = MessageBox.Show("Yakin mau menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int rowsAffected = produkController.Delete(txt_noproduk.Text);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus!");
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan atau gagal dihapus.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data: " + ex.Message);
                }

                LoadRecord();
                clear();
            }
        }

        // Klik baris di DataGridView untuk isi form
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_noproduk.Text = row.Cells[0].Value.ToString();
                txt_namaproduk.Text = row.Cells[1].Value.ToString();
                txt_harga.Text = row.Cells[2].Value.ToString();
                txt_isikardus.Text = row.Cells[4].Value.ToString();
                combo_grupproduk.Text = row.Cells[5].Value.ToString();
                dateTimePicker_expdate.Value = Convert.ToDateTime(row.Cells[6].Value.ToString());
                checkbox_status.Checked = (row.Cells[7].Value.ToString() == "True");
            }
        }

        // Tombol Clear
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        // Kolom pencarian
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DataTable dt = produkController.Search(txt_search.Text);
            foreach (DataRow dr in dt.Rows)
            {
                bool status = dr["STATUS"].ToString() == "Aktif";
                decimal hargaPerBiji = Convert.ToDecimal(dr["HARGA_PER_BIJI"]);
                int isiPerKardus = dr.Table.Columns.Contains("ISI_PER_KARDUS") ? Convert.ToInt32(dr["ISI_PER_KARDUS"]) : 0;
                decimal hargaPerKardus = isiPerKardus > 0 ? hargaPerBiji * isiPerKardus : 0;

                dataGridView1.Rows.Add(
                    dr["NOPRODUK"].ToString(),
                    dr["NAMAPRODUK"].ToString(),
                    hargaPerBiji,
                    hargaPerKardus,
                    isiPerKardus,
                    dr["GRUP"].ToString(),
                    Convert.ToDateTime(dr["EXPDATE"]).ToString("yyyy-MM-dd"),
                    status
                );
            }
        }

        // Tombol Logout
        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin mau keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form2 loginForm = new Form2();
                loginForm.Show();
                this.Hide();
            }
        }

        // Tombol Check Produk
        private void btn_checkproduk_Click(object sender, EventArgs e)
        {
            Form4 formCheckProduk = new Form4();
            formCheckProduk.Show();
            this.Hide();
        }
    }
}
