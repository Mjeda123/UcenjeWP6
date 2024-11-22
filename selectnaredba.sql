select * from smjerovi;

-- minimalna select naredba

select 1;

-- filtriranje kolona (između select i from)
-- * sve kolone
-- kolona 
-- konstanta
-- izraz
select naziv as n1 , cijena as c1
, naziv , 'Osijek' as grad,
cijena*1.25 as PDV, 
getdate() as kada, *
from smjerovi;

-- izlistajte imena i prezimena polaznika

select ime, prezime from polaznici;

-- filtriranje redova
select * from polaznici;

update polaznici set oib = '84055424835' where sifra=12;

-- operatori
-- uspoređivanje =, != (<>) <, >, <=, >=
-- logički and, or, not
-- ostali like (% je zamjena za bilo koji znak)
select * from polaznici
where not (
sifra=12 or (sifra=9 or sifra=12));

select * from polaznici
where ime like '%an%';

-- s namjanjom mogućnošću greške izlistati sve muškarce
select * from polaznici where ime not like '%a';

-- ostali in
select * from polaznici
where sifra in (1,7,9);

-- ostali between
select * from smjerovi 
where izvodiseod between '2024-01-01' and '2024-12-31';

-- slaganje rezultata
select prezime, ime from polaznici
order by prezime, 2;

-- ograničavanje rezultata
select top 10 percent * from polaznici;

select top 10 ime, prezime into nova from polaznici;

select * from nova;

drop table nova;

use knjiznica;

-- ukupno redova
select count(*) from autor;

select top 10 * from autor;

-- unesite sebe kao autora
insert into autor (sifra, ime, prezime, datumrodenja)
values (4,'Andrej','Mjeda', '1997-12-06');
