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
    public class NegProvincia
    {
        AdmProvincia ObjDatosProvincia = new AdmProvincia();
        public List<Provincia> ObtenerProv()
        {
            return ObjDatosProvincia.ObtenerProv();
        }
    }
}
