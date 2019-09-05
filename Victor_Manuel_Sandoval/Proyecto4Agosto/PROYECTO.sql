Create database Proyecto
use Proyecto;

CREATE TABLE roles(
	idRol int identity not null, 
	nombreRol varchar(30) not null, 
	constraint PK_Primary_Roles primary key (idRol));

	CREATE TABLE usuarios(
	idUsuario int not null primary key identity,
	correo varchar (20) NOT NULL unique,
	clave varchar (20) NOT NULL,
	idRol int NOT NULL,

	constraint HHH foreign key (idRol) references roles(idRol)
);


CREATE TABLE clientes(
	idCliente int identity not null, 
	documento char (10) not null,
	correo varchar(50) not null, 
	nombre varchar(40) not null, 
	direccion varchar(50) not null,
	telefono varchar(20) not null,
	idUsuario int,
	constraint PK_Primary_clientes Primary key (idCliente),
	constraint Unic_Documento unique (documento),
	constraint Unic_Correo unique (correo),
	Constraint FK_Usuarios foreign key (idUsuario) references usuarios(idUsuario)
	);

	
	create table empleados(
	idEmpleado int primary key identity not null, 
	documento char(10) not null,
	correo varchar(50) not null, 
	nombre varchar(40) not null, 
	direccion varchar(50) not null, 
	telefono varchar(20) not null,
	idUsuario int, 
	constraint FK_Usuario foreign key(idUsuario) references usuarios(idUsuario)
	);

 
use Proyecto

insert into roles(nombreRol) values 
('Admin'),
('Cliente'),
('Nutricionista')

insert into usuarios(correo, clave, idRol) values 
('Admin@gmail.com','123','1')

insert into empleados (documento,correo,nombre,direccion,telefono) values 
('1007903205','empleado@gmail.com','empleado','Casa del empleado','4445')

insert into clientes(documento,correo,nombre,direccion,telefono) values 
('1007903201','cliente@gmail.com','cliente','Casa del cliente','4425')

select * from usuarios