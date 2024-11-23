use master;
go 

drop database if exists kinowp6;
go

create database kinowp6 collate Croatian_CI_AS;
go 

use kinowp6;
go


create table dvorane(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null
);

create table film(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
zanr varchar(50)
);

create table projekcija(
sifra int not null primary key identity(1,1),
film int not null references film(sifra),
termin datetime not null,
dvorane int not null references dvorane(sifra),
);

create table gledatelji(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null
);

create table karte(
sifra int not null primary key identity(1,1),
cijena decimal(18,2) not null,
gledatelji int not null references gledatelji(sifra),
projekcija int not null references projekcija(sifra)
);

insert into dvorane (naziv)
values ('A'),
('B'),
('C'),
('D');

insert into film (naziv, zanr)
values ('Proslava','Drama'),
('Dražen','Drama'),
('Divlj Robot','Animirani'),
('Orašar','Opera'),
('Transformers Početak','Animirani'),
('Crveni','Avantura'),
('Heretik','Horor'),
('Fatalna četvorka','Komedija'),

