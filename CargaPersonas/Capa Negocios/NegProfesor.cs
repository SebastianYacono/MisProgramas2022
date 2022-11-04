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
    public class NegProfesor
    {
        AdmProfesor DatosObjProfesor = new AdmProfesor();

        public int ABM_Profesores(string accion, Profesores objProfesor)
        {
            return DatosObjProfesor.ABM_Profe(accion, objProfesor);
        }

        public DataSet listaDeProfesores(string cual)
        {
            return DatosObjProfesor.listaProfe(cual);
        }
    }
}
