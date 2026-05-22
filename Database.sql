-- ============================================
-- Quan ly Sieu Thi Mini
-- Chay file nay 1 lan duy nhat tren moi may
-- Mo SSMS -> New Query -> Paste -> F5
-- ============================================

-- Tao database
CREATE DATABASE QLSieuThiMini;
GO

USE QLSieuThiMini;
GO

-- Bang 1: Danh muc hang hoa
CREATE TABLE DanhMuc (
    MaDM    INT PRIMARY KEY IDENTITY(1,1),
    TenDM   NVARCHAR(100) NOT NULL
);
GO

-- Bang 2: Hang hoa trong kho
CREATE TABLE HangHoa (
    MaHang   INT PRIMARY KEY IDENTITY(1,1),
    TenHang  NVARCHAR(150) NOT NULL,
    MaDM     INT FOREIGN KEY REFERENCES DanhMuc(MaDM),
    NgayNhap DATE          NOT NULL DEFAULT GETDATE(),
    SoLuong  INT           NOT NULL DEFAULT 0,
    DonGia   DECIMAL(18,2) NOT NULL,
    XuatXu   NVARCHAR(100)
);
GO

-- Bang 3: San pham dang bay tren ke (Tab A)
CREATE TABLE SanPhamTrenKe (
    MaSP     INT PRIMARY KEY IDENTITY(1,1),
    MaHang   INT FOREIGN KEY REFERENCES HangHoa(MaHang),
    TenSP    NVARCHAR(150) NOT NULL,
    SoLuong  INT           NOT NULL DEFAULT 0,
    DonGia   DECIMAL(18,2) NOT NULL
);
GO

-- Bang 4: Hoa don (Tab B)
CREATE TABLE HoaDon (
    MaHD     INT PRIMARY KEY IDENTITY(1,1),
    NgayBan  DATETIME      NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0
);
GO

-- Bang 5: Chi tiet hoa don
CREATE TABLE ChiTietHD (
    MaCTHD   INT PRIMARY KEY IDENTITY(1,1),
    MaHD     INT FOREIGN KEY REFERENCES HoaDon(MaHD),
    MaSP     INT FOREIGN KEY REFERENCES SanPhamTrenKe(MaSP),
    TenSP    NVARCHAR(150),
    SoLuong  INT           NOT NULL,
    DonGia   DECIMAL(18,2) NOT NULL,
    ThanhTien DECIMAL(18,2) NOT NULL
);
GO

-- Du lieu mau de test
INSERT INTO DanhMuc (TenDM) VALUES 
    (N'Thuc pham'),
    (N'Do uong'),
    (N'Gia dung');

INSERT INTO HangHoa (TenHang, MaDM, SoLuong, DonGia, XuatXu) VALUES
    (N'Gao ST25',       1, 100, 25000, N'Viet Nam'),
    (N'Nuoc Lavie',     2,  50,  6000, N'Viet Nam'),
    (N'Dau an Neptune', 1,  30, 45000, N'Viet Nam');

INSERT INTO SanPhamTrenKe (MaHang, TenSP, SoLuong, DonGia) VALUES
    (1, N'Gao ST25',       50, 25000),
    (2, N'Nuoc Lavie',     30,  6000),
    (3, N'Dau an Neptune', 20, 45000);
GO