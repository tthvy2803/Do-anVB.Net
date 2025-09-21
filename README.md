# Quản lý sinh viên - VB.NET + SQL Server
## Mô tả dự án
Phần mềm quản lý sinh viên được xây dựng bằng VB.NET sử dụng Windows Forms, kết nối với cơ sở dữ liệu SQL Server.  
Chức năng chính:
- Thêm, sửa, xóa sinh viên
- Tìm kiếm sinh viên theo mã hoặc tên
- Quản lý lớp học, điểm số
## Công nghệ sử dụng
- Ngôn ngữ: VB.NET (.NET Framework hoặc .NET 8.0)
- Giao diện: Windows Forms
- Cơ sở dữ liệu: SQL Server
- IDE: Visual Studio
## Lưu ý 
Vì ở dự án này chỉ có Form3, Form4, Form5 mới được kết nối SQL nên khi tải dự án về hãy chạy file cơ sở dữ liệu SQL trước rồi đổi tên máy chủ trong code của 3 Form
"Data Source=TEN_SERVER;Initial Catalog=QuanLyBanHang;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"
## Cơ sở dữ liệu
- File: `QuanLyBanHang.sql` (đã upload)
### Hướng dẫn khôi phục database
1. Mở SQL Server Management Studio (SSMS)
2. Chuột phải vào **Databases** → chọn **Restore Database**
3. Chọn file `QuanLyBanHang.sql` → tiến hành khôi phục
4. Kiểm tra lại tên database và cấu hình kết nối trong VB.NET
## Cách chạy phần mềm
1. Mở file `test01.sln` bằng Visual Studio
2. Kiểm tra chuỗi kết nối SQL trong file cấu hình (nếu có)
3. Nhấn `Start` để chạy chương trình
## Tài khoản mẫu (Form1-đăng nhập)
- Username: `admin`
- Password: `12345`
