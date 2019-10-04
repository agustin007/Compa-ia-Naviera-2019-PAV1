using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;
using Compania_naviera.Negocio.Entidades;
using Compania_naviera.Acceso_a_datos.Helper;
using System.Data;
using Compania_naviera.Acceso_a_datos.Dao.Implementacion;
using Compania_naviera.Negocio.Servicios;


namespace Compania_naviera.Acceso_a_datos.Dao.Implementacion
{
    public class ItinerarioDaoSqlImpl : ItinerarioDao<Itinerario>
    {
        public ItinerarioDaoSqlImpl() { }

        public bool ModificateItinerario(Itinerario oItinerario)
        {
            string sql = @"UPDATE Itinerarios " +
                          "SET descripcion = @Descripcion," +
                          "categoria = @Categoria" +
                          " WHERE cod_intinerarios = @CodItinerarios";

            var parametros = new Dictionary<string, object>();
            parametros.Add("CodItinerarios", oItinerario.Codigo);
            parametros.Add("Descripcion", oItinerario.Descripcion);
            parametros.Add("Categoria", oItinerario.Categoria);

            return DBHelper.getDBHelper().EjecutarSQL(sql, parametros) == 1;
        }
        public bool RegistrerItinerario(Itinerario oItinerario)
        {
            string sql = @"INSERT INTO Itinerarios(cod_intinerarios, descripcion, categoria)" +
                          "VALUES(@Codigo,@Descripcion, @Categoria)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("@Codigo", oItinerario.Codigo);
            parametros.Add("@Descripcion", oItinerario.Descripcion);
            parametros.Add("@Categoria", oItinerario.Categoria);

            return DBHelper.getDBHelper().EjecutarSQL(sql, parametros) == 1;
        }
        public IList<Itinerario> GetTodosLosItinerarios()
        {
            List<Itinerario> lista = new List<Itinerario>();
            string sql = @"SELECT * " +
                          "FROM Itinerarios";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);
        
            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(MapeoItinerarios(row));
            }
            return lista;
        }
        public IList<Itinerario> GetItinerarioByCategoria(Dictionary<string,object> parametros)
        {
            List<Itinerario> lista = new List<Itinerario>();
            string sql = @"SELECT * " +
                          "FROM Itinerarios " +
                          "WHERE 1 = 1";
            if (parametros.ContainsKey("Categoria"))
                sql += " AND (categoria = @Categoria) ";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQLConParametros(sql, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                lista.Add(MapeoItinerarios(row));
            }

            return lista;
        }
        private Itinerario MapeoItinerarios(DataRow row)
        {
            Itinerario oItinerario = new Itinerario();
            { 
            oItinerario.Codigo = Convert.ToInt32(row["cod_intinerarios"].ToString());
            oItinerario.Descripcion = row["descripcion"].ToString();
            oItinerario.Categoria = Convert.ToInt32(row["categoria"].ToString());
            }
            return oItinerario;
        }
    }
}
