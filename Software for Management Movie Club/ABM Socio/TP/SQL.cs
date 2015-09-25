using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TP
{
    class SQL
    {
        SqlConnection conexion;
        SqlCommand comando;
        DataTable dt;

        public SQL()
        {
            conexion = new SqlConnection(@"Data Source=(local);Initial Catalog=TrabajoPractico;Integrated Security = True");
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
        public DataTable rellenarGrilla(string vista)
        {
            conectarse();
            dt = new DataTable();
            comando.CommandText = "select * from " + vista;
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
