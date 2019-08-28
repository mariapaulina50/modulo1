Create database Proyecto

use Proyecto;

CREATE TABLE roles(
	idRol int identity not null, 
	nombreRol varchar(30) not null, 
	constraint PK_Primary_Roles primary key (idRol));


CREATE TABLE usuarios (
	usuario varchar (20) not null,
	clave varchar (20) not null,
	idRol int not null,
	constraint Unic_Usuario unique (usuario),
	constraint FK_Usuario_Rol foreign key(idRol) references roles(idRol));


CREATE TABLE clientes(
	idCliente int identity not null, 
	documento char (10) not null,
	correo varchar(50) not null, 
	nombre varchar(40) not null, 
	direccion varchar(50) not null,
	telefono varchar(20) not null,
	constraint PK_Primary_clientes Primary key (idCliente),
	constraint Unic_Documento unique (documento),
	constraint Unic_Correo unique (correo));


 