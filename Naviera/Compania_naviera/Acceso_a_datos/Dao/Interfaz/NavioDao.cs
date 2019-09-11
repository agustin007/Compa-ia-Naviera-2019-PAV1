using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Negocio.Entidades;
namespace Compania_naviera.Acceso_a_datos.Dao.Interfaz
{
    public interface NavioDao<T>
    {
        IList<T> GetNavioById(int id);

        IList<T> GetTodosLosNavios();

        bool RegistrerNavios(Navio oNavio);
        IList<Clasificacion_Navio> GetNavioTipo();
    }
}
