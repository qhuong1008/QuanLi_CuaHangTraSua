CREATE DATABASE QLCUAHANGTRASUA

go

USE QLCUAHANGTRASUA

Go
Create table dbo.LoaiSP(
	MaLoaiSP nvarchar(10) primary key,
	TenLoaiSP nvarchar(50)
)
go

insert into LoaiSP values ('L01', N'Trà sữa')
insert into LoaiSP values ('L02', N'Trà trái cây')
insert into LoaiSP values ('L03', N'Cà phê')
insert into LoaiSP values ('L04', N'Bánh ngọt')
go

Create table dbo.SanPham(
	Stt int IDENTITY(1,1),
	MaSP nvarchar(10) primary key,
	TenSP nvarchar(50) NOT NULL,
	Loai nvarchar(10) NOT NULL,
	Gia int NOT NULL
)
go

Alter table SanPham WITH CHECK ADD FOREIGN KEY(Loai) REFERENCES LoaiSP(MaLoaiSP)
go


insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Trà sữa', 'L01', 30000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Trà sữa trân châu đường đen', 'L01',40000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Trà sữa matcha', 'L01', 35000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Trà sữa chocolate', 'L01', 35000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Trà sữa bạc hà', 'L01', 35000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Trà sữa dâu', 'L01', 35000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Trà sữa việt quốc', 'L01', 35000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Trà chanh', 'L02', 20000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Trà đào', 'L02', 25000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Trà dâu', 'L02', 20000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Trà xoài', 'L02', 20000 )
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Cà phê đen', 'L03', 20000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Cà phê sữa', 'L03', 25000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Bạc xỉu', 'L03', 25000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Mousse chanh dây', 'L04', 30000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Mousse chocolate', 'L04', 30000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Mousse chocomint', 'L04', 30000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Tiramisu việt quốc', 'L04', 30000)
insert into SanPham(MaSP,TenSP,Loai,Gia) values ((select concat('SP',(select(select Max(SanPham.Stt))+1 from SanPham))), N'Tiramisu matcha', 'L04', 30000)
go
select * from SanPham ORDER BY Stt



Create table dbo.NhanVien(
	Stt int IDENTITY(1,1),
	MaNV nvarchar(10) primary key,
	HoTen nvarchar(50) NOT NULL,
	NgaySinh date NOT NULL,
	QueQuan nvarchar(50) NOT NULL,
	Luong int NOT NULL,
	Username nvarchar(50) NOT NULL,
	Pass_word nvarchar(50) NOT NULL,
	Manager bit NOT NULL
)
go
--drop table[NhanVien]


insert into NhanVien(MaNV,HoTen,NgaySinh,QueQuan,Luong,Username,Pass_word,Manager) 
values ((select concat('NV',(select(select Max(NhanVien.Stt))+1 from NhanVien))), N'Nguyễn Quang Linh', '2000-02-01', N'Tiền Giang', 25000000, 'quanly', '88888888', 1)
insert into NhanVien(MaNV,HoTen,NgaySinh,QueQuan,Luong,Username,Pass_word,Manager) 
values ((select concat('NV',(select(select Max(NhanVien.Stt))+1 from NhanVien))), N'Trần Ngô Bích Du', '2002-01-01', N'Tiền Giang', 10000000, 'bichdu', '123456', 0)
insert into NhanVien(MaNV,HoTen,NgaySinh,QueQuan,Luong,Username,Pass_word,Manager) 
values ((select concat('NV',(select(select Max(NhanVien.Stt))+1 from NhanVien))), N'Phạm Quỳnh Hương', '2002-02-02', N'Vũng Tàu', 10000000, 'quynhhuong', '123456', 0)
insert into NhanVien(MaNV,HoTen,NgaySinh,QueQuan,Luong,Username,Pass_word,Manager) 
values ((select concat('NV',(select(select Max(NhanVien.Stt))+1 from NhanVien))), N'Trần Thị Bảo Ngọc', '2002-02-03', N'Bến Tre', 10000000, 'baongoc', '123456', 0)


go

Create table dbo.HoaDon(
	MaHoaDon int IDENTITY(1,1) primary key,
	MaNV nvarchar(10) NOT NULL,
	ThanhTien float ,
	NgayLapDon DATETIME DEFAULT GETDATE(),
)
--drop table[HoaDon]
go

create table dbo.DonHang
(
	MaDH int NOT NULL,
	MaSP nvarchar(10) NOT NULL,
	SoLuong int NOT NULL,
	Gia int NOT NULL,
	GhiChu nvarchar(100)
)
go

Alter table HoaDon WITH CHECK ADD FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)


go
Alter table DonHang WITH CHECK ADD FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP)
Alter table DonHang WITH CHECK ADD FOREIGN KEY(MaDH) REFERENCES HoaDon(MaHoaDon)


if exists (select * from HoaDon where HoaDon.MaHoaDon = 1)	
	insert into DonHang(MaDH,MaSP,SoLuong,Gia,GhiChu) 
	values ((SELECT MAX(MaHoaDon) as Max FROM HoaDon),'SP02', 3, (SELECT Gia from SanPham where SanPham.MaSP = 'SP02'),'Không đá') 
else 
	insert into HoaDon(MaNV,ThanhTien) VALUES ('NV2', 0);
	insert into DonHang(MaDH,MaSP,SoLuong,Gia,GhiChu) 
	values ((SELECT MAX(MaHoaDon) as Max FROM HoaDon),'SP02', 3, (SELECT Gia from SanPham where SanPham.MaSP = 'SP02'),'Không đá')


if not exists (select * from HoaDon where HoaDon.MaHoaDon = 1)	
	insert into HoaDon(MaNV,ThanhTien) VALUES ('NV2', 0)
insert into DonHang(MaDH,MaSP,SoLuong,Gia,GhiChu) 
values ((SELECT MAX(MaHoaDon) as Max FROM HoaDon),'SP05', 3, (SELECT Gia from SanPham where SanPham.MaSP = 'SP05'),'Không đá')

if exists (select DonHang.MaSP from DonHang where DonHang.MaSP = 'SP04')
	delete from DonHang where MaSP = 'SP04'
delete from SanPham WHERE MaSP= 'SP04'