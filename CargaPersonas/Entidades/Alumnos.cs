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
        public Alumnos (int id, string nomb, string apell, string dom, long dni, DateTime fechaNac, long tel, string mail,int idProv, int idLoc, int cAnio, char cDiv, char cTurn) : base (id, nomb, apell, dom, dni, fechaNac, tel, mail, idProv, idLoc)
        {
            anioLect = cAnio;
            div = cDiv;
            turno = cTurn;
        }
        #endregion

        #region Atributos
        private int anioLect;
        private char div;
        private char turno;
        #endregion

        #region Propiedades
        public int p_AnioLect
        {
            set { anioLect = value; } get { return anioLect; }
        }
        public char p_div
        {
            set { div = value; } get { return div; }
        }
        public char p_turno
        {
            set { turno = value; } get { return div; }
        }

        #endregion

        #region Métodos

        #endregion

    }
}
