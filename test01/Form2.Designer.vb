<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnKhachHang = New Button()
        btnSanPham = New Button()
        btnDonHang = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(49, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(374, 33)
        Label1.TabIndex = 0
        Label1.Text = "Nhấn nút để điều hướng quản lý"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(25, 78)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(210, 182)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnKhachHang
        ' 
        btnKhachHang.Font = New Font("Times New Roman", 12F)
        btnKhachHang.Location = New Point(307, 78)
        btnKhachHang.Name = "btnKhachHang"
        btnKhachHang.Size = New Size(133, 42)
        btnKhachHang.TabIndex = 2
        btnKhachHang.Text = "Khách hàng"
        btnKhachHang.UseVisualStyleBackColor = True
        ' 
        ' btnSanPham
        ' 
        btnSanPham.Font = New Font("Times New Roman", 12F)
        btnSanPham.Location = New Point(307, 148)
        btnSanPham.Name = "btnSanPham"
        btnSanPham.Size = New Size(133, 42)
        btnSanPham.TabIndex = 2
        btnSanPham.Text = "Sản phẩm"
        btnSanPham.UseVisualStyleBackColor = True
        ' 
        ' btnDonHang
        ' 
        btnDonHang.Font = New Font("Times New Roman", 12F)
        btnDonHang.Location = New Point(307, 218)
        btnDonHang.Name = "btnDonHang"
        btnDonHang.Size = New Size(133, 42)
        btnDonHang.TabIndex = 2
        btnDonHang.Text = "Đơn hàng"
        btnDonHang.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 312)
        Controls.Add(btnDonHang)
        Controls.Add(btnSanPham)
        Controls.Add(btnKhachHang)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnKhachHang As Button
    Friend WithEvents btnSanPham As Button
    Friend WithEvents btnDonHang As Button
End Class
