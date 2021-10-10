using LP2Soft.Perfil;
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
    public partial class frmAsesor : Form
    {
        public frmAsesor()
        {
            InitializeComponent();
        }

        private void btnVerPerfil1_Click(object sender, EventArgs e)
        {
            frmPerfil formPerfil = new frmPerfil();
            formPerfil.ShowDialog();
        }
    }
}
