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
            if (tb_nombProv.Text != "" && tb_telProv.Text != "" && tb_emailProv.Text != "")
            {
                if (valTel(tb_telProv.Text) == true)
                {
                    string nombre = tb_nombProv.Text;
                    decimal telefono = Convert.ToDecimal(tb_telProv.Text);
                    string email = tb_emailProv.Text;

                    DatosConexion datosConexion = new DatosConexion();

                    datosConexion.Insert("INSERT INTO PROVEEDOR(Nombre,Telefono,Email) VALUES('" + nombre + "','" + telefono + "','" + email + "')");

                    Agregar();
                    MessageBox.Show("El proveedor ha sido agregado exitosamente", "Añadir proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El teléfono debe estar compuesto por Código de área sin 0 y teléfono sin 15. Ej.: 3514517225", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private bool valTel(string ValidarTel)
        {
            int i = 0;
            if (ValidarTel.Length != 10)
                return false;

            while (i <= ValidarTel.Length - 1)
            {
                if (!char.IsDigit(ValidarTel, i))
                    return false;
                i++;
            }
            return true;
        }
        #endregion
    }
}
