# Aplikasi Manajemen Stok Produk

Aplikasi ini dibuat untuk membantu pengguna dalam mengelola stok produk yang tersedia di gudang atau toko.  
Dibuat menggunakan C# (.Net Framework) dengan Windows Forms, serta terhubung ke database MySQL menggunakan XAMPP.

Aplikasi ini memungkinkan pengguna untuk mencatat, melihat, memperbarui, dan menghapus data produk dengan mudah dan efisien.

## Fitur Aplikasi (CRUD)
- **Create**: Menambahkan data produk baru ke dalam database.
- **Read**: Melihat daftar semua produk yang sudah tersimpan.
- **Update**: Mengedit atau memperbarui informasi produk (misalnya jumlah stok, harga).
- **Delete**: Menghapus data produk dari database.
- **Search**: Mencari produk berdasarkan "No.Produk", "Nama produk", "Harga".
- **Clear**: Membersihkan form input di Form1.
  
## Teknologi yang Digunakan
- **Bahasa Pemrograman**: C#
- **Framework**: Windows Forms (.NET Framework)
- **Database**: MySQL (melalui XAMPP)
- **Tools**:
  - Visual Studio (untuk untuk menulis kode program, mendesain aplikasi, dan menjalankan aplikasi secara langsung).
  - XAMPP (untuk server database MySQL)
  - Canva (untuk desain mockup)
 
## Desain Mockup Aplikasi (Canva)
https://www.canva.com/design/DAGkVdQISmM/rtsB3hbQP4tEuWk1tHsbhw/view?utm_content=DAGkVdQISmM&utm_campaign=designshare&utm_medium=link2&utm_source=uniquelinks&utlId=h0b6026d95e

## Alur Program (Event-Driven)
- Form2 (Form Login): Form pertama yang muncul saat aplikasi dijalankan. Digunakan untuk autentikasi pengguna sebelum mengakses aplikasi. Terdapat fitur login, exit, dan tampil/sembunyikan password.
- Form1 (Form Home): Form utama setelah login berhasil. Menyediakan fitur CRUD (Create, Read, Update, Delete) untuk data produk, pencarian data, serta logout kembali ke Form2 (Form Login).
- Database (MySQL): ada 2 tabel yaitu tbl_user untuk Login, tbl_crud untuk menyimpan data produk.
