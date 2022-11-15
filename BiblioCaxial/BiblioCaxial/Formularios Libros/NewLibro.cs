using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioCaxial
{
    public partial class NewLibro : Form
    {
        Principal principal;
        public NewLibro(Principal Libro)
        {
            InitializeComponent();
            principal = Libro;
            comboBoxAutor();
            comboBoxGen();
            comboBoxIdioma();
            comboBoxEstado();
            comboBoxProv();
            dtp_fecIngLibro.Value = DateTime.Now;
        }

        #region Métodos de los botones
        private void Btn_AddLibro_Click(object sender, EventArgs e)
        {
            if (tb_tituloLibro.Text != "" && tb_ubi.Text != "" && rtb_descLibro.Text != "" && cbx_autorLibro.Text != "" && cbx_estLibro.Text != "" && cbx_generoLibro.Text != "" && cbx_idiomaLibro.Text != "" && cbx_provLibro.Text != "")
            {
                string titulo = tb_tituloLibro.Text;//Titulo 
                int idAutor = Convert.ToInt32(cbx_autorLibro.SelectedValue);//idAutor
                int idGenero = Convert.ToInt32(cbx_generoLibro.SelectedValue);//idGenero
                string desc = rtb_descLibro.Text;//Descripción
                int idIdioma = Convert.ToInt32(cbx_idiomaLibro.SelectedValue);//idIdioma
                int idProv = Convert.ToInt32(cbx_provLibro.SelectedValue);//idProveedor
                DateTime fecIng = dtp_fecIngLibro.Value;//FechaIng
                bool disp = true;//Disponible
                string ubi = tb_ubi.Text;//Ubicacion
                int idEstado = Convert.ToInt32(cbx_estLibro.SelectedValue);//idEstado

                if (rb_Yes.Checked)
                {
                    disp = true;
                }
                if (rb_No.Checked)
                {
                    disp = false;
                }

                DatosConexion datosConexion = new DatosConexion();

                datosConexion.Insert("INSERT INTO LIBROS (Titulo, idAutor, idGenero, Descripcion, idIdioma, idProveedor, FechaIng, Disponible, Ubicacion, idEstado) VALUES('" + titulo + "', " + idAutor + ", " + idGenero + ", '" + desc + "', " + idIdioma + ", " + idProv + ", '" + fecIng + "', " + disp + ", '" + ubi + "', " + idEstado + ");");
 
                MessageBox.Show("El libro ha sido agregado exitosamente", "Añadir libro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Agregar();

                this.Close();
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_CloseLibro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_CleanLibro_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
        #endregion

        #region Métodos fuera de los botones
        protected void Agregar()
        {
            principal.LlenarDgvLibro();
        }
        private void limpiarForm()
        {
            tb_tituloLibro.Clear();
            cbx_autorLibro.SelectedIndex = 0;
            cbx_generoLibro.SelectedIndex = 0;
            tb_ubi.Clear();
            cbx_estLibro.SelectedIndex = 0;
            cbx_provLibro.SelectedIndex = 0;
            rtb_descLibro.Clear();
            rb_Yes.Checked = true;
            rb_No.Checked = false;
        }
        private void comboBoxAutor()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.SelectDT("SELECT AUTOR.idAutor, AUTOR.Alias FROM AUTOR;");

            cbx_autorLibro.DataSource = datosConexion.dt;
            cbx_autorLibro.DisplayMember = "Alias";
            cbx_autorLibro.ValueMember = "idAutor";
        }
        private void comboBoxGen()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.SelectDT("SELECT * FROM GENERO;");

            cbx_generoLibro.DataSource = datosConexion.dt;
            cbx_generoLibro.DisplayMember = "Genero";
            cbx_generoLibro.ValueMember = "idGenero";
        }
        private void comboBoxIdioma()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.SelectDT("SELECT * FROM IDIOMA;");

            cbx_idiomaLibro.DataSource = datosConexion.dt;
            cbx_idiomaLibro.DisplayMember = "Idioma";
            cbx_idiomaLibro.ValueMember = "idIdioma";
        }
        private void comboBoxEstado()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.SelectDT("SELECT * FROM ESTADO;");

            cbx_estLibro.DataSource = datosConexion.dt;
            cbx_estLibro.DisplayMember = "Estado";
            cbx_estLibro.ValueMember = "idEstado";
        }
        private void comboBoxProv()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.SelectDT("SELECT idProveedor, Nombre FROM PROVEEDOR;");

            cbx_provLibro.DataSource = datosConexion.dt;
            cbx_provLibro.DisplayMember = "Nombre";
            cbx_provLibro.ValueMember = "idProveedor";
        }
        #endregion
    }
}
