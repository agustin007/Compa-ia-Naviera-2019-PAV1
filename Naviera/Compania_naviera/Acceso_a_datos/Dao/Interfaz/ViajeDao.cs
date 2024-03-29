﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Negocio.Entidades;
namespace Compania_naviera.Acceso_a_datos.Dao.Interfaz
{
    public interface ViajeDao<T>
    {
        IList<Navio> GetNavios();
        IList<Itinerario> GetItinerarios();
        IList<Tripulacion> GetTripulaciones();
        IList<Tripulacion> GetCargarTripulacion(int seleccionado);
        bool RegistrerViaje(Viaje oViaje);
        IList<Viaje> ObtainViaje(Dictionary<string, object> parametros);
    }
}
