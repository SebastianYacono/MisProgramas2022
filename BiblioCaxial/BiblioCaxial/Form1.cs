using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace BiblioCaxial
{
    public partial class Inicio : Form
    {
        DatosConexion conexionDB = new DatosConexion();
        public Inicio()
        {
            InitializeComponent();
        }

        private void lnkL_DBCons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            conexionDB.probarConexion();
        }

        private void Btn_LogIn_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
    }
}
