create database SalesDB;
go
use SalesDB;
go

create table NhanVien(
	MaNV int identity(1,1) primary key,
	TenNV nvarchar(100) NOT NULL,
	SoDienThoai varchar(15) UNIQUE,
	ChucVu nvarchar(50)
);

create table KhachHang(
	MaKH int identity(1,1) primary key,
	TenKH nvarchar(100) NOT NULL,
	DienThoai varchar(15) UNIQUE,
	DiemTichLuy int default 0
);

create table SanPham(
	MaSP varchar(20) primary key,
	TenSP nvarchar(150) NOT NULL,
	GiaBan decimal(18,2) check (GiaBan > 0),
	SoLuongTon int check (SoLuongTon > 0)
);

create table HoaDon(
	MaHD int identity(1,1) primary key,
	NgayLap datetime default getdate(),
	MaNV int foreign key references NhanVien(MaNV),
	MaKH int NULL foreign key references KhachHang(MaKH),
	TongTien decimal(18,2)
);

create table ChiTietHoaDon(
	MaHD int foreign key references HoaDon(MaHD),
	MaSP varchar(20) foreign key references SanPham(MaSP),
	SoLuong int check (SoLuong > 0),
	DonGia decimal(18,2),
	primary key (MaHD, MaSP)
);

insert into NhanVien values 
(N'Phạm Thị Thu Trang', '0901234567', N'Thu ngân'), 
(N'Trần Hoài Nam', '0907654321', N'Quản lý');
insert into KhachHang values
(N'Lê Văn An', '0988888888', 0), 
(N'Khách Lẻ', '0000000000', 0),
(N'Đỗ Phương An', '0988888899', 0);
insert into SanPham values
('SP01', N'Sữa tươi Vinamilk 1L', 35000, 100), 
('SP02', N'Bánh mì Oishi', 12000, 50), 
('SP03', N'Nước khoáng Lavie 500ml', 7000, 200);
