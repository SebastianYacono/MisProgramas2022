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
        public OleDbDataReader reader;
        protected string cadenaCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BCaixal.mdb";

        public DatosConexion()
        {
            conexion = new OleDbConnection(cadenaCon);
        }

        public void Select(string sql)
        {
            AbrirConexion();
            OleDbCommand comando = new OleDbCommand(sql, conexion);


            comando.CommandType = CommandType.Text;

            try
            {
                reader = comando.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error\n\n" + e.Message);
            }
        }//Crea copia de DB a través de SELECT.

        public void Delete (string sql)
        {
            AbrirConexion();
            OleDbCommand comando = new OleDbCommand(sql, conexion);


            comando.CommandText = sql;

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error\n\n" + e.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }//Elimina fila en DB a través de DELETE.

        public void Insert (string sql)
        { 
            AbrirConexion();
            OleDbCommand comando = new OleDbCommand(sql, conexion);


            comando.CommandText = sql;

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error\n\n" + e.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }//Crea nuevas filas en DB a través de INSERT.

        public void Update(string sql)
        {
            AbrirConexion();
            OleDbCommand comando = new OleDbCommand(sql, conexion);


            comando.CommandText = sql;

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error\n\n" + e.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }//Modifica filas en DB a través de UPDATE.


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
                MessageBox.Show("No se puede abrir la conexión a la base de datos.\n\n" + e);
            }
        }//Abre conexión.

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
                MessageBox.Show("No se puede cerrar la conexión a la base de datos.\n\n" + e);
            }
        }//Cierra conexión.

        public void ProbarConexion()
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

                MessageBox.Show("No hay conexión a la Base de Datos.\n\n" + e);
            }
            CerrarConexion();
        }
    }
}
