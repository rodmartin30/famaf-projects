create database TrabajoPractico

use TrabajoPractico

create table barrios
(
id_barrio int identity(1,1) not null,
barrio varchar(40)
constraint pk_barrio primary key (id_barrio)
)

create table empleados
(
id_empleado int identity(1,1) not null,
nombre varchar(40),
apellido varchar(40),
fecha_nacimiento datetime,
sexo int,
documento varchar(12),
calle varchar(40),
numero varchar(10),
telefono varchar(15),
e_mail varchar(60),
id_barrio int
constraint pk_empleado primary key (id_empleado),
constraint fk_empleado_barrios foreign key (id_barrio) references barrios(id_barrio)
)

create table estados
(
id_estado int identity(1,1) not null,
estado varchar(30)
constraint pk_estado primary key (id_estado)
)

create table categorias
(
id_categoria int identity(1,1) not null,
categoria varchar(40)
constraint pk_categoria primary key (id_categoria)
)

create table clasificaciones
(
id_clasificacion int identity(1,1) not null,
clasificacion varchar(40)
constraint pk_clasificacion primary key (id_clasificacion)
)

create table actores
(
id_actor int identity(1,1) not null,
nombre varchar(40),
apellido varchar(40),
fecha_nacimiento datetime
constraint pk_actor primary key (id_actor)
)

create table formatos
(
id_formato int identity(1,1) not null,
formato varchar(30)
constraint pk_formato primary key (id_formato)
)

create table tipos
(
id_tipo int identity(1,1) not null,
tipo varchar(10)
constraint pk_tipo primary key (id_tipo)
)

create table socios
(
id_socio int identity(1,1) not null,
nombre varchar(40),
apellido varchar(40),
fecha_nacimiento datetime,
sexo int,
documento varchar(12),
calle varchar(40),
numero varchar(10),
telefono varchar(15),
e_mail varchar(60),
id_barrio int
constraint pk_socio primary key(id_socio)
constraint fk_socio_barrio foreign key(id_barrio) references barrios(id_barrio)
)

create table personas_autorizadas
(
id_persona_autorizada int identity(1,1) not null,
id_socio int not null,
nombre varchar(40),
apellido varchar(40),
fecha_nacimiento datetime,
sexo int,
documento varchar(12)
constraint pk_persona_autorizada primary key(id_persona_autorizada),
constraint fk_persona_autorizada_id_socio foreign key (id_socio) references socios(id_socio)
)

create table idiomas
(
id_idioma int identity(1,1) not null,
idioma varchar(40)
constraint pk_idioma primary key(id_idioma)
)

create table directores
(
id_director int identity(1,1) not null,
nombre varchar(40),
apellido varchar(40)
constraint pk_director primary key(id_director)
)

create table materialesAV
(
id_material int identity(1,1) not null,
id_categoria int,
id_importancia int,
id_tipo int,
id_clasificacion int,
titulo varchar(50),
constraint pk_materialAV primary key(id_material),
constraint fk_materialAV_categoria foreign key(id_categoria) references categorias(id_categoria),
constraint fk_materialAV_clasificacion foreign key(id_clasificacion) references clasificaciones(id_clasificacion)
)

create table detalles_actores
(
id_material int,
id_actor int
constraint fk_detalle_actor_material foreign key(id_material) references materialesAV(id_material),
constraint fk_detalle_actor_actor foreign key(id_actor) references actores(id_actor)
)

create table detalles_directores
(
id_material int,
id_director int
constraint fk_detalle_director_director foreign key(id_director) references directores(id_director),
constraint fk_detalle_director_material foreign key(id_material) references materialesAV(id_material)
)

create table detalles_idioma
(
id_material int,
id_idioma int
constraint fk_detalle_idioma_material foreign key(id_material) references materialesAV(id_material),
constraint fk_detalle_idioma_idioma foreign key(id_idioma) references idiomas(id_idioma)
)

create table importancias
(
id_importancia int identity(1,1) not null,
importancia varchar(30)
constraint pk_importancia primary key(id_importancia)
)

