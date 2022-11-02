using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BiblioCaxial
{
    public partial class NewAutor : Form
    {
        Principal principal;
        public NewAutor(Principal autor)
        {
            InitializeComponent();
            principal = autor;
            ComboBoxPais();
            ComboBoxGen();
        }

        #region Métodos de los botones
        private void Btn_AddAutor_Click(object sender, EventArgs e)
        {
            string apellido = tb_ApellAutor.Text;
            string nombre = tb_NombAutor.Text;
            int idpais = Convert.ToInt32(cbx_paisAutor.SelectedIndex);
            int idgenero = Convert.ToInt32(cbx_genAutor.SelectedIndex);
            string alias = tb_ApellAutor.Text + ", " + tb_NombAutor.Text;

            idpais++;
            idgenero++;

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Insert("INSERT INTO AUTOR(Apellido,Nombre,idPais,idGenero, Alias) VALUES('" + apellido + "','" + nombre + "'," + idpais + "," + idgenero + ",'" + alias +"')");

            MessageBox.Show("El autor ha sido agregado exitosamente", "Añadir autor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Agregar();

            limpiarForm();
        }
        private void Btn_CloseAutor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_CleanAutor_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
        #endregion


        #region Métodos fuera de los botones
        private void limpiarForm()
        {
            tb_ApellAutor.Clear();
            tb_NombAutor.Clear();
            cbx_paisAutor.Text = "";
            cbx_genAutor.Text = "";
        }
        private void ComboBoxPais()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT * FROM Pais;");

            while (datosConexion.reader.Read())
            {
                List<object> CamposPais = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposPais.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposPais.Add(datosConexion.reader.GetString(1));
                }

                cbx_paisAutor.Items.Add(datosConexion.reader.GetString(1));
            }
        }
        private void ComboBoxGen()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT * FROM Genero;");

            while (datosConexion.reader.Read())
            {
                List<object> CamposGen = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposGen.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposGen.Add(datosConexion.reader.GetString(1));
                }

                cbx_genAutor.Items.Add(datosConexion.reader.GetString(1));
            }
        }
        protected void Agregar()
        {
            principal.LlenarDgvAutor();
        }
        #endregion

    }
}
