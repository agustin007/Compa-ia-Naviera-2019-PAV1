﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compania_naviera.Acceso_a_datos.Dao.Interfaz;
using Compania_naviera.Negocio.Entidades;
using System.Data;
using Compania_naviera.Acceso_a_datos.Helper;

namespace Compania_naviera.Acceso_a_datos.Dao.Implementacion
{
    public class ViajeDaoSqlImpl : ViajeDao<Viaje>
    {
        public ViajeDaoSqlImpl() { }

        public IList<Navio> GetNavios()
        {
            List<Navio> lista = new List<Navio>();
            string sql = " SELECT cod_navio, nombre " +
                         " FROM Navios ";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoNavio(row));
            }
            return lista;
        }

        public IList<Itinerario> GetItinerarios()
        {
            List<Itinerario> lista = new List<Itinerario>();
            string sql = " SELECT cod_intinerarios, descripcion " +
                         " FROM Itinerarios";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoItinerario(row));
            }
            return lista;
        }

        public IList<Tripulacion> GetTripulaciones()
        {
            List<Tripulacion> lista = new List<Tripulacion>();

            string sql = " SELECT legajo, nombre " +
                         " FROM Tripulaciones ";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoTripulacion(row));
            }
            return lista;
        }
        public IList<Tripulacion> GetCargarTripulacion(int seleccionado)
        {
            List<Tripulacion> lista = new List<Tripulacion>();

            string sql = " SELECT legajo, nombre " +
                         " FROM Tripulaciones " +
                         " WHERE legajo = " + seleccionado.ToString();

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoTripulacion(row));
            }

            return lista;
        }

        public bool RegistrerViaje(Viaje oViaje)
        {
        
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string sqlViaje = string.Concat(" INSERT INTO Viajes(fecha_viaje, duracion, FK_cod_navio, FK_cod_itinerario) ",
                                                " VALUES(@fechaViaje , @Duracion, @Navio, @Itinerario) ");

                var parametros = new Dictionary<string, object>();
                parametros.Add("@fechaViaje", oViaje.FechaViaje);
                parametros.Add("@Duracion", oViaje.Duracion);
                parametros.Add("@Navio", oViaje.Navio.Codigo);
                parametros.Add("@Itinerario", oViaje.Itinerario.Codigo);

                dm.EjecutarSQL(sqlViaje,parametros);

                var idDelViaje = dm.ConsultaSQLScalar("SELECT @@IDENTITY");
                oViaje.IdViaje = Convert.ToInt32(idDelViaje);

                foreach (Tripulacion tripulacion in oViaje.TripulacionAsignada)
                {
                    string sqlAsignacion = string.Concat(" INSERT INTO Tripulante_x_viaje(id_viaje,legajo) " ,
                                           " VALUES(@idViaje,@legajo)" );

                    var parametrosAsignacion = new Dictionary<string, object>();
                    parametrosAsignacion.Add("@idViaje", oViaje.IdViaje);
                    parametrosAsignacion.Add("@legajo", tripulacion.Legajo);

                    dm.EjecutarSQL(sqlAsignacion, parametrosAsignacion);
                }
                dm.Commit();
            }
            catch (Exception)
            {
                dm.Rollback();
                throw;
            }
            return true;
        }
        public IList<Viaje> ObtainViaje(Dictionary<string, object> parametros)
        {
            List<Viaje> lista = new List<Viaje>();

            string sql = "SELECT t.*  " +
                         "FROM Viajes t" +
                         "WHERE 1 = 1";

            if (parametros.ContainsKey("fechaViaje"))
                sql += "AND (t.fecha_viaje = @fechaViaje)";

            DataTable resultado = DBHelper.getDBHelper().ConsultaSQLConParametros(sql, parametros);

            foreach(DataRow row in resultado.Rows)
            {
                lista.Add(mapeoViaje(row));
            }
            return lista;
        }

        public Viaje mapeoViaje(DataRow row)
        {
            Viaje oViaje = new Viaje();
            oViaje.FechaViaje = Convert.ToDateTime(row["fecha_viaje"].ToString());
            oViaje.Duracion = Convert.ToInt32(row["duracion"].ToString());
            oViaje.IdViaje = Convert.ToInt32(row["id_viaje"].ToString());
            oViaje.Navio = new Navio();
            oViaje.Navio.Codigo = Convert.ToInt32(row["cod_navio"].ToString());
            oViaje.Itinerario = new Itinerario();
            oViaje.Itinerario.Codigo = Convert.ToInt32(row["cod_intinerarios"].ToString());

            return oViaje;
        }
        public Tripulacion mapeoTripulacion(DataRow row)
        {
            Tripulacion oTripulacion = new Tripulacion();
            oTripulacion.Legajo = Convert.ToInt32(row["legajo"].ToString());
            oTripulacion.Nombre = row["nombre"].ToString();
            return oTripulacion;
        }

        public Itinerario mapeoItinerario(DataRow row)
        {
            Itinerario oItinerario = new Itinerario();
            oItinerario.Codigo = Convert.ToInt32(row["cod_intinerarios"].ToString());
            oItinerario.Descripcion = row["descripcion"].ToString();
            return oItinerario;
        }

        public Navio mapeoNavio(DataRow row)
        {
            Navio oNavio = new Navio();
            oNavio.Codigo = Convert.ToInt32(row["cod_navio"].ToString());
            oNavio.Nombre = row["nombre"].ToString();
            return oNavio;
        }
    }
}
