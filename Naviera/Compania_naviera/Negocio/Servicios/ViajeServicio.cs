using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Negocio.Entidades;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;
using Compania_naviera.Acceso_a_datos.Dao.Implementacion;

namespace Compania_naviera.Negocio.Servicios
{
    public class ViajeServicio
    {
        public ViajeDao<Viaje> dao;

        public ViajeServicio()
        {
            dao = new ViajeDaoSqlImpl();
        }

        public IList<Navio> ObtenerNavios()
        {
            return dao.GetNavios();
        }

        public IList<Itinerario> ObtenerItinerarios()
        {
            return dao.GetItinerarios();
        }

        public IList<Tripulacion> ObtenerTripulaciones()
        {
            return dao.GetTripulaciones();
        }

        public IList<Tripulacion> CargarTripulaciones(int seleccionado)
        {
            return dao.GetCargarTripulacion(seleccionado);
        }

        public bool RegistrarViaje(Viaje oViaje)
        {
            return dao.RegistrerViaje(oViaje);
        }
    }
}
