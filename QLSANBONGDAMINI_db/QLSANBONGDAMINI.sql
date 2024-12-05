CREATE DATABASE QLSanBongDaMini;
GO

USE QLSanBongDaMini;
GO

CREATE TABLE Quyen (
    MaQuyen CHAR(10) PRIMARY KEY,
    TenQuyen NVARCHAR(50)
);

CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(50),
    Email CHAR(100) NULL,
    SoDienThoai CHAR(20) UNIQUE,
    MatKhau CHAR(50), 
    MaQuyen CHAR(10),
    FOREIGN KEY (MaQuyen) REFERENCES Quyen(MaQuyen)
);

CREATE TABLE LoaiSan (
    MaLoaiSan CHAR(20) PRIMARY KEY,
    TenLoaiSan NVARCHAR(50),
    GiaTrenGio INT
);

CREATE TABLE San (
    MaSan CHAR(20) PRIMARY KEY,
    TenSan NVARCHAR(50),
    DangSuaChua BIT,
    MaLoaiSan CHAR(20),
    FOREIGN KEY (MaLoaiSan) REFERENCES LoaiSan(MaLoaiSan)
);

CREATE TABLE DatSan (
    MaDatSan INT IDENTITY(1,1) PRIMARY KEY,
    NgayDatSan DATE,
    GioBatDau INT,
    GioKetThuc INT,
    HoTen NVARCHAR(200) NULL,
    SDTLienLac CHAR(20) NULL,
    TongTien INT,
    DaThanhToan BIT, 
    DaHuy BIT,
    MaTaiKhoan INT,
    MaSan CHAR(20),
    FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan),
    FOREIGN KEY (MaSan) REFERENCES San(MaSan)
);

CREATE TABLE ReportThongKe (
    NgayThongKe DATE,
    TongTienThuDuoc INT,
    ChuaThanhToan INT,
    SoLuongSanBai INT,
    SoLuongDatSan INT,
    SoLuongHuyDatSan INT,
    SanDatNhieuNhat NVARCHAR(200),
	MAHD INT NOT NULL,
	FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
);
CREATE TABLE HOADON(
	MAHD INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	NGAYHD DATE,
	THANHTIEN INT,
	MaDatSan INT,
	SDT CHAR(13),
	FOREIGN KEY (MaDatSan) REFERENCES DatSan(MaDatSan),
)


-- Insert data into Quyen table
INSERT INTO Quyen
VALUES
    ('staff', N'Quyền nhân viên'),
    ('owner', N'Quyền quản lý');

-- Insert data into TaiKhoan table
INSERT INTO TaiKhoan (HoTen, Email, SoDienThoai, MatKhau, MaQuyen)
VALUES
    (N'Nguyễn Văn Thịnh', 'thinh@gmail.com', '9876543210', '123456', 'staff'),
    (N'Phạm Văn Đông', 'dong@gmail.com', '0856721594', '55555', 'staff'),
    (N'Vương Văn Chương', 'chuong@gmail.com', '0378564825', '222222', 'staff'),
    (N'Lê Văn Danh', 'danh@gmail.com', '0347945363', '333333', 'staff'),
    (N'Văn Admin', 'admin@gmail.com', '0123456789', '123456', 'owner');

-- Insert data into LoaiSan table
INSERT INTO LoaiSan (MaLoaiSan, TenLoaiSan, GiaTrenGio)
VALUES
    ('LS5', N'Sân 5 người', 400000),
    ('LS7', N'Sân 7 người', 600000);

-- Insert data into San table
INSERT INTO San (MaSan, TenSan, DangSuaChua, MaLoaiSan)
VALUES
    ('S01', N'Sân bóng 01', 0, 'LS5'),
    ('S02', N'Sân bóng 02', 0, 'LS5'),
    ('S03', N'Sân bóng 03', 1, 'LS7'),
    ('S04', N'Sân bóng 04', 0, 'LS5'),
    ('S05', N'Sân bóng 05', 1, 'LS7'),
    ('S06', N'Sân bóng 06', 0, 'LS5'),
    ('S07', N'Sân bóng 07', 0, 'LS5'),
    ('S08', N'Sân bóng 08', 0, 'LS7'),
    ('S09', N'Sân bóng 09', 0, 'LS5'),
    ('S10', N'Sân bóng 10', 1, 'LS7');

