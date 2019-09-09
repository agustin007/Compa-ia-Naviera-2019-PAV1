using System;
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
        public IList<Navio> ObtenerNavioPorId(int id)
        {
            return dao.GetNavioById(id);
        }

        public IList<Navio> ObtenerTodosLosNavios()
        {
            return dao.GetTodosLosNavios();
        }

        public bool RegistrarNavio(Navio obj)
        {
            return dao.RegistrerNavios();
        }
    }
}
