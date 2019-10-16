using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compania_naviera.Negocio.Entidades
{
    class TripulacionPorViaje
    {
        public int IdFecha { get; set; }
        public IList<Tripulacion> Legajo { get; set; }

        public TripulacionPorViaje() { }
    }
}
