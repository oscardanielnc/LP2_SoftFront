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
        public frmBuscarAsesor()
        {
            InitializeComponent();
        }

        private void lblFiltros_Click(object sender, EventArgs e)
        {
            frmAsesorBuscarFiltros formFiltros = new frmAsesorBuscarFiltros();
            formFiltros.ShowDialog();
        }

        private void btnPostular_Click(object sender, EventArgs e)
        {
            frmAsesorPostular formPostular = new frmAsesorPostular();
            formPostular.ShowDialog();
        }
    }
}
