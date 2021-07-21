create procedure EliminarCliente
@nombre varchar(50)
as 
delete from clientes where nombre=@nombre

go

execute EliminarCliente 'PEPE';