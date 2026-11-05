create database HRMDB;
go
use HRMDB;
go

create table PhongBan(
	MaPB int identity(1,1) primary key,
	TenPB nvarchar(100) NOT NULL,
	MoTa nvarchar(255)
);

create table NhanVien(
	MaNV int identity(1,1) primary key,
	HoTen nvarchar(100) NOT NULL,
	NgaySinh datetime,
	CCCD varchar(20) UNIQUE,
	MaPB int foreign key references PhongBan(MaPB),
	LuongCoBan decimal(18,2) check (LuongCoBan > 0),
	HeSoLuong float default 1.0
);

create table BangChamCong(
	MaCong int identity(1,1) primary key,
    MaNV int foreign key references NhanVien(MaNV),
    ThangNam varchar(7),
    SoNgayCong float check (SoNgayCong <= 31),
    SoGioOT float default 0,
    constraint UC_ChamCong UNIQUE (MaNV, ThangNam)
);

create table BangLuong(
	MaLuong int identity(1,1) primary key,
    MaNV int foreign key references NhanVien(MaNV),
    ThangNam varchar(7),
    ThucLinh decimal(18,2),
    constraint UC_BangLuong UNIQUE (MaNV, ThangNam)
);

insert into PhongBan values 
(N'Phòng Hành chính', N'Quản lý nhân sự'), 
(N'Phòng Kỹ thuật', N'Phát triển phần mềm');
insert into NhanVien values
(N'Nguyễn Văn Chan', '1995-05-10', '012345678901', 1, 10000000, 1.2), 
(N'Phạm Thị Than', '1998-08-20', '012345678902', 2, 12000000, 1.5);