create table copias
(
id_copia int identity(1,1) not null,
id_material int,
id_formato int,
id_estado int,
precio money,
dias int
constraint pk_copia primary key(id_copia),
constraint fk_copia_material foreign key(id_material) references materialesAV(id_material),
constraint fk_copia_formato foreign key(id_formato) references formatos(id_formato),
constraint fk_copia_estado foreign key(id_estado) references estados(id_estado),
)

create table tipos_movimientos
(
id_tipo_movimiento int identity(1,1) not null,
tipo_movimiento varchar(40),
constraint pk_reserva primary key(id_tipo_movimiento)
)

create table movimientos
(
id_movimiento int identity(1,1) not null,
id_socio int,
id_empleado int,
id_tipo_movimiento int,
fecha datetime
constraint pk_movimiento primary key(id_movimiento),
constraint fk_movimiento_socio foreign key(id_socio) references socios(id_socio),
constraint fk_movimiento_empleado foreign key(id_empleado) references empleados(id_empleado),
constraint fk_movimiento_tipo_movimiento foreign key(id_tipo_movimiento) references tipos_movimientos(id_tipo_movimiento)
)

create table detalles_movimientos
(
id_movimiento int,
id_copia int,
precio money,
fecha_caducidad datetime
constraint fk_detalle_movimiento_movimiento foreign key(id_movimiento) references movimientos(id_movimiento),
constraint fk_detalle_movimiento_copia foreign key(id_copia) references copias(id_copia)
)

create view view_Socios as
Select id_socio 'ID Socio', nombre 'Nombre', apellido 'Apellido', documento 'Documento', telefono 'Telefono', calle 'Calle', numero 'Numero', id_barrio 'Id barrio', sexo 'Sexo', fecha_nacimiento 'Fecha de Nacimiento',e_mail 'E-mail' from socios 

use TrabajoPractico
drop view view_Socios
-----------------------------------------------------------------------------------------------------------------------
create procedure consulta1
	@fecha1 datetime,
	@fecha2 datetime,
	@like varchar(15)
		as
			Select s.apellido 'Apellido', s.nombre 'Nombre', s.documento 'Documento', s.e_mail 'Email', s.calle 'Calle', s.numero 'Numero', b.barrio 'Barrio' from socios s, barrios b where s.id_socio in (Select id_socio from movimientos where fecha between @fecha1 and @fecha2 and s.nombre like @like and b.id_barrio = s.id_barrio) order by s.apellido, s.nombre
			
create procedure consulta2
	@parametro int
		as
			if(@parametro = 0) begin --Alquilados
				Select ma.id_material 'ID material', ma.titulo 'Titulo' from materialAV ma where ma.id_material in (Select m.id_material from materialAV m, copias c, detalles_movimientos d where d.id_copia = c.id_copia and c.id_material = m.id_material) end
			if (@parametro = 1) begin --Nunca alquilados
				Select ma.id_material 'ID material', ma.titulo 'Titulo' from materialAV ma where ma.id_material not in (Select m.id_material from materialAV m, copias c, detalles_movimientos d where d.id_copia = c.id_copia and c.id_material = m.id_material) end
				
create procedure consulta3
	@anio int,
	@formato varchar(30)
		as			
			Select ma.titulo 'Titulo', count(d.id_copia) 'Cantidad de peliculas', sum(d.precio) 'Importe total' from detalles_movimientos d, movimientos m, copias c, formatos f, materialesAV ma where d.id_movimiento = m.id_movimiento and d.id_copia = c.id_copia and c.id_formato = f.id_formato and f.formato = @formato and year(m.fecha) = @anio group by ma.titulo
			
create procedure consulta4	
		as
				Select  s.apellido + ' ' + s.nombre 'Apellido y nombre',count(id_copia) 'Cantidad alquilada', 'Socio'  from socios s,detalles_movimientos d, movimientos m where s.id_socio = m.id_socio and d.id_movimiento = m.id_movimiento group by s.apellido + ' ' + s.nombre
					union
						Select e.apellido + ' ' + e.nombre,count(id_copia), 'Empleado' from empleados e,detalles_movimientos d, movimientos m where e.id_empleado = m.id_empleado and d.id_movimiento = m.id_movimiento group by e.apellido + ' ' + e.nombre

