-- Ki?m tra v� x�a c? s? d? li?u n?u ?� t?n t?i
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

-- Th�m d? li?u v�o b?ng KhachHang (7 b?n ghi)
INSERT INTO KhachHang (TenKH, DiaChi, SoDienThoai) VALUES
(N'Nguy?n V?n An', N'123 ???ng ABC, Qu?n 1, TP. H? Ch� Minh', '0901234567'),
(N'Tr?n Th? B�nh', N'456 ???ng XYZ, Qu?n 2, TP. H? Ch� Minh', '0909876543'),
(N'L� V?n Ch�nh', N'789 ???ng QWE, Qu?n 3, TP. H? Ch� Minh', '0912345678'),
(N'Ph?m Th? Duy�n', N'101 ???ng DEF, Qu?n 4, TP. H? Ch� Minh', '0918765432'),
(N'Ho�ng V?n H?ng', N'202 ???ng GHI, Qu?n 5, TP. H? Ch� Minh', '0987654321'),
(N'Mai Th? Kim', N'303 ???ng JKL, Qu?n 6, TP. H? Ch� Minh', '0976543210'),
(N'V? V?n Long', N'404 ???ng MNO, Qu?n 7, TP. H? Ch� Minh', '0965432109');

-- Th�m d? li?u v�o b?ng SanPham (7 b?n ghi)
INSERT INTO SanPham (TenSP, DonViTinh, GiaBan) VALUES
(N'B�n ph�m c?', N'C�i', 1500000.00),
(N'Chu?t kh�ng d�y', N'C�i', 500000.00),
(N'M�n h�nh 27 inch', N'C�i', 4500000.00),
(N'USB 32GB', N'Chi?c', 120000.00),
(N'Tai nghe gaming', N'C�i', 800000.00),
(N'Webcam HD', N'C�i', 650000.00),
(N'? c?ng SSD 500GB', N'Chi?c', 1800000.00);

-- Th�m d? li?u v�o b?ng DonHang (7 b?n ghi)
INSERT INTO DonHang (NgayLap, MaKH, TongTien) VALUES
('2023-08-10', 1, 3000000.00), -- ??n h�ng 1 c?a Nguy?n V?n An
('2023-08-11', 2, 500000.00),  -- ??n h�ng 2 c?a Tr?n Th? B�nh
('2023-08-11', 1, 4620000.00), -- ??n h�ng 3 c?a Nguy?n V?n An
('2023-08-12', 3, 2300000.00), -- ??n h�ng 4 c?a L� V?n Ch�nh
('2023-08-12', 4, 1800000.00), -- ??n h�ng 5 c?a Ph?m Th? Duy�n
('2023-08-13', 5, 800000.00),  -- ??n h�ng 6 c?a Ho�ng V?n H?ng
('2023-08-13', 6, 650000.00);  -- ??n h�ng 7 c?a Mai Th? Kim

-- Th�m d? li?u v�o b?ng ChiTietDonHang (9 b?n ghi)
INSERT INTO ChiTietDonHang (MaDH, MaSP, SoLuong, DonGia) VALUES
(1, 1, 2, 1500000.00), -- ??n h�ng 1: 2 b�n ph�m c?
(2, 2, 1, 500000.00),  -- ??n h�ng 2: 1 chu?t kh�ng d�y
(3, 3, 1, 4500000.00), -- ??n h�ng 3: 1 m�n h�nh 27 inch
(3, 4, 1, 120000.00),  -- ??n h�ng 3: 1 USB 32GB
(4, 5, 1, 800000.00),  -- ??n h�ng 4: 1 tai nghe gaming
(4, 1, 1, 1500000.00), -- ??n h�ng 4: 1 b�n ph�m c?
(5, 7, 1, 1800000.00), -- ??n h�ng 5: 1 ? c?ng SSD
(6, 5, 1, 800000.00),  -- ??n h�ng 6: 1 tai nghe gaming
(7, 6, 1, 650000.00);  -- ??n h�ng 7: 1 webcam HD
