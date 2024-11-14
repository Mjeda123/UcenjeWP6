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
klub int not null references klub(sifra)
);

drop table igrac;

create table trener(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
klub int not null references klub(sifra),
nacionalnost varchar(50) not null,
iskustvo varchar(50) not null
);

drop table trener;

create table utakmica(
sifra int not null primary key identity(1,1),
datum time not null,
vrijeme date not null,
lokacija varchar(50) not null,
stadion varchar(50) not null,
domaci_klub int not null references klub(sifra),
gostujuci_klub int not null references klub(sifra)
);

drop table utakmica;

create table klub(
sifra int not null primary key identity(1,1),
naziv int not null,
osnovan varchar(50),
stadion int not null,
predsjednik varchar(50) not null,
drzava int not null,
liga varchar(50) not null
);

drop table klub;