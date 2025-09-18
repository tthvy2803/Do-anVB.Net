Public Class Form2
    ' Code cho nút "Khách hàng"
    Private Sub btnKhachHang_Click(sender As Object, e As EventArgs) Handles btnKhachHang.Click
        ' Tạo một đối tượng của Form3 và hiển thị nó
        Dim form3 As New Form3()
        form3.Show()
        ' Bạn có thể ẩn Form2 đi nếu muốn
        ' Me.Hide() 
    End Sub

    ' Code cho nút "Sản phẩm"
    Private Sub btnSanPham_Click(sender As Object, e As EventArgs) Handles btnSanPham.Click
        ' Tạo một đối tượng của Form4 và hiển thị nó
        Dim form4 As New Form4()
        form4.Show()
        ' Bạn có thể ẩn Form2 đi nếu muốn
        ' Me.Hide()
    End Sub

    ' Code cho nút "Đơn hàng"
    Private Sub btnDonHang_Click(sender As Object, e As EventArgs) Handles btnDonHang.Click
        ' Tạo một đối tượng của Form5 và hiển thị nó
        Dim form5 As New Form5()
        form5.Show()
        ' Bạn có thể ẩn Form2 đi nếu muốn
        ' Me.Hide()
    End Sub
End Class