using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Negocio.Entidades;

namespace Compania_naviera.Acceso_a_datos.Dao.Interfaz
{
    public interface TripulacionDao<T>
    {
        IList<Puestos> GetPuestos();
        IList<Tripulacion> GetTodasLasTripulacion();
        bool RegistrerTripulacion(Tripulacion oTripulacion);
        bool ModificateTripulacion(Tripulacion oTripulacionSeleccionada);
        IList<Tripulacion> GetTripulacionPorFiltro(Dictionary<string, object> parametros);
        IList<Tripulacion> GetTripulacionesDeAlta();
    }
}
