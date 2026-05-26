CREATE DATABASE QLSieuThi

USE QLSieuThi


create table SanPhamTrongKho 
(
	MaSP VARCHAR(20) not null PRIMARY KEY,
	TenSP NVARCHAR(100) not null,
	SoLuongTrongKho INT not null
	check ( SoLuongTrongKho >= 0)
);

create table SanPhamDangBan
(
	MaSP VARCHAR(20) not null PRIMARY KEY,
	SoLuongDangBan INT not null check ( SoLuongDangBan >= 0),
	GiaBan INT not null check ( GiaBan > 0)
	Constraint FK_SanPhamDangBan_SanPhamTrongKho
		Foreign Key (MaSP)
		References SanPhamTrongKho(MaSP)
)

create table HoaDon
(
    MaHD VARCHAR(20) PRIMARY KEY,
    NgayIn DATETIME NOT NULL
        DEFAULT GETDATE(),
    TongTien INT NOT NULL
        CHECK (TongTien >= 0)
);

create table LichSuNhapHang
(
    MaPN VARCHAR(20) not null PRIMARY KEY,
    MaSP VARCHAR(20) not null,
    TenSP NVARCHAR(100) not null,
    SoLuongNhap INT not null
        CHECK (SoLuongNhap > 0),
    NgayNhap DATETIME not null
        DEFAULT GETDATE(),
    GiaNhap INT not null
        CHECK (GiaNhap > 0),

    CONSTRAINT FK_LichSuNhapHang_SanPhamTrongKho
        FOREIGN KEY (MaSP)
        REFERENCES SanPhamTrongKho(MaSP)
)

INSERT INTO SanPhamTrongKho
VALUES ('SP004', N'Mì Hảo Hảo', 100);
INSERT INTO LichSuNhapHang
VALUES ('PN001', 'SP004', N'Mì Hảo Hảo', 100, GETDATE(), 3500);

SELECT * FROM LichSuNhapHang;