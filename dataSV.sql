CREATE DATABASE dataSV
GO

USE dataSV
GO
---------------------------------------------TABLE--------------------------------------------------
---------------------------------------------KHOA---------------------------------------------------
CREATE TABLE Khoa(
	MaKhoa VARCHAR(50) PRIMARY KEY,
	TenKhoa NVARCHAR(50) NOT NULL
)
GO 
INSERT INTO dbo.Khoa
(
    MaKhoa,
    TenKhoa
)
VALUES
(   'BM-CNTT',
    N'Bộ môn Công nghệ thông tin'
    )
GO 
---------------------------------------------KHOA---------------------------------------------------
--DROP TABLE Nganh
CREATE TABLE Nganh(
	MaNganh VARCHAR(50) PRIMARY KEY,
	TenNganh NVARCHAR(50),
	MaKhoa VARCHAR(50)
)
INSERT INTO dbo.Nganh
(
    MaNganh,
	TenNganh,
	MaKhoa
)
VALUES
(   'CNTT',
    N'Công nghệ thông tin',
	'BM-CNTT'
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
	DiaChi NVARCHAR(MAX)
)
Select MaKhoa from Nganh where MaNganh='CNTT'
--SELECT * FROM dbo.GiangVien
INSERT INTO dbo.GiangVien
(
	MaGV,
	TenGV,
	SDT,
	MaKhoa,
	TruongKhoa,
	DiaChi
)
VALUES
(   'CNTT-1',       -- MaGV - varchar(50)
	N'Nguyễn Văn A',      -- TenGV - nvarchar(50)
	'0808088776',       -- SDT - varchar(20)
	'BM-CNTT',       -- MaKhoa - varchar(50)
	'BM-CNTT',       -- TruongKhoa - varchar(50)
	N'909 abcvvđ'      -- DiaChi - nvarchar(max)
	)
GO 
---------------------------------------------LOP--------------------------------------------------
--DROP TABLE dbo.Lop
CREATE TABLE Lop(
	MaLop VARCHAR(50) PRIMARY KEY,
	TenLop NVARCHAR(50),
	NgayLap DATE,
	GVCN VARCHAR(50),
	MaNganh VARCHAR(50)
)
INSERT INTO dbo.Lop
(
    MaLop,
    TenLop,
    NgayLap,
    GVCN,
	MaNganh
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
	TichLuy FLOAT,
	SoKy INT 
)
INSERT INTO dbo.SinhVien
(
    MaSV,
    TenSV,
    SDT,
	Email,
    MaLop,
    DiaChi,
	TichLuy,
	SoKy
)
VALUES
(   '20201',  -- MaSV - varchar(50)
    N'Phan Thanh Nen', -- TenSV - nvarchar(50)
    '0708853712',  -- SDT - varchar(20)
	'5851071044@st.utc2.edu.vn',
    N'CNTT-K58', -- MaLop - nvarchar(50)
    N'999 Le Van Viet',  -- DiaChi - nvarchar(max)
	0,
	0
    ) 
	GO 
	--SELECT * FROM dbo.SinhVien
---------------------------------------------HocKy--------------------------------------------------
--DROP TABLE dbo.HocKy
CREATE TABLE HocKy(
	MaHK VARCHAR(20) PRIMARY KEY,
	TenHocKy NVARCHAR(50),
	TrangThai INT
)

--DROP TABLE dbo.CTHocKy
CREATE TABLE CTHocKy(
	MaHK VARCHAR(20),
	MaSV VARCHAR(50),
	DiemTichLuy FLOAT

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
	MaNganh VARCHAR(50) NOT NULL,
	TinChi INT,
	SoKy INT 
)
INSERT INTO dbo.MonHoc
(
    MaMon,
    TenMon,
    MaNganh,
    TinChi,
	SoKy
)
VALUES
(   'CNTT-ThucTapChuyenMon',  -- MaMon - varchar(50)
    N'Thực tập chuyên môn', -- TenMon - nvarchar(50)
    'CNTT',  -- MaKhoa - varchar(50)
    3,   -- TinChi - int
	1
    )
	GO
    --SELECT MaCTMon,LopHoc.MaMon,MaGV,MaLop,phong,HocKy,TrangThai FROM dbo.LopHoc, dbo.MonHoc WHERE LopHoc.MaMon=MonHoc.MaMon AND MaKhoa='cntt'
