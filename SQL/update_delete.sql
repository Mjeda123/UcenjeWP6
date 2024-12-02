select * from smjerovi;

-- UPDATE naredba

update smjerovi set cijena=1100
where sifra=2; -- ako mijenjamo po PK tada mijenjamo 1 red

update smjerovi set 
izvodiseod='2024-12-05', 
vaucer=0
where sifra=2;

select * from polaznici where sifra=16;
update polaznici set prezime='Franjić' where sifra=16;
select * from polaznici where sifra=16;

insert into smjerovi(naziv, cijena, izvodiseod, vaucer)
values ('Web dizajn',1400.00,'2024-11-01 17:00',1),
('Marketing',1202.20,'2024-11-01 17:00',0),
('Engleski jezik',1400.00,'2024-11-01 17:00',1),
('Njemački jezik',1100.01,'2024-11-01 17:00',0),
('Java developer',1300.33,'2024-11-01 17:00',1);

select * from smjerovi;
update smjerovi set cijena = cijena * 0.9;
select * from smjerovi;

-- uvećajte sve cijene za 35%

select * from smjerovi;
update smjerovi set cijena = cijena * 1.35;
select * from smjerovi;

-- smanjite svim smjerovima cijenu za 10 eura

select * from smjerovi;
update smjerovi set cijena = cijena - 10;
select * from smjerovi;


-- uvjet vanjskog ključa
update grupe set smjer=8 where sifra=1;

-- DELETE naredba

select * from smjerovi;
delete from smjerovi where sifra>8;
select * from smjerovi;

select * from grupe;
update grupe set smjer=1 where sifra=1;

delete grupe where sifra=1;

select * from clanovi;

update clanovi set grupa=2 where grupa=1;