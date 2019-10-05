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
        public Puestos CodPuesto { get; set; }
        public Tripulacion() { }
    }
}
