using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;
using Compania_naviera.Negocio.Entidades;
using Compania_naviera.Acceso_a_datos.Dao.Implementacion;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;

namespace Compania_naviera.Negocio.Servicios
{
    class ClasificacionNavioServicio
    {
        private ClasificacionNavioDao<ClasificacionNavio> dao;

        public ClasificacionNavioServicio()
        {
            dao = new ClasificacionNavioDaoSqlImpl();
        }

        public IList<ClasificacionNavio> ObtenerTipoNavio()
        {
            return dao.GetNavioTipo();
        }
    }
}
