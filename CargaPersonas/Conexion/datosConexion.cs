using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Conexion
{
    public class datosConexion
    {
        protected OleDbConnection conexion;
        public OleDbDataReader reader;
        protected string cadenaCon = @"Provider=Microsoft.Jet.OLEDB.4.0;;Data Source=C:\DataBases\PersFinal.mdb";

        public datosConexion()
        {
            conexion = new OleDbConnection(cadenaCon);
        }

        #region Comandos SQL
        /*
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
                throw new Exception("Error\n\n", e);
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
                throw new Exception("Error\n\n", e);
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
                throw new Exception("Error\n\n", e);
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
                throw new Exception("Error\n\n", e);
            }
            finally
            {
                CerrarConexion();
            }
        }*/
        #endregion


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
                throw new Exception("Error\n\n", e);
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
                throw new Exception("Error\n\n", e);
            }
        }
    }
}
