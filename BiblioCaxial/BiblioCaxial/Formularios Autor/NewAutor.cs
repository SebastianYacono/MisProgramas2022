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
        }

        protected void Agregar()
        {
            principal.LlenarDgvAutor();
        }
        private void Btn_AddAutor_Click(object sender, EventArgs e)
        {
            string apellido = tb_ApellAutor.Text;
            string nombre = tb_NombAutor.Text;
            int idpais = Convert.ToInt32(cbx_paisAutor.SelectedIndex);

            idpais++;

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Insert("INSERT INTO AUTOR(Apellido,Nombre,idPais) VALUES('" + apellido + "','" + nombre + "'," + idpais + ")");

            MessageBox.Show("El autor ha sido agregado exitosamente", "Añadir proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void limpiarForm()
        {
            tb_ApellAutor.Clear();
            tb_NombAutor.Clear();
            cbx_paisAutor.Text = "";
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

        
    }
}
