using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;
using Compania_naviera.Negocio.Entidades;
using Compania_naviera.Acceso_a_datos.Dao.Implementacion;

namespace Compania_naviera.Negocio.Servicios
{
    public class ItinerarioServicio
    {
        private ItinerarioDao<Itinerario> dao;

        public ItinerarioServicio()
        {
            dao = new ItinerarioDaoSqlImpl(); 
        }
        
        public object obtenerItinerarioPorCategoria(Dictionary<string, object> parametros)
        {
            return dao.GetItinerarioByCategoria(parametros);
        }

        internal bool RegistrarItinerario(Itinerario oItinierario)
        {
            return dao.RegistrerItinerario(oItinierario);
        }

        public IList<Itinerario> ObtenerTodosLosItinerarios()
        {
            return dao.GetTodosLosItinerarios();
        }

        public bool ModificarItinerario(Itinerario oItinerario)
        {
            return dao.ModificateItinerario(oItinerario);
        }
    }
}
