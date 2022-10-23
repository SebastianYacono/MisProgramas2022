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

        protected void Agregar()
        {
            principal.LlenarDgvProv();
        }

        private void Btn_CloseProv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_CleanProv_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        //ALTA DE UN NUEVO PROVEEDOR
        private void Btn_AddProv_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombProv.Text;
            decimal telefono = Convert.ToDecimal(tb_telProv.Text);
            string email = tb_emailProv.Text;

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Insert("INSERT INTO PROVEEDOR(Nombre,Telefono,Email) VALUES('" + nombre + "','" + telefono + "','" + email + "')");


            MessageBox.Show("El proveedor ha sido agregado exitosamente", "Añadir proveedor");


            Agregar();

            limpiarForm();
        }

        //private bool valTel 
        private void limpiarForm()
        {
            tb_nombProv.Clear();
            tb_telProv.Clear();
            tb_emailProv.Clear();
        }
    }
}
