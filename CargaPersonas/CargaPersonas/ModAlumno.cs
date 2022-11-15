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
        Principal principal;
        Alumnos alumno;
        NegProvincia negProvincia = new NegProvincia();
        NegLocalidad negLocalidad = new NegLocalidad();
        NegAlumno NegAlumno = new NegAlumno();
        int idProvincia;
       public ModAlumno(Principal principal, Alumnos alumno)
        {
            InitializeComponent();
            LlenarCbxProv();
            LlenarCbxLoc();
            cbx_Anio.SelectedIndex = 0;
            cbx_Div.SelectedIndex = 0;
            cbx_Turno.SelectedIndex = 0;

            this.alumno = alumno;
            this.principal = principal;

            if (alumno != null)
            {
                MostrarDatos();
            }
        }

        #region Botones del formulario
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (tb_Apell.Text != "" && tb_Nomb.Text != "" && tb_Dni.Text != "" && tb_Dir.Text != "" && cbx_Prov.Text != "" && cbx_Loc.Text != "" && tb_Tel.Text != "" && tb_Mail.Text != "" && cbx_Anio.Text != "" && cbx_Div.Text != "" && cbx_Turno.Text != "")
            {
                if (NegAlumno.valTel(tb_Tel.Text) == true)
                {
                    if (NegAlumno.valDNI(tb_Dni.Text) == true)
                    {
                        alumno.p_apell = tb_Apell.Text;
                        alumno.p_nomb = tb_Nomb.Text;
                        alumno.p_dni = Convert.ToInt64(tb_Dni.Text);
                        alumno.p_fechaNac = dtp_fecNac.Value;
                        alumno.p_dom = tb_Dir.Text;
                        alumno.p_idProv = Convert.ToInt32(cbx_Prov.SelectedValue);
                        alumno.p_idLoc = Convert.ToInt32(cbx_Loc.SelectedValue);
                        alumno.p_tel = Convert.ToInt64(tb_Tel.Text);
                        alumno.p_mail = tb_Mail.Text;
                        alumno.p_AnioLect = Convert.ToInt32(cbx_Anio.Text);
                        alumno.p_div = cbx_Div.Text;
                        alumno.p_turno = cbx_Turno.Text;

                        int nResultado = -1;

                        nResultado = NegAlumno.ABM_Alumnos("UPDATE", alumno);
                        if (nResultado != -1)
                        {
                            principal.LlenarDgvAlumnos();
                            MessageBox.Show("El alumno fue modificado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Se produjo un error al intentar modificar el Producto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El DNI tiene que contar con 7 u 8 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El teléfono debe estar compuesto por Código de área sin 0 y teléfono sin 15. Ej.: 3514517225", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar completos para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funciones del formulario
        void LlenarCbxProv()
        {
            cbx_Prov.DataSource = negProvincia.ObtenerProv();
            cbx_Prov.DisplayMember = "p_prov";
            cbx_Prov.ValueMember = "p_idProv";
        }
        void LlenarCbxLoc()
        {
            cbx_Loc.DataSource = negLocalidad.ObtenerLoc();
            cbx_Loc.DisplayMember = "p_localidad";
            cbx_Loc.ValueMember = "p_idLoc";
        }
        private void cbx_Prov_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbx_Loc.Enabled = true;
            idProvincia = Convert.ToInt32(cbx_Prov.SelectedValue);
            cbx_Loc.DataSource = negLocalidad.ObtenerLoc(idProvincia);
            cbx_Loc.DisplayMember = "p_localidad";
            cbx_Loc.ValueMember = "p_idLoc";
        }
        private void MostrarDatos()
        {
            tb_Apell.Text = alumno.p_apell;
            tb_Nomb.Text = alumno.p_nomb;
            tb_Dni.Text = alumno.p_dni.ToString();
            dtp_fecNac.Value = alumno.p_fechaNac;
            tb_Dir.Text = alumno.p_dom;
            tb_Tel.Text = alumno.p_tel.ToString();
            cbx_Prov.SelectedValue = alumno.p_idProv;
            cbx_Loc.SelectedValue = alumno.p_idLoc;
            tb_Mail.Text = alumno.p_mail;
            foreach (var a in cbx_Anio.Items)
            {
                if (a.ToString() == alumno.p_AnioLect.ToString())
                    cbx_Anio.SelectedItem = a;
            }
            foreach (var d in cbx_Div.Items)
            {
                if (d.ToString() == alumno.p_div)
                    cbx_Div.SelectedItem = d;
            }
            foreach (var t in cbx_Turno.Items)
            {
                if (t.ToString() == alumno.p_turno)
                    cbx_Turno.SelectedItem = t;
            }
            cbx_Loc.Enabled = false;
        }
        #endregion
        
    }
}
