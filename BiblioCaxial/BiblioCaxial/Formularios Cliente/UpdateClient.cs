using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BiblioCaxial
{
    public partial class UpdateClient : Form
    {
        Principal principal;

        int id = 0;
        string apellido = "";
        string nombre = "";
        string direccion = "";
        string barrio = "";
        decimal telefono = 0;
        string mail = "";
        public UpdateClient(Principal ActClient, int id, string apellido, string nombre, string direccion, string barrio, decimal telefono, string mail )
        {
            InitializeComponent();
            comboBoxBarrio();

            this.principal = ActClient;

            this.id = id;
            this.apellido = apellido;
            this.nombre = nombre;
            this.direccion = direccion;
            this.barrio = barrio;
            this.telefono = telefono;
            this.mail = mail;

            lbl_id.Text = id.ToString();
            tb_ApellClient.Text = apellido;
            tb_nombClient.Text = nombre;
            tb_dirClient.Text = direccion;
            cbx_barrioClient.Text = barrio;
            tb_telClient.Text = telefono.ToString();
            tb_mailClient.Text = mail;
        }

        #region Métodos de los botones
        private void Btn_EditUClient_Click(object sender, EventArgs e)
        {
            if (tb_ApellClient.Text != "" && tb_nombClient.Text != "" && tb_dirClient.Text != "" && tb_telClient.Text != "" && tb_mailClient.Text != "" && cbx_barrioClient.Text != "")
            {
                if (valTel(tb_telClient.Text) == true)
                {
                    int idBarrio = Convert.ToInt32(cbx_barrioClient.SelectedValue);
                    string alias = tb_ApellClient.Text + ", " + tb_nombClient.Text;


                    DatosConexion datosConexion = new DatosConexion();

                    datosConexion.Update("UPDATE CLIENTE SET Apellido = '" + tb_ApellClient.Text + "', Nombre = '" + tb_nombClient.Text + "', Direccion = '" + tb_dirClient.Text + "', idBarrio = " + idBarrio + ", Telefono = " + tb_telClient.Text + ", Email = '" + tb_mailClient.Text + "', AliasCl = '" + alias + "' WHERE idCliente = " + id);
                    Thread.Sleep(1000);
                    Agregar();

                    MessageBox.Show("El cliente ha sido cambiado exitosamente", "Editar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void Btn_CloseUClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos fuera de los botones
        protected void Agregar()
        {
            principal.LlenarDgvCliente();
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
