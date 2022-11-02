using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargaPersonas
{
    public partial class ModAlumno : Form
    {
        public ModAlumno()
        {
            InitializeComponent();
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
            tb_Anio.Clear();
            tb_Div.Clear();
            tb_Turno.Clear();
        }


    }
}
