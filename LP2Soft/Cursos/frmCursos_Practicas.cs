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
    public partial class frmCursos_Practicas : Form
    {
        public frmCursos_Practicas()
        {
            InitializeComponent();
        }

        private void btnPracticasMaterial_Click(object sender, EventArgs e)
        {
            frmCursos_Home cursosHome = new frmCursos_Home();
            addPanel(cursosHome);
        }

        private void btnPracticasCiclo7_Click(object sender, EventArgs e)
        {
            frmCursos_Ciclo ciclo7 = new frmCursos_Ciclo();
            addPanel(ciclo7);
        }

        private void btnPracticasLP2_Click(object sender, EventArgs e)
        {
            frmCursos_VerCurso ciclo7LP2 = new frmCursos_VerCurso();
            addPanel(ciclo7LP2);
        }

        private void btnLP2Practicas2_Click(object sender, EventArgs e)
        {
            frmCursos_VerPractica practica2 = new frmCursos_VerPractica();
            addPanel(practica2);
        }

        private void pBLP2Practica1Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2Practica2Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2Practica3Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2Practica4Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
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
