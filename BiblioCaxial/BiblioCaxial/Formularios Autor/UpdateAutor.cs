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
        string genero = "";
        string alias = "";
        
        public UpdateAutor(Principal ActAutor, int id, string apellido, string nombre,string pais, string genero, string alias)
        {
            InitializeComponent();
            ComboBoxPais();
            ComboBoxGen();

            this.principal = ActAutor;

            this.id = id;
            this.apellido = apellido;
            this.nombre = nombre;
            this.pais = pais;
            this.genero = genero;
            this.alias = alias;

            lbl_idAu.Text = id.ToString();
            tb_apellUAut.Text = apellido;
            tb_nombUAut.Text = nombre;
            cbx_paisUAut.Text = pais;
            cbx_genUAutor.Text = genero;
            
        }

        #region Métodos de los botones
        private void Btn_EditAut_Click(object sender, EventArgs e)
        {
            int idpais = Convert.ToInt32(cbx_paisUAut.SelectedIndex);
            int idgenero = Convert.ToInt32(cbx_genUAutor.SelectedIndex);
            alias = tb_apellUAut.Text + ", " + tb_nombUAut.Text;

            idpais++;
            idgenero++;

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Update("UPDATE AUTOR SET Apellido = '" + tb_apellUAut.Text + "', Nombre = '" + tb_nombUAut.Text + "', idPais = " + idpais + ", idGenero = " + idgenero + ", Alias= '" + alias +"' WHERE idAutor = " + id);
            Thread.Sleep(1000);
            Agregar();

            MessageBox.Show("El autor ha sido cambiado exitosamente", "Editar autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void Btn_CloseAut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos fuera de los botones
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
        private void ComboBoxGen()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT * FROM Genero;");

            while (datosConexion.reader.Read())
            {
                List<object> CamposGen = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposGen.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposGen.Add(datosConexion.reader.GetString(1));
                }

                cbx_genUAutor.Items.Add(datosConexion.reader.GetString(1));
            }
        }
        protected void Agregar()
        {
            principal.LlenarDgvAutor();
        }

        #endregion


    }
}
