using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Proyecto_pva
{
    class Conexion
    {
        public SqlConnection conectarse = null;
        //public SqlTransaction mitransaccion;
        public SqlCommand comando = null; // Comando de consulta, inserción, borrado o actualización de la base de datos
        public SqlConnection Conectarse()
        {
            conectarse = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=myBike;Integrated Security=True");
            conectarse.Open();
            return conectarse;
        }
        public Conexion()
        {
            // Instanciar el atributo conexión con los datos del servidor y la base de datos de la aplicación
            conectarse = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=myBike;Integrated Security=True"); //casa
            //SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master; uid=sa;Password=omi"); //clase
            conectarse.Open(); // Abrir la conexión
                             // Instanciar el atributo comando con la cadena recibida por parámetro y la conexión instancia anteriormente
            
        }
        public SqlDataReader obtenerDatos()
        {
            // Obtener los resultados y almacenarlos en una instancia de lector
            SqlDataReader reader = this.comando.ExecuteReader();
            return reader; // Devolver el lector
        }
        public void realizarTransaccion()
        {
            // Instanciar una transacción y asignarla a la conexión y el comando de la clase
            SqlTransaction transaccion = conectarse.BeginTransaction();
            this.comando.Transaction = transaccion;
            comando.ExecuteNonQuery();
            transaccion.Commit(); // Hacer efectivos los cambios deseados
        }
        public SqlDataReader leerbasedatos(string campos, string tablas, string condicion)
        {
            conectarse = Conectarse();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conectarse;
            comandosql.CommandText = "SELECT " + campos + " FROM " + tablas + " " + condicion + ";";
            SqlDataReader midatareader = comandosql.ExecuteReader();
            return midatareader;
        }
        public SqlDataReader leerbasedatos(string campos, string tablas)
        {
            conectarse = Conectarse();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = conectarse;
            comandosql.CommandText = "SELECT " + campos + " FROM " + tablas + ";";
            SqlDataReader midatareader = comandosql.ExecuteReader();
            return midatareader;
        }
        public void cerrarConexion()
        {
            this.conectarse.Close();
        }
        public bool insertarbasedatos(string tablas, string condicion)
        {
            try
            {
                conectarse = Conectarse();
                SqlCommand comandosql = new SqlCommand();
                comandosql.Connection = conectarse;
                comandosql.CommandText = "INSERT INTO " + tablas + "VALUES (" + condicion + ");";
                comandosql.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

