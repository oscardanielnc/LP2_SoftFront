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
    public partial class frmBuscarAsesor : Form
    {
        private frmHome _formHome;
        public frmBuscarAsesor()
        {
            InitializeComponent();
        }
        public frmBuscarAsesor(frmHome formHome)
        {
            InitializeComponent();
            _formHome = formHome;
        }

        private void lblFiltros_Click(object sender, EventArgs e)
        {
            frmAsesorBuscarFiltros formFiltros = new frmAsesorBuscarFiltros();
            formFiltros.ShowDialog();
        }

        private void btnPostular_Click(object sender, EventArgs e)
        {
            _formHome.abrirFormulario(new frmAsesorPostular(_formHome));
        }
    }
}
