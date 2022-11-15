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
    public partial class NuevoProfesor : Form
    {
        Principal principal;
        Profesores profesores;
        NegProfesor negProfesor = new NegProfesor();
        NegProvincia negProvincia = new NegProvincia();
        NegLocalidad negLocalidad = new NegLocalidad();
        public NuevoProfesor(Principal Profesor)
        {
            InitializeComponent();
            principal = Profesor;
            LlenarCbxProv();
        }

        #region Botones del formulario
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (tb_Apell.Text != "" && tb_Nomb.Text != "" && tb_Dni.Text != "" && tb_Dir.Text != "" && cbx_Prov.Text != "" && cbx_Loc.Text != "" && tb_Tel.Text != "" && tb_Mail.Text != "" && tb_Legajo.Text != "" && tb_Horas.Text != "")
            {
                if (negProfesor.valTel(tb_Tel.Text) == true)
                {
                    if (negProfesor.valNum(tb_Horas.Text) == true)
                    {
                        if (negProfesor.valDNI(tb_Dni.Text) == true)
                        {
                            int nGrabados = -1;

                            profesores = new Profesores(tb_Nomb.Text, tb_Apell.Text, tb_Dir.Text, Convert.ToInt64(tb_Dni.Text), DateTime.Parse(dtp_fecNac.Text), Convert.ToInt64(tb_Tel.Text), tb_Mail.Text, Convert.ToInt32(cbx_Prov.SelectedIndex), Convert.ToInt32(cbx_Loc.SelectedIndex), tb_Legajo.Text, Convert.ToInt16(tb_Horas.Text));

                            nGrabados = negProfesor.ABM_Profesores("INSERT", profesores);

                            if (nGrabados == -1)
                            {
                                MessageBox.Show("No se pudo grabar el Profesor en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                principal.LlenarDgvProfesor();
                                MessageBox.Show("El profesor fue agregado correctamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.Close();
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
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
        #endregion

        #region Funciones del formulario
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
            tb_Legajo.Clear();
            tb_Horas.Clear();
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
        #endregion
    }
}
