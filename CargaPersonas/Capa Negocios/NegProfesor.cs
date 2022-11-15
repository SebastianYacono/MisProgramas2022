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
        public bool valNum(string Numero)
        {
            int i = 0;
            while (i <= Numero.Length - 1)
            {
                if (!char.IsDigit(Numero, i))
                    return false;
                i++;
            }
            return true;
        }
    }
}
