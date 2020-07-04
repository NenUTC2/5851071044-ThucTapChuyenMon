﻿CREATE DATABASE dataSV
GO

USE dataSV
GO
---------------------------------------------TABLE--------------------------------------------------
---------------------------------------------KHOA---------------------------------------------------
CREATE TABLE Khoa(
	MaKhoa VARCHAR(50) PRIMARY KEY,
	TenKhoa NVARCHAR(50) NOT NULL,
	NgayLap DATE
)
GO 
INSERT INTO dbo.Khoa
(
    MaKhoa,
    TenKhoa,
    NgayLap
)
VALUES
(   'CNTT',
    N'Bộ môn Công nghệ thông tin',
    '2016/08/01' 
    )
GO 

---------------------------------------------GIANGVIEN--------------------------------------------------
CREATE TABLE GiangVien(
	MaGV VARCHAR(50) PRIMARY KEY,
	TenGV NVARCHAR(50) NOT NULL,
	SDT VARCHAR(20),
	MaKhoa VARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(MAX),
	NgayDay DATE
)
INSERT INTO dbo.GiangVien
(
    MaGV,
    TenGV,
    SDT,
    MaKhoa,
    DiaChi,
    NgayDay
)
VALUES
(   'GV1',       -- MaGV - varchar(50)
    N'Tran Phong Nha',      -- TenGV - nvarchar(50)
    '123123123',       -- SDT - varchar(20)
    'CNTT',       -- MaKhoa - varchar(50)
    N'abcxyz',      -- DiaChi - nvarchar(max)
    GETDATE() -- NgayDay - date
    )
	GO 
---------------------------------------------LOP--------------------------------------------------
CREATE TABLE Lop(
	MaLop VARCHAR(50) PRIMARY KEY,
	TenLop NVARCHAR(50),
	NgayLap DATE,
	GVCN VARCHAR(50)
)
INSERT INTO dbo.Lop
(
    MaLop,
    TenLop,
    NgayLap,
    GVCN
)
VALUES
(   'CNTT-K58',        -- MaLop - varchar(50)
    N'Công nghệ thông tin K58',       -- TenLop - nvarchar(50)
    GETDATE(), -- NgayLap - date
    'GV1'         -- GVCN - varchar(50)
    )
	GO

---------------------------------------------SINHVIEN--------------------------------------------------
CREATE TABLE SinhVien(
	MaSV VARCHAR(50) PRIMARY KEY,
	TenSV NVARCHAR(50) NOT NULL,
	SDT VARCHAR(20),
	MaLop NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(MAX),
	TichLuy INT
)
INSERT INTO dbo.SinhVien
(
    MaSV,
    TenSV,
    SDT,
    MaLop,
    DiaChi
)
VALUES
(   '20201',  -- MaSV - varchar(50)
    N'Phan Thanh Nen', -- TenSV - nvarchar(50)
    '0708853712',  -- SDT - varchar(20)
    N'CNTT-K58', -- MaLop - nvarchar(50)
    N'999 Le Van Viet'  -- DiaChi - nvarchar(max)
    ) 
	GO 
---------------------------------------------MONHOC--------------------------------------------------
CREATE TABLE MonHoc(
	MaMon INT PRIMARY KEY IDENTITY,
	MaKhoa VARCHAR(50) NOT NULL,
	MaGV VARCHAR(50),
	MaLop VARCHAR(50),
	TinChi INT,
	Phong VARCHAR(20),
	TrangThai INT,
	HocKy NVARCHAR(20)
)
INSERT INTO dbo.MonHoc
(
    MaKhoa,
    MaGV,
    MaLop,
    Phong
)
VALUES
(   'CNTT', -- MaKhoa - varchar(50)
    'GV1', -- MaGV - varchar(50)
    'CNTT-K58', -- MaLop - varchar(50)
    '102C2'  -- Phong - varchar(20)
    )
	GO 
---------------------------------------------CTMON--------------------------------------------------
CREATE TABLE CTMonHoc(
	MaCTMon INT PRIMARY KEY IDENTITY,
	MaMon VARCHAR(50),
	MaSV VARCHAR(50),
	ChuyenCan INT,
	DiemGiuaKy INT,
	DiemTP INT,
	DiemThi INT,
	DiemKT INT,
	KTxTC INT
)
---------------------------------------------END TABLE--------------------------------------------------