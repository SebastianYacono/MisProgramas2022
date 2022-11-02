using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioCaxial
{
    public partial class NewProv : Form
    {
        Principal principal;
        public NewProv(Principal proveedores)
        {
            InitializeComponent();
            principal = proveedores;
        }

        #region Métodos de los botones
        private void Btn_AddProv_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombProv.Text;
            decimal telefono = Convert.ToDecimal(tb_telProv.Text);
            string email = tb_emailProv.Text;

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Insert("INSERT INTO PROVEEDOR(Nombre,Telefono,Email) VALUES('" + nombre + "','" + telefono + "','" + email + "')");


            MessageBox.Show("El proveedor ha sido agregado exitosamente", "Añadir proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Agregar();

            limpiarForm();
        }
        private void Btn_CloseProv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_CleanProv_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
        #endregion

        #region Métodos fuera de los botones
        private void limpiarForm()
        {
            tb_nombProv.Clear();
            tb_telProv.Clear();
            tb_emailProv.Clear();
        }
        protected void Agregar()
        {
            principal.LlenarDgvProv();
        }
        #endregion
    }
}
