using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Localidad
    {
        #region Constructor
        public Localidad()
        {

        }
        #endregion

        #region Atributos
        private int idLoc;
        private int idProv;
        private string localidad;
        #endregion

        #region Propiedades
        public int p_idLoc
        {
            set { idLoc = value; } get { return idLoc; } 
        }
        public int p_idProv
        {
            set { idProv = value; } get { return idProv; }
        }
        public string p_localidad
        {
            set { localidad = value; } get { return localidad; }
        }
        #endregion

        #region Métodos

        #endregion
    }
}
