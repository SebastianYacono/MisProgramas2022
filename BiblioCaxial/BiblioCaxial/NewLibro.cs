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
        }

        #region Métodos de los botones
        private void Btn_AddLibro_Click(object sender, EventArgs e)
        {
            string titulo = tb_tituloLibro.Text;//Titulo 
            int idAutor = Convert.ToInt32(cbx_autorLibro.SelectedIndex);//idAutor
            int idGenero = Convert.ToInt32(cbx_generoLibro.SelectedIndex);//idGenero
            string desc = rtb_descLibro.Text;//Descripción
            int idIdioma = Convert.ToInt32(cbx_idiomaLibro.SelectedIndex);//idIdioma
            int idProv = Convert.ToInt32(cbx_provLibro.SelectedIndex);//idProveedor
            DateTime fecIng = dtp_fecIngLibro.Value;//FechaIng
            bool disp = true;//Disponible
            string ubi = tb_ubi.Text;//Ubicacion
            int idEstado = Convert.ToInt32(cbx_estLibro.SelectedIndex);//idEstado

            idAutor++;
            idGenero++;
            idIdioma++;
            idProv++;
            idEstado++;

            if (rb_Yes.Checked)
            {
                disp = true;
            }
            if (rb_No.Checked)
            {
                disp= false;
            }    

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Insert("INSERT INTO LIBROS (Titulo, idAutor, idGenero, Descripcion, idIdioma, idProveedor, FechaIng, Disponible, Ubicacion, idEstado) VALUES('" + titulo + "', " + idAutor + ", " + idGenero + ", '" + desc + "', " + idIdioma + ", " + idProv + ", '" + fecIng + "', " + disp + ", '" + ubi + "', " + idEstado + ");");

            MessageBox.Show("El libro ha sido agregado exitosamente", "Añadir libro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Agregar();

            limpiarForm();
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
            cbx_autorLibro.Text = "";
            cbx_generoLibro.Text = "";
            tb_ubi.Clear();
            cbx_estLibro.Text = "";
            cbx_provLibro.Text = "";
            rtb_descLibro.Clear();
            rb_Yes.Checked = true;
            rb_No.Checked = false;
        }
        private void comboBoxAutor()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT AUTOR.idAutor, AUTOR.Alias FROM AUTOR;");

            while (datosConexion.reader.Read())
            {
                List<object> CamposAut = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposAut.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposAut.Add(datosConexion.reader.GetString(1));
                }

                cbx_autorLibro.Items.Add(datosConexion.reader.GetString(1));
            }
        }
        private void comboBoxGen()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT * FROM GENERO;");

            while (datosConexion.reader.Read())
            {
                List<object> CamposAut = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposAut.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposAut.Add(datosConexion.reader.GetString(1));
                }

                cbx_generoLibro.Items.Add(datosConexion.reader.GetString(1));
            }
        }
        private void comboBoxIdioma()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT * FROM IDIOMA;");

            while (datosConexion.reader.Read())
            {
                List<object> CamposAut = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposAut.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposAut.Add(datosConexion.reader.GetString(1));
                }

                cbx_idiomaLibro.Items.Add(datosConexion.reader.GetString(1));
            }
        }
        private void comboBoxEstado()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT * FROM ESTADO;");

            while (datosConexion.reader.Read())
            {
                List<object> CamposAut = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposAut.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposAut.Add(datosConexion.reader.GetString(1));
                }

                cbx_estLibro.Items.Add(datosConexion.reader.GetString(1));
            }
        }
        private void comboBoxProv()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT idProveedor, Nombre FROM PROVEEDOR;");

            while (datosConexion.reader.Read())
            {
                List<object> CamposAut = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposAut.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposAut.Add(datosConexion.reader.GetString(1));
                }

                cbx_provLibro.Items.Add(datosConexion.reader.GetString(1));
            }
        }
        #endregion


    }
}
