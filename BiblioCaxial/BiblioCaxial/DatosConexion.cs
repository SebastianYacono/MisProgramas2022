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
        public DataTable dt = new DataTable();
        protected string cadenaCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BCaixal.mdb";

        public DatosConexion()
        {
            conexion = new OleDbConnection(cadenaCon);
        }

        public void Select(string sql)//Crea copia de DB a través de SELECT.
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
        }
        public void SelectDT(string sql)//Crea copia de DB a través de SELECT.
        {
            AbrirConexion();
            OleDbCommand comando = new OleDbCommand(sql, conexion);


            comando.CommandType = CommandType.Text;

            try
            {
                dt.Load (comando.ExecuteReader());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error\n\n" + e.Message);
            }
        }
        public void Delete(string sql)//Elimina fila en DB a través de DELETE.
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
        }
        public void Insert(string sql)//Crea nuevas filas en DB a través de INSERT.
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
        }
        public void Update(string sql)//Modifica filas en DB a través de UPDATE.
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
        }


        public void AbrirConexion()//Abre conexión.
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
        }
        public void CerrarConexion()//Cierra conexión.
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
        }
        public void ProbarConexion()//Prueba conexión.
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
