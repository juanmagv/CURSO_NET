create procedure sp_Actualizar_por_codigo
@Codigo as int,
@Nombre as nvarchar(30),
@DNI as nvarchar(10),
@Turno as nvarchar(10),
@Sexo as nvarchar(10),
@Repetidor as bit,
@Modulo as nvarchar(10),
@Especialidad nvarchar(25)

as

update   Alumnos set 
[Nombre]=@Nombre,
[DNI]=@DNI,
[Turno]=@Turno,
[Sexo]=@Sexo,
[Repetidor]=@Repetidor,
[Modulo]=@Modulo,
[Especialidad]=@Especialidad
where codigo=@Codigo
go

