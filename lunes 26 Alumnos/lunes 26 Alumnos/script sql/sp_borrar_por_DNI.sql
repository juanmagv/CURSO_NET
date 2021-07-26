create procedure sp_borrar_por_DNI
@DNI  as nvarchar(10)
as
delete  from Alumnos where  DNI= @DNI;
