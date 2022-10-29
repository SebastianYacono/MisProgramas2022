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
    public partial class UpdateAutor : Form
    {
        Principal principal;

        int id = 0;
        string apellido = "";
        string nombre = "";
        string pais = "";
        
        public UpdateAutor(Principal ActAutor, int id, string apellido, string nombre,string pais)
        {
            InitializeComponent();
            ComboBoxPais();

            this.principal = ActAutor;

            this.id = id;
            this.apellido = apellido;
            this.nombre = nombre;
            this.pais = pais;

            lbl_idAu.Text = id.ToString();
            tb_apellUAut.Text = apellido;
            tb_nombUAut.Text = nombre;
            cbx_paisUAut.Text = pais;
            
        }

        private void Btn_EditAut_Click(object sender, EventArgs e)
        {
            int idpais = Convert.ToInt32(cbx_paisUAut.SelectedIndex);

            idpais++;

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Update("UPDATE AUTOR SET Apellido = '" + tb_apellUAut.Text + "', Nombre = '" + tb_nombUAut.Text + "', idPais = " + idpais + " WHERE idAutor = " + id);
            Thread.Sleep(1000);
            Agregar();

            MessageBox.Show("El autor ha sido cambiado exitosamente", "Editar autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void ComboBoxPais()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT * FROM Pais;");

            while (datosConexion.reader.Read())
            {
                List<object> CamposPais = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposPais.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposPais.Add(datosConexion.reader.GetString(1));
                }

                cbx_paisUAut.Items.Add(datosConexion.reader.GetString(1));
            }
        }
        protected void Agregar()
        {
            principal.LlenarDgvAutor();
        }
        private void Btn_CloseAut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
