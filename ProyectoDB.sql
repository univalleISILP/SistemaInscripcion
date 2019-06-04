create database proyectoBD;
use proyectoBD;

create table Usuario(
	Cod_Usuario varchar(20) not null,
	tipo varchar(20),
	contraseña varchar(20),
	primary key (Cod_usuario)
);

create table Docentes(
	CI_Docente int not null,
	nombre varchar(30),
	apellido varchar(30),
	Especialidad varchar(30),
	primary key(CI_Docente)
);

create table Alumnos(
	CI_Alumno int not null,
	nombre varchar(30),
	apellido varchar(30),
	Grado varchar(15),
	Año_Curso varchar(20),
	primary key(CI_Alumno)
);

create table Materias(
	Clave_Materia int not null,
	nombre varchar(30),	
	primary key(Clave_Materia)
);

create table Modulo(
	CI_Docente int not null,
	CI_Alumno int not null,
	Clave_Materia int not null,
	Nota1 float,
	Nota2 float,
	Nota3 float,
	Notaf float,
	foreign key (CI_Docente) references Docentes(CI_Docente),
	foreign key (CI_Alumno) references Alumnos(CI_Alumno),
	foreign key (Clave_Materia) references Materias(Clave_Materia),
	primary key(CI_Docente,CI_Alumno,Clave_Materia)
);


create database proyectoBD2;
use proyectoBD2;

create table Docentes(
	CI_Docente int not null,
	Genero char,
	Telefono int,
	Direccion varchar(40),	
	primary key(CI_Docente)
);

create table Alumnos(
	CI_Alumno int not null,
	Edad int,
	Genero char,	
	primary key(CI_Alumno)
);
alter table alumnos alter column Genero varchar(10)
alter table Docentes alter column Genero varchar(10)

--hasta aca

drop table Modulo
drop table Materias;
drop table Alumnos;
drop table Docentes;
drop table Usuario;
use master;

drop database proyectoBD2



insert into Alumnos values (123,'juan','perez',17,'m','primaria','primero');
insert into Alumnos values (234,'pepe','choque',18,'m','primaria','segundo');
insert into Alumnos values (456,'carlos','tito',12,'m','primaria','tercero');
insert into Alumnos values (678,'shalom','mendez',11,'f','primaria','cuarto');

insert into Alumnos values (939,'greis','colque',15,'f','segundaria','quinto');
insert into Alumnos values (298,'cris','tumiri',14,'m','segundaria','sexto');
insert into Alumnos values (919,'luis','apaza',14,'m','segundaria','primero');


insert into Materias values (100,'matematicas');
insert into Materias values (200,'lenguaje');
insert into Materias values (300,'ingles');
insert into Materias values (400,'fisica');
insert into Materias values (500,'quimica');
insert into Materias values (600,'artesPlasticas');


insert into Docentes values (909090,'juan','torrez','m','matematicas',123,'lago');

insert into Docentes values (808080,'luis','gonzales','m','lenguaje',234,'cerro');
insert into Docentes values (101010,'pedro','valtazar','m','quimica',456,'buenuco');
insert into Docentes values (202020,'alex','rodrigues','m','fisica',678,'sur');
insert into Docentes values (505050,'ramiro','cuellar','m','artesPlasticas',234,'oeste');
insert into Docentes values (404040,'lizet','mamani','f','mateticas',789,'chill');
insert into Docentes values (303030,'celia','velez','f','lenguaje',924,'lasis');
insert into Docentes values (606060,'martha','salias','f','ingles',981,'plas');

select * from Docentes;
select * from Materias;
select * from Alumnos;
SELECT * FROM Modulo;



insert into Modulo values (909090,123,100,40,50,80,90);
insert into Modulo values (808080,234,200,20,34,34,100);
insert into Modulo values (101010,456,300,50,56,56,34);
insert into Modulo values (202020,678,400,36,67,67,67);

use proyectoBD2
insert into Modulo values(808080,,100,40,50,80,90);
select ci_alumno from proyectoBD2.dbo.Alumnos where CI_Alumno=298
select*from Alumnos



select nombre from Materias

select * from proyectoBD.dbo.Alumnos
union
select * from proyectoBD2.dbo.Alumnos

SELECT g.*,f.Edad,f.genero FROM Alumnos g,proyectoBD2.dbo.Alumnos f where g.ci_alumno=f.ci_Alumno


SELECT a.Nombre,a.Apellido,M.Nota1,M.Nota2,M.Nota3,M.Notaf FROM Alumnos a,Docentes d,Modulo M,materia mat where a.CI_Alumno=M.CI_Alumno, and d.CI_Docente=M.CI_Docente and mat.Clave_Materia=M.Clave_Materia and mat.Nombre='ingles' and a.Curso='tercero'
Union 
SELECT a.Nombre,a.Apellido,M.Nota1,M.Nota2,M.Nota3,M.Notaf FROM proyectoBD2.dbo.Alumnos a,proyectoBD2.dbo.Docentes d,Modulo M,materia mat where a.CI_Alumno=M.CI_Alumno, and d.CI_Docente=M.CI_Docente and mat.Clave_Materia=M.Clave_Materia and mat.Nombre='{0}' and a.Curso='{1}'






Select n.Nota1,n.Nota2,n.Nota3,n.Notaf from Modulo n;


SELECT n.Nota1,n.Nota2,n.Nota3,n.Notaf,d.nombre as docente
FROM Modulo n,Materias m,Docentes d,Alumnos a	
Where a.CI_Alumno = 1010 and m.nombre = 'Matematica'




delete from proyectoBD.dbo.Docentes where CI_Docente = 190;


delete Modulo where CI_Docente=8911 and CI_Alumno=190 and Clave_Materia=200


select * from Usuario;
select * from Docentes;
select * from Materias;
select * from Alumnos;
select * from Modulo;



insert into Usuario values (11,'adm',2019);
insert into Usuario values (11,'alm',2019);
insert into Usuario values (11,'doc',2019);






SELECT nombre,apellido,Grado,Año_Curso FROM Alumnos where CI_Alumno = 1090


SELECT a.nombre,a.apellido,M.Nota1,M.Nota2,M.Nota3,M.Notaf 
                FROM Alumnos a,Docentes d,Modulo M,materias mat 
                where a.CI_Alumno=M.CI_Alumno and d.CI_Docente=M.CI_Docente and mat.Clave_Materia=M.Clave_Materia 
                and mat.Clave_Materia=100 and a.Año_Curso='Primero' and d.ci_docente=123 and a.grado='primaria'