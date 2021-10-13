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
        private Panel _panelPadre;
        public frmAsesorPostular()
        {
            InitializeComponent();
        }
        public frmAsesorPostular(Panel panel)
        {
            InitializeComponent();
            _panelPadre = panel;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _panelPadre.Controls.Clear();
            frmBuscarAsesor frmAsesor = new frmBuscarAsesor(_panelPadre);
            frmAsesor.TopLevel = false;
            _panelPadre.Controls.Add(frmAsesor);
            frmAsesor.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _panelPadre.Controls.Clear();
            frmBuscarAsesor frmAsesor = new frmBuscarAsesor(_panelPadre);
            frmAsesor.TopLevel = false;
            _panelPadre.Controls.Add(frmAsesor);
            frmAsesor.Show();
        }
    }
}
