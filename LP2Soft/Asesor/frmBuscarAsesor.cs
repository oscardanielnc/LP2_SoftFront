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
        private Panel _panelPadre;
        public frmBuscarAsesor()
        {
            InitializeComponent();
        }
        public frmBuscarAsesor(Panel panel)
        {
            InitializeComponent();
            _panelPadre = panel;
        }

        private void lblFiltros_Click(object sender, EventArgs e)
        {
            frmAsesorBuscarFiltros formFiltros = new frmAsesorBuscarFiltros();
            formFiltros.ShowDialog();
        }

        private void btnPostular_Click(object sender, EventArgs e)
        {
            _panelPadre.Controls.Clear();
            frmAsesorPostular frmPostular = new frmAsesorPostular(_panelPadre);
            frmPostular.TopLevel = false;
            _panelPadre.Controls.Add(frmPostular);
            frmPostular.Show();
        }
    }
}
