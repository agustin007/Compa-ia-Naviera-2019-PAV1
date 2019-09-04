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

        public IList<Itinerario> getItinerarioById(int id)

        //public IList<Itinerario> getItinerarioById(int id)
        {
            List<Itinerario> lista = new List<Itinerario>();
            Itinerario oItinerario = null;

            string sql = @"SELECT *" +
                          "FROM Itinerarios" +
                          "WHERE id_itinerario =" + id.ToString();
            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                //int codigo = Convert.ToInt32(row[0].ToString());
                lista.Add();
            }
            return lista;
        }
    }
}
