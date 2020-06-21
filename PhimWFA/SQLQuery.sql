create database QLyPhim

drop table Phim
drop table NhanVien
drop table Rap
drop table TTCT_Phim
drop table TTCT_Rap


create table Phim
(
ma nvarchar(100) primary key not null,
ten nvarchar(100),
theloai nvarchar(100),
quocgia nvarchar(100),
ngaychieu nvarchar(100),
diemdanhgia float
)

delete from Phim

insert into Phim values ('P01', 'Phim A', 'Hanh dong', 'Anh', '11/01/2010', 9.5)
insert into Phim values ('P02', 'Phim A', 'Hanh dong', 'Anh', '11/01/2010', 9.5)
insert into Phim values ('P03', 'Phim A', 'Hanh dong', 'Anh', '11/01/2010', 9.5)
insert into Phim values ('P04', 'Phim A', 'Hanh dong', 'Anh', '11/01/2010', 9.5)
insert into Phim values ('P05', 'Phim A', 'Hanh dong', 'Anh', '11/01/2010', 9.5)


create table NhanVien
(
ma nvarchar(100) primary key not null,
ten nvarchar(100),
ngaysinh nvarchar(100),
noisinh nvarchar(100),
chucvu nvarchar(100)
)

insert into NhanVien values ('NV01', 'Nguyen A', '01/01/2010', 'My', 'Dao dien')
insert into NhanVien values ('NV02', 'Nguyen W', '01/01/2010', 'My', 'Dao dien')
insert into NhanVien values ('NV03', 'Nguyen AS', '01/01/2010', 'My', 'Dien vien')
insert into NhanVien values ('NV04', 'Nguyen D', '01/01/2010', 'My', 'Dien vien')
insert into NhanVien values ('NV05', 'Nguyen B', '01/01/2010', 'My', 'Dien vien')


create table Rap
(
ma nvarchar(100) primary key not null,
ten nvarchar(100),
diachi nvarchar(100)
)

insert into Rap values ('R01', 'Rap A', 'Ha Noi')
insert into Rap values ('R02', 'Rap S', 'Ha Noi')
insert into Rap values ('R03', 'Rap F', 'Ha Noi')
insert into Rap values ('R04', 'Rap R', 'Ha Noi')
insert into Rap values ('R05', 'Rap T', 'Ha Noi')


create table TTCT_Phim
(
id int identity(1, 1) primary key not null,
ma_phim nvarchar(100),
ma_nhanvien nvarchar(100),
foreign key (ma_phim) references Phim(ma),
foreign key (ma_nhanvien) references NhanVien(ma)
)

insert into TTCT_Phim(ma_phim, ma_nhanvien) values ('P01', 'NV01')
insert into TTCT_Phim(ma_phim, ma_nhanvien) values ('P01', 'NV02')
insert into TTCT_Phim(ma_phim, ma_nhanvien) values ('P01', 'NV03')
insert into TTCT_Phim(ma_phim, ma_nhanvien) values ('P01', 'NV04')
insert into TTCT_Phim(ma_phim, ma_nhanvien) values ('P01', 'NV05')

create table TTCT_Rap
(
id int identity(1, 1) primary key not null,
ma_phim nvarchar(100) not null,
ma_rap nvarchar(100) not null,
foreign key (ma_phim) references Phim(ma),
foreign key (ma_rap) references Rap(ma)
)

insert into TTCT_Rap(ma_phim, ma_rap) values ('P01', 'R01')
insert into TTCT_Rap(ma_phim, ma_rap) values ('P02', 'R01')
insert into TTCT_Rap(ma_phim, ma_rap) values ('P03', 'R01')
insert into TTCT_Rap(ma_phim, ma_rap) values ('P04', 'R01')
insert into TTCT_Rap(ma_phim, ma_rap) values ('P05', 'R01')
insert into TTCT_Rap(ma_phim, ma_rap) values ('P01', 'R02')
insert into TTCT_Rap(ma_phim, ma_rap) values ('P01', 'R02')



select Phim.ten, Phim.theloai, Phim.quocgia, NhanVien.ten, NhanVien.chucvu, Rap.ten, Rap.diachi 
from ( select Phim.ten, Phim.theloai, Phim.quocgia, NhanVien.ma, Rap.ma from Phim inner join TTCT_Phim on TTCT_Phim.ma_phim = 'P01' inner join TTCT_Rap on TTCT_Rap.ma_phim = 'P01' ) as P
, (select NhanVien.ten, NhanVien.chucvu from  ), Rap  
Phim.ten, Phim.theloai, Phim.quocgia in ( ) and
NhanVien.ten, NhanVien.chucvu in ( select ten, chucvu from NhanVien inner join TTCT_Phim on NhanVien.ma = TTCT_Phim.ma_nhanvien and

Rap.ten, Rap.diachi  in 
( and 

Rap inner join TTCT_Rap on Rap.ma = TTCT_Rap.ma_rap) 
	



select Phim.ten, Phim.quocgia from 
Phim inner join TTCT_Phim on TTCT_Phim.ma_phim = Phim.ma inner join TTCT_Rap on TTCT_Rap.ma_phim = Phim.ma
where Phim.ma = 'P01'