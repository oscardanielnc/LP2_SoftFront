using LP2Soft.Cursos.Ciclo7.LP2;
using LP2Soft.Tarjetas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Cursos.Ciclo7
{
    public partial class frmCursos_Ciclo : Form
    {
        private CursosWS.CursosWSClient _daoCurso;
        private CursosWS.curso[] _cursoxNivel;
        public frmCursos_Ciclo()
        {
            InitializeComponent();
        }
        public frmCursos_Ciclo(int nivel)
        {
            InitializeComponent();
            _daoCurso = new CursosWS.CursosWSClient();
            btnCiclo7.Text = "Cliclo " + nivel;
            todosCursosxNivel(nivel);
        }

        private void todosCursosxNivel(int nivel)
        {
            _cursoxNivel = _daoCurso.listaXciclo(nivel);
            int i=0;
            foreach (CursosWS.curso u in _cursoxNivel)
            {
                tarjCursoxNivel tCurso = new tarjCursoxNivel(u);
                tCurso.TopLevel = false;
                tCurso.Location = generarCoordenadas(i);
                panelCiclo7.Controls.Add(tCurso);
                panelCiclo7.Controls.SetChildIndex(tCurso, 0);
                tCurso.Visible = true;
                i++;
            }
        }

        private Point generarCoordenadas(int i)
        {
            int x = 0;
            int y = (i) * 40;
            return new Point(x, y);
        }

        private void btnCiclo7LP2_Click(object sender, EventArgs e)
        {
            frmCursos_VerCurso ciclo7LP2 = new frmCursos_VerCurso();
            addPanel(ciclo7LP2);
        }

        private void btnCiclo7Material_Click(object sender, EventArgs e)
        {
            frmCursos_Home cursosHome = new frmCursos_Home(20186013);
            addPanel(cursosHome);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBCiclo7LP2Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBCiclo7Sis2Descargar_Click(object sender, EventArgs e)
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
