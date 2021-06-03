create database DBVacantes
go

use DBVacantes
go




Create table Categoria(
	idCategoria int not null primary key identity,
	nombre varchar(50)
)


insert into Categoria values ('TI')
insert into Categoria values ('Marketing')
insert into Categoria values ('Desarrollo Web')
insert into Categoria values ('Analisis de Datos')
insert into Categoria values ('Community Manager')



Create table Tipo(
	idTipo int not null primary key,
	nombre varchar(50)
)

go


insert into Tipo values (1, 'full-time')
insert into Tipo values (2, 'part-time')
insert into Tipo values (3, 'freelance')
go




Create table Trabajos(
	idTrabajo int not null primary key identity,
	idCategoria int foreign key references Categoria(idCategoria),
	fecha date,
	ubicacion varchar(100),
	posicion varchar(100),
	empresa varchar(100),
	idTipo int foreign key references Tipo(idTipo),
	logo image,
	urlString varchar(500),
	descripcion varchar(500),
	email varchar(50),
	comoAplicar varchar(500)
)


Create table postulaciones(
	idPostulacion int not null primary key identity,
	nombre varchar(50),
	correo varchar (50),
	telefono varchar(50),
	trabajo int foreign key references Trabajos(idTrabajo)
) 



select * from Trabajos