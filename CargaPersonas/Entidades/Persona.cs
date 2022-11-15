using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Constructor
        public Persona(int cId, string cNomb, string cApell, string cDom, long cDni, DateTime cFechaNac, decimal cTel, string cMail, int cIdProv, int cIdLoc)
        {
            id = cId;
            nomb = cNomb;
            apell = cApell;
            dom = cDom;
            dni = cDni;
            fechaNac = cFechaNac;
            tel = cTel;
            mail = cMail;
            idProv = cIdProv;
            idLoc = cIdLoc;
        }
        public Persona (string cNomb, string cApell, string cDom, long cDni, DateTime cFechaNac, decimal cTel, string cMail, int cIdProv, int cIdLoc)
        {
            nomb = cNomb;
            apell = cApell;
            dom = cDom;
            dni = cDni;
            fechaNac = cFechaNac;
            tel = cTel;
            mail = cMail;
            idProv = cIdProv;
            idLoc = cIdLoc;
        }
        public Persona()
        {
            nomb = "";
            apell = "";
            dom = "";
            dni = 0;
            fechaNac = DateTime.Today;
            tel = 0;
            mail = "";
        }
        #endregion

        #region Atributos
        private int id;
        private string nomb;
        private string apell;
        private string dom;
        private long dni;
        DateTime fechaNac;
        private decimal tel;
        private string mail;
        int idProv;
        private int idLoc;
        #endregion

        #region Propiedades
        public int p_id
        {
            set { id = value; } get { return id; } 
        }
        public string p_nomb
        {
            set { nomb = value; } get { return nomb; }
        }
        public string p_apell
        {
            set { apell = value; } get { return apell; }
        }
        public string p_dom
        {
            set { dom = value; } get { return dom; }
        }
        public long p_dni
        {
            set { dni = value; } get { return dni; }
        }
        public DateTime p_fechaNac
        {
            set { fechaNac = value; } get { return fechaNac; }
        }
        public decimal p_tel
        {
            set { tel = value; } get { return tel; }
        }
        public string p_mail
        {
            set { mail = value; } get { return mail; }
        }
        public int p_idProv
        {
            set { idProv = value; } get { return idProv; }
        }
        public int p_idLoc
        {
            set { idLoc = value; } get { return idLoc; }
        }
        #endregion

        #region Métodos

        #endregion
    }
}