-- Insert data into DatSan table
INSERT INTO DatSan (NgayDatSan, GioBatDau, GioKetThuc, HoTen, SDTLienLac, TongTien, DaThanhToan, DaHuy, MaTaiKhoan, MaSan)
VALUES
    ('2023-08-01', 16, 17, N'Nguyễn Văn Huy', '9876543210', 400000, 1, 0, 1, 'S01'),
    ('2023-08-02', 16, 17, N'Nguyễn Văn Bách', '5465175522', 400000, 1, 0, 1, 'S01'),
    ('2023-09-03', 16, 17, N'Nguyễn Văn Vinh', '7851224282', 400000, 1, 0, 1, 'S01'),
    ('2023-09-04', 16, 17, N'Huỳnh Văn Lâm', '1548185155', 400000, 0, 1, 2, 'S02'),
    ('2023-09-04', 16, 17, N'Huỳnh Xuân Phước', '1681525155', 400000, 1, 1, 3, 'S04'),
    ('2023-09-06', 16, 17, N'Lê Văn Tuấn', '5421288222', 400000, 0, 0, 3, 'S04'),
    ('2023-09-06', 18, 19, N'Nguyễn Văn Giang', '1584251585', 600000, 1, 0, 1, 'S05'),
    ('2023-09-06', 20, 21, N'Nguyễn Xuân Lộc', '8543258242', 600000, 1, 0, 1, 'S05'),
    ('2023-09-10', 16, 17, N'Lê Anh', '1681525155', 400000, 1, 1, 3, 'S04'),
    ('2023-09-11', 16, 17, N'Nguyễn Khoa Kiệt', '5421288222', 400000, 0, 0, 3, 'S04'),
    ('2023-09-12', 18, 19, N'Đỗ Hoàng Bảo', '1584251585', 600000, 1, 0, 1, 'S05');

CREATE VIEW TongTien AS
select NgayDatSan,sum(TongTien) as 'Tổng Tiền Thu Được'
from DatSan
group by NgayDatSan

--select [Tổng Tiền Thu Được] from TongTien 

create view ChuaThanhToan as
select NgayDatSan,count (DaThanhToan) as N'Chưa Thanh Toán'
from DatSan
where DaThanhToan=0
group by NgayDatSan
--select* from ChuaThanhToan 

create view SLSan as
select count(*) as'Số Lượng Sân Bãi'
from San


create view SLDatSan as		
select NgayDatSan,count(DaHuy) as N'Số Lượng Đặt Sân'
from DatSan
group by NgayDatSan
--select* from SlDatSan where NgayDatSan='2023-09-03'

create view HuySan as
select NgayDatSan,count(DaHuy) as N'Đã Hủy'
from DatSan
where DaHuy=1 
group by NgayDatSan


--select * from TopSan
CREATE VIEW TopSan AS
SELECT
    ds.NgayDatSan,
    s.TenSan
FROM
    DatSan ds
JOIN
    San s ON ds.MaSan = s.MaSan
GROUP BY
    ds.NgayDatSan,
    s.TenSan
HAVING
    COUNT(*) = (
        SELECT
            MAX(CountPerDay)
        FROM (
            SELECT
                ds2.NgayDatSan,
                s2.TenSan,
                COUNT(*) AS CountPerDay
            FROM
                DatSan ds2
            JOIN
                San s2 ON ds2.MaSan = s2.MaSan
            GROUP BY
                ds2.NgayDatSan,
                s2.TenSan
        ) AS SubQuery
        WHERE
            SubQuery.NgayDatSan = ds.NgayDatSan
    );

CREATE TRIGGER THEMHOADON ON DATSAN
FOR INSERT
AS
BEGIN
	DECLARE @NGAYHD DATE,@THANHTIEN FLOAT,@MADATSAN CHAR(10),@SDT CHAR(13)
	SELECT @NGAYHD=NGAYDATSAN,@THANHTIEN=TONGTIEN,@MADATSAN=MaDatSan,@SDT=SDTLienLac FROM DatSan WHERE MaDatSan=(SELECT MaDatSan FROM inserted)
	INSERT INTO HOADON(NGAYHD,THANHTIEN,MaDatSan,SDT)
	VALUES(@NGAYHD,@THANHTIEN,@MADATSAN,@SDT)

END

CREATE TRIGGER CAPNHATHOADON ON DATSAN
FOR UPDATE
AS
BEGIN
	DECLARE @NGAYHD DATE,@THANHTIEN FLOAT,@MADATSAN CHAR(10),@SDT CHAR(13)
	SELECT @NGAYHD=NGAYDATSAN,@THANHTIEN=TONGTIEN,@MADATSAN=MaDatSan,@SDT=SDTLienLac FROM DatSan WHERE MaDatSan=(SELECT MaDatSan FROM inserted)
	UPDATE HOADON
	SET NGAYHD=@NGAYHD,THANHTIEN=@THANHTIEN,MADATSAN=@MADATSAN,SDT=@SDT
	WHERE MaDatSan=(SELECT MaDatSan FROM inserted)
END

CREATE TRIGGER XOAHOADON ON DATSAN
FOR DELETE
AS
BEGIN
	DELETE FROM HOADON WHERE MADATSAN=(SELECT MaDatSan FROM inserted)
END