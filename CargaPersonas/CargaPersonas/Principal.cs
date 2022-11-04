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

            dgv_Alumn.Columns[0].Visible = false;
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
                    dgv_Alumn.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7], dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11], dr[12]);
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
        private void Btn_editAlumn_Click(object sender, EventArgs e)
        {
            ModAlumno modAlumno = new ModAlumno();
            modAlumno.ShowDialog();
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
            dgv_Prof.Columns[10].Width = 60;
            dgv_Prof.Columns[11].Width = 60;

            dgv_Prof.Columns[0].Visible = false;
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
                    dgv_Prof.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7], dr[8].ToString(), dr[9].ToString(), dr[10], dr[11].ToString());
                }
            }
            else
                MessageBox.Show("No hay profesores cargados en el sistema");
        }


        private void Btn_addProf_Click(object sender, EventArgs e)
        {
            NuevoProfesor nuevoProfesor = new NuevoProfesor();
            nuevoProfesor.ShowDialog();
        }
        private void Btn_editProf_Click(object sender, EventArgs e)
        {
            ModProfesor modProfesor = new ModProfesor();
            modProfesor.ShowDialog();
        }
        #endregion


    }
}
