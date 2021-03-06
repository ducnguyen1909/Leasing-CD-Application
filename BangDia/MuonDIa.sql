create database MuonDia
use MuonDia

create table KhachHang
(
	MaKH int identity(1,1) primary key,
	TenKH nvarchar(100) not null,
	CMND int not null,
	DiaChi varchar(100),
	DT varchar(20)
)

create table BangDia
(
	MaBang int identity(1,1) primary key,
	TuaDe nvarchar(100) not null,
	ChuDe nvarchar(100),
	TacGia nvarchar(100),
	SoLuong int not null,
	DonGia money not null
)

create table HSMuon
(
	MaHSMuon int identity(1,1) primary key,
	NgayMuon Date not null,
	NgayDuKien Date not null,
	MaKH int,
	DaTra bit,
	--MaBang varchar(50)not null,
	--CONSTRAINT FK_MaBang FOREIGN KEY (MaBang) REFERENCES BangDia(MaBang),
	CONSTRAINT FK_MaKH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
)

create table HSMuon_BangDia
(
	MaHSMuon int not null,
	MaBang int not null,
	SoLuongMua int not null,
	--CONSTRAINT MaHSMuon_MaBang_pk PRIMARY KEY(MaHSMuon,MaBang),
	CONSTRAINT FK_MaHSMuon FOREIGN KEY (MaHSMuon) REFERENCES HSMuon(MaHSMuon),
	CONSTRAINT FK_MaBang FOREIGN KEY (MaBang) REFERENCES BangDia(MaBang)

)

create table DoanhThu
(
	MaDT int identity(1,1) primary key,
	NgayTra date not null,
	TongTien money not null,
	MaHSMuon int,
	CONSTRAINT FK_MaHSMuon_DoanhThu FOREIGN KEY (MaHSMuon) REFERENCES HSMuon(MaHSMuon),
)

create table TaiKhoan
(
	MaTK int identity(1,1) primary key,
	TenTK nvarchar(100),
	TenDN varchar(50) not null,
	MatKhau varchar(50) not null
	
)

select * from HSMuon

insert into KhachHang values(N'Đức',24568763,'Q7','090-5243-223')
insert into KhachHang values('Huy',334253434,'Q7','090-5243-223')
insert into KhachHang values(N'Quân',245823553,'Q7','090-5243-223')

insert into BangDia values('Caption American',N'Phim Hành Động','VHQ',15,40000)
insert into BangDia values('Hulk',N'Phim Hành Động','VHQ',10,30000)
insert into BangDia values('The Avengers American',N'Phim Hành Động','VHQ',5,10000)
insert into BangDia values('Tom and Jerry',N'Phim Hoạt Hình','VHQ',20,50000)

insert into TaiKhoan values(N'Đức','ducnguyen','123456')
insert into TaiKhoan values(N'Văn','van','123456')