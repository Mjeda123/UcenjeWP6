--use edunovawp6;

use master;
go

drop database if exists edunovawp6;
go

create database edunovawp6;
go

use edunovawp6;
go

--create database zoo;

--use zoo;

--create table zivotinja(
--sifra int,
--vrsta varchar(50),
--ime varchar(50),
--djelatnik int,
--prostorija int,
--datum int
--);

--drop table zivotinja;

create table zivotinja(
sifra int not null primary key identity(1,1),
vrsta varchar(50),
ime varchar(50),
djelatnik int references djelatnik(sifra),
prostorija int references prostorija(sifra),
datum int references datum(sifra)
);

drop table zivotinja;

create table djelatnik(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(50),
iban varchar(50)
);

create table datum(
sifra int,
ime varchar(50),
prezime varchar(50),
iban varchar(50)
);