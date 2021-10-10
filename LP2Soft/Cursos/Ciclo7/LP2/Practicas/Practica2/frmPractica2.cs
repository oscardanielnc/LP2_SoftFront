using LP2Soft.Cursos.AgregarMaterial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Cursos.Ciclo7.LP2.Practicas.Practica2
{
    public partial class frmPractica2 : Form
    {
        public frmPractica2()
        {
            InitializeComponent();
        }

        private void btnLP2Practica2Material_Click(object sender, EventArgs e)
        {
            frmCursosHome cursosHome = new frmCursosHome();
            cursosHome.ShowDialog();
        }

        private void btnLP2Practica2Ciclo7_Click(object sender, EventArgs e)
        {
            frmCiclo7 ciclo7 = new frmCiclo7();
            ciclo7.ShowDialog();
        }

        private void btnLP2Practica2LP2_Click(object sender, EventArgs e)
        {
            frmCiclo7LP2 ciclo7LP2 = new frmCiclo7LP2();
            ciclo7LP2.ShowDialog();
        }

        private void btnLLP2Practica2Practicas_Click(object sender, EventArgs e)
        {
            frmPracticas practicas = new frmPracticas();
            practicas.ShowDialog();
        }

        private void btnLLP2Practica2AgregarMaterial_Click(object sender, EventArgs e)
        {
            frmAgregarMaterial agregarMaterial = new frmAgregarMaterial();
            agregarMaterial.ShowDialog();
        }
    }
}
