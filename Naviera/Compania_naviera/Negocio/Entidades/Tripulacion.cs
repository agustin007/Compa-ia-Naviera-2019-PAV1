using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compania_naviera.Negocio.Entidades
{
    public class Tripulacion
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public int LegajoJefe { get; set; }
        public Puestos Puesto { get; set; }
        public string Estado { get; set; }
        public Tripulacion() { }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
