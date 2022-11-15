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
            dtp_fecIngLibro.Value = DateTime.Parse(fecIng);
            tb_ubi.Text = ubi;
            cbx_estLibro.Text = estado;
            rb_Yes.Checked = true;
            rb_No.Checked = false;
        }

        #region Métodos de los botones
        private void Btn_EditLibro_Click(object sender, EventArgs e)
        {
            if (tb_tituloLibro.Text != "" && tb_ubi.Text != "" && rtb_descLibro.Text != "" && cbx_autorLibro.Text != "" && cbx_estLibro.Text != "" && cbx_generoLibro.Text != "" && cbx_idiomaLibro.Text != "" && cbx_provLibro.Text != "")
            {
                int idAutor = Convert.ToInt32(cbx_autorLibro.SelectedValue);
                int idGenero = Convert.ToInt32(cbx_generoLibro.SelectedValue);
                int idIdioma = Convert.ToInt32(cbx_idiomaLibro.SelectedValue);
                int idProv = Convert.ToInt32(cbx_provLibro.SelectedValue);
                int idEstado = Convert.ToInt32(cbx_estLibro.SelectedValue);

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
            else
            {
                MessageBox.Show("Debes completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
