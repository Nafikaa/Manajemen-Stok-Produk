using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ManajemenStokProduk
{
    public partial class Form1 : Form
    {
        // Inisialisasi objek DatabaseConnection untuk mengelola koneksi ke database
        private DatabaseConnection db = new DatabaseConnection();
        private MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        // Event saat Form1 pertama kali dimuat
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = db.GetConnection();

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal koneksi : " + ex.Message);
            }

            LoadRecord();
        }

        // Fungsi untuk memuat data dari database ke DataGridView
        public void LoadRecord()
        {
            dataGridView1.Rows.Clear();
            conn = db.GetConnection();  
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT NOPRODUK, NAMAPRODUK, HARGA, GRUP, EXPDATE, STATUS FROM tbl_crud", conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            // Menghapus semua baris di DataGridView sebelum menambahkan data baru
            while (dr.Read())
            {
                // Mengambil nilai dari DataReader dan menambahkannya ke DataGridView
                bool status = dr["STATUS"].ToString() == "Aktif";
                dataGridView1.Rows.Add(
                    dr["NOPRODUK"].ToString(),
                    dr["NAMAPRODUK"].ToString(),
                    dr["HARGA"].ToString(),
                    dr["GRUP"].ToString(),
                    Convert.ToDateTime(dr["EXPDATE"]).ToString("yyyy-MM-dd"),
                    status
                );
            }

            dr.Close();
            conn.Close();
        }

        // Fungsi untuk mengosongkan inputan
        public void clear()
        {
            // Mengosongkan semua inputan
            txt_noproduk.Clear();
            txt_namaproduk.Clear();
            txt_harga.Clear();
            combo_grupproduk.SelectedIndex = -1;
            dateTimePicker_expdate.Value = DateTime.Today;
            checkbox_status.Checked = false;
        }

        // Event saat tombol Simpan diklik
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_noproduk.Text) ||
                string.IsNullOrWhiteSpace(txt_namaproduk.Text) ||
                string.IsNullOrWhiteSpace(txt_harga.Text) ||
                string.IsNullOrWhiteSpace(combo_grupproduk.Text) ||
                dateTimePicker_expdate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Harap lengkapi semua data dengan benar!");
                return;
            }

            try
            {
                // Menyimpan data ke database
                conn = db.GetConnection();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_crud (NOPRODUK, NAMAPRODUK, HARGA, GRUP, EXPDATE, STATUS) VALUES (@NOPRODUK, @NAMAPRODUK, @HARGA, @GRUP, @EXPDATE, @STATUS)", conn);
                
                cmd.Parameters.AddWithValue("@NOPRODUK", txt_noproduk.Text);
                cmd.Parameters.AddWithValue("@NAMAPRODUK", txt_namaproduk.Text);
                cmd.Parameters.AddWithValue("@HARGA", txt_harga.Text);
                cmd.Parameters.AddWithValue("@GRUP", combo_grupproduk.Text);
                cmd.Parameters.AddWithValue("@EXPDATE", dateTimePicker_expdate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@STATUS", checkbox_status.Checked ? "Aktif" : "Tidak Aktif");

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            LoadRecord();   
            clear();
        }

        // Event saat tombol Edit diklik
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_noproduk.Text))
            {
                MessageBox.Show("Pilih data yang mau diedit!");
                return;
            }

            try
            {
                // Mengupdate data di database
                conn = db.GetConnection();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE tbl_crud SET NAMAPRODUK = @NAMAPRODUK, HARGA = @HARGA, GRUP = @GRUP, EXPDATE = @EXPDATE, STATUS = @STATUS WHERE NOPRODUK = @NOPRODUK", conn);

                cmd.Parameters.AddWithValue("@NAMAPRODUK", txt_namaproduk.Text);
                cmd.Parameters.AddWithValue("@HARGA", txt_harga.Text);
                cmd.Parameters.AddWithValue("@GRUP", combo_grupproduk.Text);
                cmd.Parameters.AddWithValue("@EXPDATE", dateTimePicker_expdate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@STATUS", checkbox_status.Checked ? "Aktif" : "Tidak Aktif");
                cmd.Parameters.AddWithValue("@NOPRODUK", txt_noproduk.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Memuat ulang data setelah edit
            LoadRecord();
            clear();
        }

        // Event saat tombol Hapus diklik
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_noproduk.Text))
            {
                MessageBox.Show("Pilih data yang mau dihapus!");
                return;
            }

            // Konfirmasi penghapusan
            DialogResult result = MessageBox.Show("Yakin mau menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Jika pengguna mengkonfirmasi, lakukan penghapusan
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Menghapus data dari database
                    conn = db.GetConnection();
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM tbl_crud WHERE NOPRODUK = @NOPRODUK", conn);
                    cmd.Parameters.AddWithValue("@NOPRODUK", txt_noproduk.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Jika ada baris yang terpengaruh, berarti data berhasil dihapus
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
                finally
                {
                    conn.Close();
                }

                // Memuat ulang data setelah hapus
                LoadRecord();
                clear();
            }
        }

        // Event saat sel di DataGridView diklik
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan sel yang diklik bukan header
            if (e.RowIndex >= 0)
            {
                // Mengambil data dari sel yang diklik dan menampilkannya di TextBox
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_noproduk.Text = row.Cells[0].Value.ToString();
                txt_namaproduk.Text = row.Cells[1].Value.ToString();
                txt_harga.Text = row.Cells[2].Value.ToString();
                combo_grupproduk.Text = row.Cells[3].Value.ToString();
                dateTimePicker_expdate.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                checkbox_status.Checked = (row.Cells[5].Value.ToString() == "True");
            }
        }

        // Event saat tombol Clear diklik
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        // Event saat teks di TextBox pencarian berubah
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn = db.GetConnection();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(
                "SELECT NOPRODUK, NAMAPRODUK, HARGA, GRUP, EXPDATE, STATUS FROM tbl_crud WHERE NOPRODUK LIKE @search OR NAMAPRODUK LIKE @search", conn);
            cmd.Parameters.AddWithValue("@search", "%" + txt_search.Text + "%");

            // Menjalankan query dan membaca hasilnya
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Mengambil nilai dari DataReader dan menambahkannya ke DataGridView
                bool status = dr["STATUS"].ToString() == "Aktif";
                dataGridView1.Rows.Add(
                    dr["NOPRODUK"].ToString(),
                    dr["NAMAPRODUK"].ToString(),
                    dr["HARGA"].ToString(),
                    dr["GRUP"].ToString(),
                    Convert.ToDateTime(dr["EXPDATE"]).ToString("yyyy-MM-dd"),
                    status
                );
            }
            // Menutup DataReader dan koneksi
            dr.Close();
            conn.Close();
        }

        // Event saat tombol Logout diklik
        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Konfirmasi sebelum keluar
            DialogResult result = MessageBox.Show("Yakin mau keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form2 loginForm = new Form2();  
                loginForm.Show();   
                this.Hide();
            }
        }
    }
}
