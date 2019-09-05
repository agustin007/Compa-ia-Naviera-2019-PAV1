using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compania_naviera.Acceso_a_datos.Dao.Interfaz
{
    public interface NavioDao<T>
    {
        IList<T> GetNavioById(int id);
    }
}
