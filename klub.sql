--use master;

--create database klub;

--use klub;

create table igrac(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
datum_rodenja varchar(50),
pozicija varchar(50) not null,
bro_dresa varchar(50) not null,
klub int not null
);

create table trener(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
klub varchar(50),
nacionalnost varchar(50) not null,
iskustvo varchar(50) not null
);