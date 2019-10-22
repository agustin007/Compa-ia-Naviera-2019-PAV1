using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compania_naviera.Negocio.Entidades
{
    public class Viaje
    {
        public int IdViaje { get; set; }
        public DateTime FechaViaje { get; set; }
        public int Duracion { get; set; }
        public Navio CodNavio { get; set; }
        public Itinerario CodItinerario { get; set; }
        public IList<Tripulacion> TripulacionAsignada { get; set; }
        public Viaje() { }

    }
}
