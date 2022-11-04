using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        #region Constructor
        public Provincia()
        {

        }
        #endregion

        #region Atributos
        private int idProv;
        private string prov;
        #endregion

        #region Propiedades
        public int p_idProv
        {
            set { idProv = value; }
            get { return idProv; }
        }
        public string p_prov
        {
            set { prov = value; }
            get { return prov; }
        }
        #endregion

        #region Métodos

        #endregion
    }
}

