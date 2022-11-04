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
    public partial class InfLibro : Form
    {
        Principal principal;


        string titulo = "";
        string autor = "";
        string genero = "";
        string desc = "";
        string idioma = "";
        string prov = "";
        string fecIng = "";
        string ubi = "";
        string estado = "";
        public InfLibro(Principal InfLibro, string titulo, string autor, string genero, string desc, string idioma, string prov, string fecIng, string ubi, string estado)
        {
            InitializeComponent();
            this.principal = InfLibro;

            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.desc = desc;
            this.idioma = idioma;
            this.prov = prov;
            this.fecIng = fecIng;
            this.ubi = ubi;
            this.estado = estado;

            tb_tituloLibro.Text = titulo;
            cbx_autorLibro.Text = autor;
            cbx_generoLibro.Text = genero;
            rtb_descLibro.Text = desc;
            cbx_idiomaLibro.Text = idioma;
            cbx_provLibro.Text = prov;
            dtp_fecIngLibro.Text = fecIng;
            tb_ubi.Text = ubi;
            cbx_estLibro.Text = estado;
        }

        private void Btn_CloseLibro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
