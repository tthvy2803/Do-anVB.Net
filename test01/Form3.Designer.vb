<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        dgvKhachHang = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTenKH = New TextBox()
        txtDiaChi = New TextBox()
        txtSDT = New TextBox()
        txtMaKH = New TextBox()
        btnThemKH = New Button()
        btnSuaKH = New Button()
        btnXoaKH = New Button()
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvKhachHang
        ' 
        dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKhachHang.Location = New Point(12, 21)
        dgvKhachHang.Name = "dgvKhachHang"
        dgvKhachHang.RowHeadersWidth = 51
        dgvKhachHang.Size = New Size(830, 281)
        dgvKhachHang.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 330)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 22)
        Label1.TabIndex = 1
        Label1.Text = "Mã KH"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 372)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 22)
        Label2.TabIndex = 1
        Label2.Text = "Tên KH"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 414)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 22)
        Label3.TabIndex = 1
        Label3.Text = "Địa chỉ "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(54, 457)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 22)
        Label4.TabIndex = 1
        Label4.Text = "SĐT"
        ' 
        ' txtTenKH
        ' 
        txtTenKH.Location = New Point(195, 364)
        txtTenKH.Name = "txtTenKH"
        txtTenKH.Size = New Size(212, 30)
        txtTenKH.TabIndex = 2
        ' 
        ' txtDiaChi
        ' 
        txtDiaChi.Location = New Point(195, 406)
        txtDiaChi.Name = "txtDiaChi"
        txtDiaChi.Size = New Size(212, 30)
        txtDiaChi.TabIndex = 2
        ' 
        ' txtSDT
        ' 
        txtSDT.Location = New Point(195, 449)
        txtSDT.Name = "txtSDT"
        txtSDT.Size = New Size(212, 30)
        txtSDT.TabIndex = 2
        ' 
        ' txtMaKH
        ' 
        txtMaKH.Location = New Point(195, 322)
        txtMaKH.Name = "txtMaKH"
        txtMaKH.Size = New Size(212, 30)
        txtMaKH.TabIndex = 2
        ' 
        ' btnThemKH
        ' 
        btnThemKH.Location = New Point(585, 330)
        btnThemKH.Name = "btnThemKH"
        btnThemKH.Size = New Size(134, 46)
        btnThemKH.TabIndex = 3
        btnThemKH.Text = "Thêm"
        btnThemKH.UseVisualStyleBackColor = True
        ' 
        ' btnSuaKH
        ' 
        btnSuaKH.Location = New Point(585, 382)
        btnSuaKH.Name = "btnSuaKH"
        btnSuaKH.Size = New Size(134, 46)
        btnSuaKH.TabIndex = 3
        btnSuaKH.Text = "Sửa"
        btnSuaKH.UseVisualStyleBackColor = True
        ' 
        ' btnXoaKH
        ' 
        btnXoaKH.Location = New Point(585, 434)
        btnXoaKH.Name = "btnXoaKH"
        btnXoaKH.Size = New Size(134, 46)
        btnXoaKH.TabIndex = 3
        btnXoaKH.Text = "Xóa"
        btnXoaKH.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(853, 572)
        Controls.Add(btnXoaKH)
        Controls.Add(btnSuaKH)
        Controls.Add(btnThemKH)
        Controls.Add(txtMaKH)
        Controls.Add(txtSDT)
        Controls.Add(txtDiaChi)
        Controls.Add(txtTenKH)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvKhachHang)
        Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form3"
        Text = "Form3"
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvKhachHang As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents btnThemKH As Button
    Friend WithEvents btnSuaKH As Button
    Friend WithEvents btnXoaKH As Button
End Class
