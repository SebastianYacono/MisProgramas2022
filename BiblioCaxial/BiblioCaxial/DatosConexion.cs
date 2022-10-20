using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BiblioCaxial
{
    internal class DatosConexion
    {
        protected OleDbConnection conexion;
        protected string cadenaCon = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Estudio\Desarrollo de Software\SEGUNDO AÑO\Programación II\Mis programas 2022\BiblioCaxial\BiblioCaxial\bd\BCaixal.mdb";

        public DatosConexion()
        {
            conexion = new OleDbConnection(cadenaCon);
        }

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch (Exception e)
            {

                throw new Exception("No se puede abrir la conexión a la base de datos", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se puede cerrar la conexión a la base de datos", e);
            }
        }

        public void probarConexion()
        {
            try
            {
                AbrirConexion();
                if (conexion.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexión exitosa a la Base de Datos");
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e + "\n\nNo hay conexión a la Base de Datos.");
            }
            CerrarConexion();
        }
    }
}
