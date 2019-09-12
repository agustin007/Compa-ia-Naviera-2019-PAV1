using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Compania_naviera.Acceso_a_datos.Helper
{
    public class DBHelper
    {
        private string cadena_conexion;
        private static DBHelper instancia = new DBHelper();

        private DBHelper()
        {
            cadena_conexion = "Data Source=MAQUIS;Initial Catalog=Naviera_67298;User ID=avisuales1;Password=avisuales1";
        }

        public static DBHelper getDBHelper()
        {
            if (instancia == null)
                instancia = new DBHelper();
            return instancia;
        }


        // Resumen:
        //     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        // Devuelve:
        //      un valor entero con el número de filas afectadas por la sentencia ejecutada
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.

        public int ejecutarSQL(string strSql)
        {

            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.ConnectionString = cadena_conexion;
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandText = strSql;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }

        // Resumen:
        //     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        // Devuelve:
        //      un objeto de tipo DataTable con el resultado de la consulta
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.

        public DataTable ConsultaSQL(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = cadena_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }

        // Resumen:
        //      Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        //      La función recibe por valor una sentencia sql como string y un arreglo de objetos como parámetros
        // Devuelve:
        //      un objeto de tipo DataTable con el resultado de la consulta
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.

        public DataTable ConsultarSQLConParametros(string sqlStr, Object[] prs)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            string n_param;
            try
            {
                cnn.ConnectionString = cadena_conexion;
                cnn.Open();
                cmd.Connection = cnn;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                //IMPORTANTE: cada parametro deberá llamarse: param1, param2,.., paramN
                for (int i = 0; i < prs.Length; i++)
                    if (prs[i] != null)
                    {
                        n_param = "param" + Convert.ToString(i + 1);
                        cmd.Parameters.AddWithValue(n_param, prs[i]);
                    }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(cnn);
            }
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }

        }
    }
}
