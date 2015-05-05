CREATE DATABASE policiacoDB;
go
use policiacoDB;
go
CREATE TABLE usuarios(
id int identity(101,1) PRIMARY KEY NOT NULL,
username varchar(20) NULL,
password varchar(20) NULL,
rol varchar(20) NULL);
go
INSERT INTO usuarios(username,password,rol) VALUES
('admin','e1a965abd6a8ca67b5cb780c83b533c9eb49b967','Administrador'),
('user','b4d894113178942de203ff5f783edc9e593818be','Usuario');
go
CREATE TABLE puestos(
id int identity(201,1) PRIMARY KEY NOT NULL,
nombre varchar(30) NULL);
go
INSERT INTO puestos(nombre) VALUES
('Cuerpos de vigilancia'),
('Policía Preventiva'),
('Policía montada'),
('Policía turística'),
('Cuerpo de granaderos');
go
CREATE TABLE municipios(
id int identity PRIMARY KEY NOT NULL,
nombre varchar(30) NULL);
go
INSERT INTO municipios(nombre) VALUES
('Ecatepec'),
('Coacalco'),
('Cuautitlan'),
('Huixquilucan'),
('Naucalpan'),
('Nezahualcoyotl'),
('Tlanepantla');
go
CREATE TABLE delegaciones(
id int identity PRIMARY KEY NOT NULL,
nombre varchar(30) NULL);
go
INSERT INTO delegaciones(nombre) VALUES
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
id int identity PRIMARY KEY NOT NULL,
nombre varchar(30) NOT NULL,
clave varchar(2) NOT NULL);
go
INSERT INTO estados(nombre,clave) VALUES
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
id int identity(100001,1) PRIMARY KEY NOT NULL,
etapa int NULL);
go
CREATE TABLE personal(
id int identity PRIMARY KEY NOT NULL,
aspirante_id int NOT NULL,
apellido_paterno varchar(20) NULL,
apellido_materno varchar(20) NULL,
nombre varchar(30) NULL,
fecha_nacimiento date NULL,
sexo varchar(30) NULL,
entidad_federativa varchar(30) NULL,
curp varchar(30) NULL,
rfc varchar(30) NULL,
estado_civil varchar(30) NULL,
CONSTRAINT FK_personal_aspirantes_cascade
FOREIGN KEY (aspirante_id)
REFERENCES aspirantes(id)
ON DELETE CASCADE);
go 
CREATE TABLE domicilio(
id int identity PRIMARY KEY NOT NULL,
aspirante_id int NOT NULL,
entidad_federativa varchar(30) NULL,
delegacion_municipio varchar(30) NULL,
colonia varchar(30) NULL,
codigo_postal varchar(5) NULL,
calle varchar(30) NULL,
numero_exterior varchar(6) NULL,
numero_interior varchar(6) NULL
CONSTRAINT FK_domicilio_aspirantes_cascade
FOREIGN KEY (aspirante_id)
REFERENCES aspirantes(id)
ON DELETE CASCADE);
go 
CREATE TABLE contacto(
id int identity PRIMARY KEY NOT NULL,
aspirante_id int NOT NULL,
telefono varchar(10) NULL,
celular varchar(10) NULL,
email varchar(50) NULL
CONSTRAINT FK_contacto_aspirantes_cascade
FOREIGN KEY (aspirante_id)
REFERENCES aspirantes(id)
ON DELETE CASCADE);
go 
CREATE TABLE foto(
id int identity PRIMARY KEY NOT NULL,
aspirante_id int NOT NULL,
foto image NULL,
CONSTRAINT FK_foto_aspirantes_cascade
FOREIGN KEY (aspirante_id)
REFERENCES aspirantes(id)
ON DELETE CASCADE);
go 
CREATE TABLE huella(
id int identity PRIMARY KEY NOT NULL,
aspirante_id int NOT NULL,
huella_01 image NULL,
huella_02 image NULL,
huella_03 image NULL,
huella_04 image NULL,
huella_05 image NULL,
CONSTRAINT FK_huella_aspirantes_cascade
FOREIGN KEY (aspirante_id)
REFERENCES aspirantes(id)
ON DELETE CASCADE);
go 
CREATE TABLE documentos(
id int identity PRIMARY KEY NOT NULL, 
estAsp varchar(MAX) NULL,
pasAsp varchar(MAX) NULL,
ptcAsp varchar(MAX) NULL,
escAsp varchar(MAX) NULL,
mafAsp varchar(MAX) NULL);
go
CREATE TABLE departamentos(
id int identity PRIMARY KEY NOT NULL,
nombre varchar(50));
go
INSERT INTO departamentos(nombre)VALUES
('Recursos Humanos'),
('Finanzas'),
('Sistemas'),
('Marketing'),
('Operaciones');
go
CREATE TABLE recursos(
id int identity PRIMARY KEY NOT NULL,
departamento_id int,
monto decimal(9,2),
CONSTRAINT FK_recursos_departamentos_cascade
FOREIGN KEY (departamento_id)
REFERENCES departamentos(id)
ON DELETE CASCADE);
go
CREATE TABLE actividades(
id int identity PRIMARY KEY NOT NULL,
departamento_id int,
monto decimal(9,2),
fecha date,
CONSTRAINT FK_actividades_departamentos_cascade
FOREIGN KEY (departamento_id)
REFERENCES departamentos(id)
ON DELETE CASCADE);