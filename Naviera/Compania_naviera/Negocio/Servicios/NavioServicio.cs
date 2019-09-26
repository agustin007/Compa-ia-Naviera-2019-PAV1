﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Negocio.Entidades;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;
using Compania_naviera.Acceso_a_datos.Dao.Implementacion;

namespace Compania_naviera.Negocio.Servicios
{
    public class NavioServicio
    {
        private NavioDao<Navio> dao;

        public NavioServicio()
        {
            dao = new NavioDaoSqlImpl();
        }
        public IList<Navio> ObtenerNavioPorId(Dictionary<string,object> parametros)
        {
            return dao.GetNavioById(parametros);
        }

        public IList<Navio> ObtenerTodosLosNavios()
        {
            return dao.GetTodosLosNavios();
        }

        public bool RegistrarNavio(Navio oNavio)
        {
            return dao.RegistrerNavios(oNavio);
        }

        public bool ModificarNavio(Navio oNavio)
        {
            return dao.ModificateNavio(oNavio);   
        }

        public bool ModificarEstadoNavio(Navio oNavio)
        {
            if (oNavio.Estado == "N")
                oNavio.Estado = "S";
            else
                oNavio.Estado = "N";
            return dao.ModificateNavio(oNavio);
        }
    }
}
