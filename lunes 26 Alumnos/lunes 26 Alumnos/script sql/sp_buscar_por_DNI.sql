create procedure sp_Buscar_por_DNI
@DNI as nvarchar(10)

as

select * from Alumnos where DNI=@DNI;
