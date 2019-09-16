using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compania_naviera.Negocio.Entidades
{
    public class Navio
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Altura { get; set; }
        public int Autonomia { get; set; }
        public int Desplazamiento { get; set; }
        public int Eslora { get; set; }
        public int Manga { get; set; }
        public int Cantidad_pasajeros { get; set; }
        public int Cantidad_tripulacion { get; set; }
        public ClasificacionNavio Tipo_clasificacion { get; set; }
        public int Cantidad_motores { get; set; }

        public Navio() { }
    }
}
