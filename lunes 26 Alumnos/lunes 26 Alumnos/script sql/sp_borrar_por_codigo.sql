create procedure sp_borrar_por_codigo
@Codigo  as int
as
delete  from Alumnos where  Codigo= @Codigo;
