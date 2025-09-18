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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnDangNhap = New Button()
        btnThoat = New Button()
        txtTenDangNhap = New TextBox()
        txtMatKhau = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(12, 92)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 173)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(92, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(365, 34)
        Label1.TabIndex = 1
        Label1.Text = "Chào mừng đến với cửa hàng"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F)
        Label2.Location = New Point(219, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 22)
        Label2.TabIndex = 1
        Label2.Text = "Tên đăng nhập"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F)
        Label3.Location = New Point(219, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 22)
        Label3.TabIndex = 1
        Label3.Text = "Mật khẩu"
        ' 
        ' btnDangNhap
        ' 
        btnDangNhap.Font = New Font("Times New Roman", 12F)
        btnDangNhap.Location = New Point(233, 231)
        btnDangNhap.Name = "btnDangNhap"
        btnDangNhap.Size = New Size(110, 46)
        btnDangNhap.TabIndex = 2
        btnDangNhap.Text = "Đăng nhập"
        btnDangNhap.UseVisualStyleBackColor = True
        ' 
        ' btnThoat
        ' 
        btnThoat.Font = New Font("Times New Roman", 12F)
        btnThoat.Location = New Point(382, 231)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(110, 46)
        btnThoat.TabIndex = 2
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' txtTenDangNhap
        ' 
        txtTenDangNhap.Font = New Font("Times New Roman", 12F)
        txtTenDangNhap.Location = New Point(363, 112)
        txtTenDangNhap.Name = "txtTenDangNhap"
        txtTenDangNhap.Size = New Size(138, 30)
        txtTenDangNhap.TabIndex = 3
        ' 
        ' txtMatKhau
        ' 
        txtMatKhau.Font = New Font("Times New Roman", 12F)
        txtMatKhau.Location = New Point(363, 168)
        txtMatKhau.Name = "txtMatKhau"
        txtMatKhau.Size = New Size(138, 30)
        txtMatKhau.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(525, 314)
        Controls.Add(txtMatKhau)
        Controls.Add(txtTenDangNhap)
        Controls.Add(btnThoat)
        Controls.Add(btnDangNhap)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents txtTenDangNhap As TextBox
    Friend WithEvents txtMatKhau As TextBox

End Class
