using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;
using Compania_naviera.Negocio.Entidades;
using Compania_naviera.Acceso_a_datos.Helper;
using System.Data;

namespace Compania_naviera.Acceso_a_datos.Dao.Implementacion
{
    public class ClasificacionNavioDaoSqlImpl : ClasificacionNavioDao<ClasificacionNavio>
    {
        public ClasificacionNavioDaoSqlImpl() { }

        public IList<ClasificacionNavio> GetNavioTipo()
        {
            List<ClasificacionNavio> listadoNavioTipo = new List<ClasificacionNavio>();

            string sql = @"SELECT * " +
                          "FROM clasificacion_navio";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach (DataRow row in resultado.Rows)
            {
                listadoNavioTipo.Add(mapeoTipoNavio(row));
            }
            return listadoNavioTipo;
        }
        private ClasificacionNavio mapeoTipoNavio(DataRow row)
        {
            ClasificacionNavio oNavio = new ClasificacionNavio()
            {
                CodClasificacion = Convert.ToInt32(row["cod_clasificacion"].ToString()),
                Descripcion = row["descripcion"].ToString()
            };
            //oNavio.CodClasificacion = Convert.ToInt32(row["CodClasificacion"].ToString());
            //oNavio.Descripcion = row["Descripcion"].ToString();

            return oNavio;
        }
    }
}
