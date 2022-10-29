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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            LlenarDgvProv();
            LlenarDgvAutor();
            //LlenarDgvLibro();
            //LlenarDgvCliente();
        }

        #region Tab Autor

        public void LlenarDgvAutor() //Rellena el dgv de autor
        {
            dgv_Autor.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT AUTOR.idAutor, AUTOR.Apellido, AUTOR.Nombre, PAIS.Pais FROM AUTOR INNER JOIN PAIS ON AUTOR.idPais = PAIS.idPais; ");
            while (datosConexion.reader.Read())
            {
                List<object> CamposAut = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposAut.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposAut.Add(datosConexion.reader.GetString(1));
                }
                if (!datosConexion.reader.IsDBNull(2))
                {
                    CamposAut.Add(datosConexion.reader.GetString(2));
                }
                if (!datosConexion.reader.IsDBNull(3))
                {
                    CamposAut.Add(datosConexion.reader.GetString(3));
                }

                dgv_Autor.Rows.Add(CamposAut.ToArray());

            }

            datosConexion.CerrarConexion();
        }

        private void Btn_NewAut_Click(object sender, EventArgs e)
        {
            NewAutor newAutor = new NewAutor(this);
            newAutor.ShowDialog();
        }//Comando para crear el autor.

        private void Btn_deleteAut_Click(object sender, EventArgs e)//Comando para eliminar autor
        {
            string valor;
            valor = dgv_Autor.Rows[dgv_Autor.CurrentRow.Index].Cells[0].Value.ToString();

            DialogResult r = MessageBox.Show("¿Quieres eliminar este elemento?", "Eliminar autor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DatosConexion datosConexion = new DatosConexion();
                datosConexion.Delete("DELETE FROM AUTOR WHERE(idAutor = " + valor + ")");

                LlenarDgvAutor();

                MessageBox.Show("El autor ha sido eliminado exitosamente", "Eliminar autor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_editAut_Click(object sender, EventArgs e)
        {
            var fila = dgv_Autor.CurrentRow;
            int id = 0;
            string apellido = "";
            string nombre = "";
            string pais = "";

            if (fila != null)
            {
                if (fila.Cells[0].Value != null)
                    id = Convert.ToInt32(fila.Cells[0].Value);
                if (fila.Cells[1].Value != null)
                    apellido = fila.Cells[1].Value.ToString();
                if (fila.Cells[2].Value != null)
                    nombre = fila.Cells[2].Value.ToString();
                if (fila.Cells[3].Value != null)
                    pais = fila.Cells[3].Value.ToString();
            }
            //Lleva al form UpdateAut
            UpdateAutor updateAutor = new UpdateAutor(this, id, apellido, nombre, pais);
            updateAutor.ShowDialog();
        }

        #endregion


        #region Tab Proveedores

        public void LlenarDgvProv() //Rellena el dgv de proveedores
        {
            dgv_prov.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT * from PROVEEDOR");
            while (datosConexion.reader.Read())
            {
                List<object> CamposPr = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposPr.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposPr.Add(datosConexion.reader.GetString(1));
                }
                if (!datosConexion.reader.IsDBNull(2))
                {
                    CamposPr.Add(datosConexion.reader.GetDecimal(2));
                }
                if (!datosConexion.reader.IsDBNull(3))
                {
                    CamposPr.Add(datosConexion.reader.GetString(3));
                }

                dgv_prov.Rows.Add(CamposPr.ToArray());

            }

            datosConexion.CerrarConexion();
        }

        private void Btn_NewProv_Click(object sender, EventArgs e) //Comando para crear el proveedor.
        {
            //Lleva al form NvoProv
            NewProv NvoProv = new NewProv(this);
            NvoProv.ShowDialog();
        }

        private void Btn_deleteProv_Click(object sender, EventArgs e) //Comando para eliminar el proveedor
        {


            string valor;
            valor = dgv_prov.Rows[dgv_prov.CurrentRow.Index].Cells[0].Value.ToString();

            DialogResult r = MessageBox.Show("¿Quieres eliminar este elemento?","Eliminar Proveedor", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DatosConexion datosConexion = new DatosConexion();
                datosConexion.Delete("DELETE FROM PROVEEDOR WHERE(idProveedor = " + valor + ")");

                LlenarDgvProv();

                MessageBox.Show("El proveedor ha sido eliminado exitosamente", "Eliminar proveedor",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void Btn_editProv_Click(object sender, EventArgs e) //Comando para editar el proveedor
        {
            //Realiza lectura del dgv y lo guarda para trasladar la info
            var fila = dgv_prov.CurrentRow;
            int id = 0;
            string nombre = "";
            decimal telefono = 0;
            string email = "";

            if (fila != null)
            {
                if (fila.Cells[0].Value != null)
                    id = Convert.ToInt32(fila.Cells[0].Value);
                if (fila.Cells[1].Value != null)
                    nombre = fila.Cells[1].Value.ToString();
                if (fila.Cells[2].Value != null)
                    telefono = (decimal)fila.Cells[2].Value;
                if (fila.Cells[3].Value != null)
                    email = fila.Cells[3].Value.ToString();
            }
            //Lleva al form UpdateProv
            UpdateProv updateProv = new UpdateProv(this, id, nombre, telefono, email);
            updateProv.ShowDialog();
        }

        #endregion


        #region Funciones del formulario
        private void SalirApp_Click(object sender, EventArgs e) //Boton Cerrar. Produce cierre completo del programa
        {
            Application.Exit();
        }
        
        
        private void timer1_Tick_1(object sender, EventArgs e) // Controla fecha y hora
        {
            lbl_FecHor.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  -  " + DateTime.Now.ToString("HH:mm");
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e) //Genera el cierre total del soft cuando se presiona la X
        {
            Application.Exit();
        }


        #endregion


    }
}
