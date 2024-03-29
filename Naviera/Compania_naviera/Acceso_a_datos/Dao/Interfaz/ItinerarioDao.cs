﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Negocio.Entidades;

namespace Compania_naviera.Acceso_a_datos.Dao.Interfaz
{
    public interface ItinerarioDao<T>
    {
        IList<T> GetItinerarioByCategoria(Dictionary<string, object> parametros);
        bool RegistrerItinerario(Itinerario oItinierario);
        IList<Itinerario> GetTodosLosItinerarios();
        bool ModificateItinerario(Itinerario oItinerario);
    }
}
