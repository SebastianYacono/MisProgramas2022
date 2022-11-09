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
    public partial class AlqNvo : Form
    {
        public AlqNvo()
        {
            InitializeComponent();
            LlenarDgvLibAlq();
            comboBoxCliente();
            Comprobante();
            Fecha();            
        }

        #region Buscador
        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            tb_Buscar.Clear();
            LlenarDgvLibAlq();
            cbx_Buscar.Text = "";
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cbx_Buscar.Text == "Título")
            {
                LlenarDgvLibTitulo();
            }
            if (cbx_Buscar.Text == "Autor")
            {
                LlenarDgvLibAutor();
            }
            if (cbx_Buscar.Text == string.Empty || tb_Buscar.Text == string.Empty)
            {
                MessageBox.Show("Debes seleccionar un indicador para buscar");
            }
            
        }
        #endregion

        #region Carga de libros
        private void bt_mas1_Click(object sender, EventArgs e)
        {
            var fila1 = dgv_LibAlq.CurrentRow;
            int id1 = 0;
            string titulo1 = "";

            if (fila1 != null)
            {
                if (fila1.Cells[0].Value != null)
                    id1 = Convert.ToInt32(fila1.Cells[0].Value);
                if (fila1.Cells[1].Value != null)
                    titulo1 = fila1.Cells[1].Value.ToString();
            }
            tb_id1.Text = id1.ToString();
            tb_lib1.Text = titulo1;
        }
        private void bt_mas2_Click(object sender, EventArgs e)
        {
                var fila2 = dgv_LibAlq.CurrentRow;
                int id2 = 0;
                string titulo2 = "";

                if (fila2 != null)
                {
                    if (fila2.Cells[0].Value != null)
                        id2 = Convert.ToInt32(fila2.Cells[0].Value);
                    if (fila2.Cells[1].Value != null)
                        titulo2 = fila2.Cells[1].Value.ToString();
                }
                tb_id2.Text = id2.ToString();
                tb_lib2.Text = titulo2;            
        }
        private void bt_mas3_Click(object sender, EventArgs e)
        {
            var fila3 = dgv_LibAlq.CurrentRow;
            int id3 = 0;
            string titulo3 = "";

            if (fila3 != null)
            {
                if (fila3.Cells[0].Value != null)
                    id3 = Convert.ToInt32(fila3.Cells[0].Value);
                if (fila3.Cells[1].Value != null)
                    titulo3 = fila3.Cells[1].Value.ToString();
            }
            tb_id3.Text = id3.ToString();
            tb_lib3.Text = titulo3;
        }
        #endregion

        #region Botones importantes del formulario
        private void btn_Alquilar_Click(object sender, EventArgs e)
        {
            DatosConexion datosConexion = new DatosConexion();

            //Parte de comprobante
            int idCliente = (cbx_clientAlq.SelectedIndex) + 1;
            DateTime fechaComp = DateTime.Parse(tb_fecHoy.Text);
            decimal monto = Convert.ToDecimal(tb_Monto.Text);

            datosConexion.Insert("INSERT INTO COMPROBANTE(idCliente, FechaComprobante, Monto) VALUES ("+ idCliente +", '" + fechaComp + "', " + monto + ");");


            //Parte de alquiler de libro
            //int idLibro1 = Convert.ToInt32(tb_id1.Text);
            //int idLibro2 = Convert.ToInt32(tb_id2.Text);
            //int idLibro3 = Convert.ToInt32(tb_id3.Text);
            //DateTime fin1 = DateTime.Parse(dtp_fec1.Text);
            //DateTime fin2 = DateTime.Parse(dtp_fec2.Text);
            //DateTime fin3 = DateTime.Parse(dtp_fec3.Text);
            int idComprobante = Convert.ToInt32(tb_compr.Text);
            bool dev = false;
            //DateTime fdev1 = DateTime.Parse(dtp_fec1.Text);
            //DateTime fdev2 = DateTime.Parse(dtp_fec2.Text);
            //DateTime fdev3 = DateTime.Parse(dtp_fec3.Text);
            int cantLibros = 0;

            if (rb_lib1.Checked == true)
            {
                int idLibro1 = Convert.ToInt32(tb_id1.Text);
                DateTime fin1 = DateTime.Parse(dtp_fec1.Text);
                DateTime fdev1 = DateTime.Parse(dtp_fec1.Text);

                cantLibros = 1;
                datosConexion.Insert("INSERT INTO DETALLE (idLibro, FechaFin, idComprobante, Cantidad, Devolucion, FechaDev) VALUES (" + idLibro1 +", '" + fin1 + "'," + idComprobante + ", " + cantLibros + ", " + dev + ",'" + fdev1 + "');");

                MessageBox.Show("Se ha cargado el alquiler de 1 libro correctamente", "Alquiler realizado");
            }
            if (rb_lib2.Checked == true)
            {
                int idLibro1 = Convert.ToInt32(tb_id1.Text);
                int idLibro2 = Convert.ToInt32(tb_id2.Text);
                DateTime fin1 = DateTime.Parse(dtp_fec1.Text);
                DateTime fin2 = DateTime.Parse(dtp_fec2.Text);
                DateTime fdev1 = DateTime.Parse(dtp_fec1.Text);
                DateTime fdev2 = DateTime.Parse(dtp_fec2.Text);

                cantLibros = 2;
                datosConexion.Insert("INSERT INTO DETALLE (idLibro, FechaFin, idComprobante, Cantidad, Devolucion, FechaDev) VALUES (" + idLibro1 + ", '" + fin1 + "'," + idComprobante + ", " + cantLibros + ", " + dev + ",'" + fdev1 + "')");
                datosConexion.Insert("INSERT INTO DETALLE (idLibro, FechaFin, idComprobante, Cantidad, Devolucion, FechaDev) VALUES (" + idLibro2 + ", '" + fin2 + "'," + idComprobante + ", " + cantLibros + ", " + dev + ",'" + fdev2 + "')");

                MessageBox.Show("Se ha cargado el alquiler de 2 libros correctamente", "Alquiler realizado");
            }
            if (rb_lib3.Checked == true)
            {

                int idLibro1 = Convert.ToInt32(tb_id1.Text);
                int idLibro2 = Convert.ToInt32(tb_id2.Text);
                int idLibro3 = Convert.ToInt32(tb_id3.Text);
                DateTime fin1 = DateTime.Parse(dtp_fec1.Text);
                DateTime fin2 = DateTime.Parse(dtp_fec2.Text);
                DateTime fin3 = DateTime.Parse(dtp_fec3.Text);
                DateTime fdev1 = DateTime.Parse(dtp_fec1.Text);
                DateTime fdev2 = DateTime.Parse(dtp_fec2.Text);
                DateTime fdev3 = DateTime.Parse(dtp_fec3.Text);

                cantLibros = 3;
                datosConexion.Insert("INSERT INTO DETALLE (idLibro, FechaFin, idComprobante, Cantidad, Devolucion, FechaDev) VALUES (" + idLibro1 + ", '" + fin1 + "'," + idComprobante + ", " + cantLibros + ", " + dev + ",'" + fdev1 + "')");
                datosConexion.Insert("INSERT INTO DETALLE (idLibro, FechaFin, idComprobante, Cantidad, Devolucion, FechaDev) VALUES (" + idLibro2 + ", '" + fin2 + "'," + idComprobante + ", " + cantLibros + ", " + dev + ",'" + fdev2 + "')");
                datosConexion.Insert("INSERT INTO DETALLE (idLibro, FechaFin, idComprobante, Cantidad, Devolucion, FechaDev) VALUES (" + idLibro3 + ", '" + fin3 + "'," + idComprobante + ", " + cantLibros + ", " + dev + ",'" + fdev3 + "')");

                MessageBox.Show("Se ha cargado el alquiler de 3 libros correctamente", "Alquiler realizado");
            }


        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funciones del formulario
        private void LlenarDgvLibAlq()
        {
            dgv_LibAlq.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT LIBROS.IdLibro, LIBROS.Titulo, AUTOR.Alias FROM AUTOR INNER JOIN LIBROS ON AUTOR.idAutor = LIBROS.idAutor ORDER BY LIBROS.Titulo Asc;");
            while (datosConexion.reader.Read())
            {
                List<object> CamposLibros = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))//id
                {
                    CamposLibros.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))//titulo
                {
                    CamposLibros.Add(datosConexion.reader.GetString(1));
                }
                if (!datosConexion.reader.IsDBNull(2))//autor
                {
                    CamposLibros.Add(datosConexion.reader.GetString(2));
                }
                dgv_LibAlq.Rows.Add(CamposLibros.ToArray());
            }
            datosConexion.CerrarConexion();
        }
        private void LlenarDgvLibTitulo()
        {
            dgv_LibAlq.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            string dato = tb_Buscar.Text;

            datosConexion.Select("SELECT LIBROS.IdLibro, LIBROS.Titulo, AUTOR.Alias FROM AUTOR INNER JOIN LIBROS ON AUTOR.idAutor = LIBROS.idAutor WHERE LIBROS.Titulo Like ('%" + dato + "%') ORDER BY LIBROS.Titulo;");
            while (datosConexion.reader.Read())
            {
                List<object> CamposLibros = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))//id
                {
                    CamposLibros.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))//titulo
                {
                    CamposLibros.Add(datosConexion.reader.GetString(1));
                }
                if (!datosConexion.reader.IsDBNull(2))//autor
                {
                    CamposLibros.Add(datosConexion.reader.GetString(2));
                }
                dgv_LibAlq.Rows.Add(CamposLibros.ToArray());
            }
            datosConexion.CerrarConexion();
        }
        private void LlenarDgvLibAutor()
        {
            dgv_LibAlq.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            string dato = tb_Buscar.Text;

            datosConexion.Select("SELECT LIBROS.IdLibro, LIBROS.Titulo, AUTOR.Alias FROM AUTOR INNER JOIN LIBROS ON AUTOR.idAutor = LIBROS.idAutor WHERE AUTOR.Alias Like ('%" + dato + "%') ORDER BY LIBROS.Titulo;");
            while (datosConexion.reader.Read())
            {
                List<object> CamposLibros = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))//id
                {
                    CamposLibros.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))//titulo
                {
                    CamposLibros.Add(datosConexion.reader.GetString(1));
                }
                if (!datosConexion.reader.IsDBNull(2))//autor
                {
                    CamposLibros.Add(datosConexion.reader.GetString(2));
                }
                dgv_LibAlq.Rows.Add(CamposLibros.ToArray());
            }
            datosConexion.CerrarConexion();
        }

        private void comboBoxCliente()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT idCliente, AliasCl FROM CLIENTE ORDER BY AliasCl Asc;");

            while (datosConexion.reader.Read())
            {
                List<object> CpClient = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CpClient.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CpClient.Add(datosConexion.reader.GetString(1));
                }

                cbx_clientAlq.Items.Add(datosConexion.reader.GetString(1));
            }
            datosConexion.CerrarConexion();
        }
        private void Comprobante()
        {
            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT IIF(IsNull(MAX(idComprobante)),0,MAX(idComprobante)) FROM COMPROBANTE;");

            while (datosConexion.reader.Read())
            {
                List<object> CpComp = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CpComp.Add(datosConexion.reader.GetInt32(0));
                }

                int next = datosConexion.reader.GetInt32(0);
                next++;
                tb_compr.Text = next.ToString();

            }
            datosConexion.CerrarConexion();  
                      
        }
        private void Fecha()
        {
            tb_fecHoy.Text = DateTime.Now.ToShortDateString();
        }


        private void rb_lib1_CheckedChanged(object sender, EventArgs e)
        {
            tb_id1.Enabled = true;
            tb_id2.Enabled = false;
            tb_id3.Enabled = false;
            dtp_fec1.Enabled = true;
            dtp_fec2.Enabled = false;
            dtp_fec3.Enabled = false;
            tb_lib1.Enabled = true;
            tb_lib2.Enabled = false;
            tb_lib3.Enabled = false;
            bt_mas1.Enabled = true;
            bt_mas2.Enabled = false;
            bt_mas3.Enabled = false;
        }
        private void rb_lib2_CheckedChanged(object sender, EventArgs e)
        {
            tb_id1.Enabled = true;
            tb_id2.Enabled = true;
            tb_id3.Enabled = false;
            dtp_fec1.Enabled = true;
            dtp_fec2.Enabled = true;
            dtp_fec3.Enabled = false;
            tb_lib1.Enabled = true;
            tb_lib2.Enabled = true;
            tb_lib3.Enabled = false;
            bt_mas1.Enabled = true;
            bt_mas2.Enabled = true;
            bt_mas3.Enabled = false;
        }
        private void rb_lib3_CheckedChanged(object sender, EventArgs e)
        {
            tb_id1.Enabled = true;
            tb_id2.Enabled = true;
            tb_id3.Enabled = true;
            dtp_fec1.Enabled = true;
            dtp_fec2.Enabled = true;
            dtp_fec3.Enabled = true;
            tb_lib1.Enabled = true;
            tb_lib2.Enabled = true;
            tb_lib3.Enabled = true;
            bt_mas1.Enabled = true;
            bt_mas2.Enabled = true;
            bt_mas3.Enabled = true;
        }


        #endregion


    }
}
