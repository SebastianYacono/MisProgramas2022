using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial8agosto
{
    class Persona
    {
        #region atributos
        private string nombre;
        private long dni;
        private DateTime fechanac;
        #endregion

        #region Propiedades
        public string PropNombre
        {
            set { nombre = value; } get { return nombre; }
        }
        public long PropDni
        {
            set { dni = value; } get { return dni; }
        }
        public DateTime PropFecha
        {
            set { fechanac = value; } get { return fechanac; }
        }
        #endregion

        #region Constructores
        public Persona()
        { }

        public Persona(string nomb, long doc, DateTime fecha)
        {
            nombre = nomb;
            dni = doc;
            fechanac = fecha;
           
        }
        #endregion

        public int ResEdad()
        {
            return DateTime.Now.Year - fechanac.Year;
        }
    }
}
