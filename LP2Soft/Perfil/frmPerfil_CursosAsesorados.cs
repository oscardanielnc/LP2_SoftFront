using LP2Soft.Asesor;
using LP2Soft.Cursos.Ciclo7.LP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Perfil
{
    public partial class frmPerfil_CursosAsesorados : Form
    {
        public frmPerfil_CursosAsesorados()
        {
            InitializeComponent();
        }

        private void btnAniadirCurso_Click(object sender, EventArgs e)
        {
            frmAsesorPostular fromPostular = new frmAsesorPostular();
            fromPostular.ShowDialog();
        }

        private void btnLP3_Click(object sender, EventArgs e)
        {
            frmCiclo7LP2 fromLP2 = new frmCiclo7LP2();
            fromLP2.ShowDialog();
        }
    }
}
