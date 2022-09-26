using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial8agosto
{
    public partial class Form1 : Form
    {
        Persona UnaPersona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Persona_Click(object sender, EventArgs e)
        {
            if (valDNI (Txt_Dni.Text) == true)
            {
                UnaPersona.PropNombre = Txt_Nombre.Text;
                UnaPersona.PropDni = Convert.ToInt64(Txt_Dni.Text);
                UnaPersona.PropFecha = DateTime.Parse(Txt_FechaNac.Text);

                Btn_Edad.Enabled = true;
            }
            else
            {
                MessageBox.Show("El número de documento no es valido", "ERROR");
            }
            
        }

        private bool valDNI(string ValidarDoc)
        {
            int i = 0;
            if (ValidarDoc.Length != 7 && ValidarDoc.Length != 8)
                return false;
           

            while (i <= ValidarDoc.Length-1)
            {
                if (!char.IsDigit(ValidarDoc,i))
                    return false;
                i++;
            }
        return true;
        }

        private void Btn_Edad_Click(object sender, EventArgs e)
        {
            Lbl_Edad.Text = UnaPersona.ResEdad().ToString();
        }
    }
}
