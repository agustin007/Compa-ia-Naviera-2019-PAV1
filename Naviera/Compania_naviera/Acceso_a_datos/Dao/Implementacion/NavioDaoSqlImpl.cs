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

        public IList<Navio> GetNavioById(int id)
        {
            List<Navio> lista = new List<Navio>();

            string sql = @"SELECT * " +
                          "FROM Navios " +
                          "WHERE cod_navio = " + id.ToString();
            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(MapeoNavios(row));
            }

            return lista;
        }

        //public IList<Clasificacion_Navio> GetNavioTipo()
        //{
        //    List<Clasificacion_Navio> listadoNavioTipo = new List<Clasificacion_Navio>();

        //    string sql = @"SELECT * " +
        //                  "FROM clasificacion_navio";

        //    DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);
            
        //    foreach(DataRow row in resultado.Rows)
        //    {
        //        listadoNavioTipo.Add(mapeoTipoNavio(row));
        //    }
        //    return listadoNavioTipo;
        //}

        //private Clasificacion_Navio mapeoTipoNavio(DataRow row)
        //{
        //    Clasificacion_Navio oNavio = new Clasificacion_Navio()
        //    {
        //        CodClasificacion = Convert.ToInt32(row["cod_clasificacion"].ToString()),
        //        Descripcion = row["descripcion"].ToString()
        //    };
        //    //oNavio.CodClasificacion = Convert.ToInt32(row["CodClasificacion"].ToString());
        //    //oNavio.Descripcion = row["Descripcion"].ToString();
                
        //    return oNavio;
        //}
        
        public IList<Navio> GetTodosLosNavios()
        {
            List<Navio> lista = new List<Navio>();

            string sql = @"SELECT * " +
                          "FROM Navios ";

            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in tabla.Rows)
            {
                lista.Add(MapeoNavios(row));
            }
            return lista;
        }

        public bool RegistrerNavios(Navio oNavio)
        {
            //string sql = "INSERT INTO Navios(cod_navio, nombre, altura, " +
            //                 "autonomia, desplazamiento, eslora, manga," +
            //                 "cantidad_maxima_pasajeros, cantidad_maxima_tripulantes," +
            //                 " tipo_clasificacion, cantidad_motores)" +
            //                 "VALUES (" + oNavio.Codigo + "," + oNavio.Nombre + "," + oNavio.Altura + "," + oNavio.Autonomia + "," +
            //                 oNavio.Desplazamiento + "," + oNavio.Eslora + "," + oNavio.Manga + "," + oNavio.Cantidad_pasajeros + "," +
            //                 oNavio.Cantidad_tripulacion + "," + oNavio.Tipo_clasificacion + "," + oNavio.Cantidad_motores + ")";

            string sql = "INSERT INTO Navios(cod_navio, nombre, altura, " +
                             "autonomia, desplazamiento, eslora, manga," +
                             "cantidad_maxima_pasajeros, cantidad_maxima_tripulantes," +
                             " tipo_clasificacion, cantidad_motores)" +
                             "VALUES (@cod_navio, @nombre, @altura, @autonomia, @eslora, @manga,cantidad_maxima_pasajeros, @cantidad_tripulantes, @cod_clasificacion, @cantidad_motores)";
            var parametros = new Dictionary<string, object>();
            parametros.Add("cod_navio",oNavio.Codigo);
            parametros.Add("nombre",oNavio.Nombre);
            parametros.Add("altura",oNavio.Altura);
            parametros.Add("autonomia",oNavio.Autonomia);
            parametros.Add("eslora",oNavio.Eslora);
            parametros.Add("cantidad_maxima_pasajeros",oNavio.Cantidad_pasajeros);
            parametros.Add("cantidad_tripulantes",oNavio.Cantidad_tripulacion);
            parametros.Add("cod_clasificacion",oNavio.Tipo_clasificacion.CodClasificacion);
            parametros.Add("cantidad_motores",oNavio.Cantidad_motores);
            return DBHelper.getDBHelper().EjecutarSQL(sql, parametros) == 1;
        }

        private Navio MapeoNavios(DataRow row)
        {
            Navio oNavio = new Navio();
            oNavio.Codigo = Convert.ToInt32(row[0].ToString());
            oNavio.Nombre = row[1].ToString();
            oNavio.Altura = Convert.ToInt32(row[2].ToString());
            oNavio.Autonomia = Convert.ToInt32(row[3].ToString());
            oNavio.Desplazamiento = Convert.ToInt32(row[4].ToString());
            oNavio.Eslora = Convert.ToInt32(row[5].ToString());
            oNavio.Manga = Convert.ToInt32(row[6].ToString());
            oNavio.Cantidad_pasajeros = Convert.ToInt32(row[7].ToString());
            oNavio.Cantidad_tripulacion = Convert.ToInt32(row[8].ToString());
            //oNavio.Tipo_clasificacion = new ClasificacionNavio()
            //{
            //    CodClasificacion = Convert.ToInt32(row[9].ToString()),
            //    Descripcion = row[9].ToString(),
            //};
            oNavio.Cantidad_motores = Convert.ToInt32(row[10].ToString());
            return oNavio;
        }
    }
}
