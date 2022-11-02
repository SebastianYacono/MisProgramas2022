using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Conexion
{
    public class AdmProfesor : datosConexion
    {
        public int ABM_Profe(string accion, Profesores ObjProfe)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "INSERT")
                orden = "INSERT into PROFESOR (Nombre, Apellido, Domicilio, DNI, FechaNac, Telefono, Email, idProv, idLoc, Legajo, CantHs) VALUES ('" + ObjProfe.p_nomb + "', '" + ObjProfe.p_apell + "', '" + ObjProfe.p_dom + "', " + ObjProfe.p_dni + ", '" + ObjProfe.p_fechaNac + "', " + ObjProfe.p_tel + ", '" + ObjProfe.p_mail + "', " + ObjProfe.p_idProv + ", " + ObjProfe.p_idLoc + ", '" + ObjProfe.p_legajo + "', " + ObjProfe.p_cantHs + ");";
            if (accion == "DELETE")
                orden = "DELETE FROM ALUMNO WHERE(idPersona = " + ObjProfe.p_id + ")";
            if (accion == "UPDATE")
                orden = "UPDATE PROFESOR SET Nombre = '" + ObjProfe.p_nomb + "', Apellido = '" + ObjProfe.p_apell + "', Domicilio = '" + ObjProfe.p_dom + "', DNI = " + ObjProfe.p_dni + ", FechaNac = '" + ObjProfe.p_fechaNac + "', Telefono = " + ObjProfe.p_tel + ", Email = '" + ObjProfe.p_mail + "', idProv = " + ObjProfe.p_idProv + ", idLoc = " + ObjProfe.p_idLoc + ", Legajo = '" + ObjProfe.p_legajo + "', CantHs = " + ObjProfe.p_cantHs + ";";


            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de Agregar,Borrar o Modificar un Profesor", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listaProfe(string cual)
        {
            string orden = string.Empty;

            if (cual != "SELECT")
                orden = "SELECT * FROM PROFESOR WHERE idPersona = " + int.Parse(cual) + ";";
            else
                orden = "SELECT * FROM ALUMNO;";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Productos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
