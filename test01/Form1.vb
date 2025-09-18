Public Class Form1
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        ' Thoát khỏi form hiện tại
        Me.Close()
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        ' Kiểm tra tên đăng nhập và mật khẩu
        If txtTenDangNhap.Text = "admin" And txtMatKhau.Text = "12345" Then
            ' Nếu đúng, hiển thị Form2 và ẩn Form1
            Dim form2 As New Form2()
            form2.Show()
            Me.Hide()
        Else
            ' Nếu sai, hiển thị thông báo lỗi
            MsgBox("Tên đăng nhập hoặc mật khẩu không chính xác!", MsgBoxStyle.Critical, "Lỗi đăng nhập")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