---------------------------------------------LopHocPhan--------------------------------------------------
--DROP TABLE LopHocPhan
CREATE TABLE LopHocPhan(
	MaHP VARCHAR(50) PRIMARY KEY,
	MaMon VARCHAR(50),
	MaGV VARCHAR(50),
	MaLop VARCHAR(50),
	Phong VARCHAR(20),
	HocKy VARCHAR(20),
	TrangThai INT
)
--SELECT * FROM dbo.LopHoc
---------------------------------------------DIEMHOCPHAN--------------------------------------------------
--DROP TABLE dbo.DiemHocPhan
CREATE TABLE DiemHocPhan(
	MaHP VARCHAR(50),
	MaSV VARCHAR(50),
	ChuyenCan FLOAT,
	DiemGiuaKy FLOAT,
	DiemTP FLOAT,
	DiemThi FLOAT,
	DiemKT FLOAT,
	KTxTC FLOAT,
	Tra INT

	PRIMARY KEY(MaSV,MaHP)
)
--SELECT * FROM dbo.LopHocPhan
--Select MonHoc.MaMon,TenMon from MonHoc where MaNganh='CNTT' and SoKy=1  
--UNION ALL
--Select MonHoc.MaMon,TenMon from MonHoc,dbo.LopHocPhan,dbo.DiemHocPhan WHERE DiemKT<4 AND DiemHocPhan.MaHP=LopHocPhan.MaHP AND LopHocPhan.MaMon=MonHoc.MaMon AND Tra=0 AND MaSV='20201';
--SELECT HocKy, TenMon, DiemKT FROM dbo.DiemLopHoc, dbo.LopHoc, dbo.MonHoc WHERE DiemLopHoc.MaCTMon=LopHoc.MaCTMon AND LopHoc.MaMon=MonHoc.MaMon AND MaSV='20201'
--SELECT TenMon, TinChi,TenGV, Phong FROM dbo.DiemLopHoc, dbo.LopHoc, dbo.MonHoc, dbo.GiangVien 
--WHERE DiemLopHoc.MaCTMon=LopHoc.MaCTMon AND LopHoc.MaMon=MonHoc.MaMon AND LopHoc.MaGV=GiangVien.MaGV AND MaSV='20201'
--SELECT * FROM dbo.DiemLopHoc
--SELECT SUM(KTxTC) FROM dbo.DiemLopHoc WHERE MaSV='20201'
--SELECT SUM(TinChi) FROM dbo.MonHoc, dbo.LopHoc, dbo.DiemLopHoc WHERE LopHoc.MaCTMon=DiemLopHoc.MaCTMon AND LopHoc.MaMon=MonHoc.MaMon AND MaSV='20201'
---------------------------------------------ACCOUNT--------------------------------------------------
--DROP TABLE dbo.Account
--DELETE FROM dbo.DiemHocPhan
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
--DELETE FROM dbo.Account
--Select TenSV, Email, DiemTP, DiemKT, TenMon from DiemLopHoc, SinhVien, dbo.MonHoc,dbo.LopHoc WHERE DiemLopHoc.MaCTMon=LopHoc.MaCTMon AND LopHoc.MaMon=MonHoc.MaMon and DiemLopHoc.MaSV=SinhVien.MaSV and DiemLopHoc.MaCTMon='CNTT-API-1'
--Select TenMon FROM dbo.MonHoc,dbo.LopHoc WHERE LopHoc.MaMon=MonHoc.MaMon AND LopHoc.MaCTMon='CNTT-API-1'
--Select MaHK, DiemTichLuy from CTHocKy where MaSV='20201'