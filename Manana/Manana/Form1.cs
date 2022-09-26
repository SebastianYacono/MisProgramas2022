using System;
using System.Windows.Forms;

namespace Manana
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            TB_anio.Focus();
        }




        public void BT_cargarAnio_Click(object sender, EventArgs e)
        {
            int anio = System.Convert.ToInt32(TB_anio.Text);

            //FILTRO PARA AÑO
            if (anio > 0)
            {
                TB_mes.Enabled = true;
                BT_cargarMes.Enabled = true;
                TB_anio.Enabled = false;
                BT_cargarAnio.Enabled = false;
                TB_mes.Focus();
            }
            else
            {
                MessageBox.Show("Los años antes de Cristo no cuentan. El valor debe ser mayor a 1.", "ERROR");
                TB_anio.Focus();
            }


        }

        public void BT_cargarMes_Click(object sender, EventArgs e)
        {
            int mes = System.Convert.ToInt32(TB_mes.Text);

            //FILTRO PARA MESES
            if (mes > 0 & mes < 13)
            {
                TB_dia.Enabled = true;
                BT_cargarDia.Enabled = true;
                TB_mes.Enabled = false;
                BT_cargarMes.Enabled = false;
            }
            else
            {
                MessageBox.Show("El año tiene 12 meses. Los valores introducidos deben estar entre el 1 y el 12", "ERROR");
                TB_mes.Focus();
            }

        }

        public void BT_cargarDia_Click(object sender, EventArgs e)
        {
            int dia = System.Convert.ToInt32(TB_dia.Text);
            int mes = System.Convert.ToInt32(TB_mes.Text);
            int anio = System.Convert.ToInt32(TB_anio.Text);

            //FILTRO PARA MESES DE 31 DIAS
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                if (dia > 0 & dia < 32)
                {
                    TB_dia.Enabled = false;
                    BT_cargarDia.Enabled = false;
                    Bt_fecha.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Este mes tiene entre 1 y 31 días.", "ERROR");
                    TB_dia.Focus();
                }
            }

            //FILTRO PARA MESES DE 30 DIAS
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                if (dia > 0 & dia < 31)
                {
                    TB_dia.Enabled = false;
                    BT_cargarDia.Enabled = false;
                    Bt_fecha.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Este mes tiene entre 1 y 30 días.", "ERROR");
                    TB_dia.Focus();
                }
            }

            //FILTRO PARA FEBRERO CON AÑO BISIESTO
            if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
            {
                if (mes == 2)
                {
                    if (dia > 0 & dia < 30)
                    {
                        TB_dia.Enabled = false;
                        BT_cargarDia.Enabled = false;
                        Bt_fecha.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Este año es bisiesto y tiene entre 1 y 29 días.", "ERROR");
                        TB_dia.Focus();
                    }
                }
            }
            else
            {
                if (mes == 2)
                {
                    if (dia > 0 & dia < 29)
                    {
                        TB_dia.Enabled = false;
                        BT_cargarDia.Enabled = false;
                        Bt_fecha.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Este año no es bisiesto y tiene entre 1 y 28 días.", "ERROR");
                        TB_dia.Focus();
                    }
                }
            }

        }

        public void Bt_fecha_Click(object sender, EventArgs e)
        {
            int dia = System.Convert.ToInt32(TB_dia.Text);
            int mes = System.Convert.ToInt32(TB_mes.Text);
            int anio = System.Convert.ToInt32(TB_anio.Text);
            int diaMas;
            int mesMas;
            int anioMas;
            string mesText = System.Convert.ToString(mes);

            //INSTRUCCIONES PARA COMBINACION DIA-MES
            if (((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia == 30) || dia == 31 || (mes == 2 && (dia == 29 || dia == 28 && (anio % 4 != 0 || anio % 100 == 0 || anio % 100 == 0))))
            {
                diaMas = 1;
                mesMas = mes + 1;
            }
            else
            {
                diaMas = dia + 1;
                mesMas = mes;
            }

            //INSTRUCCIONES PARA COMBINACION MES-AÑO
            if (mesMas == 13)
            {
                anioMas = anio + 1;
                mesMas = 1;
            }
            else
            {
                anioMas = anio;
            }

            //CONVERTIDOR DE MESES NUMERICOS A LETRAS
            if (mesMas == 1) { mesText = "enero"; }
            else if (mesMas == 2) { mesText = "febrero"; }
            else if (mesMas == 3) { mesText = "marzo"; }
            else if (mesMas == 4) { mesText = "abril"; }
            else if (mesMas == 5) { mesText = "mayo"; }
            else if (mesMas == 6) { mesText = "junio"; }
            else if (mesMas == 7) { mesText = "julio"; }
            else if (mesMas == 8) { mesText = "agosto"; }
            else if (mesMas == 9) { mesText = "setiembre"; }
            else if (mesMas == 10) { mesText = "octubre"; }
            else if (mesMas == 11) { mesText = "noviembre"; }
            else if (mesMas == 12) { mesText = "diciembre"; }

            //ESCRIBIR RESULTADO
            lbl_resultado.Text = "El día siguiente es: " + "\r\n" + "\r\n" + Convert.ToString(diaMas) + " de " + mesText + " de " + Convert.ToString(anioMas);
            Bt_fecha.Enabled = false;
        }

        private void BT_reset_Click(object sender, EventArgs e)
        {
            TB_anio.Text = "0";
            TB_mes.Text = "0";
            TB_dia.Text = "0";
            lbl_resultado.Text = "";
            TB_anio.Enabled = true;
            TB_mes.Enabled = false;
            TB_dia.Enabled = false;
            BT_cargarAnio.Enabled = true;
            BT_cargarMes.Enabled = false;
            BT_cargarDia.Enabled = false;
            Bt_fecha.Enabled = false;
            TB_anio.Focus();
        }


    }
}
