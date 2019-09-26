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
        IList<Navio> GetNavioById(Dictionary<string, object> parametros);

        IList<Navio> GetTodosLosNavios();

        bool RegistrerNavios(Navio oNavio);
        bool ModificateNavio(Navio oNavio);
        //bool DeleteNavio(Navio oNavio);
        //IList<ClasificacionNavio> GetNavioTipo();
    }
}
