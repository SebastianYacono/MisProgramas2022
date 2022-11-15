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
            LlenarDgvLibro();
            LlenarDgvCliente();
        }

        #region Tab Bienvenidos
        private void btn_Alq_Click(object sender, EventArgs e)
        {
            AlqPrincipal alqPrincipal = new AlqPrincipal();
            alqPrincipal.ShowDialog();
        }
        private void btn_Ren_Click(object sender, EventArgs e)
        {
            RenPrincipal renPrincipal = new RenPrincipal();
            renPrincipal.ShowDialog();
        }
        private void btn_Dev_Click(object sender, EventArgs e)
        {
            DevPrincipal devPrincipal = new DevPrincipal();
            devPrincipal.ShowDialog();
        }

        #endregion


        #region Tab Clientes
        public void LlenarDgvCliente()//Rellena el dgv de cliente
        {
            dgv_Client.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT CLIENTE.idCliente, CLIENTE.Apellido, CLIENTE.Nombre, CLIENTE.Direccion, BARRIO.Barrio, CLIENTE.Telefono, CLIENTE.Email FROM BARRIO INNER JOIN CLIENTE ON BARRIO.idBarrio = CLIENTE.idBarrio;");
            while (datosConexion.reader.Read())
            {
                List<object> CamposClient = new List<object>();
                if (!datosConexion.reader.IsDBNull(0))
                {
                    CamposClient.Add(datosConexion.reader.GetInt32(0));
                }
                if (!datosConexion.reader.IsDBNull(1))
                {
                    CamposClient.Add(datosConexion.reader.GetString(1));
                }
                if (!datosConexion.reader.IsDBNull(2))
                {
                    CamposClient.Add(datosConexion.reader.GetString(2));
                }
                if (!datosConexion.reader.IsDBNull(3))
                {
                    CamposClient.Add(datosConexion.reader.GetString(3));
                }
                if (!datosConexion.reader.IsDBNull(4))
                {
                    CamposClient.Add(datosConexion.reader.GetString(4));
                }
                if (!datosConexion.reader.IsDBNull(5))
                {
                    CamposClient.Add(datosConexion.reader.GetDecimal(5));
                }
                if (!datosConexion.reader.IsDBNull(6))
                {
                    CamposClient.Add(datosConexion.reader.GetString(6));
                }
                
                dgv_Client.Rows.Add(CamposClient.ToArray());

            }

            datosConexion.CerrarConexion();
        }
        private void Btn_newClient_Click(object sender, EventArgs e)//Comando para crear el cliente.
        {
            NewClient newClient = new NewClient(this);
            newClient.ShowDialog();
        }
        private void Btn_deleteClient_Click(object sender, EventArgs e)//Comando para eliminar cliente
        {
            string valor;
            valor = dgv_Client.Rows[dgv_Client.CurrentRow.Index].Cells[0].Value.ToString();

            DialogResult r = MessageBox.Show("¿Quieres eliminar este elemento?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DatosConexion datosConexion = new DatosConexion();
                datosConexion.Delete("DELETE FROM CLIENTE WHERE(idCliente = " + valor + ")");

                LlenarDgvCliente();

                MessageBox.Show("El cliente ha sido eliminado exitosamente", "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_editClient_Click(object sender, EventArgs e)//Comando para editar el cliente.
        {
            var fila = dgv_Client.CurrentRow;
            int id = 0;
            string apellido = "";
            string nombre = "";
            string direccion = "";
            string barrio = "";
            decimal telefono = 0;
            string mail = "";

            if (fila != null)
            {
                if (fila.Cells[0].Value != null)
                    id = Convert.ToInt32(fila.Cells[0].Value);
                if (fila.Cells[1].Value != null)
                    apellido = fila.Cells[1].Value.ToString();
                if (fila.Cells[2].Value != null)
                    nombre = fila.Cells[2].Value.ToString();
                if (fila.Cells[3].Value != null)
                    direccion = fila.Cells[3].Value.ToString();
                if (fila.Cells[4].Value != null)
                    barrio = fila.Cells[4].Value.ToString();
                if (fila.Cells[5].Value != null)
                    telefono = Convert.ToDecimal(fila.Cells[5].Value);
                if (fila.Cells[6].Value != null)
                    mail = fila.Cells[6].Value.ToString();
            }
            //Lleva al form UpdateAut
            UpdateClient updateClient = new UpdateClient(this, id, apellido, nombre, direccion,barrio,telefono, mail);
            updateClient.ShowDialog();
        }
        #endregion


        #region Tab Libros
        public void LlenarDgvLibro()//Rellena el dgv de libro
        {
            dgv_Libros.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT LIBROS.IdLibro, LIBROS.Titulo, AUTOR.Alias, GENERO.Genero, LIBROS.Descripcion, IDIOMA.Idioma, PROVEEDOR.Nombre, LIBROS.FechaIng, LIBROS.Disponible, LIBROS.Ubicacion, ESTADO.Estado FROM PROVEEDOR INNER JOIN (IDIOMA INNER JOIN (GENERO INNER JOIN (ESTADO INNER JOIN (AUTOR INNER JOIN LIBROS ON AUTOR.idAutor = LIBROS.idAutor) ON ESTADO.idEstado = LIBROS.idEstado) ON GENERO.idGenero = LIBROS.idGenero) ON IDIOMA.idIdioma = LIBROS.idIdioma) ON PROVEEDOR.idProveedor = LIBROS.idProveedor ORDER BY LIBROS.Titulo Asc;");
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
                if (!datosConexion.reader.IsDBNull(3))//genero
                {
                    CamposLibros.Add(datosConexion.reader.GetString(3));
                }
                if (!datosConexion.reader.IsDBNull(4))//descripcion
                {
                    CamposLibros.Add(datosConexion.reader.GetString(4));
                }
                if (!datosConexion.reader.IsDBNull(5))//idioma
                {
                    CamposLibros.Add(datosConexion.reader.GetString(5));
                }
                if (!datosConexion.reader.IsDBNull(6))//proveedor
                {
                    CamposLibros.Add(datosConexion.reader.GetString(6));
                }
                if (!datosConexion.reader.IsDBNull(7))//fechaIng
                {
                    CamposLibros.Add(datosConexion.reader.GetDateTime(7));
                }
                if (!datosConexion.reader.IsDBNull(8))//disp
                {
                    CamposLibros.Add(datosConexion.reader.GetBoolean(8));
                }
                if (!datosConexion.reader.IsDBNull(9))//ubicacion
                {
                    CamposLibros.Add(datosConexion.reader.GetString(9));
                }
                if (!datosConexion.reader.IsDBNull(10))//estado
                {
                    CamposLibros.Add(datosConexion.reader.GetString(10));
                }

                dgv_Libros.Rows.Add(CamposLibros.ToArray());

            }

            datosConexion.CerrarConexion();
        }
        public void LlenarDgvLibDisp()//Rellena el dgv de libro
        {
            dgv_Libros.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT LIBROS.IdLibro, LIBROS.Titulo, AUTOR.Alias, GENERO.Genero, LIBROS.Descripcion, IDIOMA.Idioma, PROVEEDOR.Nombre, LIBROS.FechaIng, LIBROS.Disponible, LIBROS.Ubicacion, ESTADO.Estado FROM PROVEEDOR INNER JOIN (IDIOMA INNER JOIN (GENERO INNER JOIN (ESTADO INNER JOIN (AUTOR INNER JOIN LIBROS ON AUTOR.idAutor = LIBROS.idAutor) ON ESTADO.idEstado = LIBROS.idEstado) ON GENERO.idGenero = LIBROS.idGenero) ON IDIOMA.idIdioma = LIBROS.idIdioma) ON PROVEEDOR.idProveedor = LIBROS.idProveedor WHERE LIBROS.Disponible LIKE true ORDER BY LIBROS.Titulo Asc;");
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
                if (!datosConexion.reader.IsDBNull(3))//genero
                {
                    CamposLibros.Add(datosConexion.reader.GetString(3));
                }
                if (!datosConexion.reader.IsDBNull(4))//descripcion
                {
                    CamposLibros.Add(datosConexion.reader.GetString(4));
                }
                if (!datosConexion.reader.IsDBNull(5))//idioma
                {
                    CamposLibros.Add(datosConexion.reader.GetString(5));
                }
                if (!datosConexion.reader.IsDBNull(6))//proveedor
                {
                    CamposLibros.Add(datosConexion.reader.GetString(6));
                }
                if (!datosConexion.reader.IsDBNull(7))//fechaIng
                {
                    CamposLibros.Add(datosConexion.reader.GetDateTime(7));
                }
                if (!datosConexion.reader.IsDBNull(8))//disp
                {
                    CamposLibros.Add(datosConexion.reader.GetBoolean(8));
                }
                if (!datosConexion.reader.IsDBNull(9))//ubicacion
                {
                    CamposLibros.Add(datosConexion.reader.GetString(9));
                }
                if (!datosConexion.reader.IsDBNull(10))//estado
                {
                    CamposLibros.Add(datosConexion.reader.GetString(10));
                }

                dgv_Libros.Rows.Add(CamposLibros.ToArray());

            }

            datosConexion.CerrarConexion();
        }
        public void LlenarDgvLibNDisp()//Rellena el dgv de libro
        {
            dgv_Libros.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT LIBROS.IdLibro, LIBROS.Titulo, AUTOR.Alias, GENERO.Genero, LIBROS.Descripcion, IDIOMA.Idioma, PROVEEDOR.Nombre, LIBROS.FechaIng, LIBROS.Disponible, LIBROS.Ubicacion, ESTADO.Estado FROM PROVEEDOR INNER JOIN (IDIOMA INNER JOIN (GENERO INNER JOIN (ESTADO INNER JOIN (AUTOR INNER JOIN LIBROS ON AUTOR.idAutor = LIBROS.idAutor) ON ESTADO.idEstado = LIBROS.idEstado) ON GENERO.idGenero = LIBROS.idGenero) ON IDIOMA.idIdioma = LIBROS.idIdioma) ON PROVEEDOR.idProveedor = LIBROS.idProveedor WHERE LIBROS.Disponible LIKE false ORDER BY LIBROS.Titulo Asc;");
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
                if (!datosConexion.reader.IsDBNull(3))//genero
                {
                    CamposLibros.Add(datosConexion.reader.GetString(3));
                }
                if (!datosConexion.reader.IsDBNull(4))//descripcion
                {
                    CamposLibros.Add(datosConexion.reader.GetString(4));
                }
                if (!datosConexion.reader.IsDBNull(5))//idioma
                {
                    CamposLibros.Add(datosConexion.reader.GetString(5));
                }
                if (!datosConexion.reader.IsDBNull(6))//proveedor
                {
                    CamposLibros.Add(datosConexion.reader.GetString(6));
                }
                if (!datosConexion.reader.IsDBNull(7))//fechaIng
                {
                    CamposLibros.Add(datosConexion.reader.GetDateTime(7));
                }
                if (!datosConexion.reader.IsDBNull(8))//disp
                {
                    CamposLibros.Add(datosConexion.reader.GetBoolean(8));
                }
                if (!datosConexion.reader.IsDBNull(9))//ubicacion
                {
                    CamposLibros.Add(datosConexion.reader.GetString(9));
                }
                if (!datosConexion.reader.IsDBNull(10))//estado
                {
                    CamposLibros.Add(datosConexion.reader.GetString(10));
                }

                dgv_Libros.Rows.Add(CamposLibros.ToArray());

            }

            datosConexion.CerrarConexion();
        }

        private void rb_nDisp_CheckedChanged(object sender, EventArgs e)
        {
            LlenarDgvLibNDisp();
        }
        private void rb_disp_CheckedChanged(object sender, EventArgs e)
        {
            LlenarDgvLibDisp();
        }
        private void rb_All_CheckedChanged(object sender, EventArgs e)
        {
            LlenarDgvLibro();
        }

        private void Btn_newLibro_Click(object sender, EventArgs e)//Comando para crear el libro.
        {
            NewLibro newLibro = new NewLibro(this);
            newLibro.ShowDialog();
        }
        private void Btn_deleteLibro_Click(object sender, EventArgs e)//Comando para eliminar libro.
        {
            string valor;
            valor = dgv_Libros.Rows[dgv_Libros.CurrentRow.Index].Cells[0].Value.ToString();

            DialogResult r = MessageBox.Show("¿Quieres eliminar este elemento?", "Eliminar libro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DatosConexion datosConexion = new DatosConexion();
                datosConexion.Delete("DELETE FROM LIBROS WHERE(idLibro = " + valor + ")");

                LlenarDgvLibro();

                MessageBox.Show("El libro ha sido eliminado exitosamente", "Eliminar libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_editLibro_Click(object sender, EventArgs e)//Comando para editar el libro.
        {
            var fila = dgv_Libros.CurrentRow;
            int id = 0;
            string titulo = "";
            string autor = "";
            string genero = "";
            string desc = "";
            string idioma = "";
            string prov = "";
            string fecIng = "";
            bool disp = true;
            string ubi = "";
            string estado = "";

            if (fila != null)
            {
                if (fila.Cells[0].Value != null)
                    id = Convert.ToInt32(fila.Cells[0].Value);
                if (fila.Cells[1].Value != null)
                    titulo = fila.Cells[1].Value.ToString();
                if (fila.Cells[2].Value != null)
                    autor = fila.Cells[2].Value.ToString();
                if (fila.Cells[3].Value != null)
                    genero = fila.Cells[3].Value.ToString();
                if (fila.Cells[4].Value != null)
                    desc = fila.Cells[4].Value.ToString();
                if (fila.Cells[5].Value != null)
                    idioma = fila.Cells[5].Value.ToString();
                if (fila.Cells[6].Value != null)
                    prov = fila.Cells[6].Value.ToString();
                if (fila.Cells[7].Value != null)
                    fecIng = fila.Cells[7].Value.ToString();
                if (fila.Cells[8].Value != null)
                    disp = Convert.ToBoolean(fila.Cells[8].Value);
                if (fila.Cells[9].Value != null)
                    ubi = fila.Cells[9].Value.ToString();
                if (fila.Cells[10].Value != null)
                    estado = fila.Cells[10].Value.ToString();
                
            }
            //Lleva al form UpdateAut
            UpdateLibro updateLibro = new UpdateLibro(this, id, titulo, autor, genero, desc, idioma, prov, fecIng, disp, ubi, estado);
            updateLibro.ShowDialog();
        }
        private void btn_InfoLibro_Click(object sender, EventArgs e)
        {
            var fila = dgv_Libros.CurrentRow;
            int id = 0;
            string titulo = "";
            string autor = "";
            string genero = "";
            string desc = "";
            string idioma = "";
            string prov = "";
            string fecIng = "";
            bool disp = true;
            string ubi = "";
            string estado = "";

            if (fila != null)
            {
                if (fila.Cells[0].Value != null)
                    id = Convert.ToInt32(fila.Cells[0].Value);
                if (fila.Cells[1].Value != null)
                    titulo = fila.Cells[1].Value.ToString();
                if (fila.Cells[2].Value != null)
                    autor = fila.Cells[2].Value.ToString();
                if (fila.Cells[3].Value != null)
                    genero = fila.Cells[3].Value.ToString();
                if (fila.Cells[4].Value != null)
                    desc = fila.Cells[4].Value.ToString();
                if (fila.Cells[5].Value != null)
                    idioma = fila.Cells[5].Value.ToString();
                if (fila.Cells[6].Value != null)
                    prov = fila.Cells[6].Value.ToString();
                if (fila.Cells[7].Value != null)
                    fecIng = fila.Cells[7].Value.ToString();
                if (fila.Cells[8].Value != null)
                    disp = Convert.ToBoolean(fila.Cells[8].Value);
                if (fila.Cells[9].Value != null)
                    ubi = fila.Cells[9].Value.ToString();
                if (fila.Cells[10].Value != null)
                    estado = fila.Cells[10].Value.ToString();

            }
            //Lleva al form UpdateAut
            InfLibro infoLibro = new InfLibro (this, titulo, autor, genero, desc, idioma, prov, fecIng,ubi, estado);
            infoLibro.ShowDialog();
        }
        #endregion


        #region Tab Autor
        public void LlenarDgvAutor()//Rellena el dgv de autor.
        {
            dgv_Autor.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT AUTOR.idAutor, AUTOR.Apellido, AUTOR.Nombre, PAIS.Pais, GENERO.Genero, AUTOR.Alias FROM PAIS INNER JOIN (AUTOR INNER JOIN GENERO ON AUTOR.idGenero = GENERO.idGenero) ON PAIS.idPais = AUTOR.idPais ORDER BY AUTOR.Apellido Asc;");
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
                if (!datosConexion.reader.IsDBNull(4))
                {
                    CamposAut.Add(datosConexion.reader.GetString(4));
                }
                if (!datosConexion.reader.IsDBNull(5))
                {
                    CamposAut.Add(datosConexion.reader.GetString(5));
                }

                dgv_Autor.Rows.Add(CamposAut.ToArray());

            }

            datosConexion.CerrarConexion();
        }
        private void Btn_NewAut_Click(object sender, EventArgs e)//Comando para crear el autor.
        {
            NewAutor newAutor = new NewAutor(this);
            newAutor.ShowDialog();
        }
        private void Btn_deleteAut_Click(object sender, EventArgs e)//Comando para eliminar autor.
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
        private void Btn_editAut_Click(object sender, EventArgs e)//Comando para editar el autor.
        {
            var fila = dgv_Autor.CurrentRow;
            int id = 0;
            string apellido = "";
            string nombre = "";
            string pais = "";
            string genero = "";
            string alias = "";

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
                if (fila.Cells[4].Value != null)
                    genero = fila.Cells[4].Value.ToString();
                if (fila.Cells[5].Value != null)
                    alias = fila.Cells[5].Value.ToString();
            }
            //Lleva al form UpdateAut
            UpdateAutor updateAutor = new UpdateAutor(this, id, apellido, nombre, pais, genero, alias);
            updateAutor.ShowDialog();
        }
        #endregion


        #region Tab Proveedores
        public void LlenarDgvProv() //Rellena el dgv de proveedores.
        {
            dgv_prov.Rows.Clear();

            DatosConexion datosConexion = new DatosConexion();

            datosConexion.Select("SELECT * from PROVEEDOR ORDER BY Nombre Asc");
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
        private void Btn_deleteProv_Click(object sender, EventArgs e) //Comando para eliminar el proveedor.
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
        private void Btn_editProv_Click(object sender, EventArgs e) //Comando para editar el proveedor.
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
        private void SalirApp_Click(object sender, EventArgs e) //Boton Cerrar. Produce cierre completo del programa.
        {
            Application.Exit();
        }
        private void timer1_Tick_1(object sender, EventArgs e) // Controla fecha y hora.
        {
            lbl_FecHor.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  -  " + DateTime.Now.ToString("HH:mm");
        }
        private void Principal_FormClosed(object sender, FormClosedEventArgs e) //Genera el cierre total del soft cuando se presiona la X.
        {
            Application.Exit();
        }
        #endregion
    }
}
