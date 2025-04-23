<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt_prono = New TextBox()
        txt_Proname = New TextBox()
        txt_price = New TextBox()
        combo_proGroup = New ComboBox()
        exp_datepicker = New DateTimePicker()
        status_checkbox = New CheckBox()
        btn_save = New Button()
        btn_edit = New Button()
        btn_delete = New Button()
        btn_clear = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewCheckBoxColumn()
        Label6 = New Label()
        txt_search = New TextBox()
        Label7 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_prono
        ' 
        txt_prono.Location = New Point(48, 131)
        txt_prono.Name = "txt_prono"
        txt_prono.Size = New Size(300, 31)
        txt_prono.TabIndex = 0
        ' 
        ' txt_Proname
        ' 
        txt_Proname.Location = New Point(48, 193)
        txt_Proname.Name = "txt_Proname"
        txt_Proname.Size = New Size(300, 31)
        txt_Proname.TabIndex = 1
        ' 
        ' txt_price
        ' 
        txt_price.Location = New Point(48, 255)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(300, 31)
        txt_price.TabIndex = 2
        ' 
        ' combo_proGroup
        ' 
        combo_proGroup.FormattingEnabled = True
        combo_proGroup.Items.AddRange(New Object() {"SWEETS", "COOL DRINKS", "FOODS"})
        combo_proGroup.Location = New Point(48, 317)
        combo_proGroup.Name = "combo_proGroup"
        combo_proGroup.Size = New Size(300, 33)
        combo_proGroup.TabIndex = 4
        ' 
        ' exp_datepicker
        ' 
        exp_datepicker.Location = New Point(48, 381)
        exp_datepicker.Name = "exp_datepicker"
        exp_datepicker.Size = New Size(300, 31)
        exp_datepicker.TabIndex = 5
        ' 
        ' status_checkbox
        ' 
        status_checkbox.AutoSize = True
        status_checkbox.Location = New Point(48, 418)
        status_checkbox.Name = "status_checkbox"
        status_checkbox.Size = New Size(109, 29)
        status_checkbox.TabIndex = 6
        status_checkbox.Text = "Available"
        status_checkbox.UseVisualStyleBackColor = True
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.LimeGreen
        btn_save.Cursor = Cursors.Hand
        btn_save.FlatStyle = FlatStyle.Flat
        btn_save.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_save.ForeColor = Color.White
        btn_save.Location = New Point(48, 453)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(112, 34)
        btn_save.TabIndex = 7
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' btn_edit
        ' 
        btn_edit.BackColor = Color.DarkOrange
        btn_edit.Cursor = Cursors.Hand
        btn_edit.FlatStyle = FlatStyle.Flat
        btn_edit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_edit.ForeColor = Color.White
        btn_edit.Location = New Point(236, 453)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(112, 34)
        btn_edit.TabIndex = 8
        btn_edit.Text = "Update"
        btn_edit.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.Red
        btn_delete.Cursor = Cursors.Hand
        btn_delete.FlatStyle = FlatStyle.Flat
        btn_delete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_delete.ForeColor = Color.White
        btn_delete.Location = New Point(48, 493)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(112, 34)
        btn_delete.TabIndex = 9
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' btn_clear
        ' 
        btn_clear.BackColor = Color.DarkSlateGray
        btn_clear.Cursor = Cursors.Hand
        btn_clear.FlatStyle = FlatStyle.Flat
        btn_clear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_clear.ForeColor = Color.White
        btn_clear.Location = New Point(236, 493)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(112, 34)
        btn_clear.TabIndex = 10
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 11
        Label1.Text = "No.Produk"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 25)
        Label2.TabIndex = 12
        Label2.Text = "Nama Produk"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 25)
        Label3.TabIndex = 13
        Label3.Text = "Harga"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 289)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 25)
        Label4.TabIndex = 14
        Label4.Text = "Grup Produk"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(48, 353)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 25)
        Label5.TabIndex = 15
        Label5.Text = "Expired Date"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.GridColor = SystemColors.ControlDark
        DataGridView1.ImeMode = ImeMode.NoControl
        DataGridView1.Location = New Point(382, 168)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(791, 359)
        DataGridView1.TabIndex = 15
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "No. Produk"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 138
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Nama Produk"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 157
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Harga"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 96
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Grup Produk"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 149
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Expired Date"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 148
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Status"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 66
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(382, 103)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 25)
        Label6.TabIndex = 18
        Label6.Text = "Search"
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(382, 131)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(408, 31)
        txt_search.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label7.Location = New Point(363, 29)
        Label7.Name = "Label7"
        Label7.Size = New Size(485, 41)
        Label7.TabIndex = 19
        Label7.Text = "Aplikasi Manajemen Stok Produk"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1214, 575)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(txt_search)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_clear)
        Controls.Add(btn_delete)
        Controls.Add(btn_edit)
        Controls.Add(btn_save)
        Controls.Add(status_checkbox)
        Controls.Add(exp_datepicker)
        Controls.Add(combo_proGroup)
        Controls.Add(txt_price)
        Controls.Add(txt_Proname)
        Controls.Add(txt_prono)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_prono As TextBox
    Friend WithEvents txt_Proname As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents combo_proGroup As ComboBox
    Friend WithEvents exp_datepicker As DateTimePicker
    Friend WithEvents status_checkbox As CheckBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn
    Friend WithEvents Label7 As Label

End Class
