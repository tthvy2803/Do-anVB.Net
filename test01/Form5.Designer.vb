<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        dgvDonHang = New DataGridView()
        dgvChiTietDonHang = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNgayLap = New TextBox()
        txtTongTien = New TextBox()
        txtMaDH = New TextBox()
        txtMaKH = New TextBox()
        btnThemDH = New Button()
        btnSuaDH = New Button()
        btnXoaDH = New Button()
        txtSoLuong = New TextBox()
        txtDonGia = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtMaSP = New TextBox()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvChiTietDonHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDonHang
        ' 
        dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDonHang.Location = New Point(13, 12)
        dgvDonHang.Margin = New Padding(4, 3, 4, 3)
        dgvDonHang.Name = "dgvDonHang"
        dgvDonHang.RowHeadersWidth = 51
        dgvDonHang.Size = New Size(840, 136)
        dgvDonHang.TabIndex = 0
        ' 
        ' dgvChiTietDonHang
        ' 
        dgvChiTietDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvChiTietDonHang.Location = New Point(13, 164)
        dgvChiTietDonHang.Margin = New Padding(4, 3, 4, 3)
        dgvChiTietDonHang.Name = "dgvChiTietDonHang"
        dgvChiTietDonHang.RowHeadersWidth = 51
        dgvChiTietDonHang.Size = New Size(840, 136)
        dgvChiTietDonHang.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 366)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 22)
        Label1.TabIndex = 1
        Label1.Text = "Ngày lập"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 402)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 22)
        Label2.TabIndex = 1
        Label2.Text = "Mã KH"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(50, 438)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 22)
        Label3.TabIndex = 1
        Label3.Text = "Tổng tiền"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 329)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 22)
        Label4.TabIndex = 1
        Label4.Text = "Mã ĐH"
        ' 
        ' txtNgayLap
        ' 
        txtNgayLap.Location = New Point(179, 358)
        txtNgayLap.Name = "txtNgayLap"
        txtNgayLap.Size = New Size(187, 30)
        txtNgayLap.TabIndex = 2
        ' 
        ' txtTongTien
        ' 
        txtTongTien.Location = New Point(179, 430)
        txtTongTien.Name = "txtTongTien"
        txtTongTien.Size = New Size(187, 30)
        txtTongTien.TabIndex = 2
        ' 
        ' txtMaDH
        ' 
        txtMaDH.Location = New Point(179, 321)
        txtMaDH.Name = "txtMaDH"
        txtMaDH.Size = New Size(187, 30)
        txtMaDH.TabIndex = 2
        ' 
        ' txtMaKH
        ' 
        txtMaKH.Location = New Point(179, 394)
        txtMaKH.Name = "txtMaKH"
        txtMaKH.Size = New Size(187, 30)
        txtMaKH.TabIndex = 2
        ' 
        ' btnThemDH
        ' 
        btnThemDH.Location = New Point(133, 495)
        btnThemDH.Name = "btnThemDH"
        btnThemDH.Size = New Size(138, 47)
        btnThemDH.TabIndex = 3
        btnThemDH.Text = "Thêm"
        btnThemDH.UseVisualStyleBackColor = True
        ' 
        ' btnSuaDH
        ' 
        btnSuaDH.Location = New Point(361, 495)
        btnSuaDH.Name = "btnSuaDH"
        btnSuaDH.Size = New Size(138, 47)
        btnSuaDH.TabIndex = 3
        btnSuaDH.Text = "Sửa"
        btnSuaDH.UseVisualStyleBackColor = True
        ' 
        ' btnXoaDH
        ' 
        btnXoaDH.Location = New Point(599, 495)
        btnXoaDH.Name = "btnXoaDH"
        btnXoaDH.Size = New Size(138, 47)
        btnXoaDH.TabIndex = 3
        btnXoaDH.Text = "Xóa"
        btnXoaDH.UseVisualStyleBackColor = True
        ' 
        ' txtSoLuong
        ' 
        txtSoLuong.Location = New Point(582, 384)
        txtSoLuong.Name = "txtSoLuong"
        txtSoLuong.Size = New Size(187, 30)
        txtSoLuong.TabIndex = 4
        ' 
        ' txtDonGia
        ' 
        txtDonGia.Location = New Point(582, 420)
        txtDonGia.Name = "txtDonGia"
        txtDonGia.Size = New Size(187, 30)
        txtDonGia.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(453, 392)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 22)
        Label5.TabIndex = 5
        Label5.Text = "Số lượng"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(453, 428)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 22)
        Label6.TabIndex = 5
        Label6.Text = "Đơn giá"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(453, 354)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 22)
        Label7.TabIndex = 6
        Label7.Text = "Mã SP"
        ' 
        ' txtMaSP
        ' 
        txtMaSP.Location = New Point(582, 346)
        txtMaSP.Name = "txtMaSP"
        txtMaSP.Size = New Size(187, 30)
        txtMaSP.TabIndex = 7
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(866, 551)
        Controls.Add(txtMaSP)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtDonGia)
        Controls.Add(txtSoLuong)
        Controls.Add(btnXoaDH)
        Controls.Add(btnSuaDH)
        Controls.Add(btnThemDH)
        Controls.Add(txtMaKH)
        Controls.Add(txtMaDH)
        Controls.Add(txtTongTien)
        Controls.Add(txtNgayLap)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvChiTietDonHang)
        Controls.Add(dgvDonHang)
        Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form5"
        Text = "Form5"
        CType(dgvDonHang, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvChiTietDonHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDonHang As DataGridView
    Friend WithEvents dgvChiTietDonHang As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNgayLap As TextBox
    Friend WithEvents txtTongTien As TextBox
    Friend WithEvents txtMaDH As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents btnThemDH As Button
    Friend WithEvents btnSuaDH As Button
    Friend WithEvents btnXoaDH As Button
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMaSP As TextBox
End Class
