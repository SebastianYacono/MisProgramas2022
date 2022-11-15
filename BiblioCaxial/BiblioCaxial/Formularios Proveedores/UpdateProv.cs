using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioCaxial
{
    
    public partial class UpdateProv : Form
    {
        Principal principal;

        int id = 0;
        string nombre = "";
        decimal telefono = 0;
        string email = "";

        public UpdateProv(Principal ActProveedor, int id, string nombre, decimal telefono, string email)
        {
            InitializeComponent();
            this.principal = ActProveedor;

            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.email = email;

            lbl_id.Text = id.ToString();
            tb_nombUProv.Text = nombre;
            tb_telUProv.Text = telefono.ToString();
            tb_emailUProv.Text = email;
        }

        protected void Agregar()
        {
            principal.LlenarDgvProv();
        }

        #region Métodos de los botones
        private void Btn_EditProv_Click(object sender, EventArgs e)
        {
            if (tb_nombUProv.Text != "" && tb_telUProv.Text != "" && tb_emailUProv.Text != "")
            {
                if (valTel(tb_telUProv.Text) == true)
                {
                    DatosConexion datosConexion = new DatosConexion();

                    datosConexion.Update("UPDATE PROVEEDOR SET Nombre = '" + tb_nombUProv.Text + "', Telefono = " + tb_telUProv.Text + ", Email = '" + tb_emailUProv.Text + "' WHERE idProveedor = " + id);
                    Thread.Sleep(1000);
                    Agregar();

                    MessageBox.Show("El proveedor ha sido cambiado exitosamente", "Editar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
        #endregion

        #region Métodos fuera de los botones
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
