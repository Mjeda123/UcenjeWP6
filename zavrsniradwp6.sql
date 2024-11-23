use master;
go 

drop database if exists zavrsniradwp6;
go

create database zavrsniradwp6 collate Croatian_CI_AS;
go 

use zavrsniradwp6;
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
termin time not null,
dvorane int not null references dvorane(sifra),
datum date not null
);

create table karte(
sifra int not null primary key identity(1,1),
cijena decimal(18,2) not null,
projekcija int not null references projekcija(sifra)
);

create table gledatelji(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
karte int not null references karte(sifra)
);
