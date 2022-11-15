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
    public partial class DevPrincipal : Form
    {
        public DevPrincipal()
        {
            InitializeComponent();
            LlenarDgvDev();
            cbx_Buscar.SelectedIndex = 0;
        }

        #region Carga de libro a editar
        private void btn_Llam_Click(object sender, EventArgs e)
        {
            var fila1 = dgv_DevP.CurrentRow;
            int idAlq = 0;
            int idCom = 0;
            string titulo = "";
            DateTime fecha = DateTime.Now;
            DateTime Dev = DateTime.Now;
            int monto = 0;
            int idLib = 0;

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
                if (fila1.Cells[5].Value != null)
                    idLib = Convert.ToInt32(fila1.Cells[5].Value);
            }

            lbl_idCom.Text = idCom.ToString();
            lbl_monto.Text = monto.ToString();
            lbl_idLibro.Text = idLib.ToString();
            tb_id.Text = idAlq.ToString();
            tb_titulo.Text = titulo;
            dtp_fec.Value = fecha;
            dtp_fecDev.Value = Dev;

            demora();
        }
        private void btn_LimDev_Click(object sender, EventArgs e)
        {
            limpiarDevolucion();
        }
        #endregion

        #region Buscador
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_Buscar.Clear();
            cbx_Buscar.SelectedIndex = 0;
            LlenarDgvDev();
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cbx_Buscar.Text == "Comprobante")
            {
                if (valNum(tb_Buscar.Text) == true)
                {
                    LlenarDgvDevComp();
                }
                else
                {
                    MessageBox.Show("Para buscar un Comprobante, debes introducir valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (cbx_Buscar.Text == "Libro")
            {
                LlenarDgvDevLib();
            }
            if (cbx_Buscar.Text == string.Empty || tb_Buscar.Text == string.Empty)
            {
                MessageBox.Show("Debes seleccionar un indicador para buscar","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Botones principales del formulario
        private void btn_AlqDev_Click(object sender, EventArgs e)
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
                DateTime fecha = dtp_fecDev.Value;
                int monto = Convert.ToInt32(lbl_monto.Text);
                int idLib = Convert.ToInt32(lbl_idLibro.Text);
                int monto2 = Convert.ToInt32(tb_monto.Text);
                int suma = monto + monto2;
                bool dev = true;
                bool disp = true;

                datosConexion.Update("UPDATE COMPROBANTE SET Monto = " + suma + " WHERE idComprobante = " + idCom);//Comprobante
                datosConexion.Update("UPDATE DETALLE SET FechaDev = '" + fecha + "', Devolucion = " + dev +" WHERE idAlquiler = " + idAlq);//Alquiler
                datosConexion.Update("UPDATE LIBROS SET Disponible = " + disp +" WHERE idLibro = " + idLib);//Libro

                MessageBox.Show("Se ha cargado la devolución exitosamente.", "Devolución exitosa");

                LlenarDgvDev();
                limpiarDevolucion();
            }
        }
        private void btn_AlqClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funciones del formulario
        public void LlenarDgvDev()//Rellena el dgv de Alquiler. 
        {
            dgv_DevP.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT DETALLE.idAlquiler, COMPROBANTE.idComprobante, LIBROS.Titulo, DETALLE.FechaDev, COMPROBANTE.Monto, LIBROS.IdLibro FROM LIBROS INNER JOIN (COMPROBANTE INNER JOIN DETALLE ON COMPROBANTE.idComprobante = DETALLE.idComprobante) ON LIBROS.IdLibro = DETALLE.idLibro WHERE(((DETALLE.Devolucion) Like False)) ORDER BY DETALLE.FechaFin Desc;");
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
                if (!datosConexion.reader.IsDBNull(5))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(5));
                }

                dgv_DevP.Rows.Add(CpRen.ToArray());
            }
            datosConexion.CerrarConexion();
        }
        public void LlenarDgvDevComp()//Rellena el dgv de Alquiler.
        {
            dgv_DevP.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            string filtro = tb_Buscar.Text;

            datosConexion.Select("SELECT DETALLE.idAlquiler, COMPROBANTE.idComprobante, LIBROS.Titulo, DETALLE.FechaDev, COMPROBANTE.Monto, LIBROS.IdLibro FROM LIBROS INNER JOIN (COMPROBANTE INNER JOIN DETALLE ON COMPROBANTE.idComprobante = DETALLE.idComprobante) ON LIBROS.IdLibro = DETALLE.idLibro WHERE  (DETALLE.Devolucion Like False)  AND (COMPROBANTE.idComprobante Like  ('%" + filtro + "%')) ORDER BY DETALLE.FechaFin DESC; ");
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
                if (!datosConexion.reader.IsDBNull(5))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(5));
                }

                dgv_DevP.Rows.Add(CpRen.ToArray());
            }
            datosConexion.CerrarConexion();
        }
        public void LlenarDgvDevLib()//Rellena el dgv de Alquiler.
        {
            dgv_DevP.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            string filtro = tb_Buscar.Text;

            datosConexion.Select("SELECT DETALLE.idAlquiler, COMPROBANTE.idComprobante, LIBROS.Titulo, DETALLE.FechaDev, COMPROBANTE.Monto, LIBROS.IdLibro FROM LIBROS INNER JOIN (COMPROBANTE INNER JOIN DETALLE ON COMPROBANTE.idComprobante = DETALLE.idComprobante) ON LIBROS.IdLibro = DETALLE.idLibroWHERE  (DETALLE.Devolucion Like False)  AND (LIBROS.Titulo Like  ('%" + filtro + "%')) ORDER BY DETALLE.FechaFin DESC; ");
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
                if (!datosConexion.reader.IsDBNull(5))
                {
                    CpRen.Add(datosConexion.reader.GetInt32(5));
                }

                dgv_DevP.Rows.Add(CpRen.ToArray());
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
        public void demora()
        {
            DateTime dev = dtp_fecDev.Value;
            DateTime fin = dtp_fec.Value;

            int difDias = Convert.ToInt32((dev - fin).Days);

            if (difDias > 0)
            {
                tb_demora.Text = difDias.ToString();
                tb_monto.Enabled = true;
            }
            else
            {
                difDias = 0;
                tb_demora.Text = difDias.ToString();
                tb_monto.Enabled = false;
            }
        }
        public void limpiarDevolucion()
        {
            tb_id.Clear();
            tb_titulo.Clear();
            tb_demora.Clear();
            tb_monto.Text = "0";
            tb_monto.Enabled = false;
        }
        #endregion
    }
}
