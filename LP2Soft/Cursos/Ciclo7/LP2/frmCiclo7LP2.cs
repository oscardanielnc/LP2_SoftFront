using LP2Soft.Cursos.Ciclo7.LP2.Practicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Cursos.Ciclo7.LP2
{
    public partial class frmCiclo7LP2 : Form
    {
        public frmCiclo7LP2()
        {
            InitializeComponent();
        }

        private void btnLP2Ciclo7_Click(object sender, EventArgs e)
        {
            frmCiclo7 ciclo7 = new frmCiclo7();
            ciclo7.ShowDialog();
            this.Close();
        }

        private void btnLP2Material_Click(object sender, EventArgs e)
        {
            frmCursosHome cursosHome = new frmCursosHome();
            cursosHome.ShowDialog();
        }

        private void btnLP2DescargarPcs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void btnLP2CompartirPcs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        private void btnLP2Practicas_Click(object sender, EventArgs e)
        {
            frmPracticas practicas = new frmPracticas();
            practicas.ShowDialog();
        }

        private void pBLP2DescargarLabs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2DescargarPcs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2DescargarParciales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2DescargarFinales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2DescargarLibros_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2DescargasExtras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void btnLike1_Click(object sender, EventArgs e)
        {
            if (btnLike1.ForeColor == Color.Black)
                btnLike1.ForeColor = Color.Blue;
            else {
                btnLike1.ForeColor = Color.Black;
            }
        }
    }
}
