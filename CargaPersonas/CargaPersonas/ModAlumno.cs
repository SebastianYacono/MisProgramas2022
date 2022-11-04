using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace CargaPersonas
{
    public partial class ModAlumno : Form
    {
        NegProvincia negProvincia = new NegProvincia();
        public ModAlumno()
        {
            InitializeComponent();
            LlenarCbxProv();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }


        public void limpiarForm()
        {
            tb_Apell.Clear();
            tb_Nomb.Clear();
            tb_Dni.Clear();
            tb_Dir.Clear();
            cbx_Prov.Text = "";
            cbx_Loc.Text = "";
            tb_Tel.Clear();
            tb_Mail.Clear();
            cbx_Anio.Text = "";
            cbx_Div.Text = "";
            cbx_Turno.Text = "";
        }
        void LlenarCbxProv()
        {
            cbx_Prov.DataSource = negProvincia.ObtenerProv();
            cbx_Prov.DisplayMember = "p_prov";
            cbx_Prov.ValueMember = "p_idProv";

        }
    }
}
