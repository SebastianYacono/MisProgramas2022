using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesores : Persona
    {
        #region Atributos
        private string legajo;
        private int cantHs;
        #endregion

        #region Constructor
        public Profesores(int id, string nomb, string apell, string dom, long dni, DateTime fechaNac, decimal tel, string mail, int idProv, int idLoc, string cLegajo, int cCantHs) : base(id, nomb, apell, dom, dni, fechaNac, tel, mail, idProv, idLoc)
        {
            legajo = cLegajo;
            cantHs = cCantHs;
        }

        public Profesores(string nomb, string apell, string dom, long dni, DateTime fechaNac, decimal tel, string mail, int idProv, int idLoc, string cLegajo, int cCantHs) : base(nomb, apell, dom, dni, fechaNac, tel, mail, idProv, idLoc)
        {
            legajo = cLegajo;
            cantHs = cCantHs;
        }

        public Profesores()
        {
            legajo = "";
            cantHs = 0;
        }
        #endregion

        #region Propiedades
        public string p_legajo
        {
            set { legajo = value; } get { return legajo; } 
        }
        public int p_cantHs
        {
            set { cantHs = value; } get { return cantHs; }
        }
        #endregion

        #region Métodos

        #endregion
    }
}
