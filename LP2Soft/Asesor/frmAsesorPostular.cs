using LP2Soft.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Asesor
{
    public partial class frmAsesorPostular : Form
    {
        private frmHome _formHome;
        public frmAsesorPostular()
        {
            InitializeComponent();
        }
        public frmAsesorPostular(frmHome formHome)
        {
            InitializeComponent();
            _formHome = formHome;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _formHome.abrirFormulario(new frmBuscarAsesor());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _formHome.abrirFormulario(new frmBuscarAsesor());
        }
    }
}
