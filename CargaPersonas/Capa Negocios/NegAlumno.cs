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
    public class NegAlumno
    {
        AdmAlumno DatosObjAlumno = new AdmAlumno();

        public int ABM_Alumnos(string accion, Alumnos objAlumno)
        {
            return DatosObjAlumno.ABM_Alumno(accion, objAlumno);
        }
        public DataSet listaDeAlumnos(string cual)
        {
            return DatosObjAlumno.listaAlumn(cual);
        }
        public bool valDNI(string ValidarDoc)
        {
            int i = 0;
            if (ValidarDoc.Length != 7 && ValidarDoc.Length != 8)
                return false;


            while (i <= ValidarDoc.Length - 1)
            {
                if (!char.IsDigit(ValidarDoc, i))
                    return false;
                i++;
            }
            return true;
        }
        public bool valTel(string ValidarTel)
        {
            int i = 0;
            if (ValidarTel.Length != 10)
                return false;


            while (i <= ValidarTel.Length - 1)
            {
                if (!char.IsDigit(ValidarTel, i))
                    return false;
                i++;
            }
            return true;
        }
    }
}
