# 🗃️ Aplikasi Manajemen Stok Produk

Aplikasi ini dibuat untuk membantu pengguna dalam mengelola stok produk yang tersedia di gudang atau toko.  
Dibuat menggunakan C# (.Net Framework) dengan Windows Forms, serta terhubung ke database MySQL menggunakan XAMPP.
Aplikasi ini memungkinkan pengguna untuk menambahkan, melihat, memperbarui, dan menghapus data produk dengan mudah dan efisien. Aplikasi ini menerapkan pola desain MVC (Model-View-Controller).

## Fitur Aplikasi:
- **Create (Save)**: Menambahkan data produk baru ke dalam database.
- **Read**: Menampilkan seluruh data produk dari database ke DataGridView di Form1 (Form Home).
- **Update**: Mengedit atau memperbarui informasi produk (misalnya kategori, harga).
- **Delete**: Menghapus data produk di Form1 (Form Home) dan menghapus data user di Form3 (Form Register) dari database.
- **Search**: Mencari produk berdasarkan "No.Produk", "Nama produk".
- **Clear**: Mengosongkan semua inputan form agar siap digunakan kembali.
- **Logout**: Keluar dari Form1 (Form Home) dan kembali ke Form2 (Form Login).
- **Register**: Membuka Form3 (Form Register) untuk menambahkan akun user baru ke database.
- **Back**: Kembali dari Form3 (Form Register) ke Form2 (Form Login).
- **Check Product**: Membuka Form4 (Form Cek Produk) untuk menampilkan produk dan jumlah produk berdasarkan grup produk.

## Teknologi yang Digunakan
- **Bahasa Pemrograman**: C#
- **Framework**: Windows Forms (.NET Framework)
- **Database**: MySQL (melalui XAMPP)
- **Tools**:
  - Visual Studio (untuk untuk menulis kode program, mendesain antarmuka aplikasi, dan menjalankan aplikasi secara langsung).
  - XAMPP (untuk server database MySQL).
  - Canva (untuk desain mockup tampilan aplikasi).
 
## Desain Mockup Aplikasi (Canva)
https://www.canva.com/design/DAGkVdQISmM/rtsB3hbQP4tEuWk1tHsbhw/view?utm_content=DAGkVdQISmM&utm_campaign=designshare&utm_medium=link2&utm_source=uniquelinks&utlId=h0b6026d95e

## Alur Program (Event-Driven)
- Database (MySQL): ada 2 tabel yaitu tbl_user untuk Login, tbl_crud untuk menyimpan data produk.
- Form2 (Form Login): Form pertama yang muncul saat aplikasi dijalankan. Digunakan untuk autentikasi pengguna sebelum mengakses aplikasi. Terdapat fitur login, exit, tampil/sembunyikan password, dan register.
- Form3 (Form Register): Form untuk mendaftarkan user baru. Terdapat fitur register, delete, back ke Form2 (Form Login).
- Form1 (Form Home): Form utama setelah login berhasil. Menyediakan fitur CRUD (Create, Read, Update, Delete) untuk data produk, pencarian data, Check Product, serta logout kembali ke Form2 (Form Login).
- Form4 (Form Cek Produk): Form yang menampilkan data produk di DataGridView setelah user memilih grup produk (combo box).

## Struktur MVC (Model-View-Controller)
- **Model**
  - Form2 (Form Login): UserModel2.cs
  - Form3 (Form Register): UserModel3.cs
  - Form1 (Form Home): FormModel1.cs
  - Form4 (Form Cek Produk): FormModel4.cs
- **View**
  - Form2 (Form Login): Form2.cs
  - Form3 (Form Register): Form3.cs
  - Form1 (Form Home): Form1.cs
  - Form4 (Form Cek Produk): Form4.cs
- **Controller**
  - Form2 (Form Login): UserController2.cs
  - Form3 (Form Register): UserController3.cs 
  - Form1 (Form Home): FormController1.cs
  - Form4 (Form Cek Produk): FormController4.cs 
