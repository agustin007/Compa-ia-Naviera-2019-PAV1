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

        public IList<Itinerario> obtenerItinerarioPorId(int id)
        {
            return dao.getItinerarioById(id);
        }
    }
}
