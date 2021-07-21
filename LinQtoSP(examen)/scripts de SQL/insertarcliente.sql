
create procedure insertarcliente
@Nombre as varchar(50),
@Apellido1  as varchar(50),
@Apellido2  as varchar(50),
@Telefono  as varchar(50)
as 
insert into Clientes (Nombre,Apellido1,Apellido2,Telefono)
values(@Nombre,@Apellido1,@Apellido2,@Telefono)
go
exec insertarcliente 'PEPE','PEREZ','REINA','679523623'