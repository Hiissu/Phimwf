create database dbQlyPhim

create table Phim
(
id nvarchar(20) primary key not null,
ten nvarchar(50) not null,
theloai nvarchar(50) not null,
quocgia nvarchar(50) not null,
diemdanhgia float,
)

insert into Phim values ('P01', 'Phim01', 'Hanhdong', 'My', 6.5)
insert into Phim values ('P02', 'Phim02', 'Hai', 'Anh', 6.4)
insert into Phim values ('P03', 'Phim03', 'Kinhdi', 'Phap', 8.2)

create table Nhanvien
(
id nvarchar(20) primary key not null,
ten nvarchar(50) not null,
chucvu nvarchar(50) not null,
)

insert into Nhanvien values ('NV01', 'Harry', 'Dienvien')
insert into Nhanvien values ('NV02', 'Lucas', 'Daodien')
insert into Nhanvien values ('NV03', 'Alex', 'Dienvien')
insert into Nhanvien values ('NV04', 'Ana', 'Dienvien')
insert into Nhanvien values ('NV05', 'Lucy', 'Dienvien')
insert into Nhanvien values ('NV06', 'Peter', 'Dienvien')

create table TTPhim
(
id_phim nvarchar(20) not null,
id_nhanvien nvarchar(20)not null,
primary key (id_phim, id_nhanvien),
foreign key (id_phim) references Phim(id),
foreign key (id_nhanvien) references Nhanvien(id)
)


insert into TTPhim values ('P01', 'NV01')
insert into TTPhim values ('P01', 'NV02')
insert into TTPhim values ('P01', 'NV03')
insert into TTPhim values ('P01', 'NV06')

insert into TTPhim values ('P02', 'NV06')
insert into TTPhim values ('P02', 'NV01')
insert into TTPhim values ('P02', 'NV04')
insert into TTPhim values ('P02', 'NV05')

create table Rap
(
id nvarchar(20) primary key not null,
ten nvarchar(50) not null,
diachi nvarchar(50) not null,
)

insert into Rap values ('R01', 'CGV', 'Hanoi')
insert into Rap values ('R02', 'Lotte', 'Hanoi')
insert into Rap values ('R03', 'Galaxy', 'Hanoi')


create table TTRap
(
id_phim nvarchar(20) not null,
id_rap nvarchar(20) not null,
primary key (id_phim, id_rap),
foreign key (id_phim) references Phim(id),
foreign key (id_rap) references Rap(id)
)


insert into TTRap values ('P01', 'R01')
insert into TTRap values ('P02', 'R01')
insert into TTRap values ('P03', 'R01')
insert into TTRap values ('P02', 'R02')
insert into TTRap values ('P03', 'R03')
insert into TTRap values ('P02', 'R03')


SELECT dbo.Nhanvien.ten as ten_NV, dbo.Nhanvien.chucvu,
		dbo.Phim.ten as ten_Phim, dbo.Phim.theloai, dbo.Phim.quocgia, dbo.Phim.diemdanhgia
		FROM dbo.Phim INNER JOIN dbo.TTPhim ON dbo.Phim.id = dbo.TTPhim.id_phim 
						INNER JOIN dbo.Nhanvien ON dbo.TTPhim.id_nhanvien  = dbo.Nhanvien.id 
		 WHERE dbo.Phim.id = 'P01'

SELECT dbo.Phim.ten as ten_Phim, dbo.Phim.theloai, dbo.Phim.quocgia, dbo.Phim.diemdanhgia,
		dbo.Rap.ten as ten_Rap, dbo.Rap.diachi
		FROM dbo.Phim INNER JOIN dbo.TTRap ON dbo.Phim.id = dbo.TTRap.id_phim 
						INNER JOIN dbo.Rap ON dbo.TTRap.id_rap  = dbo.Rap.id 
		 --WHERE dbo.Phim.id = 'P01'
		 WHERE dbo.Rap.id = 'R01'
