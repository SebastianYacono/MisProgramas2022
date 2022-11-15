using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;


namespace BiblioCaxial
{
    public partial class AlqNvo : Form
    {
        AlqPrincipal principal;
        public AlqNvo(AlqPrincipal NuevoAlq)
        {
            InitializeComponent();
            principal = NuevoAlq;
            LlenarDgvLibAlq();
            comboBoxCliente();
            Comprobante();
            Fecha();
            cbx_Buscar.SelectedIndex = 1;
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
            rb_lib1.Enabled = false;
            rb_lib2.Enabled = false;
            rb_lib3.Enabled = false;
            bt_mas1.Enabled = false;

            if (rb_lib2.Checked || rb_lib3.Checked)
            {
                bt_mas2.Enabled = true;
            }
            if (rb_lib1.Checked)
            {
                btn_Alquilar.Enabled = true;
            }
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

            int tb1 = Convert.ToInt32(tb_id1.Text);
            if (id2 == tb1)
            {
                MessageBox.Show("No se puede cargar 2 veces el mismo libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tb_id2.Text = id2.ToString();
                tb_lib2.Text = titulo2;
                bt_mas2.Enabled = false;

                if (rb_lib3.Checked)
                {
                    bt_mas3.Enabled = true;
                }
                if (rb_lib2.Checked)
                {
                    btn_Alquilar.Enabled = true;
                }
            }
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

            int tb1 = Convert.ToInt32(tb_id1.Text);
            int tb2 = Convert.ToInt32(tb_id2.Text);
            if (id3 == tb1 || id3 == tb2)
            {
                MessageBox.Show("No se puede cargar 2 veces el mismo libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tb_id3.Text = id3.ToString();
                tb_lib3.Text = titulo3;
                bt_mas3.Enabled = false;
            }
            if (rb_lib3.Checked)
            {
                btn_Alquilar.Enabled = true;
            }
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            rb_lib1.Enabled = true;
            rb_lib2.Enabled = true;
            rb_lib3.Enabled = true;
            rb_lib1.Checked = true;
            rb_lib2.Checked = false;
            rb_lib3.Checked = false;
            bt_mas1.Enabled = true;
            bt_mas2.Enabled = false;
            bt_mas3.Enabled = false;
            tb_id1.Clear();
            tb_id2.Clear();
            tb_id3.Clear();
            tb_lib1.Clear();
            tb_lib2.Clear();
            tb_lib3.Clear();
            btn_Alquilar.Enabled = false;
        }
        #endregion

        #region Botones importantes del formulario
        private void btn_Alquilar_Click(object sender, EventArgs e)
        {
            DatosConexion datosConexion = new DatosConexion();

            if (cbx_clientAlq.Text == "" || tb_Monto.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un cliente o no se ha cargado el monto a cobrar.", "Error al crear Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Parte de comprobante
                int idCliente = Convert.ToInt32(cbx_clientAlq.SelectedValue);
                DateTime fechaComp = DateTime.Parse(tb_fecHoy.Text);
                decimal monto = Convert.ToDecimal(tb_Monto.Text);

                datosConexion.Insert("INSERT INTO COMPROBANTE(idCliente, FechaComprobante, Monto) VALUES (" + idCliente + ", '" + fechaComp + "', " + monto + ");");

                Thread.Sleep(1000);


                //Parte de alquiler de libro
                int idComprobante = Convert.ToInt32(tb_compr.Text);
                bool dev = false;
                int cantLibros = 0;

                if (rb_lib1.Checked == true)
                {
                    if (tb_id1.Text != "")
                    {
                        int idLibro1 = Convert.ToInt32(tb_id1.Text);
                        DateTime fin1 = DateTime.Parse(dtp_fec1.Text);
                        DateTime fdev1 = DateTime.Parse(dtp_fec1.Text);

                        cantLibros = 1;
                        datosConexion.Insert("INSERT INTO DETALLE (idLibro, FechaFin, idComprobante, Cantidad, Devolucion, FechaDev) VALUES (" + idLibro1 + ", '" + fin1 + "'," + idComprobante + ", " + cantLibros + ", " + dev + ",'" + fdev1 + "');");
                        datosConexion.Update("UPDATE LIBROS SET Disponible = false WHERE idLibro = " + idLibro1 + ";");

                        MessageBox.Show("Se ha cargado el alquiler de 1 libro correctamente", "Alquiler realizado");
                    }
                    else
                    {
                        MessageBox.Show("Falta cargar el libro a alquilar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (rb_lib2.Checked == true)
                {
                    if (tb_id1.Text != "" && tb_id2.Text != "")
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
                        datosConexion.Update("UPDATE LIBROS SET Disponible = false WHERE idLibro = " + idLibro1 + ";");
                        datosConexion.Update("UPDATE LIBROS SET Disponible = false WHERE idLibro = " + idLibro2 + ";");
                        MessageBox.Show("Se ha cargado el alquiler de 2 libros correctamente", "Alquiler realizado");
                    }
                    else
                    {
                        MessageBox.Show("Falta cargar un libro a alquilar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (rb_lib3.Checked == true)
                {
                    if (tb_id1.Text != "" && tb_id2.Text != "" && tb_id3.Text != "")
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
                        datosConexion.Update("UPDATE LIBROS SET Disponible = false WHERE idLibro = " + idLibro1 + ";");
                        datosConexion.Update("UPDATE LIBROS SET Disponible = false WHERE idLibro = " + idLibro2 + ";");
                        datosConexion.Update("UPDATE LIBROS SET Disponible = false WHERE idLibro = " + idLibro3 + ";");
                        MessageBox.Show("Se ha cargado el alquiler de 3 libros correctamente", "Alquiler realizado");
                    }
                    else
                    {
                        MessageBox.Show("Falta cargar un libro a alquilar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.Close();
            }
            principal.LlenarDgvAlq();
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

            datosConexion.Select("SELECT LIBROS.IdLibro, LIBROS.Titulo, AUTOR.Alias FROM AUTOR INNER JOIN LIBROS ON AUTOR.idAutor = LIBROS.idAutor WHERE LIBROS.Disponible LIKE true ORDER BY LIBROS.Titulo Asc;");
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

            datosConexion.SelectDT("SELECT idCliente, AliasCl FROM CLIENTE;");

            cbx_clientAlq.DataSource = datosConexion.dt;
            cbx_clientAlq.DisplayMember = "AliasCl";
            cbx_clientAlq.ValueMember = "idCliente";


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
        }
        #endregion
    }
}
