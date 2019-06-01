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
	Genero char,
	Telefono int,
	Direccion varchar(40),
	Especialidad varchar(30),
	primary key(CI_Docente)
);

create table Alumnos(
	CI_Alumno int not null,
	nombre varchar(30),
	apellido varchar(30),
	Genero char,
	Edad int,
	Direccion varchar(40),
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
	Nota float,	
	foreign key (CI_Docente) references Docentes(CI_Docente),
	foreign key (CI_Alumno) references Alumnos(CI_Alumno),
	foreign key (Clave_Materia) references Materias(Clave_Materia),
	primary key(CI_Docente,CI_Alumno,Clave_Materia)
);
