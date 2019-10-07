using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;
using Compania_naviera.Acceso_a_datos.Dao.Implementacion;
using Compania_naviera.Negocio.Entidades;

namespace Compania_naviera.Negocio.Servicios
{
    public class TripulacionServicio
    {
        private TripulacionDao<Tripulacion> dao;

        public TripulacionServicio()
        {
            dao = new TripulacionDaoSqlImpl();
        }

        public IList<Puestos> ObtenerPuestos()
        {
            return dao.GetPuestos();
        }

        public IList<Tripulacion> ObtenerTodasLasTripulaciones()
        {
            return dao.GetTodasLasTripulacion();
        }

        public bool RegistrarTripulacion(Tripulacion oTripulacion)
        {
            return dao.RegistrerTripulacion(oTripulacion);
        }

        public bool ModificarTripulacion(Tripulacion oTripulacionSeleccionada)
        {
            return dao.ModificateTripulacion(oTripulacionSeleccionada);
        }

        public bool ModificarEstadoTripulacion(Tripulacion oTripulacionSeleccionada)
        {
            if (oTripulacionSeleccionada.Estado == "false")
                oTripulacionSeleccionada.Estado = "true";
            else
                oTripulacionSeleccionada.Estado = "false";
            return dao.ModificateTripulacion(oTripulacionSeleccionada);
        }

        //public IList<Tripulacion> ObtenerPorFiltros(Dictionary<string, object> parametros)
        //{
        //    return dao.GetType();
        //}
    }
}
