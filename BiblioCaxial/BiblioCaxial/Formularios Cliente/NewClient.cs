using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioCaxial
{
    public partial class NewClient : Form
    {
        Principal principal;
        public NewClient(Principal Cliente)
        {
            InitializeComponent();
            principal = Cliente;
            comboBoxBarrio();
        }

        #region Métodos de los botones
        private void Btn_AddClient_Click(object sender, EventArgs e)
        {
            if (tb_ApellClient.Text != "" && tb_nombClient.Text != "" && tb_dirClient.Text != "" && tb_telClient.Text != "" && tb_mailClient.Text != "" && cbx_barrioClient.Text != "")
            {
                if (valTel(tb_telClient.Text) == true)
                {
                    string apellido = tb_ApellClient.Text;
                    string nombre = tb_nombClient.Text;
                    string direccion = tb_dirClient.Text;
                    int idBarrio = Convert.ToInt32(cbx_barrioClient.SelectedValue);
                    decimal telefono = Convert.ToDecimal(tb_telClient.Text);
                    string mail = tb_mailClient.Text;
                    int idPen = 1;
                    string alias = tb_ApellClient.Text + ", " + tb_nombClient.Text;

                    DatosConexion datosConexion = new DatosConexion();

                    datosConexion.Insert("INSERT INTO CLIENTE(Apellido,Nombre,Direccion,idBarrio,Telefono,Email,idPenalizacion, AliasCl) VALUES('" + apellido + "','" + nombre + "','" + direccion + "'," + idBarrio + "," + telefono + ",'" + mail + "'," + idPen + ", '" + alias + "');");

                    MessageBox.Show("El cliente ha sido agregado exitosamente", "Añadir cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Agregar();

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
        private void Btn_CloseClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_CleanClean_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
        #endregion
        
        #region Métodos fuera de los botones
        protected void Agregar()
        {
            principal.LlenarDgvCliente();
        }
        private void limpiarForm()
        {
            tb_ApellClient.Clear();
            tb_nombClient.Clear();
            tb_dirClient.Clear();
            tb_telClient.Clear();
            tb_mailClient.Clear();
            cbx_barrioClient.SelectedIndex = 0;
        }
        private void comboBoxBarrio()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.SelectDT("SELECT * FROM BARRIO;");

            cbx_barrioClient.DataSource = datosConexion.dt;
            cbx_barrioClient.DisplayMember = "Barrio";
            cbx_barrioClient.ValueMember = "idBarrio";
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
