using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Muestreo_de_consultas
{
    class SQL
    {
        SqlConnection conexion;
        SqlCommand comando;
        DataTable dt;

        public SQL()
        {
            conexion = new SqlConnection(@"Data Source=User;Initial Catalog=TrabajoPractico;Integrated Security = True");
            comando = new SqlCommand();
        }

        private void conectarse()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        private void desconectarse()
        {
            conexion.Close();
        }
        public void abm(string sentencia)
        {
            conectarse();
            comando.CommandText = sentencia;
            comando.ExecuteNonQuery();
            desconectarse();
        }
        public void rellenarCombo(string tabla, ComboBox combo)
        {
            dt = new DataTable();
            conectarse();
            comando.CommandText = "Select * from " + tabla;
            dt.Load(comando.ExecuteReader());
            desconectarse();
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public DataTable consulta1(string fecha1, string fecha2, string letra1, string letra2)
        {
            conectarse();
            dt = new DataTable();
            comando.CommandText = "Select s.apellido 'Apellido', s.nombre 'Nombre', s.documento 'Documento', s.e_mail 'Email', s.calle 'Calle', s.numero 'Numero', b.barrio 'Barrio' from socios s, barrios b where s.id_socio in (Select m.id_socio from movimientos m where fecha between '" + fecha1 +"' and '" + fecha2 + "' and s.nombre like  '["+letra1+"-"+letra2+"]%'  and b.id_barrio = s.id_barrio) order by s.apellido, s.nombre";
            dt.Load(comando.ExecuteReader());
            desconectarse();           
            return dt;
        }
        public DataTable consulta2(int index)
        {
            conectarse();
            dt = new DataTable();
            if (index == 0)
            {
                comando.CommandText = "Select ma.id_material 'ID material', ma.titulo 'Titulo' from materialesAV ma where ma.id_material in (Select m.id_material from materialesAV m, copias c, detalles_movimientos d where d.id_copia = c.id_copia and c.id_material = m.id_material)";
            }
            else
            {
                if (index == 1)
                {
                    comando.CommandText = "Select ma.id_material 'ID material', ma.titulo 'Titulo' from materialesAV ma where ma.id_material not in (Select m.id_material from materialesAV m, copias c, detalles_movimientos d where d.id_copia = c.id_copia and c.id_material = m.id_material)";
                }
            }
            dt.Load(comando.ExecuteReader());
            desconectarse();
            return dt;
        }
        public DataTable consulta3(string formato, int anio)
        {
            conectarse();
            dt = new DataTable();
            comando.CommandText = "Select ma.titulo 'Titulo', count(d.id_copia) 'Cantidad de peliculas', sum(d.precio) 'Importe total' from detalles_movimientos d, movimientos m, copias c, formatos f, materialesAV ma where d.id_movimiento = m.id_movimiento and d.id_copia = c.id_copia and c.id_formato = f.id_formato and f.formato = '" + formato + "' and year(m.fecha) = " + anio + " group by ma.titulo";
            dt.Load(comando.ExecuteReader());
            desconectarse();
            return dt;
        }
        public DataTable consulta4()
        {
            conectarse();
            dt = new DataTable();
            comando.CommandText = "Select  s.apellido + ' ' + s.nombre 'Apellido y nombre',count(id_copia) 'Cantidad alquilada', 'Socio' 'Tipo'  from socios s,detalles_movimientos d, movimientos m where s.id_socio = m.id_socio and d.id_movimiento = m.id_movimiento group by s.apellido + ' ' + s.nombre union Select e.apellido + ' ' + e.nombre,count(id_copia), 'Empleado' from empleados e,detalles_movimientos d, movimientos m where e.id_empleado = m.id_empleado and d.id_movimiento = m.id_movimiento group by e.apellido + ' ' + e.nombre";
            dt.Load(comando.ExecuteReader());
            desconectarse();
            return dt;
        }
        public DataTable consulta5(int anio)
        {
            conectarse();
            dt = new DataTable();
            comando.CommandText = "Select e.id_empleado 'ID empleado ', nombre 'Nombre', fecha 'Fecha', id_movimiento 'ID movimiento' from empleados e left join movimientos m on m.id_empleado = e.id_empleado and year(fecha) = " + anio;
            dt.Load(comando.ExecuteReader());
            desconectarse();
            return dt;
        }
        public DataTable consulta6(string operador,int anio1,int anio2)
        {
            conectarse();
            dt = new DataTable();
            
            if(operador == "<") 
            {
			    comando.CommandText = "Select s.id_socio, apellido + ',' + nombre 'Socio',  min(fecha)'Primer movimiento', max(fecha) 'Ultimo movimiento',  sum(precio) 'Importe total' from detalles_movimientos d,movimientos m ,socios s where m.id_movimiento = d.id_movimiento  and m.id_socio = s.id_socio " +
                 " and year(fecha) between " + anio1 + " and " + anio2 + " group by s.id_socio, apellido + ',' + nombre having avg(precio) < (select avg(precio)  from detalles_movimientos d1,movimientos m1  where d1.id_movimiento=m1.id_movimiento and  m1.id_socio=s.id_socio) ";
 
            }
            if(operador == "<=") 
            {
			    comando.CommandText = "Select s.id_socio, apellido + ',' + nombre 'Socio',  min(fecha)'Primer movimiento', max(fecha) 'Ultimo movimiento',  sum(precio) 'Importe total' from detalles_movimientos d,movimientos m ,socios s where m.id_movimiento = d.id_movimiento  and m.id_socio = s.id_socio " +
                "and year(fecha) between " + anio1 + " and " + anio2 + " group by s.id_socio, apellido + ',' + nombre having avg(precio) <= (select avg(precio)  from detalles_movimientos d1,movimientos m1  where d1.id_movimiento=m1.id_movimiento and  m1.id_socio=s.id_socio)";
            }
            if (operador == "=")
            {
                comando.CommandText = "Select s.id_socio, apellido + ',' + nombre 'Socio',  min(fecha)'Primer movimiento', max(fecha) 'Ultimo movimiento',  sum(precio) 'Importe total' from detalles_movimientos d,movimientos m ,socios s where m.id_movimiento = d.id_movimiento  and m.id_socio = s.id_socio " +
                " and year(fecha) between " + anio1 + " and " + anio2 + " group by s.id_socio, apellido + ',' + nombre having avg(precio) = (select avg(precio)  from detalles_movimientos d1,movimientos m1  where d1.id_movimiento=m1.id_movimiento and  m1.id_socio=s.id_socio)";
            }
            if(operador == ">") 
            {
			    comando.CommandText = "Select s.id_socio, apellido + ',' + nombre 'Socio',  min(fecha)'Primer movimiento', max(fecha) 'Ultimo movimiento',  sum(precio) 'Importe total' from detalles_movimientos d,movimientos m ,socios s where m.id_movimiento = d.id_movimiento  and m.id_socio = s.id_socio " +
                " and year(fecha) between " + anio1 + " and " + anio2 + " group by s.id_socio, apellido + ',' + nombre having avg(precio) > (select avg(precio)  from detalles_movimientos d1,movimientos m1  where d1.id_movimiento=m1.id_movimiento and  m1.id_socio=s.id_socio) ";
            }
            if(operador == ">=") 
            {
			    comando.CommandText = "Select s.id_socio, apellido + ',' + nombre 'Socio',  min(fecha)'Primer movimiento', max(fecha) 'Ultimo movimiento',  sum(precio) 'Importe total' from detalles_movimientos d,movimientos m ,socios s where m.id_movimiento = d.id_movimiento  and m.id_socio = s.id_socio " +
                " and year(fecha) between " + anio1 + " and " + anio2 + " group by s.id_socio, apellido + ',' + nombre having avg(precio) >= (select avg(precio)  from detalles_movimientos d1,movimientos m1  where d1.id_movimiento=m1.id_movimiento and  m1.id_socio=s.id_socio) ";	
            }
            
            dt.Load(comando.ExecuteReader());
            desconectarse();
            return dt;
        }
        public DataTable consultar(string sql)
        {
            DataTable dt = new DataTable();
            conectarse();
            comando.CommandText = sql;
            dt.Load(comando.ExecuteReader());
            desconectarse();
            return dt;
        }
    }
}
