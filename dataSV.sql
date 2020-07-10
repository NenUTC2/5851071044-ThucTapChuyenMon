CREATE DATABASE dataSV
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
SELECT * FROM dbo.GiangVien
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
--DROP TABLE dbo.Lop
CREATE TABLE Lop(
	MaLop VARCHAR(50) PRIMARY KEY,
	TenLop NVARCHAR(50),
	NgayLap DATE,
	GVCN VARCHAR(50),
	Makhoa VARCHAR(50)
)
INSERT INTO dbo.Lop
(
    MaLop,
    TenLop,
    NgayLap,
    GVCN,
	MaKhoa
)
VALUES
(   'CNTT-K58',        -- MaLop - varchar(50)
    N'Công nghệ thông tin K58',       -- TenLop - nvarchar(50)
    GETDATE(), -- NgayLap - date
    'GV1',         -- GVCN - varchar(50)
	'CNTT'
    )
	GO

---------------------------------------------SINHVIEN--------------------------------------------------
DROP TABLE dbo.SinhVien
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
    DiaChi,
	TichLuy
)
VALUES
(   '20201',  -- MaSV - varchar(50)
    N'Phan Thanh Nen', -- TenSV - nvarchar(50)
    '0708853712',  -- SDT - varchar(20)
    N'CNTT-K58', -- MaLop - nvarchar(50)
    N'999 Le Van Viet',  -- DiaChi - nvarchar(max)
	0
    ) 
	GO 
---------------------------------------------HocKy--------------------------------------------------

CREATE TABLE HocKy(
	MaHK VARCHAR(20) PRIMARY KEY,
	TenHocKy NVARCHAR(50)
)

CREATE TABLE CTHocKy(
	MaHK VARCHAR(20),
	MaSV VARCHAR(50),
	DiemTichLuy INT 

	PRIMARY KEY(MaHK,MaSV)
)

---------------------------------------------MONHOC--------------------------------------------------
--DROP TABLE dbo.MonHoc
CREATE TABLE MonHoc(
	MaMon VARCHAR(50) PRIMARY KEY,
	TenMon NVARCHAR(50),
	MaKhoa VARCHAR(50) NOT NULL,
	TinChi INT
)
INSERT INTO dbo.MonHoc
(
    MaMon,
    TenMon,
    MaKhoa,
    TinChi
)
VALUES
(   'CNTT-ThucTapChuyenMon',  -- MaMon - varchar(50)
    N'Thực tập chuyên môn', -- TenMon - nvarchar(50)
    'CNTT',  -- MaKhoa - varchar(50)
    3    -- TinChi - int
    )
---------------------------------------------LOPMON--------------------------------------------------
--DROP TABLE LopHoc
CREATE TABLE LopHoc(
	MaCTMon VARCHAR(60) PRIMARY KEY,
	MaMon VARCHAR(50),
	MaGV VARCHAR(50),
	MaLop VARCHAR(50),
	Phong VARCHAR(20),
	HocKy VARCHAR(20),
	TrangThai INT
)
---------------------------------------------DIEM LOPHOC--------------------------------------------------
DROP TABLE dbo.DiemLopHoc
CREATE TABLE DiemLopHoc(
	MaCTMon VARCHAR(50),
	MaSV VARCHAR(50),
	ChuyenCan FLOAT,
	DiemGiuaKy FLOAT,
	DiemTP FLOAT,
	DiemThi FLOAT,
	DiemKT FLOAT,
	KTxTC FLOAT

	PRIMARY KEY(MaSV,MaCTMon)
)

SELECT TinChi FROM dbo.MonHoc, dbo.LopHoc, dbo.DiemLopHoc WHERE LopHoc.MaCTMon=DiemLopHoc.MaCTMon AND LopHoc.MaMon=MonHoc.MaMon AND MaSV
---------------------------------------------ACCOUNT--------------------------------------------------
CREATE TABLE Account(
	TenDN VARCHAR(50) PRIMARY KEY,
	MatKhau VARCHAR(50),
	MaGV VARCHAR(50),
	Quyen NVARCHAR(50),
	Theme VARCHAR(20)
)
---------------------------------------------END TABLE--------------------------------------------------