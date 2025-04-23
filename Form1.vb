Imports System.ComponentModel.DataAnnotations
Imports MySql.Data.MySqlClient

Public Class Form1
    ' Inisialisasi koneksi ke database MySQL
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=curd")
    Dim dr As MySqlDataReader

    ' Saat form dimuat, data langsung ditampilkan di DataGridView
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    ' Tombol Simpan untuk menyimpan data ke tabel tbl_curd
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim cmd As New MySqlCommand("INSERT INTO `tbl_curd`(`NOPRODUK`,`NAMAPRODUK`, `HARGA`, `GRUP`, `EXPDATE`, `STATUS`) VALUES (@NOPRODUK,@NAMAPRODUK,@HARGA,@GRUP,@EXPDATE,@STATUS)", conn)
        ' Mengisi parameter dengan data dari form
        cmd.Parameters.AddWithValue("@NOPRODUK", txt_prono.Text)
        cmd.Parameters.AddWithValue("@NAMAPRODUK", txt_Proname.Text)
        cmd.Parameters.AddWithValue("@HARGA", CDec(txt_price.Text))
        cmd.Parameters.AddWithValue("@GRUP", combo_proGroup.Text)
        cmd.Parameters.AddWithValue("@EXPDATE", CDate(exp_datepicker.Value))
        cmd.Parameters.AddWithValue("@STATUS", status_checkbox.Checked)

        Try
            ' Menjalankan perintah INSERT
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Save Success", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Menangani error saat menyimpan
            MessageBox.Show("Record Save Failed: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Finally
            conn.Close()
        End Try

        ' Setelah simpan, bersihkan form dan refresh data
        clear()
        DGV_load()
    End Sub

    ' Prosedur untuk memuat data dari database ke DataGridView
    Private Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `tbl_curd`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                ' Tambahkan setiap baris dari hasil query ke DataGridView
                DataGridView1.Rows.Add(dr.Item("NOPRODUK"), dr.Item("NAMAPRODUK"), dr.Item("HARGA"), dr.Item("GRUP"), dr.Item("EXPDATE"), Format(CBool(dr.Item("STATUS"))))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Tombol untuk menghapus isian form
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
    End Sub

    Private Sub clear()
        txt_prono.Clear()
        txt_Proname.Clear()
        txt_price.Clear()
        combo_proGroup.Text = ""
        exp_datepicker.Value = DateTime.Now
        status_checkbox.CheckState = CheckState.Unchecked

        ' Aktifkan kembali textbox dan tombol simpan
        txt_prono.ReadOnly = False
        btn_save.Enabled = True
    End Sub

    ' Saat pengguna mengklik data di DataGridView, tampilkan di input form
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txt_prono.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_Proname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_price.Text = DataGridView1.CurrentRow.Cells(2).Value
        combo_proGroup.Text = DataGridView1.CurrentRow.Cells(3).Value
        exp_datepicker.Text = DataGridView1.CurrentRow.Cells(4).Value
        status_checkbox.Checked = DataGridView1.CurrentRow.Cells(5).Value

        ' Buat NOPRODUK tidak bisa diubah, dan matikan tombol simpan
        txt_prono.ReadOnly = True
        btn_save.Enabled = False
    End Sub

    ' Prosedur untuk mengedit data yang dipilih
    Sub Edit()
        Dim cmd As New MySqlCommand("UPDATE `tbl_curd` SET `NAMAPRODUK` = @NAMAPRODUK, `HARGA` = @HARGA, `GRUP` = @GRUP, `EXPDATE` = @EXPDATE, `STATUS` = @STATUS WHERE `NOPRODUK` = @NOPRODUK", conn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@NOPRODUK", txt_prono.Text)
        cmd.Parameters.AddWithValue("@NAMAPRODUK", txt_Proname.Text)
        cmd.Parameters.AddWithValue("@HARGA", CDec(txt_price.Text))
        cmd.Parameters.AddWithValue("@GRUP", combo_proGroup.Text)
        cmd.Parameters.AddWithValue("@EXPDATE", CDate(exp_datepicker.Value))
        cmd.Parameters.AddWithValue("@STATUS", status_checkbox.Checked)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Update Success", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Record Update Failed: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Finally
            conn.Close()
        End Try

        clear()
        DGV_load()
    End Sub

    ' Tombol untuk memanggil prosedur Edit
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Edit()
    End Sub

    ' Prosedur untuk menghapus data
    Private Sub Delete()
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
            Dim cmd As New MySqlCommand("DELETE FROM `tbl_curd` WHERE `NOPRODUK` = @NOPRODUK", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@NOPRODUK", txt_prono.Text)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Delete Success", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Record Delete Failed: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Finally
                conn.Close()
            End Try
            clear()
            DGV_load()
        End If
    End Sub

    ' Tombol hapus memanggil prosedur Delete
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Delete()
    End Sub

    ' Prosedur pencarian data berdasarkan NOPRODUK atau NAMAPRODUK
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `tbl_curd` WHERE `NOPRODUK` LIKE @search OR `NAMAPRODUK` LIKE @search", conn)
            cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("NOPRODUK"), dr.Item("NAMAPRODUK"), dr.Item("HARGA"), dr.Item("GRUP"), dr.Item("EXPDATE"), Format(CBool(dr.Item("STATUS"))))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class


