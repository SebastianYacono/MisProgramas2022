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
    public partial class NuevoAlumno : Form
    {
        Principal principal;
        Alumnos alumnos;
        NegAlumno negAlumno = new NegAlumno();
        NegProvincia negProvincia = new NegProvincia();
        NegLocalidad negLocalidad = new NegLocalidad();
        public NuevoAlumno(Principal Alumno)
        {
            InitializeComponent();
            principal = Alumno;
            LlenarCbxProv();
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            alumnos = new Alumnos(tb_Apell.Text, tb_Nomb.Text, tb_Dir.Text, Convert.ToInt32(tb_Dni.Text), DateTime.Parse(dtp_fecNac.Text), Convert.ToInt32(tb_Tel.Text), tb_Mail.Text, Convert.ToInt32(cbx_Prov.SelectedIndex), Convert.ToInt32(cbx_Loc.SelectedIndex), Convert.ToInt32(cbx_Anio.Text), cbx_Div.Text, cbx_Turno.Text);

            nGrabados = negAlumno.ABM_Alumnos("INSERT", alumnos);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el Alumno en el sistema");
            }
            else
            {
                principal.LlenarDgvAlumnos();
            }
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
            cbx_Loc.Enabled = false;
        }
        void LlenarCbxProv()
        {
            cbx_Prov.DataSource = negProvincia.ObtenerProv();
            cbx_Prov.DisplayMember = "p_prov";
            cbx_Prov.ValueMember = "p_idProv";
        }
        private void cbx_Prov_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbx_Loc.Enabled = true;
            cbx_Loc.DataSource = negLocalidad.ObtenerLoc(Convert.ToInt32(cbx_Prov.SelectedValue));
            cbx_Loc.DisplayMember = "p_localidad";
            cbx_Loc.ValueMember = "p_idLoc";
        }
    }
}
