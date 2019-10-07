using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Negocio.Entidades;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;
using Compania_naviera.Acceso_a_datos.Helper;
using System.Data;
namespace Compania_naviera.Acceso_a_datos.Dao.Implementacion
{
    public class TripulacionDaoSqlImpl: TripulacionDao<Tripulacion>
    {
        public TripulacionDaoSqlImpl() { }

        public IList<Puestos> GetPuestos()
        {
            List<Puestos> lista = new List<Puestos>();
            string sql = @"SELECT * " +
                          "FROM Puestos";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoPuestos(row));
            }
            return lista;
        }
        public IList<Tripulacion> GetTripulacionesDeAlta()
        {
            IList<Tripulacion> lista = new List<Tripulacion>();
            string sql = @"SELECT t.*, t1.descripcion " +
                          "FROM Tripulaciones t, Puestos t1 " +
                          " WHERE t.estado = 'true'";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach (DataRow row in resultado.Rows)
            {
                lista.Add(mapeoTripulacion(row));
            }
            return lista;
        }
        public IList<Tripulacion> GetTodasLasTripulacion()
        {
            IList<Tripulacion> lista = new List<Tripulacion>();
            string sql = @"SELECT t.*, t1.descripcion " +
                          "FROM Tripulaciones t, Puestos t1 " + 
                          " WHERE t.FK_cod_puesto = t1.cod_puesto";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoTripulacion(row));
            }
            return lista;
        }
        public IList<Tripulacion> GetTripulacionPorFiltro(Dictionary<string,object> parametros)
        {
            List<Tripulacion> lista = new List<Tripulacion>();
            string sql = "SELECT t.*, t1.cod_puesto " +
                         "FROM Tripulaciones t, Puestos t1 " +
                         "WHERE t.FK_cod_puesto = t1.cod_puesto";

            if (parametros.ContainsKey("Nombre"))
                sql += " AND (t.nombre LIKE '%' + @Nombre + '%') ";

            if (parametros.ContainsKey("CodPuesto"))
                sql += "AND t.FK_cod_puesto = @Cod_puesto";
            
            DataTable resultado = DBHelper.getDBHelper().ConsultaSQLConParametros(sql, parametros);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoTripulacion(row));
            }

            return lista;
        }

        public bool RegistrerTripulacion(Tripulacion oTripulacion)
        {
            string sql = @"INSERT INTO Tripulaciones(legajo,nombre,FK_cod_puesto)" + 
                          "VALUES(@Legajo, @Nombre, @Puesto)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("@Legajo", oTripulacion.Legajo);
            parametros.Add("@Nombre", oTripulacion.Nombre);
            parametros.Add("@Puesto", oTripulacion.CodPuesto.CodPuesto);

            return DBHelper.getDBHelper().EjecutarSQL(sql, parametros) == 1;
        }

        public bool ModificateTripulacion(Tripulacion oTripulacionSeleccionada)
        {
            string sql = @"UPDATE Tripulaciones " +
                          "SET nombre = @nombre," +
                          "FK_cod_puesto = @Puesto," +
                          "estado = @Estado" + 
                          " WHERE legajo = @legajo";

            var parametros = new Dictionary<string, object>();
            parametros.Add("@Legajo", oTripulacionSeleccionada.Legajo);
            parametros.Add("@Nombre", oTripulacionSeleccionada.Nombre);
            parametros.Add("@Puesto", oTripulacionSeleccionada.CodPuesto.CodPuesto);
            parametros.Add("@Estado", oTripulacionSeleccionada.Estado);

            return DBHelper.getDBHelper().EjecutarSQL(sql, parametros) == 1;
        }

        public Tripulacion mapeoTripulacion(DataRow row)
        {
            Tripulacion oTripulacion = new Tripulacion();
            {
                oTripulacion.Legajo = Convert.ToInt32(row["legajo"].ToString());
                oTripulacion.Nombre = row["nombre"].ToString();
                oTripulacion.LegajoJefe = Convert.ToInt32(row["FK_legajo_jefe"].ToString());
                oTripulacion.CodPuesto = new Puestos()
                {
                    CodPuesto = Convert.ToInt32(row["FK_cod_puesto"].ToString()),
                    Descripcion = row["descripcion"].ToString()
                };
                oTripulacion.Estado = row["estado"].ToString();

            }
            return oTripulacion;
        }
        public Puestos mapeoPuestos(DataRow row)
        {
            Puestos oPuestos = new Puestos();
            {
                oPuestos.CodPuesto = Convert.ToInt32(row["cod_puesto"].ToString());
                oPuestos.Descripcion = row["descripcion"].ToString();
            };
            return oPuestos;
        }
    }
}