create proc consulta5
	@anio int
		as
			Select e.id_empleado 'ID empleado ', nombre 'Nombre', fecha 'Fecha', id_movimiento 'ID movimiento' from empleados e left join movimientos m on m.id_empleado = e.id_empleado and year(m.fecha) = 2010
			
create proc consulta6
	@operador varchar(3),
	@anio1 int,
	@anio2 int
		as
		if(@operador = '<') begin
			Select s.id_socio, apellido + ',' + nombre 'Socio',  min(fecha)'Primer movimiento', max(fecha) 'Ultimo movimiento',  sum(precio) 'Importe total' from detalles_movimientos d,movimientos m ,socios s where m.id_movimiento = d.id_movimiento  and m.id_socio = s.id_socio 
 and year(fecha) between @anio1 and @anio2 group by s.id_socio, apellido + ',' + nombre having avg(precio) < (select avg(precio)  from detalles_movimientos d1,movimientos m1  where d1.id_movimiento=m1.id_movimiento and  m1.id_socio=s.id_socio) end	
 if(@operador = '<=') begin
			Select s.id_socio, apellido + ',' + nombre 'Socio',  min(fecha)'Primer movimiento', max(fecha) 'Ultimo movimiento',  sum(precio) 'Importe total' from detalles_movimientos d,movimientos m ,socios s where m.id_movimiento = d.id_movimiento  and m.id_socio = s.id_socio 
 and year(fecha) between @anio1 and @anio2 group by s.id_socio, apellido + ',' + nombre having avg(precio) <= (select avg(precio)  from detalles_movimientos d1,movimientos m1  where d1.id_movimiento=m1.id_movimiento and  m1.id_socio=s.id_socio) end	
 if(@operador = '=') begin
			Select s.id_socio, apellido + ',' + nombre 'Socio',  min(fecha)'Primer movimiento', max(fecha) 'Ultimo movimiento',  sum(precio) 'Importe total' from detalles_movimientos d,movimientos m ,socios s where m.id_movimiento = d.id_movimiento  and m.id_socio = s.id_socio 
 and year(fecha) between @anio1 and @anio2 group by s.id_socio, apellido + ',' + nombre having avg(precio) = (select avg(precio)  from detalles_movimientos d1,movimientos m1  where d1.id_movimiento=m1.id_movimiento and  m1.id_socio=s.id_socio) end	
 if(@operador = '>') begin
			Select s.id_socio, apellido + ',' + nombre 'Socio',  min(fecha)'Primer movimiento', max(fecha) 'Ultimo movimiento',  sum(precio) 'Importe total' from detalles_movimientos d,movimientos m ,socios s where m.id_movimiento = d.id_movimiento  and m.id_socio = s.id_socio 
 and year(fecha) between @anio1 and @anio2 group by s.id_socio, apellido + ',' + nombre having avg(precio) > (select avg(precio)  from detalles_movimientos d1,movimientos m1  where d1.id_movimiento=m1.id_movimiento and  m1.id_socio=s.id_socio) end	
 if(@operador = '>=') begin
			Select s.id_socio, apellido + ',' + nombre 'Socio',  min(fecha)'Primer movimiento', max(fecha) 'Ultimo movimiento',  sum(precio) 'Importe total' from detalles_movimientos d,movimientos m ,socios s where m.id_movimiento = d.id_movimiento  and m.id_socio = s.id_socio 
 and year(fecha) between @anio1 and @anio2 group by s.id_socio, apellido + ',' + nombre having avg(precio) >= (select avg(precio)  from detalles_movimientos d1,movimientos m1  where d1.id_movimiento=m1.id_movimiento and  m1.id_socio=s.id_socio) end	
 		
		 						