using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BiblioCaxial
{
    public partial class AlqPrincipal : Form
    {
        public AlqPrincipal()
        {
            InitializeComponent();
            LlenarDgvAlq();
        }

        #region Botones del formulario
        private void btn_AlqInf_Click(object sender, EventArgs e)
        {
            var fila = dgv_AlqP.CurrentRow;
            int idComp = 0;
            string client = "";
            string fecha = "";
            int monto = 0;

            if (fila != null)
            {
                if (fila.Cells[0].Value != null)
                    idComp = Convert.ToInt32(fila.Cells[0].Value);
                if (fila.Cells[1].Value != null)
                    client = fila.Cells[1].Value.ToString();
                if (fila.Cells[2].Value != null)
                    fecha = fila.Cells[2].Value.ToString();
                if (fila.Cells[3].Value != null)
                    monto = Convert.ToInt32(fila.Cells[3].Value);
            }

            AlqInfo alqInfo = new AlqInfo(this, idComp, client, fecha, monto);
            alqInfo.ShowDialog();
        }
        private void btn_AlqClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_AlqAdd_Click(object sender, EventArgs e)
        {
            AlqNvo alqNvo = new AlqNvo(this);
            alqNvo.ShowDialog();
        }
        #endregion

        #region Funciones del formulario
        public void LlenarDgvAlq()//Rellena el dgv de Alquiler.
        {
            dgv_AlqP.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT COMPROBANTE.idComprobante, CLIENTE.AliasCl, COMPROBANTE.FechaComprobante, COMPROBANTE.Monto FROM CLIENTE INNER JOIN COMPROBANTE ON CLIENTE.idCliente = COMPROBANTE.idCliente ORDER BY idComprobante Asc;");
            while (datosConexion.reader.Read())
            {
                List<object> CpAlq = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CpAlq.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CpAlq.Add(datosConexion.reader.GetString(1));
                }
                if (!datosConexion.reader.IsDBNull(2))
                {
                    CpAlq.Add(datosConexion.reader.GetDateTime(2));
                }
                if (!datosConexion.reader.IsDBNull(3))
                {
                    CpAlq.Add(datosConexion.reader.GetInt32(3));
                }
                dgv_AlqP.Rows.Add(CpAlq.ToArray());
            }
            datosConexion.CerrarConexion();
        }
        #endregion
    }
}
