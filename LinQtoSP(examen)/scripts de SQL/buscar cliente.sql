create procedure BuscarCliente
@Nombre varchar(50)
as
select * from clientes where Nombre=@Nombre;

select * from clientes where  NOmbre like '%p%';