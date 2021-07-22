
create procedure ModificarCliente
@Nombre as varchar(50),
@Apellido1  as varchar(50),
@Apellido2  as varchar(50),
@Telefono  as varchar(50)
as 
update  Clientes set 
Nombre=@Nombre,Apellido1=@Apellido1,Apellido2=@Apellido2,Telefono=@Telefono
where Nombre=@Nombre

exec Modificarcliente 'PEPE','Gandalf','el gris','679523623'