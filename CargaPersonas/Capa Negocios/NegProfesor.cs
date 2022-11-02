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
    internal class NegProfesor
    {
        AdmProfesor DatosObjProfesor = new AdmProfesor();

        public int abmProductos(string accion, Profesores objProfesor)
        {
            return DatosObjProfesor.ABM_Profe(accion, objProfesor);
        }

        public DataSet listadoProductos(string cual)
        {
            return DatosObjProfesor.listaProfe(cual);
        }
    }
}
