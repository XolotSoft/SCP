CREATE DATABASE policiacoDB;
go
use policiacoDB;
go
CREATE TABLE usuarios(
idUsu int identity(101,1) primary key not null,
noUsu varchar(20) not null,
pwUsu varchar(20) not null,
tpUsu varchar(20) not null);
go
INSERT INTO usuarios(noUsu,pwUsu,tpUsu) VALUES
('admin','admin','Administrador'),
('user','user','Usuario');
go
CREATE TABLE puestos(
idPue int identity(201,1) primary key not null,
noPue varchar(30) not null);
go
INSERT INTO puestos(noPue) VALUES
('Cuerpos de vigilancia'),
('Policía Preventiva'),
('Policía montada'),
('Policía turística'),
('Cuerpo de granaderos');
go
CREATE TABLE municipios(
idMun int identity primary key not null,
noMun varchar(30) not null);
go
INSERT INTO municipios(noMun) VALUES
('Ecatepec'),
('Coacalco'),
('Cuautitlan'),
('Huixquilucan'),
('Naucalpan'),
('Nezahualcoyotl'),
('Tlanepantla');
go
CREATE TABLE delegaciones(
idMun int identity primary key not null,
noMun varchar(30) not null);
go
INSERT INTO delegaciones(noMun) VALUES
('Álvaro Obregón'),
('Azcapotzalco'),
('Benito Juárez'),
('Coyoacán'),
('Cuajimalpa de Morelos'),
('Cuauhtémoc'),
('Gustavo A. Madero'),
('Iztacalco'),
('Iztapalapa'),
('La Magdalena Contreras'),
('Miguel Hidalgo'),
('Milpa Alta'),
('Tláhuac'),
('Tlalpan'),
('Venustiano Carranza'),
('Xochimilco');
go
CREATE TABLE estados(
idEst int identity primary key not null,
noEst varchar(30) not null,
clEst varchar(2) not null);
go
INSERT INTO estados(noEst,clEst) VALUES
('Aguascalientes','AS'),
('Baja California','BC'),
('Baja California Sur','BS'),
('Campeche','CC'),
('Chiapas','CS'),
('Chihuahua','CH'),
('Coahuila','CL'),
('Colima','CM'),
('Distrito Federal','DF'),
('Durango','DG'),
('Guanajuato','GT'),
('Guerrero','GR'),
('Hidalgo','HG'),
('Jalisco','JC'),
('Mexico','MC'),
('Michoacan','MN'),
('Morelos','MS'),
('Nayarit','NT'),
('Nuevo Leon','NL'),
('Oaxaca','OC'),
('Puebla','PL'),
('Queretaro','QT'),
('Quintana Roo','QR'),
('San Luis Potosi','SP'),
('Sinaloa','SL'),
('Sonora','SR'),
('Tabasco','TC'),
('Tamaulipas','TS'),
('Tlaxcala','TL'),
('Veracruz','VZ'),
('Yucatan','YN'),
('Zacatecas','ZS'),
('Nacido Extranjero','NE');
go
CREATE TABLE aspirantes(
idAsp int identity(100001,1) primary key not null,
appAsp varchar(20) not null,
apmAsp varchar(20) not null,
nomAsp varchar(30) not null,
fncAsp date not null,
sexAsp varchar(30) not null,
enfAsp varchar(30) not null,
curAsp varchar(30) not null,
rfcAsp varchar(30) not null,
edcAsp varchar(30) not null,
efdAsp varchar(30) not null,
domAsp varchar(30) not null,
colAsp varchar(30) not null,
cdpAsp varchar(5) not null,
cllAsp varchar(30) not null,
nueAsp varchar(6) not null,
nuiAsp varchar(6) not null,
conAsp varchar(30) not null,
pueAsp varchar(30) not null,
telAsp varchar(10) not null,
celAsp varchar(10) not null,
emaAsp varchar(50) not null,
fotAsp varchar(MAX) null,
gueAsp varchar(MAX) null);
