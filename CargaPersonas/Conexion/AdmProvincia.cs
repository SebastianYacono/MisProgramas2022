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
    public class AdmProvincia : datosConexion
    {
        public List<Provincia> ObtenerProv()
        {
            List<Provincia> lista = new List<Provincia>();
            string orden = "SELECT IdProv, Provincia From PROVINCIA";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            OleDbDataReader dr;
            try
            {
                AbrirConexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Provincia prov = new Provincia();
                    prov.p_idProv = dr.GetInt32(0);                    
                    prov.p_prov = dr.GetString(1);
                    lista.Add(prov);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Provincia", e);
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
