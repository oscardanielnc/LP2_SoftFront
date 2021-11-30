using LP2Soft.Cursos.Ciclo7.LP2.Practicas.Practica2;
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

namespace LP2Soft.Cursos.Ciclo7.LP2.Practicas
{
    public partial class frmCursos_Practicas : Form
    {
        private String[] tipoMaterial = new String[] { "Práctica", "Laboratorio", "Tarea Académica", "Exámenes" };
        private CursosWS.curso _cursoAux;
        public frmCursos_Practicas()
        {
            InitializeComponent();
        }

        public frmCursos_Practicas(CursosWS.curso _cursoVer, int tipo)
        {
            InitializeComponent();
            lblNombreCodigo.Text = _cursoVer.nombre + " (" + _cursoVer.codigo + ")";
            _cursoAux = _cursoVer;
            desplegar_numero_Evaluaciones(_cursoVer, tipo);
            btnRCiclo.Text = "Ciclo " + _cursoVer.nivel;
            botonChevere1.Text = _cursoVer.nombre;
            btnPractica.Text = tipoMaterial[tipo];
        }

        private void desplegar_numero_Evaluaciones(CursosWS.curso _cursoVer, int tipo)
        {
            if (tipo == 0)
            {
                for (int i = 0; i < _cursoVer.cantPc; i++)
                {
                    tarjTipoMaterialIndice tTipoMaterialIndice = new tarjTipoMaterialIndice(tipo, _cursoVer, i+1);
                    tTipoMaterialIndice.TopLevel = false;
                    tTipoMaterialIndice.Location = generarCoordenadas(i);
                    panelLP2Practicas.Controls.Add(tTipoMaterialIndice);
                    panelLP2Practicas.Controls.SetChildIndex(tTipoMaterialIndice, 0);
                    tTipoMaterialIndice.Visible = true;
                    
                }
            }
            else if (tipo == 1)
            {
                for (int i = 0; i < _cursoVer.cantLab; i++)
                {
                    tarjTipoMaterialIndice tTipoMaterialIndice = new tarjTipoMaterialIndice(tipo, _cursoVer, i + 1);
                    tTipoMaterialIndice.TopLevel = false;
                    tTipoMaterialIndice.Location = generarCoordenadas(i);
                    panelLP2Practicas.Controls.Add(tTipoMaterialIndice);
                    panelLP2Practicas.Controls.SetChildIndex(tTipoMaterialIndice, 0);
                    tTipoMaterialIndice.Visible = true;
                    
                }
            }
            else if (tipo == 2)
            {
                for (int i = 0; i < _cursoVer.cantTA; i++)
                {
                    tarjTipoMaterialIndice tTipoMaterialIndice = new tarjTipoMaterialIndice(tipo, _cursoVer, i + 1);
                    tTipoMaterialIndice.TopLevel = false;
                    tTipoMaterialIndice.Location = generarCoordenadas(i);
                    panelLP2Practicas.Controls.Add(tTipoMaterialIndice);
                    panelLP2Practicas.Controls.SetChildIndex(tTipoMaterialIndice, 0);
                    tTipoMaterialIndice.Visible = true;
                    
                }
            }
            else if (tipo == 3)
            {
                for (int i = 0; i < _cursoVer.cantEx; i++)
                {
                    tarjTipoMaterialIndice tTipoMaterialIndice = new tarjTipoMaterialIndice(tipo, _cursoVer, i + 1);
                    tTipoMaterialIndice.TopLevel = false;
                    tTipoMaterialIndice.Location = generarCoordenadas(i);
                    panelLP2Practicas.Controls.Add(tTipoMaterialIndice);
                    panelLP2Practicas.Controls.SetChildIndex(tTipoMaterialIndice, 0);
                    tTipoMaterialIndice.Visible = true;
                    
                }
            }
        }
        private Point generarCoordenadas(int i)
        {
            int x = 0;
            int y = (i) * 34;
            return new Point(x, y);
        }

        private void btnPracticasMaterial_Click(object sender, EventArgs e)
        {
            frmCursos_Home cursosHome = new frmCursos_Home(20186013);
            addPanel(cursosHome);
        }

        private void btnPracticasCiclo7_Click(object sender, EventArgs e)
        {
            frmCursos_Ciclo ciclo7 = new frmCursos_Ciclo(_cursoAux.nivel);
            addPanel(ciclo7);
        }

        private void btnPracticasLP2_Click(object sender, EventArgs e)
        {
            frmCursos_VerCurso ciclo7LP2 = new frmCursos_VerCurso(_cursoAux);
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

        private void btnRMaterial_Click(object sender, EventArgs e)
        {
            frmCursos_Home cursosHome = new frmCursos_Home(20186013);
            addPanel(cursosHome);
        }

        private void btnRCiclo_Click(object sender, EventArgs e)
        {
            frmCursos_Ciclo ciclo7 = new frmCursos_Ciclo(_cursoAux.nivel);
            addPanel(ciclo7);
        }

        private void botonChevere1_Click(object sender, EventArgs e)
        {
            frmCursos_VerCurso ciclo7LP2 = new frmCursos_VerCurso(_cursoAux);
            addPanel(ciclo7LP2);
        }

        private void btnPractica_Click(object sender, EventArgs e)
        {

        }
    }
}
