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
    public partial class AlqInfo : Form
    {
        AlqPrincipal principal;
        int idComp = 0;
        string client = "";
        string fecha = "";
        int monto = 0;

        public AlqInfo(AlqPrincipal alquiler, int idComp, string client, string fecha, int monto)
        {
            InitializeComponent();

            this.principal = alquiler;
            this.idComp = idComp;
            this.client = client;
            this.fecha = fecha;
            this.monto = monto;
            DateTime fechaComp = DateTime.Parse(fecha);

            tb_Comp.Text = idComp.ToString();
            tb_client.Text = client;
            tb_Fecha.Text = fechaComp.ToShortDateString().ToString();
            tb_Mont.Text = monto.ToString();

            LlenarDGV();
        }

        private void tb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LlenarDGV()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT LIBROS.Titulo, AUTOR.Alias, DETALLE.FechaFin, DETALLE.Devolucion FROM (AUTOR INNER JOIN LIBROS ON AUTOR.idAutor = LIBROS.idAutor) INNER JOIN DETALLE ON LIBROS.IdLibro = DETALLE.idLibro WHERE DETALLE.idComprobante Like " + idComp);
            while (datosConexion.reader.Read())
            {
                List<object> CpLibros = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))//titulo
                {
                    CpLibros.Add(datosConexion.reader.GetString(0));
                }
                if (!datosConexion.reader.IsDBNull(1))//autor
                {
                    CpLibros.Add(datosConexion.reader.GetString(1));
                }
                if (!datosConexion.reader.IsDBNull(2))//fecha
                {
                    CpLibros.Add(datosConexion.reader.GetDateTime(2));
                }
                if (!datosConexion.reader.IsDBNull(3))//Devuelto
                {
                    CpLibros.Add(datosConexion.reader.GetBoolean(3));
                }

                dgvLibros.Rows.Add(CpLibros.ToArray());

            }

            datosConexion.CerrarConexion();
        }
    }
}
