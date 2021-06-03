create database proyectoWEB
go

use proyectoWEB
go




create table Categoria(
id int primary key identity(1,1),
nombre varchar(50)




)

Create table Tipo(
id int primary key,
nombre varchar(50)



)

go


insert into Tipo values (1, 'full-time')
insert into Tipo values (2, 'part-time')
insert into Tipo values (3, 'freelance')


go




create table Trabajos(
id int primary key identity(1,1),
categoria int foreign key references Categoria(id),
fecha date,
ubiacion varchar(100),
posicion varchar(100),
empresa varchar(100),
tipo int foreign key references Tipo(id),
logo image,
urlString varchar(500),
descripcion varchar(500),
email varchar(50),
comoAplicar varchar(500)






)


create table postulaciones(
nombre varchar(50),
correo varchar (50),
telefono varchar(50),
trabajo int foreign key references Trabajos(id)



)