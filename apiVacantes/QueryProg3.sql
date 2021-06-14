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
	idCategoria int foreign key references Categoria(idCategoria) on delete cascade on update cascade,
	fecha date,
	ubicacion varchar(200),
	posicion varchar(200),
	empresa varchar(200),
	idTipo int foreign key references Tipo(idTipo),
	logo varchar(200),
	urlString varchar(500),
	descripcion text,
	email varchar(50),
	comoAplicar varchar(500)
)


go


/**/



insert into AspNetRoles(Id,Name) values ('admin','admin') 
insert into AspNetRoles(Id,Name) values ('postulante','postulante') 



alter table aspnetusers add Rol nvarchar(450) foreign key references aspnetroles(id)
go


create trigger TR_agregar_rol on AspNetUsers
for insert
as
begin

	insert into AspNetUserRoles(UserId,RoleId) select id, rol from inserted
	end
go


ALTER TABLE aspnetusers add constraint defualtrol DEFAULT 'postulante' for rol;


/**/

go

/* Si ya esta creada hay que ejecutar esta parte

alter table trabajos alter column descripcion nvarchar(max)
go


alter table trabajos drop column logo 
go



alter table trabajos add  logo nvarchar(max)
go

/*en el fk pon el nombre que genero tu pc*/
alter table trabajos drop  constraint  FK__Trabajos__idCate__286302EC
go


alter table trabajos add constraint fk_categoria foreign key (idcategoria) references categoria(idcategoria) on delete cascade on update cascade
go

*/