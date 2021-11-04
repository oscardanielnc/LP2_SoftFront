using LP2Soft.Cursos.AgregarMaterial;
using LP2Soft.Cursos.Calificación;
using LP2Soft.Cursos.Flitro;
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
            addPanel(cursosHome);
        }

        private void btnLP2Practica2Ciclo7_Click(object sender, EventArgs e)
        {
            frmCiclo7 ciclo7 = new frmCiclo7();
            addPanel(ciclo7);
        }

        private void btnLP2Practica2LP2_Click(object sender, EventArgs e)
        {
            frmCiclo7LP2 ciclo7LP2 = new frmCiclo7LP2();
            addPanel(ciclo7LP2);
        }

        private void btnLLP2Practica2Practicas_Click(object sender, EventArgs e)
        {
            frmPracticas practicas = new frmPracticas();
            addPanel(practicas);
        }

        private void btnLLP2Practica2AgregarMaterial_Click(object sender, EventArgs e)
        {
            frmAgregarMaterial agregarMaterial = new frmAgregarMaterial();
            agregarMaterial.ShowDialog();
        }

        private void btnestrella1_Click(object sender, EventArgs e)
        {
            frmCalificacion calificacion = new frmCalificacion();
            calificacion.ShowDialog();
        }

        private void pBLP2Practica4Compartir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        private void pBLP2Practica4Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2Practica3Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2Practica2Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2Practica1Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2Practica3Compartir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        private void pBLP2Practica2Compartir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        private void pBLP2Practica1Compartir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        private void btnLLP2Practica2Filtrar_Click(object sender, EventArgs e)
        {
            frmFiltro filtro = new frmFiltro();
            filtro.Show();
        }

        private void pBFiltro_Click(object sender, EventArgs e)
        {
            frmFiltro filtro = new frmFiltro();
            filtro.Show();
        }
        public void addPanel(Form f)
        {
            while (this.panel4.Controls.Count > 0)
            {
                this.panel4.Controls.RemoveAt(0);
            }
            f.TopLevel = false;
            this.panel4.Controls.Add(f);
            f.Show();
        }
    }
}
