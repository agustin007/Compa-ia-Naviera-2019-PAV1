﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compania_naviera.Negocio.Entidades
{
    public class Itinerario
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Categoria { get; set; }
        public string Estado { get; set; }
        public Itinerario() { }
    }
}
