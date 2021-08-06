﻿create database QLTrungTamDayThem
go
use QLTrungTamDayThem
go 

--Tạo bảng admin
create table Adminn
(	
	TaiKhoan varchar(20),
	MatKhau varchar(10),
	ChucVu nvarchar(20),
	Constraint PK_Admin primary key(TaiKhoan)
)

--Tạo bảng Giáo Viên
create table GiaoVien
(
	MaGV varchar(5) not null,
	HoTen nvarchar(20),
	NamSinh date,
	GioiTinh bit,
	DiaChi nvarchar(50),
	ChuyenMon nvarchar(20),
	TrinhDo nvarchar(15),
	SDT varchar(10),
	Constraint PK_GiaoVien primary key(MaGV)
)

--Tạo bảng Lớp Học
create table LopHoc
(
	MaLH varchar(5) not null,
	TenLop varchar(20),
	SiSo int, 	
	Constraint PK_LopHoc primary key(MaLH),		
)

--Tạo bảng Học Viên
create table HocVien
(
	MaHV varchar(6) not null,
	MaLH varchar(5),
	HoTen nvarchar(20),
	NamSinh date,
	GioiTinh bit,
	DiaChi nvarchar(50),
	SDT varchar(10),
	TinhTrang nvarchar(20),
	Constraint PK_HocVien primary key(MaHV),	
	Constraint FK_MaLH_HocVien foreign key(MaLH) references LopHoc(MaLH)
	on update cascade on delete cascade,
)

--Tạo bảng Môn Học
create table MonHoc
(
	MaMH varchar(5) not null,	
	TenMon nvarchar(20),
	MaGV varchar(5) not null,
	MaLH varchar(5),
	ThoiGianHoc nvarchar(20),
	NgayBatDau date,
	NgayKetThuc date,
	
	Constraint PK_MonHoc primary key(MaMH),
	Constraint FK_MaGV_MonHoc foreign key(MaGV) references GiaoVien(MaGV)
	on update cascade on delete cascade,
	Constraint FK_MaLH_MonHoc foreign key(MaLH) references LopHoc(MaLH)
	on update cascade on delete cascade,
)

--Tạo bảng Biên Lai
create table BienLai
(
	MaLH varchar(5) not null,
	MaHV varchar(6) not null,
	HocPhi integer,
	TinhTrang nvarchar(10),
	Constraint FK_MaLH_BienLai foreign key(MaLH) references LopHoc(MaLH),
	Constraint FK_MaHV_BienLai foreign key(MaHV) references HocVien(MaHV)
	on update cascade on delete cascade,
	Constraint  PK_BienLai primary key(MaHV),
)
