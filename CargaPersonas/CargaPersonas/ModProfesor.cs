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
    public partial class ModProfesor : Form
    {
        Principal principal;

        Profesores profesor;
        NegProvincia negProvincia = new NegProvincia();
        NegLocalidad negLocalidad = new NegLocalidad();
        NegProfesor negProfesor = new NegProfesor();
        int idProvincia;
        public ModProfesor(Principal principal, Profesores profesor)
        {
            InitializeComponent();
            LlenarCbxProv();
            LlenarCbxLoc();

            this.profesor = profesor;
            this.principal = principal;

            if (profesor != null)
            {
                MostrarDatos();
            }
        }

        #region Botones del formulario
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (tb_Apell.Text != "" && tb_Nomb.Text != "" && tb_Dni.Text != "" && tb_Dir.Text != "" && cbx_Prov.Text != "" && cbx_Loc.Text != "" && tb_Tel.Text != "" && tb_Mail.Text != "" && tb_Legajo.Text != "" && tb_Horas.Text != "")
            {
                if (negProfesor.valTel(tb_Tel.Text) == true)
                {
                    if (negProfesor.valNum(tb_Horas.Text) == true)
                    {
                        if (negProfesor.valDNI(tb_Dni.Text) == true)
                        {

                            profesor.p_apell = tb_Apell.Text;
                            profesor.p_nomb = tb_Nomb.Text;
                            profesor.p_dni = Convert.ToInt64(tb_Dni.Text);
                            profesor.p_fechaNac = dtp_fecNac.Value;
                            profesor.p_dom = tb_Dir.Text;
                            profesor.p_idProv = Convert.ToInt32(cbx_Prov.SelectedValue);
                            profesor.p_idLoc = Convert.ToInt32(cbx_Loc.SelectedValue);
                            profesor.p_tel = Convert.ToInt64(tb_Tel.Text);
                            profesor.p_mail = tb_Mail.Text;
                            profesor.p_legajo = tb_Legajo.Text;
                            profesor.p_cantHs = Convert.ToInt32(tb_Horas.Text);

                            int nResultado = -1;

                            nResultado = negProfesor.ABM_Profesores("UPDATE", profesor);
                            if (nResultado != -1)
                            {
                                principal.LlenarDgvProfesor();
                                MessageBox.Show("El profesor fue modificado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("En cantidad de horas solo se pueden poner valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            tb_Apell.Text = profesor.p_apell;
            tb_Nomb.Text = profesor.p_nomb;
            tb_Dni.Text = profesor.p_dni.ToString();
            dtp_fecNac.Value = profesor.p_fechaNac;
            tb_Dir.Text = profesor.p_dom;
            tb_Tel.Text = profesor.p_tel.ToString();
            cbx_Prov.SelectedValue = profesor.p_idProv;
            cbx_Loc.SelectedValue = profesor.p_idLoc;
            tb_Mail.Text = profesor.p_mail;
            tb_Legajo.Text = profesor.p_legajo;
            tb_Horas.Text = profesor.p_cantHs.ToString();

            cbx_Loc.Enabled = false;
        }
        #endregion

    }
}
