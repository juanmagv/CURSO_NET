create procedure sp_alta
@Nombre as nvarchar(30),
@DNI as nvarchar(10),
@Turno as nvarchar(10),
@Sexo as nvarchar(10),
@Repetidor as bit,
@Modulo as nvarchar(10),
@Especialidad nvarchar(25)

as

insert into Alumnos ([Nombre],[DNI],[Turno],[Sexo],[Repetidor],[Modulo],[Especialidad])
values(@Nombre,@DNI,@Turno,@Sexo,@Repetidor,@Modulo,@Especialidad)

go

exec sp_alta 'uno', '32875319Q' ,'Mañana' ,'mujer',0,'DAW','fumador';