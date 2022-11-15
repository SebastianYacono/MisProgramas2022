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
    public class AdmAlumno : datosConexion
    {
        public int ABM_Alumno(string accion, Alumnos ObjAlumno)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "INSERT")
                orden = "INSERT INTO ALUMNO (Nombre, Apellido, Domicilio, DNI, FechaNac, Telefono, Email, idProv, idLoc, AnioCurs, Division, Turno) VALUES ('" + ObjAlumno.p_nomb + "', '" + ObjAlumno.p_apell + "', '" + ObjAlumno.p_dom + "', " + ObjAlumno.p_dni + ", '" + ObjAlumno.p_fechaNac + "', " + ObjAlumno.p_tel + ", '" + ObjAlumno.p_mail + "', " + ObjAlumno.p_idProv + ", " + ObjAlumno.p_idLoc + ", " + ObjAlumno.p_AnioLect + ", '" + ObjAlumno.p_div + "', '" + ObjAlumno.p_turno +"');";
            if (accion == "DELETE")
                orden = "DELETE FROM ALUMNO WHERE(idPersona = " + ObjAlumno.p_id + ")";
            if (accion == "UPDATE")
                orden = "UPDATE ALUMNO SET Nombre = '" + ObjAlumno.p_nomb + "', Apellido = '" + ObjAlumno.p_apell + "', Domicilio = '" + ObjAlumno.p_dom + "', DNI = " + ObjAlumno.p_dni + ", FechaNac = '" + ObjAlumno.p_fechaNac + "', Telefono = " + ObjAlumno.p_tel + ", Email = '" + ObjAlumno.p_mail + "', idProv = " + ObjAlumno.p_idProv + ", idLoc = " + ObjAlumno.p_idLoc + ", AnioCurs = " + ObjAlumno.p_AnioLect + ", Division = '" + ObjAlumno.p_div + "', Turno = '" + ObjAlumno.p_turno + "' WHERE idPersona= " + ObjAlumno.p_id + ";";


            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de Agregar, Borrar o Modificar un alumno", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listaAlumn(string cual)
        {
            string orden = string.Empty;

            if (cual != "SELECT")
                orden = "SELECT ALUMNO.IdPersona, ALUMNO.Apellido, ALUMNO.Nombre, ALUMNO.Domicilio, ALUMNO.DNI, ALUMNO.FechaNac, ALUMNO.Telefono, ALUMNO.Email, PROVINCIA.Provincia, LOCALIDAD.Localidad, ALUMNO.AnioCurs, ALUMNO.Division, ALUMNO.Turno, ALUMNO.idProv, ALUMNO.idLoc FROM PROVINCIA INNER JOIN (LOCALIDAD INNER JOIN ALUMNO ON LOCALIDAD.idLoc = ALUMNO.idLoc) ON (PROVINCIA.idProv = LOCALIDAD.idProv) WHERE idPersona = " + int.Parse(cual) + ";";
            else
                orden = "SELECT ALUMNO.IdPersona, ALUMNO.Apellido, ALUMNO.Nombre, ALUMNO.Domicilio, ALUMNO.DNI, ALUMNO.FechaNac, ALUMNO.Telefono, ALUMNO.Email, PROVINCIA.Provincia, LOCALIDAD.Localidad, ALUMNO.AnioCurs, ALUMNO.Division, ALUMNO.Turno, ALUMNO.idProv, ALUMNO.idLoc FROM PROVINCIA INNER JOIN (LOCALIDAD INNER JOIN ALUMNO ON LOCALIDAD.idLoc = ALUMNO.idLoc) ON (PROVINCIA.idProv = LOCALIDAD.idProv);";

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
                throw new Exception("Error al listar Alumnos", e);
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
