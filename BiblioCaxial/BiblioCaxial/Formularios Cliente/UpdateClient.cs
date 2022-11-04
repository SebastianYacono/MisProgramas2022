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
            int idBarrio = Convert.ToInt32(cbx_barrioClient.SelectedIndex);

            idBarrio++;

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Update("UPDATE CLIENTE SET Apellido = '" + tb_ApellClient.Text + "', Nombre = '" + tb_nombClient.Text + "', Direccion = '" + tb_dirClient.Text + "', idBarrio = " + idBarrio + ", Telefono = " + tb_telClient.Text + ", Email = '" + tb_mailClient.Text + "' WHERE idCliente = " + id);
            Thread.Sleep(1000);
            Agregar();

            MessageBox.Show("El cliente ha sido cambiado exitosamente", "Editar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
        private void limpiarForm()
        {
            tb_ApellClient.Clear();
            tb_nombClient.Clear();
            tb_dirClient.Clear();
            tb_telClient.Clear();
            tb_mailClient.Clear();
            cbx_barrioClient.Text = "";
        }
        private void comboBoxBarrio()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT * FROM BARRIO;");

            while (datosConexion.reader.Read())
            {
                List<object> CamposBarrio = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposBarrio.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposBarrio.Add(datosConexion.reader.GetString(1));
                }

                cbx_barrioClient.Items.Add(datosConexion.reader.GetString(1));
            }
        }

        #endregion       

    }
}
