Imports Microsoft.Data.SqlClient

Public Class Form5
    Dim connectionString As String = "Data Source=NGUYENPHUNG\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"

    ' Hàm load dữ liệu đơn hàng
    Private Sub LoadDonHang()
        Using cnn As New SqlConnection(connectionString)
            Dim da As New SqlDataAdapter("SELECT * FROM DonHang", cnn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvDonHang.DataSource = dt
        End Using
    End Sub

    ' Hàm load chi tiết đơn hàng
    Private Sub LoadChiTietDonHang()
        Using cnn As New SqlConnection(connectionString)
            Dim da As New SqlDataAdapter("SELECT * FROM ChiTietDonHang", cnn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvChiTietDonHang.DataSource = dt
        End Using
    End Sub

    ' Nút thêm đơn hàng
    Private Sub btnThemDH_Click(sender As Object, e As EventArgs) Handles btnThemDH.Click
        If String.IsNullOrEmpty(txtNgayLap.Text) Or String.IsNullOrEmpty(txtMaKH.Text) Then
            MessageBox.Show("Vui lòng nhập Ngày lập và Mã KH")
            Exit Sub
        End If

        Using cnn As New SqlConnection(connectionString)
            cnn.Open()
            Dim sql As String = "INSERT INTO DonHang(NgayLap, MaKH, TongTien) VALUES(@NgayLap, @MaKH, @TongTien); SELECT SCOPE_IDENTITY();"
            Dim cmd As New SqlCommand(sql, cnn)
            cmd.Parameters.AddWithValue("@NgayLap", txtNgayLap.Text)
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            cmd.Parameters.AddWithValue("@TongTien", txtTongTien.Text)

            Dim maDH As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' thêm chi tiết đơn hàng
            Dim sqlCT As String = "INSERT INTO ChiTietDonHang(MaDH, MaSP, SoLuong, DonGia) VALUES(@MaDH, @MaSP, @SoLuong, @DonGia)"
            Dim cmdCT As New SqlCommand(sqlCT, cnn)
            cmdCT.Parameters.AddWithValue("@MaDH", maDH)
            cmdCT.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            cmdCT.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            cmdCT.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
            cmdCT.ExecuteNonQuery()

            MessageBox.Show("Thêm đơn hàng thành công!")
        End Using

        LoadDonHang()
        LoadChiTietDonHang()
    End Sub

    ' Nút sửa đơn hàng
    Private Sub btnSuaDH_Click(sender As Object, e As EventArgs) Handles btnSuaDH.Click
        If String.IsNullOrEmpty(txtMaDH.Text) Then
            MessageBox.Show("Vui lòng nhập Mã ĐH cần sửa")
            Exit Sub
        End If

        Using cnn As New SqlConnection(connectionString)
            cnn.Open()
            Dim sql As String = "UPDATE DonHang SET NgayLap=@NgayLap, MaKH=@MaKH, TongTien=@TongTien WHERE MaDH=@MaDH"
            Dim cmd As New SqlCommand(sql, cnn)
            cmd.Parameters.AddWithValue("@NgayLap", txtNgayLap.Text)
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            cmd.Parameters.AddWithValue("@TongTien", txtTongTien.Text)
            cmd.Parameters.AddWithValue("@MaDH", txtMaDH.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Sửa đơn hàng thành công!")
        End Using

        LoadDonHang()
    End Sub

    ' Nút xóa đơn hàng
    Private Sub btnXoaDH_Click(sender As Object, e As EventArgs) Handles btnXoaDH.Click
        If String.IsNullOrEmpty(txtMaDH.Text) Then
            MessageBox.Show("Vui lòng nhập Mã ĐH cần xóa")
            Exit Sub
        End If

        Using cnn As New SqlConnection(connectionString)
            cnn.Open()

            ' Xóa chi tiết trước (do khóa ngoại)
            Dim sqlCT As String = "DELETE FROM ChiTietDonHang WHERE MaDH=@MaDH"
            Dim cmdCT As New SqlCommand(sqlCT, cnn)
            cmdCT.Parameters.AddWithValue("@MaDH", txtMaDH.Text)
            cmdCT.ExecuteNonQuery()

            ' Xóa đơn hàng
            Dim sql As String = "DELETE FROM DonHang WHERE MaDH=@MaDH"
            Dim cmd As New SqlCommand(sql, cnn)
            cmd.Parameters.AddWithValue("@MaDH", txtMaDH.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Xóa đơn hàng thành công!")
        End Using

        LoadDonHang()
        LoadChiTietDonHang()
    End Sub

    ' Load dữ liệu khi mở Form
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDonHang()
        LoadChiTietDonHang()
    End Sub

End Class
