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
    public partial class RenPrincipal : Form
    {
        public RenPrincipal()
        {
            InitializeComponent();
            LlenarDgvRen();
            cbx_Buscar.SelectedIndex = 0;
        }

        #region Carga de libro a editar
        private void btn_Llam_Click(object sender, EventArgs e)
        {
            var fila1 = dgv_RenP.CurrentRow;
            int idAlq = 0;
            int idCom = 0;
            string titulo = "";
            DateTime fecha = DateTime.Now;
            int monto = 0;

            if (fila1 != null)
            {
                if (fila1.Cells[0].Value != null)
                    idAlq = Convert.ToInt32(fila1.Cells[0].Value);
                if (fila1.Cells[1].Value != null)
                    idCom = Convert.ToInt32(fila1.Cells[1].Value);
                if (fila1.Cells[2].Value != null)
                    titulo = fila1.Cells[2].Value.ToString();
                if (fila1.Cells[3].Value != null)
                    fecha = Convert.ToDateTime(fila1.Cells[3].Value);
                if (fila1.Cells[4].Value != null)
                    monto = Convert.ToInt32(fila1.Cells[4].Value);
            }
            lbl_idCom.Text = idCom.ToString();
            lbl_monto.Text = monto.ToString();
            tb_id.Text = idAlq.ToString();
            tb_titulo.Text = titulo;
            dtp_fec.Value = fecha;
            tb_monto.Enabled = true;
            dtp_fec.Enabled = true;
        }
        private void btn_LimRen_Click(object sender, EventArgs e)
        {
            LimpiarRenovacion();
        }
        #endregion

        #region Buscador
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_Buscar.Clear();
            LlenarDgvRen();
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cbx_Buscar.Text == "Comprobante")
            {
                if (valNum(tb_Buscar.Text) == true)
                {
                    LlenarDgvRenComp();
                }
                else
                {
                    MessageBox.Show("Para buscar un Comprobante, debes introducir valores numéricos", "Error");
                }
                
            }
            if (cbx_Buscar.Text == "Libro")
            {
                LlenarDgvRenLib();
            }
            if (cbx_Buscar.Text == string.Empty || tb_Buscar.Text == string.Empty)
            {
                MessageBox.Show("Debes seleccionar un indicador para buscar");
            }

        }
        #endregion

        #region Botones principales del formulario
        private void btn_AlqClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_AlqRen_Click(object sender, EventArgs e)
        {
            DatosConexion datosConexion = new DatosConexion();

            if (tb_monto.Text == "" || tb_titulo.Text == "" || tb_id.Text == "")
            {
                MessageBox.Show("Los parámetros deben estar completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idAlq = Convert.ToInt32(tb_id.Text);
                int idCom = Convert.ToInt32(lbl_idCom.Text);
                DateTime fecha = dtp_fec.Value;
                int monto = Convert.ToInt32(lbl_monto.Text);
                int monto2 = Convert.ToInt32(tb_monto.Text);
                int suma = monto + monto2;

                datosConexion.Update("UPDATE DETALLE SET FechaFin = '" + fecha + "' WHERE idAlquiler = " + idAlq);
                datosConexion.Update("UPDATE COMPROBANTE SET Monto = " + suma + " WHERE idComprobante = " + idCom);

                LlenarDgvRen();
            }
        }
        #endregion

        #region Funciones del formulario
        public void LlenarDgvRen()//Rellena el dgv de Alquiler. 
        {
            dgv_RenP.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT DETALLE.idAlquiler, COMPROBANTE.idComprobante, LIBROS.Titulo, DETALLE.FechaFin, COMPROBANTE.Monto FROM LIBROS INNER JOIN (COMPROBANTE INNER JOIN DETALLE ON COMPROBANTE.idComprobante = DETALLE.idComprobante) ON LIBROS.IdLibro = DETALLE.idLibro WHERE (((DETALLE.Devolucion) Like False)) ORDER BY DETALLE.FechaFin Desc;");
            while (datosConexion.reader.Read())
            {
                List<object> CpRen = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(1));
                }
                if (!datosConexion.reader.IsDBNull(2))
                {
                    CpRen.Add(datosConexion.reader.GetString(2));
                }
                if (!datosConexion.reader.IsDBNull(3))
                {
                    CpRen.Add(datosConexion.reader.GetDateTime(3));
                }
                if (!datosConexion.reader.IsDBNull(4))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(4));
                }

                dgv_RenP.Rows.Add(CpRen.ToArray());
            }
            datosConexion.CerrarConexion();
        }
        public void LlenarDgvRenComp()//Rellena el dgv de Alquiler.
        {
            dgv_RenP.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            string filtro = tb_Buscar.Text;

            datosConexion.Select("SELECT DETALLE.idAlquiler, COMPROBANTE.idComprobante, LIBROS.Titulo, DETALLE.FechaFin, COMPROBANTE.Monto FROM LIBROS INNER JOIN (COMPROBANTE INNER JOIN DETALLE ON COMPROBANTE.idComprobante = DETALLE.idComprobante) ON LIBROS.IdLibro = DETALLE.idLibro WHERE  (DETALLE.Devolucion Like False)  AND (COMPROBANTE.idComprobante Like  ('%" + filtro + "%')) ORDER BY DETALLE.FechaFin DESC; ");
            while (datosConexion.reader.Read())
            {
                List<object> CpRen = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(1));
                }
                if (!datosConexion.reader.IsDBNull(2))
                {
                    CpRen.Add(datosConexion.reader.GetString(2));
                }
                if (!datosConexion.reader.IsDBNull(3))
                {
                    CpRen.Add(datosConexion.reader.GetDateTime(3));
                }
                if (!datosConexion.reader.IsDBNull(4))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(4));
                }

                dgv_RenP.Rows.Add(CpRen.ToArray());
            }
            datosConexion.CerrarConexion();
        }
        public void LlenarDgvRenLib()//Rellena el dgv de Alquiler.
        {
            dgv_RenP.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            string filtro = tb_Buscar.Text;

            datosConexion.Select("SELECT DETALLE.idAlquiler, COMPROBANTE.idComprobante, LIBROS.Titulo, DETALLE.FechaFin, COMPROBANTE.Monto FROM LIBROS INNER JOIN (COMPROBANTE INNER JOIN DETALLE ON COMPROBANTE.idComprobante = DETALLE.idComprobante) ON LIBROS.IdLibro = DETALLE.idLibro WHERE  (DETALLE.Devolucion Like False)  AND (LIBROS.Titulo Like  ('%" + filtro + "%')) ORDER BY DETALLE.FechaFin DESC; ");
            while (datosConexion.reader.Read())
            {
                List<object> CpRen = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(1));
                }
                if (!datosConexion.reader.IsDBNull(2))
                {
                    CpRen.Add(datosConexion.reader.GetString(2));
                }
                if (!datosConexion.reader.IsDBNull(3))
                {
                    CpRen.Add(datosConexion.reader.GetDateTime(3));
                }
                if (!datosConexion.reader.IsDBNull(4))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(4));
                }

                dgv_RenP.Rows.Add(CpRen.ToArray());
            }
            datosConexion.CerrarConexion();
        }

        private bool valNum(string IsNum)
        {
            int i = 0;

            while (i <= IsNum.Length - 1)
            {
                if (!char.IsDigit(IsNum, i))
                    return false;
                i++;
            }
            return true;
        }
        public void LimpiarRenovacion()
        {
            tb_id.Clear();
            tb_titulo.Clear();
            tb_monto.Clear();
            tb_monto.Enabled = false;
            dtp_fec.Enabled = false;
        }

        #endregion
    }
}
