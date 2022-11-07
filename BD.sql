create database Proyecto
go
use Proyecto

create table Personas 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Apellidos nvarchar (100),
Direccion nvarchar (100),
ciudad nvarchar (100),
Telefono int
)

insert into Personas 
values
('Mateo','Munoz','Cra 34','Medellin',320751),
('Pablo','Mena','cra 35','Medellin',311806)

---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR 
create proc MostrarPersonas
as
select * from Personas
go

--------------------------INSERTAR 
create proc InsertarPersonas
@nombre nvarchar (100),
@Apellidos nvarchar (100),
@Direccion nvarchar (100),
@ciudad nvarchar (100),
@Telefono int
as
insert into Personas values (@nombre,@Apellidos,@Direccion,@ciudad,@Telefono)
go

------------------------ELIMINAR
create proc EliminarPersonas
@idpro int
as
delete from Personas where Id=@idpro
go
------------------EDITAR

create proc EditarPersonas
@nombre nvarchar (100),
@Apellidos nvarchar (100),
@Direccion nvarchar (100),
@ciudad nvarchar (100),
@Telefono int,
@id int
as
update Personas set Nombre=@nombre, Apellidos=@Apellidos, Direccion=@Direccion, ciudad=@ciudad, Telefono=@Telefono where Id=@id
go
