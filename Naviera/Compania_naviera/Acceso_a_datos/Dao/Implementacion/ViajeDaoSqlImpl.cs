using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;
using Compania_naviera.Negocio.Entidades;
using System.Data;
using Compania_naviera.Acceso_a_datos.Helper;

namespace Compania_naviera.Acceso_a_datos.Dao.Implementacion
{
    public class ViajeDaoSqlImpl : ViajeDao<Viaje>
    {
        public ViajeDaoSqlImpl() { }

        public IList<Navio> GetNavios()
        {
            List<Navio> lista = new List<Navio>();
            string sql = " SELECT cod_navio, nombre " +
                         " FROM Navios ";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoNavio(row));
            }
            return lista;
        }

        public IList<Itinerario> GetItinerarios()
        {
            List<Itinerario> lista = new List<Itinerario>();
            string sql = " SELECT cod_intinerarios, descripcion " +
                         " FROM Itinerarios";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoItinerario(row));
            }
            return lista;
        }

        public IList<Tripulacion> GetTripulaciones()
        {
            List<Tripulacion> lista = new List<Tripulacion>();

            string sql = " SELECT legajo, nombre " +
                         " FROM Tripulaciones ";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoTripulacion(row));
            }
            return lista;
        }
        public IList<Tripulacion> GetCargarTripulacion(int seleccionado)
        {
            List<Tripulacion> lista = new List<Tripulacion>();

            string sql = " SELECT legajo, nombre " +
                         " FROM Tripulaciones " +
                         " WHERE legajo = " + seleccionado.ToString();

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoTripulacion(row));
            }

            return lista;
        }


        private Tripulacion mapeoTripulacion(DataRow row)
        {
            Tripulacion oTripulacion = new Tripulacion();
            oTripulacion.Legajo = Convert.ToInt32(row["legajo"].ToString());
            oTripulacion.Nombre = row["nombre"].ToString();
            return oTripulacion;
        }

        public Itinerario mapeoItinerario(DataRow row)
        {
            Itinerario oItinerario = new Itinerario();
            oItinerario.Codigo = Convert.ToInt32(row["cod_intinerarios"].ToString());
            oItinerario.Descripcion = row["descripcion"].ToString();
            return oItinerario;
        }

        public Navio mapeoNavio(DataRow row)
        {
            Navio oNavio = new Navio();
            oNavio.Codigo = Convert.ToInt32(row["cod_navio"].ToString());
            oNavio.Nombre = row["nombre"].ToString();
            return oNavio;
        }
    }
}
