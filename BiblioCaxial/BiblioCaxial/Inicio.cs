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
        readonly DatosConexion conexionDB = new DatosConexion();
        public Inicio()
        {
            InitializeComponent();
        }

        private void LnkL_DBCons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Test DB
        {
            conexionDB.ProbarConexion();
        }

        private void Btn_LogIn_Click(object sender, EventArgs e) //Cambia a form Principal. Futuro login.
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
    }
}
