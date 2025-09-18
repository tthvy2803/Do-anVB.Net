Imports Microsoft.Data.SqlClient

Public Class Form4
    Private ReadOnly connectionString As String =
        "Data Source=NGUYENPHUNG\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"

    ' ===== Hiển thị dữ liệu sản phẩm =====
    Private Sub HienThiDuLieu()
        Try
            Using cnn As New SqlConnection(connectionString)
                cnn.Open()
                Dim sql As String = "SELECT MaSP, TenSP, DonViTinh, GiaBan FROM SanPham"
                Dim da As New SqlDataAdapter(sql, cnn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvSanPham.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Lỗi hiển thị dữ liệu: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' ===== Dọn trống các ô nhập =====
    Private Sub ClearInputs()
        txtMaSP.Clear()
        txtTenSP.Clear()
        txtDonViTinh.Clear()
        txtGiaBan.Clear()
    End Sub

    ' ===== Sự kiện Load Form =====
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDuLieu()
    End Sub

    ' ===== Thêm sản phẩm =====
    Private Sub btnThemSP_Click(sender As Object, e As EventArgs) Handles btnThemSP.Click
        If String.IsNullOrWhiteSpace(txtTenSP.Text) Then
            MsgBox("Vui lòng nhập tên sản phẩm.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Using cnn As New SqlConnection(connectionString)
                cnn.Open()
                Dim sql As String = "INSERT INTO SanPham (TenSP, DonViTinh, GiaBan) VALUES (@TenSP, @DonViTinh, @GiaBan)"
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text.Trim())
                    cmd.Parameters.AddWithValue("@DonViTinh", txtDonViTinh.Text.Trim())
                    ' Ép kiểu decimal cho giá bán
                    Dim gia As Decimal
                    If Decimal.TryParse(txtGiaBan.Text.Trim(), gia) Then
                        cmd.Parameters.AddWithValue("@GiaBan", gia)
                    Else
                        MsgBox("Giá bán phải là số.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MsgBox("Thêm sản phẩm thành công!", MsgBoxStyle.Information)
            ClearInputs()
            HienThiDuLieu()
        Catch ex As Exception
            MsgBox("Lỗi khi thêm: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' ===== Sửa sản phẩm =====
    Private Sub btnSuaSP_Click(sender As Object, e As EventArgs) Handles btnSuaSP.Click
        If String.IsNullOrWhiteSpace(txtMaSP.Text) Then
            MsgBox("Vui lòng chọn sản phẩm cần sửa.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Using cnn As New SqlConnection(connectionString)
                cnn.Open()
                Dim sql As String = "UPDATE SanPham SET TenSP = @TenSP, DonViTinh = @DonViTinh, GiaBan = @GiaBan WHERE MaSP = @MaSP"
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text.Trim())
                    cmd.Parameters.AddWithValue("@DonViTinh", txtDonViTinh.Text.Trim())
                    Dim gia As Decimal
                    If Decimal.TryParse(txtGiaBan.Text.Trim(), gia) Then
                        cmd.Parameters.AddWithValue("@GiaBan", gia)
                    Else
                        MsgBox("Giá bán phải là số.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                    cmd.Parameters.AddWithValue("@MaSP", Convert.ToInt32(txtMaSP.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MsgBox("Sửa thông tin sản phẩm thành công!", MsgBoxStyle.Information)
            ClearInputs()
            HienThiDuLieu()
        Catch ex As Exception
            MsgBox("Lỗi khi sửa: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' ===== Xóa sản phẩm =====
    Private Sub btnXoaSP_Click(sender As Object, e As EventArgs) Handles btnXoaSP.Click
        If String.IsNullOrWhiteSpace(txtMaSP.Text) Then
            MsgBox("Vui lòng chọn sản phẩm cần xóa.", MsgBoxStyle.Exclamation)
            Return
        End If

        If MsgBox("Bạn có chắc chắn muốn xóa sản phẩm này không?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Xác nhận") = MsgBoxResult.Yes Then
            Try
                Using cnn As New SqlConnection(connectionString)
                    cnn.Open()
                    Dim sql As String = "DELETE FROM SanPham WHERE MaSP = @MaSP"
                    Using cmd As New SqlCommand(sql, cnn)
                        cmd.Parameters.AddWithValue("@MaSP", Convert.ToInt32(txtMaSP.Text))
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MsgBox("Xóa sản phẩm thành công!", MsgBoxStyle.Information)
                ClearInputs()
                HienThiDuLieu()
            Catch ex As Exception
                MsgBox("Lỗi khi xóa: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' ===== Chọn hàng trong DataGridView =====
    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvSanPham.Rows.Count Then
            Dim row As DataGridViewRow = dgvSanPham.Rows(e.RowIndex)
            If row.Cells("MaSP").Value IsNot Nothing Then
                txtMaSP.Text = row.Cells("MaSP").Value.ToString()
                txtTenSP.Text = row.Cells("TenSP").Value.ToString()
                txtDonViTinh.Text = row.Cells("DonViTinh").Value.ToString()
                txtGiaBan.Text = row.Cells("GiaBan").Value.ToString()
            End If
        End If
    End Sub
End Class
