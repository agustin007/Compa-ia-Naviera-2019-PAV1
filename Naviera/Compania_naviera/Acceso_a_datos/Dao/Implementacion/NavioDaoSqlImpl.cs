using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;
using Compania_naviera.Negocio.Entidades;
using Compania_naviera.Acceso_a_datos.Helper;
using System.Data;

namespace Compania_naviera.Acceso_a_datos.Dao.Implementacion
{
    public class NavioDaoSqlImpl : NavioDao<Navio>
    {
        public NavioDaoSqlImpl() { }

        public IList<Navio> GetNavioById(Dictionary<string, object> parametros)
        {
            List<Navio> lista = new List<Navio>();

            string sql = string.Concat(@"SELECT t.*,t1.descripcion ",
                          "FROM Navios t, Clasificacion_navio t1 ",
                          "WHERE t.tipo_clasificacion = cod_clasificacion");

            if (parametros.ContainsKey("codNavio"))
                sql += " AND (t.cod_navio = @codNavio )";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQLConParametros(sql, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                lista.Add(MapeoNavios(row));
            }

            return lista;
        }

        public IList<Navio> GetTodosLosNavios()
        {
            List<Navio> lista = new List<Navio>();

            string sql = @"SELECT t.*,t1.descripcion " +
                          "FROM Navios t, Clasificacion_navio t1 " +
                          " WHERE t.tipo_clasificacion = cod_clasificacion";

            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in tabla.Rows)
            {
                lista.Add(MapeoNavios(row));
            }
            return lista;
        }

        public bool RegistrerNavios(Navio oNavio)
        {

            string sql = "INSERT INTO Navios(cod_navio, nombre, altura, " +
                             "autonomia, desplazamiento, eslora, manga," +
                             "cantidad_maxima_pasajeros, cantidad_tripulantes," +   
                             " tipo_clasificacion, cantidad_motores)" +
                             "VALUES (@cod_navio, @nombre, @altura, @autonomia, @desplazamiento, @eslora, @manga, @cantidad_maxima_pasajeros, @cantidad_tripulantes, @cod_clasificacion, @cantidad_motores)";
            var parametros = new Dictionary<string, object>();
            parametros.Add("@cod_navio", oNavio.Codigo);
            parametros.Add("@nombre", oNavio.Nombre);
            parametros.Add("@altura", oNavio.Altura);
            parametros.Add("@autonomia", oNavio.Autonomia);
            parametros.Add("@desplazamiento", oNavio.Desplazamiento);
            parametros.Add("@eslora", oNavio.Eslora);
            parametros.Add("@manga", oNavio.Manga);
            parametros.Add("@cantidad_maxima_pasajeros", oNavio.Cantidad_pasajeros);
            parametros.Add("@cantidad_tripulantes", oNavio.Cantidad_tripulacion);
            parametros.Add("@cod_clasificacion", oNavio.Tipo_clasificacion.CodClasificacion);
            parametros.Add("@cantidad_motores", oNavio.Cantidad_motores);
            return DBHelper.getDBHelper().EjecutarSQL(sql, parametros) == 1;
        }

        public bool ModificateNavio(Navio oNavio)
        {
            string sql = " UPDATE Navios" +
                         " SET nombre = @nombre," +
                         " altura = @altura," +
                         " autonomia = @autonomia," +
                         " desplazamiento = @desplazamiento," +
                         " eslora = @eslora," +
                         " manga = @manga," +
                         " cantidad_maxima_pasajeros = @cantidad_maxima_pasajeros," +
                         " cantidad_tripulantes = @cantidad_tripulantes," +
                         " tipo_clasificacion = @cod_clasificacion," +
                         " cantidad_motores = @cantidad_motores," +
                         "estado = @estado" +
                         " WHERE cod_navio = @cod_navio";

            var parametros = new Dictionary<string, object>();
            parametros.Add("@cod_navio", oNavio.Codigo);
            parametros.Add("@nombre", oNavio.Nombre);
            parametros.Add("@altura", oNavio.Altura);
            parametros.Add("@autonomia", oNavio.Autonomia);
            parametros.Add("@desplazamiento", oNavio.Desplazamiento);
            parametros.Add("@eslora", oNavio.Eslora);
            parametros.Add("@manga", oNavio.Manga);
            parametros.Add("@cantidad_maxima_pasajeros", oNavio.Cantidad_pasajeros);
            parametros.Add("@cantidad_tripulantes", oNavio.Cantidad_tripulacion);
            parametros.Add("@cod_clasificacion", oNavio.Tipo_clasificacion.CodClasificacion);
            parametros.Add("@cantidad_motores", oNavio.Cantidad_motores);
            parametros.Add("@estado", oNavio.Estado);

            return DBHelper.getDBHelper().EjecutarSQL(sql, parametros) == 1;
        }

         private Navio MapeoNavios(DataRow row)
        {
            Navio oNavio = new Navio();
            {
                
                oNavio.Codigo = Convert.ToInt32(row["cod_navio"].ToString());
                oNavio.Nombre = row["nombre"].ToString();
                oNavio.Altura = Convert.ToInt32(row["altura"].ToString());
                oNavio.Autonomia = Convert.ToInt32(row["autonomia"].ToString());
                oNavio.Desplazamiento = Convert.ToInt32(row["desplazamiento"].ToString());
                oNavio.Eslora = Convert.ToInt32(row["eslora"].ToString());
                oNavio.Manga = Convert.ToInt32(row["manga"].ToString());
                oNavio.Cantidad_pasajeros = Convert.ToInt32(row["cantidad_maxima_pasajeros"].ToString());
                oNavio.Cantidad_tripulacion = Convert.ToInt32(row["cantidad_tripulantes"].ToString());
                oNavio.Tipo_clasificacion = new ClasificacionNavio()
                {
                    CodClasificacion = Convert.ToInt32(row["tipo_clasificacion"].ToString()),
                    Descripcion = row["descripcion"].ToString(),
                };
                oNavio.Cantidad_motores = Convert.ToInt32(row["cantidad_motores"].ToString());
            }
            return oNavio;
        }


    }
}
