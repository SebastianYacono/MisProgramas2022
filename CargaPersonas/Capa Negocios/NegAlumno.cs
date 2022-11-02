using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;
using Entidades;

namespace Negocios
{
    internal class NegAlumno
    {
        AdmAlumno DatosObjAlumno = new AdmAlumno();

        public int abmProductos(string accion, Alumnos objAlumno)
        {
            return DatosObjAlumno.ABM_Alumno(accion, objAlumno);
        }

        public DataSet listadoProductos(string cual)
        {
            return DatosObjAlumno.listaAlumn(cual);
        }
    }
}
