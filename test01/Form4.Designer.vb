<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvSanPham = New DataGridView()
        btnThemSP = New Button()
        btnSuaSP = New Button()
        btnXoaSP = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtMaSP = New TextBox()
        txtTenSP = New TextBox()
        txtDonViTinh = New TextBox()
        txtGiaBan = New TextBox()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvSanPham
        ' 
        dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSanPham.Location = New Point(13, 12)
        dgvSanPham.Margin = New Padding(4, 3, 4, 3)
        dgvSanPham.Name = "dgvSanPham"
        dgvSanPham.RowHeadersWidth = 51
        dgvSanPham.Size = New Size(789, 273)
        dgvSanPham.TabIndex = 0
        ' 
        ' btnThemSP
        ' 
        btnThemSP.Location = New Point(541, 312)
        btnThemSP.Name = "btnThemSP"
        btnThemSP.Size = New Size(139, 49)
        btnThemSP.TabIndex = 1
        btnThemSP.Text = "Thêm "
        btnThemSP.UseVisualStyleBackColor = True
        ' 
        ' btnSuaSP
        ' 
        btnSuaSP.Location = New Point(541, 367)
        btnSuaSP.Name = "btnSuaSP"
        btnSuaSP.Size = New Size(139, 49)
        btnSuaSP.TabIndex = 1
        btnSuaSP.Text = "Sửa"
        btnSuaSP.UseVisualStyleBackColor = True
        ' 
        ' btnXoaSP
        ' 
        btnXoaSP.Location = New Point(541, 422)
        btnXoaSP.Name = "btnXoaSP"
        btnXoaSP.Size = New Size(139, 49)
        btnXoaSP.TabIndex = 1
        btnXoaSP.Text = "Xóa"
        btnXoaSP.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(72, 367)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 22)
        Label1.TabIndex = 2
        Label1.Text = "Tên SP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(72, 409)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 22)
        Label2.TabIndex = 2
        Label2.Text = "Đơn vị tính"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(72, 449)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 22)
        Label3.TabIndex = 2
        Label3.Text = "Giá bán"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(72, 325)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 22)
        Label4.TabIndex = 2
        Label4.Text = "Mã SP"
        ' 
        ' txtMaSP
        ' 
        txtMaSP.Location = New Point(192, 319)
        txtMaSP.Name = "txtMaSP"
        txtMaSP.Size = New Size(167, 30)
        txtMaSP.TabIndex = 3
        ' 
        ' txtTenSP
        ' 
        txtTenSP.Location = New Point(192, 359)
        txtTenSP.Name = "txtTenSP"
        txtTenSP.Size = New Size(167, 30)
        txtTenSP.TabIndex = 3
        ' 
        ' txtDonViTinh
        ' 
        txtDonViTinh.Location = New Point(192, 401)
        txtDonViTinh.Name = "txtDonViTinh"
        txtDonViTinh.Size = New Size(167, 30)
        txtDonViTinh.TabIndex = 3
        ' 
        ' txtGiaBan
        ' 
        txtGiaBan.Location = New Point(192, 441)
        txtGiaBan.Name = "txtGiaBan"
        txtGiaBan.Size = New Size(167, 30)
        txtGiaBan.TabIndex = 3
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(815, 495)
        Controls.Add(txtGiaBan)
        Controls.Add(txtDonViTinh)
        Controls.Add(txtTenSP)
        Controls.Add(txtMaSP)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnXoaSP)
        Controls.Add(btnSuaSP)
        Controls.Add(btnThemSP)
        Controls.Add(dgvSanPham)
        Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form4"
        Text = "Form4"
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents btnThemSP As Button
    Friend WithEvents btnSuaSP As Button
    Friend WithEvents btnXoaSP As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents txtDonViTinh As TextBox
    Friend WithEvents txtGiaBan As TextBox
End Class
