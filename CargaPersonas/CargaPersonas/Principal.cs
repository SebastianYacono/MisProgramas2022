using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace CargaPersonas
{
    public partial class Principal : Form
    {
        NegAlumno DatosObjAlumno = new NegAlumno();
        NegProfesor DatosObjProfesor = new NegProfesor();
        public Principal()
        {
            InitializeComponent();
            CrearDgvAlumnos();
            LlenarDgvAlumnos();
            CrearDgvProfesor();
            LlenarDgvProfesor();
        }

        #region Tab Alumnos
        private void CrearDgvAlumnos()
        {
            dgv_Alumn.Columns.Add("0", "Id");
            dgv_Alumn.Columns.Add("1", "Apellido");
            dgv_Alumn.Columns.Add("2", "Nombre");
            dgv_Alumn.Columns.Add("3", "Domicilio");
            dgv_Alumn.Columns.Add("4", "DNI");
            dgv_Alumn.Columns.Add("5", "F.Nac.");
            dgv_Alumn.Columns.Add("6", "Teléfono");
            dgv_Alumn.Columns.Add("7", "E-Mail");
            dgv_Alumn.Columns.Add("8", "Provincia");
            dgv_Alumn.Columns.Add("9", "Localidad");
            dgv_Alumn.Columns.Add("10", "Cur.");
            dgv_Alumn.Columns.Add("11", "Div.");
            dgv_Alumn.Columns.Add("12", "Tur.");
            dgv_Alumn.Columns.Add("13", "idProv.");
            dgv_Alumn.Columns.Add("14", "idLoc");

            dgv_Alumn.Columns[0].Width = 10;
            dgv_Alumn.Columns[1].Width = 100;
            dgv_Alumn.Columns[2].Width = 100;
            dgv_Alumn.Columns[3].Width = 150;
            dgv_Alumn.Columns[4].Width = 100;
            dgv_Alumn.Columns[5].Width = 100;
            dgv_Alumn.Columns[6].Width = 100;
            dgv_Alumn.Columns[7].Width = 100;
            dgv_Alumn.Columns[8].Width = 90;
            dgv_Alumn.Columns[9].Width = 90;
            dgv_Alumn.Columns[10].Width = 40;
            dgv_Alumn.Columns[11].Width = 40;
            dgv_Alumn.Columns[12].Width = 40;
            dgv_Alumn.Columns[13].Width = 40;
            dgv_Alumn.Columns[14].Width = 40;

            dgv_Alumn.Columns[0].Visible = false;
            dgv_Alumn.Columns[13].Visible = false;
            dgv_Alumn.Columns[14].Visible = false;
        }
        public void LlenarDgvAlumnos()
        {
            dgv_Alumn.Rows.Clear();

            DataSet ds = new DataSet();
            ds = DatosObjAlumno.listaDeAlumnos("SELECT");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_Alumn.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7], dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11], dr[12], dr[13].ToString(), dr[14].ToString());
                }
            }
            else
                MessageBox.Show("No hay alumnos cargados en el sistema");
        }

        private void Btn_addAlumn_Click(object sender, EventArgs e)
        {
            NuevoAlumno nuevoAlumno = new NuevoAlumno(this);
            nuevoAlumno.ShowDialog();
        }
        public void Btn_editAlumn_Click(object sender, EventArgs e)
        {
            Alumnos Alumno = new Alumnos();
            if (dgv_Alumn.SelectedCells.Count > 0)
            {
                if (dgv_Alumn.CurrentRow.Cells[0].Value != null)
                    Alumno.p_id = Convert.ToInt32(dgv_Alumn.CurrentRow.Cells[0].Value);
                if (dgv_Alumn.CurrentRow.Cells[1].Value != null)
                    Alumno.p_apell = dgv_Alumn.CurrentRow.Cells[1].Value.ToString();
                if (dgv_Alumn.CurrentRow.Cells[2].Value != null)
                    Alumno.p_nomb = dgv_Alumn.CurrentRow.Cells[2].Value.ToString();
                if (dgv_Alumn.CurrentRow.Cells[3].Value != null)
                    Alumno.p_dom = dgv_Alumn.CurrentRow.Cells[3].Value.ToString();
                if (dgv_Alumn.CurrentRow.Cells[4].Value != null)
                    Alumno.p_dni = Convert.ToInt64(dgv_Alumn.CurrentRow.Cells[4].Value);
                if (dgv_Alumn.CurrentRow.Cells[5].Value != null)
                    Alumno.p_fechaNac = DateTime.Parse(dgv_Alumn.CurrentRow.Cells[5].Value.ToString());
                if (dgv_Alumn.CurrentRow.Cells[6].Value != null)
                    Alumno.p_tel = Convert.ToDecimal(dgv_Alumn.CurrentRow.Cells[6].Value);
                if (dgv_Alumn.CurrentRow.Cells[7].Value != null)
                    Alumno.p_mail = dgv_Alumn.CurrentRow.Cells[7].Value.ToString();
                if (dgv_Alumn.CurrentRow.Cells[10].Value != null)
                    Alumno.p_AnioLect = Convert.ToInt32(dgv_Alumn.CurrentRow.Cells[10].Value);
                if (dgv_Alumn.CurrentRow.Cells[11].Value != null)
                    Alumno.p_div = dgv_Alumn.CurrentRow.Cells[11].Value.ToString();
                if (dgv_Alumn.CurrentRow.Cells[12].Value != null)
                    Alumno.p_turno = dgv_Alumn.CurrentRow.Cells[12].Value.ToString();
                if (dgv_Alumn.CurrentRow.Cells[13].Value != null)
                    Alumno.p_idProv = Convert.ToInt32(dgv_Alumn.CurrentRow.Cells[13].Value);
                if (dgv_Alumn.CurrentRow.Cells[14].Value != null)
                    Alumno.p_idLoc = Convert.ToInt32(dgv_Alumn.CurrentRow.Cells[14].Value);
            }

            //new ModAlumno(Alumno).ShowDialog();
            ModAlumno modAlumno = new ModAlumno(this, Alumno);
            modAlumno.ShowDialog();
        }
        private void Btn_deleteAlumn_Click(object sender, EventArgs e)
        {
            Alumnos Alumno = new Alumnos();
            string valor;
            valor = dgv_Alumn.Rows[dgv_Alumn.CurrentRow.Index].Cells[0].Value.ToString();

            Alumno.p_id = Convert.ToInt32(valor);

            DialogResult r = MessageBox.Show("¿Quieres eliminar este alumno?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                int nResultado = -1;

                nResultado = DatosObjAlumno.ABM_Alumnos("DELETE", Alumno);
                if (nResultado != -1)
                {
                    LlenarDgvAlumnos();
                    MessageBox.Show("El alumno fue eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Error", "Se produjo un error al intentar modificar el Producto");
                }
            }
        }
        #endregion

        #region Tab Profesores
        private void CrearDgvProfesor()
        {
            dgv_Prof.Columns.Add("0", "Id");
            dgv_Prof.Columns.Add("1", "Apellido");
            dgv_Prof.Columns.Add("2", "Nombre");
            dgv_Prof.Columns.Add("3", "Domicilio");
            dgv_Prof.Columns.Add("4", "DNI");
            dgv_Prof.Columns.Add("5", "F.Nac.");
            dgv_Prof.Columns.Add("6", "Teléfono");
            dgv_Prof.Columns.Add("7", "E-Mail");
            dgv_Prof.Columns.Add("8", "Provincia");
            dgv_Prof.Columns.Add("9", "Localidad");
            dgv_Prof.Columns.Add("10", "Legajo");
            dgv_Prof.Columns.Add("11", "Cant. Hs.");
            dgv_Prof.Columns.Add("12", "idProv");
            dgv_Prof.Columns.Add("13", "idLoc");

            dgv_Prof.Columns[0].Width = 10;
            dgv_Prof.Columns[1].Width = 100;
            dgv_Prof.Columns[2].Width = 100;
            dgv_Prof.Columns[3].Width = 150;
            dgv_Prof.Columns[4].Width = 100;
            dgv_Prof.Columns[5].Width = 100;
            dgv_Prof.Columns[6].Width = 100;
            dgv_Prof.Columns[7].Width = 100;
            dgv_Prof.Columns[8].Width = 90;
            dgv_Prof.Columns[9].Width = 90;
            dgv_Prof.Columns[10].Width = 40;
            dgv_Prof.Columns[11].Width = 40;
            dgv_Prof.Columns[12].Width = 40;
            dgv_Prof.Columns[13].Width = 40;

            dgv_Prof.Columns[0].Visible = false;
            dgv_Prof.Columns[12].Visible = false;
            dgv_Prof.Columns[13].Visible = false;
        }
        public void LlenarDgvProfesor()
        {
            dgv_Prof.Rows.Clear();

            DataSet ds = new DataSet();
            ds = DatosObjProfesor.listaDeProfesores("SELECT");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_Prof.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7], dr[8].ToString(), dr[9].ToString(), dr[10], dr[11].ToString(), dr[12].ToString(), dr[13].ToString());
                }
            }
            else
                MessageBox.Show("No hay profesores cargados en el sistema");
        }


        private void Btn_addProf_Click(object sender, EventArgs e)
        {
            NuevoProfesor nuevoProfesor = new NuevoProfesor(this);
            nuevoProfesor.ShowDialog();
        }
        private void Btn_editProf_Click(object sender, EventArgs e)
        {
            Profesores profesor = new Profesores();
            if (dgv_Prof.SelectedCells.Count > 0)
            {
                if (dgv_Prof.CurrentRow.Cells[0].Value != null)
                    profesor.p_id = Convert.ToInt32(dgv_Prof.CurrentRow.Cells[0].Value);
                if (dgv_Prof.CurrentRow.Cells[1].Value != null)
                    profesor.p_apell = dgv_Prof.CurrentRow.Cells[1].Value.ToString();
                if (dgv_Prof.CurrentRow.Cells[2].Value != null)
                    profesor.p_nomb = dgv_Prof.CurrentRow.Cells[2].Value.ToString();
                if (dgv_Prof.CurrentRow.Cells[3].Value != null)
                    profesor.p_dom = dgv_Prof.CurrentRow.Cells[3].Value.ToString();
                if (dgv_Prof.CurrentRow.Cells[4].Value != null)
                    profesor.p_dni = Convert.ToInt64(dgv_Prof.CurrentRow.Cells[4].Value);
                if (dgv_Prof.CurrentRow.Cells[5].Value != null)
                    profesor.p_fechaNac = DateTime.Parse(dgv_Prof.CurrentRow.Cells[5].Value.ToString());
                if (dgv_Prof.CurrentRow.Cells[6].Value != null)
                    profesor.p_tel = Convert.ToDecimal(dgv_Prof.CurrentRow.Cells[6].Value);
                if (dgv_Prof.CurrentRow.Cells[7].Value != null)
                    profesor.p_mail = dgv_Prof.CurrentRow.Cells[7].Value.ToString();
                if (dgv_Prof.CurrentRow.Cells[10].Value != null)
                    profesor.p_legajo = dgv_Prof.CurrentRow.Cells[10].Value.ToString();
                if (dgv_Prof.CurrentRow.Cells[11].Value != null)
                    profesor.p_cantHs = Convert.ToInt32(dgv_Prof.CurrentRow.Cells[11].Value);
                if (dgv_Prof.CurrentRow.Cells[12].Value != null)
                    profesor.p_idProv = Convert.ToInt32(dgv_Prof.CurrentRow.Cells[12].Value);
                if (dgv_Prof.CurrentRow.Cells[13].Value != null)
                    profesor.p_idLoc = Convert.ToInt32(dgv_Prof.CurrentRow.Cells[13].Value);
            }

            ModProfesor modProfesor = new ModProfesor(this, profesor);
            modProfesor.ShowDialog();
        }
        private void Btn_deleteProf_Click(object sender, EventArgs e)
        {
            Profesores profesor = new Profesores();
            string valor;
            valor = dgv_Prof.Rows[dgv_Prof.CurrentRow.Index].Cells[0].Value.ToString();

            profesor.p_id = Convert.ToInt32(valor);

            DialogResult r = MessageBox.Show("¿Quieres eliminar este profesor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                int nResultado = -1;

                nResultado = DatosObjProfesor.ABM_Profesores("DELETE", profesor);
                if (nResultado != -1)
                {
                    LlenarDgvProfesor();
                    MessageBox.Show("El profesor fue eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Error", "Se produjo un error al intentar eliminar el profesor");
                }
            }
        }

        #endregion


    }
}
