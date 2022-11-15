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
            if (tb_ApellAutor.Text != "" && tb_NombAutor.Text != "" && cbx_genAutor.Text != "" && cbx_paisAutor.Text != "")
            {
                string apellido = tb_ApellAutor.Text;
                string nombre = tb_NombAutor.Text;
                int idpais = Convert.ToInt32(cbx_paisAutor.SelectedValue);
                int idgenero = Convert.ToInt32(cbx_genAutor.SelectedValue);
                string alias = tb_ApellAutor.Text + ", " + tb_NombAutor.Text;

                DatosConexion datosConexion = new DatosConexion();

                datosConexion.Insert("INSERT INTO AUTOR(Apellido,Nombre,idPais,idGenero, Alias) VALUES('" + apellido + "','" + nombre + "'," + idpais + "," + idgenero + ",'" + alias + "')");

                MessageBox.Show("El autor ha sido agregado exitosamente", "Añadir autor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Agregar();

                this.Close();
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            cbx_paisAutor.SelectedIndex = 0;
            cbx_genAutor.SelectedIndex = 0;
        }
        private void ComboBoxPais()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.SelectDT("SELECT * FROM Pais;");

            cbx_paisAutor.DataSource = datosConexion.dt;
            cbx_paisAutor.DisplayMember = "Pais";
            cbx_paisAutor.ValueMember = "idPais";
        }
        private void ComboBoxGen()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.SelectDT("SELECT * FROM Genero;");

            cbx_genAutor.DataSource = datosConexion.dt;
            cbx_genAutor.DisplayMember = "Genero";
            cbx_genAutor.ValueMember = "idGenero";
        }
        protected void Agregar()
        {
            principal.LlenarDgvAutor();
        }
        #endregion
    }
}
