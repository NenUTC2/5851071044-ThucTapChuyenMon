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
--DROP TABLE dbo.GiangVien
CREATE TABLE GiangVien(
	MaGV VARCHAR(50) PRIMARY KEY,
	TenGV NVARCHAR(50) NOT NULL,
	SDT VARCHAR(20),
	MaKhoa VARCHAR(50) NOT NULL,
	TruongKhoa VARCHAR(50),
	DiaChi NVARCHAR(MAX),
	NgayDay DATE
)
--SELECT * FROM dbo.GiangVien
INSERT INTO dbo.GiangVien
(
	MaGV,
	TenGV,
	SDT,
	MaKhoa,
	TruongKhoa,
	DiaChi,
	NgayDay
)
VALUES
(   'CNTT-1',       -- MaGV - varchar(50)
	N'Nguyễn Văn A',      -- TenGV - nvarchar(50)
	'0808088776',       -- SDT - varchar(20)
	'CNTT',       -- MaKhoa - varchar(50)
	'CNTT',       -- TruongKhoa - varchar(50)
	N'909 abcvvđ',      -- DiaChi - nvarchar(max)
	GETDATE() -- NgayDay - date
	)
GO 
SELECT TenGV FROM 
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
--DROP TABLE dbo.SinhVien
CREATE TABLE SinhVien(
	MaSV VARCHAR(50) PRIMARY KEY,
	TenSV NVARCHAR(50) NOT NULL,
	SDT VARCHAR(20),
	Email VARCHAR(50),
	MaLop NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(MAX),
	TichLuy FLOAT
)
INSERT INTO dbo.SinhVien
(
    MaSV,
    TenSV,
    SDT,
	Email,
    MaLop,
    DiaChi,
	TichLuy
)
VALUES
(   '20201',  -- MaSV - varchar(50)
    N'Phan Thanh Nen', -- TenSV - nvarchar(50)
    '0708853712',  -- SDT - varchar(20)
	'5851071044@st.utc2.edu.vn',
    N'CNTT-K58', -- MaLop - nvarchar(50)
    N'999 Le Van Viet',  -- DiaChi - nvarchar(max)
	0
    ) 
	GO 
	--SELECT * FROM dbo.SinhVien
---------------------------------------------HocKy--------------------------------------------------

CREATE TABLE HocKy(
	MaHK VARCHAR(20) PRIMARY KEY,
	TenHocKy NVARCHAR(50)
)

CREATE TABLE CTHocKy(
	MaHK VARCHAR(20),
	MaSV VARCHAR(50),
	DiemTichLuy FLOAT,
	id INT

	PRIMARY KEY(MaHK,MaSV)
)

--SELECT * FROM dbo.Lop WHERE CONCAT(MaLop,Makhoa,TenLop) LIKE '%CNTT%'

--SELECT * FROM dbo.CTHocKy
--SELECT SUM(DiemTichLuy) FROM dbo.CTHocKy WHERE MaSV='20201'
--SELECT COUNT(*) FROM dbo.CTHocKy WHERE MaSV='20201'
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
	GO
    SELECT MaCTMon,LopHoc.MaMon,MaGV,MaLop,phong,HocKy,TrangThai FROM dbo.LopHoc, dbo.MonHoc WHERE LopHoc.MaMon=MonHoc.MaMon AND MaKhoa='cntt'
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
SELECT * FROM dbo.LopHoc
---------------------------------------------DIEM LOPHOC--------------------------------------------------
--DROP TABLE dbo.DiemLopHoc
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
--SELECT HocKy, TenMon, DiemKT FROM dbo.DiemLopHoc, dbo.LopHoc, dbo.MonHoc WHERE DiemLopHoc.MaCTMon=LopHoc.MaCTMon AND LopHoc.MaMon=MonHoc.MaMon AND MaSV='20201'
--SELECT TenMon, TinChi,TenGV, Phong FROM dbo.DiemLopHoc, dbo.LopHoc, dbo.MonHoc, dbo.GiangVien 
--WHERE DiemLopHoc.MaCTMon=LopHoc.MaCTMon AND LopHoc.MaMon=MonHoc.MaMon AND LopHoc.MaGV=GiangVien.MaGV AND MaSV='20201'
--SELECT * FROM dbo.DiemLopHoc
--SELECT SUM(KTxTC) FROM dbo.DiemLopHoc WHERE MaSV='20201'
--SELECT SUM(TinChi) FROM dbo.MonHoc, dbo.LopHoc, dbo.DiemLopHoc WHERE LopHoc.MaCTMon=DiemLopHoc.MaCTMon AND LopHoc.MaMon=MonHoc.MaMon AND MaSV='20201'
---------------------------------------------ACCOUNT--------------------------------------------------
--DROP TABLE dbo.Account
CREATE TABLE Account(
	TenDN VARCHAR(50) PRIMARY KEY,
	MatKhau VARCHAR(50),
	Quyen VARCHAR(50),
	Theme VARCHAR(20)
)
INSERT INTO dbo.Account
(
    TenDN,
    MatKhau,
    Quyen,
    Theme
)
VALUES
(   'admin',  -- TenDN - varchar(50)
    '123',  -- MatKhau - varchar(50)
    N'admin', -- Quyen - nvarchar(50)
    'white'   -- Theme - varchar(20)
    )
GO 
---------------------------------------------END TABLE--------------------------------------------------

Select TenSV, Email, DiemTP, DiemKT, TenMon from DiemLopHoc, SinhVien, dbo.MonHoc,dbo.LopHoc WHERE DiemLopHoc.MaCTMon=LopHoc.MaCTMon AND LopHoc.MaMon=MonHoc.MaMon and DiemLopHoc.MaSV=SinhVien.MaSV and DiemLopHoc.MaCTMon='CNTT-API-1'
Select TenMon FROM dbo.MonHoc,dbo.LopHoc WHERE LopHoc.MaMon=MonHoc.MaMon AND LopHoc.MaCTMon='CNTT-API-1'
Select MaHK, DiemTichLuy from CTHocKy where MaSV='20201'