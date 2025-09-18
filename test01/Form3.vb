Imports Microsoft.Data.SqlClient

Public Class Form3
    Private ReadOnly connectionString As String =
        "Data Source=NGUYENPHUNG\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"

    ' ===== Hiển thị dữ liệu =====
    Private Sub HienThiDuLieu()
        Try
            Using cnn As New SqlConnection(connectionString)
                cnn.Open()
                Dim sql As String = "SELECT MaKH, TenKH, DiaChi, SoDienThoai FROM KhachHang"
                Dim da As New SqlDataAdapter(sql, cnn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvKhachHang.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Lỗi hiển thị dữ liệu: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' ===== Dọn trống các ô nhập =====
    Private Sub ClearInputs()
        txtMaKH.Clear()
        txtTenKH.Clear()
        txtDiaChi.Clear()
        txtSDT.Clear()
    End Sub

    ' ===== Sự kiện Load Form =====
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDuLieu()
    End Sub

    ' ===== Thêm khách hàng =====
    Private Sub btnThemKH_Click(sender As Object, e As EventArgs) Handles btnThemKH.Click
        If String.IsNullOrWhiteSpace(txtTenKH.Text) Then
            MsgBox("Vui lòng nhập tên khách hàng.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Using cnn As New SqlConnection(connectionString)
                cnn.Open()
                Dim sql As String = "INSERT INTO KhachHang (TenKH, DiaChi, SoDienThoai) VALUES (@TenKH, @DiaChi, @SoDienThoai)"
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text.Trim())
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim())
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MsgBox("Thêm khách hàng thành công!", MsgBoxStyle.Information)
            ClearInputs()
            HienThiDuLieu()
        Catch ex As Exception
            MsgBox("Lỗi khi thêm: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' ===== Sửa khách hàng =====
    Private Sub btnSuaKH_Click(sender As Object, e As EventArgs) Handles btnSuaKH.Click
        If String.IsNullOrWhiteSpace(txtMaKH.Text) Then
            MsgBox("Vui lòng chọn khách hàng cần sửa.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Using cnn As New SqlConnection(connectionString)
                cnn.Open()
                Dim sql As String = "UPDATE KhachHang SET TenKH = @TenKH, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai WHERE MaKH = @MaKH"
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text.Trim())
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim())
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text.Trim())
                    cmd.Parameters.AddWithValue("@MaKH", Convert.ToInt32(txtMaKH.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MsgBox("Sửa thông tin khách hàng thành công!", MsgBoxStyle.Information)
            ClearInputs()
            HienThiDuLieu()
        Catch ex As Exception
            MsgBox("Lỗi khi sửa: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' ===== Xóa khách hàng =====
    Private Sub btnXoaKH_Click(sender As Object, e As EventArgs) Handles btnXoaKH.Click
        If String.IsNullOrWhiteSpace(txtMaKH.Text) Then
            MsgBox("Vui lòng chọn khách hàng cần xóa.", MsgBoxStyle.Exclamation)
            Return
        End If

        If MsgBox("Bạn có chắc chắn muốn xóa khách hàng này không?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Xác nhận") = MsgBoxResult.Yes Then
            Try
                Using cnn As New SqlConnection(connectionString)
                    cnn.Open()
                    Dim sql As String = "DELETE FROM KhachHang WHERE MaKH = @MaKH"
                    Using cmd As New SqlCommand(sql, cnn)
                        cmd.Parameters.AddWithValue("@MaKH", Convert.ToInt32(txtMaKH.Text))
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MsgBox("Xóa khách hàng thành công!", MsgBoxStyle.Information)
                ClearInputs()
                HienThiDuLieu()
            Catch ex As Exception
                MsgBox("Lỗi khi xóa: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' ===== Chọn hàng trong DataGridView =====
    Private Sub dgvKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhachHang.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvKhachHang.Rows.Count Then
            Dim row As DataGridViewRow = dgvKhachHang.Rows(e.RowIndex)
            If row.Cells("MaKH").Value IsNot Nothing Then
                txtMaKH.Text = row.Cells("MaKH").Value.ToString()
                txtTenKH.Text = row.Cells("TenKH").Value.ToString()
                txtDiaChi.Text = row.Cells("DiaChi").Value.ToString()
                txtSDT.Text = row.Cells("SoDienThoai").Value.ToString()
            End If
        End If
    End Sub
End Class
