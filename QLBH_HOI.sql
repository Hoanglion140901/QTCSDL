USE master;  
GO  
IF DB_ID (N'QLBH_HOI') IS NOT NULL  
DROP DATABASE QLBH_HOI;  
GO  
CREATE DATABASE QLBH_HOI  
go
use QLBH_HOI
go

--TAO BANG NHACUNGCAP
create table NHACUNGCAP
(
	MaNCC varchar(10) primary key,
	TenNCC nvarchar(100) not null,
	SDTNCC varchar(11) not null,
	DiaChiNCC nvarchar(100) not null,
	STK varchar(15)
)

go
--TAO BANG HANGHOA
create table HANGHOA
(
	MaMH varchar(10) primary key,
	TenMH nvarchar(50) not null,
	DonGiaBan  numeric(12,0) not null,
	DonGiaMua  numeric(12,0) not null,
	SL int not null
)
go
--TAO BANG KHACHHANG
create table KHACHHANG
(
	MaKH varchar(10) primary key,
	TenKH nvarchar(50) not null,
	SDT varchar(11),
	DiaChi nvarchar(100),
)
--TAO BANG NHANVIEN
create table NHANVIEN
(
	MaNV varchar(10) primary key,
	TenNV nvarchar(50) not null,
	NgaySinh date not null,
	SDT varchar(11) not null
)
--TAO BANG NHAP
create table NHAP
(
	MAHDN varchar(10) primary key,
	MANCC varchar(10),
	NgayNhap date not null,
	TongTien  numeric(12,0)  not null,
	FOREIGN KEY (MaNCC) REFERENCES NHACUNGCAP(MaNCC)
)
--TAO BANG NHAP_CHI_TIET
create table NHAP_CHI_TIET
(
	MaHDN varchar(10),
	MaMH varchar(10),
	SoLuong int not null,
	ThanhTien  numeric(12,0) not null,
	FOREIGN KEY (MaMH) REFERENCES HANGHOA(MaMH),
	FOREIGN KEY (MaHDN) REFERENCES NHAP(MaHDN)
)
--TAO BANG BAN
create table BAN
(
	MaHDB varchar(10) primary key,
	MaNV varchar(10),
	MaKH varchar(10),
	NgayBH date not null,
	TongTien numeric(12,0) not null,
	FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV),
	FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
)
--TAO BANG BAN_CHI_TIET
create table BAN_CHI_TIET
(
	MaHDB varchar(10),
	MaMH varchar(10),
	SoLuong int not null,
	ThanhTien numeric(12,0)  not null,
	FOREIGN KEY (MaMH) REFERENCES HANGHOA(MaMH),
	FOREIGN KEY (MaHDB) REFERENCES BAN(MaHDB)
)





Create table TAIKHOAN
(
TenDangNhap nvarchar(100) primary key,
MatKhau nvarchar(1000) not null default 0
)
insert into TAIKHOAN values('Nhom5', 'abc123')

--R9
go
Create proc sp_Login @username varchar(100), @password varchar(100)
As 
Begin
	select * from TAIKHOAN where TenDangNhap = @username And MatKhau = @password
End
drop proc sp_Login
--'or 1=1--






