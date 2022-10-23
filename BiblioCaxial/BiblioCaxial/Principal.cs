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
        }

        #region Tab Proveedores

        //Invocador a la base de datos para mostrar datos en el DGV
        public void LlenarDgvProv()
        {
            dgv_prov.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("select * from PROVEEDOR");
            while (datosConexion.reader.Read())
            {
                List<object> campos = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    campos.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    campos.Add(datosConexion.reader.GetString(1));
                }
                if (!datosConexion.reader.IsDBNull(2))
                {
                    campos.Add(datosConexion.reader.GetDecimal(2));
                }
                if (!datosConexion.reader.IsDBNull(3))
                {
                    campos.Add(datosConexion.reader.GetString(3));
                }

                dgv_prov.Rows.Add(campos.ToArray());

                dgv_prov.Columns[1].Width = 200;
                dgv_prov.Columns[2].Width = 100;
                dgv_prov.Columns[3].Width = 220;
            }
            datosConexion.CerrarConexion();
        }

        //Invocador a formulario para agregar un nuevo proveedor
        private void Btn_NewProv_Click(object sender, EventArgs e)
        {
            NewProv NvoProv = new NewProv(this);
            NvoProv.ShowDialog();
        }

        private void Btn_deleteProv_Click(object sender, EventArgs e)
        {
            
            string valor;
            valor = dgv_prov.Rows[dgv_prov.CurrentRow.Index].Cells[0].Value.ToString();

            DatosConexion datosConexion = new DatosConexion();
            datosConexion.Delete("DELETE FROM PROVEEDOR WHERE(idProveedor = " + valor + ")");

            LlenarDgvProv();

            MessageBox.Show("El proveedor ha sido eliminado exitosamente", "Eliminar proveedor");
        }

        private void Btn_editProv_Click(object sender, EventArgs e)
        {
            //Metodo para traer los datos de una fila de una DataGridView
            
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

            UpdateProv updateProv= new UpdateProv (this, id, nombre, telefono, email);
            updateProv.ShowDialog();
        }

        #endregion

        //Boton Cerrar. Produce cierre completo del programa
        private void SalirApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbl_FecHor.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  -  " + DateTime.Now.ToString("HH:mm");
        }


    }
}
