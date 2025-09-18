-- Ki?m tra và xóa c? s? d? li?u n?u ?ã t?n t?i
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'QuanLyBanHang')
BEGIN
    DROP DATABASE QuanLyBanHang;
END
GO

-- T?o CSDL
CREATE DATABASE QuanLyBanHang;
GO

-- S? d?ng CSDL v?a t?o
USE QuanLyBanHang;
GO

-- T?o b?ng KhachHang
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY IDENTITY(1,1),
    TenKH NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255),
    SoDienThoai VARCHAR(20)
);

-- T?o b?ng SanPham
CREATE TABLE SanPham (
    MaSP INT PRIMARY KEY IDENTITY(1,1),
    TenSP NVARCHAR(100) NOT NULL,
    DonViTinh NVARCHAR(50),
    GiaBan DECIMAL(18, 2) CHECK (GiaBan >= 0)
);

-- T?o b?ng DonHang
CREATE TABLE DonHang (
    MaDH INT PRIMARY KEY IDENTITY(1,1),
    NgayLap DATE NOT NULL,
    MaKH INT,
    TongTien DECIMAL(18, 2) DEFAULT 0,
    CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

-- T?o b?ng ChiTietDonHang
CREATE TABLE ChiTietDonHang (
    MaDH INT,
    MaSP INT,
    SoLuong INT CHECK (SoLuong > 0),
    DonGia DECIMAL(18, 2) CHECK (DonGia >= 0),
    PRIMARY KEY (MaDH, MaSP),
    CONSTRAINT FK_CTDH_DonHang FOREIGN KEY (MaDH) REFERENCES DonHang(MaDH),
    CONSTRAINT FK_CTDH_SanPham FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- Thêm d? li?u vào b?ng KhachHang (7 b?n ghi)
INSERT INTO KhachHang (TenKH, DiaChi, SoDienThoai) VALUES
(N'Nguy?n V?n An', N'123 ???ng ABC, Qu?n 1, TP. H? Chí Minh', '0901234567'),
(N'Tr?n Th? Bình', N'456 ???ng XYZ, Qu?n 2, TP. H? Chí Minh', '0909876543'),
(N'Lê V?n Chính', N'789 ???ng QWE, Qu?n 3, TP. H? Chí Minh', '0912345678'),
(N'Ph?m Th? Duyên', N'101 ???ng DEF, Qu?n 4, TP. H? Chí Minh', '0918765432'),
(N'Hoàng V?n H?ng', N'202 ???ng GHI, Qu?n 5, TP. H? Chí Minh', '0987654321'),
(N'Mai Th? Kim', N'303 ???ng JKL, Qu?n 6, TP. H? Chí Minh', '0976543210'),
(N'V? V?n Long', N'404 ???ng MNO, Qu?n 7, TP. H? Chí Minh', '0965432109');

-- Thêm d? li?u vào b?ng SanPham (7 b?n ghi)
INSERT INTO SanPham (TenSP, DonViTinh, GiaBan) VALUES
(N'Bàn phím c?', N'Cái', 1500000.00),
(N'Chu?t không dây', N'Cái', 500000.00),
(N'Màn hình 27 inch', N'Cái', 4500000.00),
(N'USB 32GB', N'Chi?c', 120000.00),
(N'Tai nghe gaming', N'Cái', 800000.00),
(N'Webcam HD', N'Cái', 650000.00),
(N'? c?ng SSD 500GB', N'Chi?c', 1800000.00);

-- Thêm d? li?u vào b?ng DonHang (7 b?n ghi)
INSERT INTO DonHang (NgayLap, MaKH, TongTien) VALUES
('2023-08-10', 1, 3000000.00), -- ??n hàng 1 c?a Nguy?n V?n An
('2023-08-11', 2, 500000.00),  -- ??n hàng 2 c?a Tr?n Th? Bình
('2023-08-11', 1, 4620000.00), -- ??n hàng 3 c?a Nguy?n V?n An
('2023-08-12', 3, 2300000.00), -- ??n hàng 4 c?a Lê V?n Chính
('2023-08-12', 4, 1800000.00), -- ??n hàng 5 c?a Ph?m Th? Duyên
('2023-08-13', 5, 800000.00),  -- ??n hàng 6 c?a Hoàng V?n H?ng
('2023-08-13', 6, 650000.00);  -- ??n hàng 7 c?a Mai Th? Kim

-- Thêm d? li?u vào b?ng ChiTietDonHang (9 b?n ghi)
INSERT INTO ChiTietDonHang (MaDH, MaSP, SoLuong, DonGia) VALUES
(1, 1, 2, 1500000.00), -- ??n hàng 1: 2 bàn phím c?
(2, 2, 1, 500000.00),  -- ??n hàng 2: 1 chu?t không dây
(3, 3, 1, 4500000.00), -- ??n hàng 3: 1 màn hình 27 inch
(3, 4, 1, 120000.00),  -- ??n hàng 3: 1 USB 32GB
(4, 5, 1, 800000.00),  -- ??n hàng 4: 1 tai nghe gaming
(4, 1, 1, 1500000.00), -- ??n hàng 4: 1 bàn phím c?
(5, 7, 1, 1800000.00), -- ??n hàng 5: 1 ? c?ng SSD
(6, 5, 1, 800000.00),  -- ??n hàng 6: 1 tai nghe gaming
(7, 6, 1, 650000.00);  -- ??n hàng 7: 1 webcam HD
