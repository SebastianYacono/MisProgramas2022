using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;
using Entidades;

namespace Negocios
{
    public class NegLocalidad
    {
        AdmLocalidad ObjDatosLocalidad = new AdmLocalidad();
        public List<Localidad> ObtenerLoc(int idProvincia)
        {
            return ObjDatosLocalidad.ObtenerLoc(idProvincia);
        }
    }
}
