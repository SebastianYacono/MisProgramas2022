using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BiblioCaxial
{
    public partial class UpdateLibro : Form
    {
        Principal principal;

        int id = 0;
        string titulo = "";
        string autor = "";
        string genero = "";
        string desc = "";
        string idioma = "";
        string prov = "";
        string fecIng = "";
        bool disp = true;
        string ubi = "";
        string estado = "";
        public UpdateLibro(Principal ActLibro, int id, string titulo, string autor, string genero, string desc, string idioma, string prov, string fecIng,bool disp, string ubi, string estado)
        {
            InitializeComponent();
            comboBoxAutor();
            comboBoxGen();
            comboBoxIdioma();
            comboBoxEstado();
            comboBoxProv();

            this.principal = ActLibro;

            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.desc = desc;
            this.idioma = idioma;
            this.prov = prov;
            this.fecIng = fecIng;
            this.disp = disp;
            this.ubi = ubi;
            this.estado = estado;

            lbl_id.Text = id.ToString();
            tb_tituloLibro.Text = titulo;
            cbx_autorLibro.Text = autor;
            cbx_generoLibro.Text = genero;
            rtb_descLibro.Text = desc;
            cbx_idiomaLibro.Text = idioma;
            cbx_provLibro.Text = prov;
            dtp_fecIngLibro.Text = fecIng;
            tb_ubi.Text = ubi;
            cbx_estLibro.Text = estado;
            rb_Yes.Checked = true;
            rb_No.Checked = false;
            
        }
        #region Métodos de los botones
        private void Btn_EditLibro_Click(object sender, EventArgs e)
        {
            int idAutor = Convert.ToInt32(cbx_autorLibro.SelectedIndex);
            int idGenero = Convert.ToInt32(cbx_generoLibro.SelectedIndex);
            int idIdioma = Convert.ToInt32(cbx_idiomaLibro.SelectedIndex);
            int idProv = Convert.ToInt32(cbx_provLibro.SelectedIndex);
            int idEstado = Convert.ToInt32(cbx_estLibro.SelectedIndex);

            idAutor++;
            idGenero++;
            idIdioma++;
            idProv++;
            idEstado++;

            bool disp = true;

            DateTime fecIngreso = dtp_fecIngLibro.Value;

            if (rb_Yes.Checked)
            {
                disp = true;
            }
            if (rb_No.Checked)
            {
                disp = false;
            }

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Update("UPDATE LIBROS SET Titulo = '" + tb_tituloLibro.Text + "', idGenero = " + idGenero + ", idAutor = " + idAutor + ", Descripcion = '" + rtb_descLibro.Text + "', idProveedor = " + idProv + ", FechaIng = '" + fecIngreso + "', Disponible = " + disp + ", idIdioma = " + idIdioma + ", Ubicacion = '" + tb_ubi.Text + "', idEstado = " + idEstado + " WHERE idLibro = " + id);
            Thread.Sleep(1000);
            Agregar();

            MessageBox.Show("El libro ha sido cambiado exitosamente", "Editar libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void Btn_CloseLibro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos fuera de los botones
        protected void Agregar()
        {
            principal.LlenarDgvLibro();
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
