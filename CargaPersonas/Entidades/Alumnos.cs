using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumnos : Persona
    {
        #region Constructor
        public Alumnos (int id, string nomb, string apell, string dom, long dni, DateTime fechaNac, decimal tel, string mail,int idProv, int idLoc, int cAnio, string cDiv, string cTurn) : base (id, nomb, apell, dom, dni, fechaNac, tel, mail, idProv, idLoc)
        {
            anioLect = cAnio;
            div = cDiv;
            turno = cTurn;
        }

        public Alumnos(string nomb, string apell, string dom, long dni, DateTime fechaNac, decimal tel, string mail, int idProv, int idLoc, int cAnio, string cDiv, string cTurn) : base(nomb, apell, dom, dni, fechaNac, tel, mail, idProv, idLoc)
        {
            anioLect = cAnio;
            div = cDiv;
            turno = cTurn;
        }

        public Alumnos()
        {
            anioLect = 0;
            div = "";
            turno = "";
        }
        #endregion

        #region Atributos
        private int anioLect;
        private string div;
        private string turno;

        #endregion

        #region Propiedades
        public int p_AnioLect
        {
            set { anioLect = value; } get { return anioLect; }
        }
        public string p_div
        {
            set { div = value; } get { return div; }
        }
        public string p_turno
        {
            set { turno = value; } get { return turno; }
        }

        #endregion

        #region Métodos

        #endregion

    }
}
