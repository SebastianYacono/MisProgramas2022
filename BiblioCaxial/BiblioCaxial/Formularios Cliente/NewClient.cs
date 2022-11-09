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
            string apellido = tb_ApellClient.Text;
            string nombre = tb_nombClient.Text;
            string direccion = tb_dirClient.Text;
            int idBarrio = Convert.ToInt32(cbx_barrioClient.SelectedIndex);
            decimal telefono = Convert.ToDecimal(tb_telClient.Text);
            string mail = tb_mailClient.Text;
            int idPen = 1;
            string alias = tb_ApellClient.Text + ", " + tb_nombClient.Text;

            idBarrio++;

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Insert("INSERT INTO CLIENTE(Apellido,Nombre,Direccion,idBarrio,Telefono,Email,idPenalizacion, AliasCl) VALUES('" + apellido + "','" + nombre + "','" + direccion + "'," + idBarrio + "," + telefono + ",'" + mail + "'," + idPen + ", '" + alias + ");");

            MessageBox.Show("El cliente ha sido agregado exitosamente", "Añadir cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Agregar();

            limpiarForm();
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
