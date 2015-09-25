use trabajoPractico

insert into barrios(barrio) values('Ameghino')
insert into barrios(barrio) values('Rivadavia')
insert into barrios(barrio) values('Palermo')
insert into barrios(barrio) values('Avellaneda')
insert into barrios(barrio) values('Centro')

insert into idiomas(idioma) values('Español')
insert into idiomas(idioma) values('Chino')
insert into idiomas(idioma) values('Aleman')
insert into idiomas(idioma) values('Ingles')

insert into directores(nombre,apellido) values('Steven','Spilberg')
insert into directores(nombre,apellido) values('Jonh','Lennon')
insert into directores(nombre,apellido) values('Jony','Depp')

insert into actores (nombre,apellido) values('Jim','Carrey')
insert into actores (nombre,apellido) values('Jony','Depp')
insert into actores (nombre,apellido) values('Martin','Rodriguez')

insert into clasificaciones(clasificacion) values('Apta para todo publico')
insert into clasificaciones(clasificacion) values('Apta para publico adulto')

insert into categorias(categoria) values('Suspenso')
insert into categorias(categoria) values('Accion')
insert into categorias(categoria) values('Drama')
insert into categorias(categoria) values('Comedia')

insert into tipos(tipo) values('3D')
insert into tipos(tipo) values('2D')

insert into formatos(formato) values('Blue-ray')
insert into formatos(formato) values('DVD')
insert into formatos(formato) values('VHS')

insert into importancias(importancia) values('Estreno')
insert into importancias(importancia) values('No estreno')

insert into estados(estado) values('disponible')
insert into estados(estado) values('no disponible')

insert into tipos_movimientos(tipo_movimiento) values('Alquilada')
insert into tipos_movimientos(tipo_movimiento) values('Comprada')
insert into tipos_movimientos(tipo_movimiento) values('Reserva por internet')

insert into empleados(nombre,apellido,documento,id_barrio) values('Federico','Gonzalez','38699566',2)
insert into empleados(nombre,apellido,documento,id_barrio) values('Juan','Perez','6599845',3)
insert into empleados(nombre,apellido,documento,id_barrio) values('Alberto','Sosa','36556542',1)

insert into socios(nombre,apellido,id_barrio) values('Maria','Paz',1)
insert into socios(nombre,apellido,id_barrio) values('Cristian','Donalicio',1)
insert into socios(nombre,apellido,id_barrio) values('Fabrizio','Pozzerle',3)

insert into materialesAV(id_categoria,id_importancia,id_tipo,id_clasificacion,titulo) values(1,1,2,2,'La sirenita')
insert into materialesAV(id_categoria,id_importancia,id_tipo,id_clasificacion,titulo) values(1,1,2,2,'El rey leon')
insert into materialesAV(id_categoria,id_importancia,id_tipo,id_clasificacion,titulo) values(1,1,2,2,'Yo robot')

insert into copias(id_material,id_formato,id_estado,precio,dias) values(4,1,2,15,2)
insert into copias(id_material,id_formato,id_estado,precio,dias) values(5,1,2,15,2)
insert into copias(id_material,id_formato,id_estado,precio,dias) values(6,1,2,15,2)
insert into copias(id_material,id_formato,id_estado,precio,dias) values(4,2,2,15,2)

insert into movimientos(id_socio,id_empleado,id_tipo_movimiento,fecha) values(1,1,1,'10/10/2012')
insert into movimientos(id_socio,id_empleado,id_tipo_movimiento,fecha) values(2,1,1,'30/05/2012')
insert into movimientos(id_socio,id_empleado,id_tipo_movimiento,fecha) values(1,2,1,'18/02/2012')
insert into movimientos(id_socio,id_empleado,id_tipo_movimiento,fecha) values(2,1,2,'05/12/2013')
insert into movimientos(id_socio,id_empleado,id_tipo_movimiento,fecha) values(3,2,1,'01/11/2013')

insert into detalles_movimientos(id_movimiento,id_copia,precio,fecha_caducidad) values(1,1,15,'10/10/2013')
insert into detalles_movimientos(id_movimiento,id_copia,precio,fecha_caducidad) values(1,4,15,'10/10/2013')
insert into detalles_movimientos(id_movimiento,id_copia,precio,fecha_caducidad) values(3,6,15,'10/10/2013')

1- Select s.apellido 'Apellido',s.nombre 'Nombre ',s.documento 'Documento', s.e_mail 'EMAIL',s.calle 'Calle',s.numero 'Numero',b.barrio 'Barrio' from socios s,barrios b where s.id_socio in (Select id_socio from movimientos where fecha between '07/10/2012' and '30/10/2012') and s.nombre like '[c-p]%' and b.id_barrio = s.id_barrio order by s.apellido,s.nombre

2- Select m.id_material 'ID material', m.titulo 'Titulo' from materialAV m where m.id_material not in (Select m1.id_material from materialesAV m1,copias c,detalles_movimientos d where d.id_copia = c.id_copia and c.id_material = m1.id_material)

3-Select ma.titulo 'Titulo', count(d.id_copia) 'Cantidad de peliculas', sum(d.precio) 'Importe total' from detalles_movimientos d, movimientos m, copias c, formatos f, materialesAV ma where d.id_movimiento = m.id_movimiento and d.id_copia = c.id_copia and c.id_formato = f.id_formato and f.formato = 'dvd' and year(m.fecha) = year(getdate()) group by ma.titulo

4- Select  s.apellido + ' ' + s.nombre 'Apellido y nombre',count(id_copia) 'Cantidad alquilada', 'Socio'  from socios s,detalles_movimientos d, movimientos m where s.id_socio = m.id_socio and d.id_movimiento = m.id_movimiento group by s.apellido + ' ' + s.nombre
union
Select e.apellido + ' ' + e.nombre,count(id_copia), 'Empleado' from empleados e,detalles_movimientos d, movimientos m where e.id_empleado = m.id_empleado and d.id_movimiento = m.id_movimiento group by e.apellido + ' ' + e.nombre

5- select e.id_empleado 'ID empleado ', nombre 'Nombre', fecha 'Fecha', id_movimiento 'ID movimiento' from empleados e left join movimientos m on m.id_empleado = e.id_empleado and year(fecha) = year(getdate()) 

6- Select s.id_socio, apellido + ',' + nombre 'Socio',  min(fecha)'Primer movimiento', max(fecha) 'Ultimo movimiento',  sum(precio) 'Importe total' from detalles_movimientos d,movimientos m ,socios s where m.id_movimiento = d.id_movimiento  and m.id_socio = s.id_socio 
 and year(fecha) between 2007 and 2010 group by s.id_socio, apellido + ',' + nombre having avg(precio) < (select avg(precio)  from detalles_movimientos d1,movimientos m1  where d1.id_movimiento=m1.id_movimiento and  m1.id_socio=s.id_socio) 