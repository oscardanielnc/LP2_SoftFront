using LP2Soft.Cursos.Ciclo7.LP2.Practicas.Practica2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Cursos.Ciclo7.LP2.Practicas
{
    public partial class frmPracticas : Form
    {
        public frmPracticas()
        {
            InitializeComponent();
        }

        private void btnPracticasMaterial_Click(object sender, EventArgs e)
        {
            frmCursosHome cursosHome = new frmCursosHome();
            cursosHome.ShowDialog();
        }

        private void btnPracticasCiclo7_Click(object sender, EventArgs e)
        {
            frmCiclo7 ciclo7 = new frmCiclo7();
            ciclo7.ShowDialog();
        }

        private void btnPracticasLP2_Click(object sender, EventArgs e)
        {
            frmCiclo7LP2 ciclo7LP2 = new frmCiclo7LP2();
            ciclo7LP2.ShowDialog();
        }

        private void btnLP2Practicas2_Click(object sender, EventArgs e)
        {
            frmPractica2 practica2 = new frmPractica2();
            practica2.ShowDialog();
        }
    }
}
