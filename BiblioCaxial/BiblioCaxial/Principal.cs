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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void SalirApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
