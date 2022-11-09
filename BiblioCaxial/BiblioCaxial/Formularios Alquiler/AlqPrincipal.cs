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
    public partial class AlqPrincipal : Form
    {
        public AlqPrincipal()
        {
            InitializeComponent();
        }

        private void btn_AlqClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AlqAdd_Click(object sender, EventArgs e)
        {
            AlqNvo alqNvo = new AlqNvo();
            alqNvo.ShowDialog();
        }
    }
}
