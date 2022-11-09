using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;

namespace Conexion
{
    public class AdmLocalidad : datosConexion
    {
        public List<Localidad> ObtenerLoc(int idProvincia)
        {
            List<Localidad> lista = new List<Localidad>();
            string orden = "SELECT IdLoc, IdProv, Localidad From LOCALIDAD WHERE idProv = " + idProvincia;
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            OleDbDataReader dr;
            try
            {
                AbrirConexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Localidad loc = new Localidad();
                    //loc.p_idLoc = dr.GetInt32(0);
                    loc.p_idLoc = Convert.ToInt32(dr["idLoc"]);
                    //loc.p_localidad = dr.GetString(1);
                    loc.p_localidad = dr["Localidad"].ToString();
                    lista.Add(loc);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Localidad", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return lista;
        }
    }
}
