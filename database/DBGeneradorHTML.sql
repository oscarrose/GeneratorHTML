create database PraticaHTML
go

use PraticaHtml
go

create table InfPersonal(
infPersonalId int not null identity constraint PK_infoPersonal primary key(infPersonalId),
NombreCompleto varchar(40),
fechaNacimiento date,

NombreCompletoPadre varchar(40),
imgPadre varchar(max),

NombreCompletoMadre varchar(40),
imgMadre varchar(max),

NombrecompletoPadreAbuela varchar (40),
imgPadreAbuela varchar(max),
NombreCompletoPadreAbuelo varchar(40),
imgPadreAbuelo varchar(max),

NombrecompletoMadreAbuela varchar (40),
imgMadreAbuela varchar(max),
NombreCompletoMadreAbuelo varchar(40),
imgMadreAbuelo varchar(max),


NombreCompletoAbuelaBisabuela varchar(40),
imgAbuelaBisabuela varchar(max),
NombreCompletoAbuelaBisabuelo varchar(40),
imgAbuelaBisabuelo varchar(max),

NombreCompletoAbueloBisabuela varchar(40),
imgAbueloBisabuela varchar(max),
NombreCompletoAbueloBisabuelo varchar(40),
imgAbueloBisabuelo varchar(max)
 );
 go


 create table pasatiempos(
 pasatiemposId int not null identity constraint PK_pasatiempos primary key(pasatiemposId),
 nombreCompleto varchar(40),
 PasatiemposFavoritos varchar(max)
 );
 go

 create table youtuberFavs(
 youtuberFavsId int not null identity constraint PK_youtubeFav primary key(youtuberFavsId),
 youtubeFav varchar(50),
 enlaceCanal varchar(max)
 );
 go

 create table SeriesFav(
 serieId int not null identity constraint PK_seriesFav primary key(serieId),
 SerieFav varchar (60),
 trailer varchar(max)
 );
 go

 create table formularioContactos(
 formularioId int not null identity constraint PK_formulario primary key(formularioId),
 Nombre varchar(20),
 apellido varchar(20),
 Email varchar(150),
 telefono varchar(15),
 facebook varchar(25),
 instagram varchar(35),
 whatsApp varchar(15)
 );
 go

 select * from InfPersonal

