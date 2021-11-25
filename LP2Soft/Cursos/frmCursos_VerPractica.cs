using LP2Soft.Cursos.AgregarMaterial;
using LP2Soft.Cursos.Calificación;
using LP2Soft.Cursos.Flitro;
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

namespace LP2Soft.Cursos.Ciclo7.LP2.Practicas.Practica2
{
    public partial class frmCursos_VerPractica : Form
    {
        private CursosWS.curso _cursoVer;
        private int _tipo;
        private int _indice;
        private String[] tipoMaterial = new String[] { "Práctica", "Laboratorio", "Tarea Academica", "Exámenes" };
        private PublicacionesWS.PublicacionesWSClient _daoMaterial;
        private PublicacionesWS.material[] _lMaterial;
        public frmCursos_VerPractica()
        {
            InitializeComponent();
        }


        public frmCursos_VerPractica(CursosWS.curso curso, int auxTipo, int indice)
        {
            InitializeComponent();
            _daoMaterial = new PublicacionesWS.PublicacionesWSClient();
            _cursoVer = curso;
            _tipo = auxTipo;
            _indice = indice;
            btnLP2Practica2Ciclo7.Text = "Ciclo " + curso.nivel;
            btnLP2Practica2LP2.Text = curso.nombre;
            btnLLP2Practica2Practicas.Text = tipoMaterial[auxTipo];
            btnLLP2Practica2Practica2.Text = tipoMaterial[auxTipo] + " " + indice;
            todoMaterial();
        }

        public void todoMaterial()
        {

             
            _lMaterial = _daoMaterial.listar_material_tipo_indice(_cursoVer.idCurso, _tipo+1, _indice);
            int i = 0;
            if (_lMaterial != null)
            {
                foreach (PublicacionesWS.material u in _lMaterial)
                {
                    tarjMaterial tMaterial = new tarjMaterial(u);
                    tMaterial.TopLevel = false;
                    tMaterial.Location = generarCoordenadas(i);
                    panelLP2Practicas.Controls.Add(tMaterial);
                    panelLP2Practicas.Controls.SetChildIndex(tMaterial, 0);
                    tMaterial.Visible = true;
                    i++;
                }
            }
        }


        private Point generarCoordenadas(int i)
        {
            int x = 0;
            int y = i * 40;
            return new Point(x, y);
        }

        private void btnLP2Practica2Material_Click(object sender, EventArgs e)
        {
            frmCursos_Home cursosHome = new frmCursos_Home(20186013);
            addPanel(cursosHome);
        }

        private void btnLP2Practica2Ciclo7_Click(object sender, EventArgs e)
        {
            frmCursos_Ciclo ciclo7 = new frmCursos_Ciclo(_cursoVer.nivel);
            addPanel(ciclo7);
        }

        private void btnLP2Practica2LP2_Click(object sender, EventArgs e)
        {
            frmCursos_VerCurso ciclo7LP2 = new frmCursos_VerCurso(_cursoVer);
            addPanel(ciclo7LP2);
        }

        private void btnLLP2Practica2Practicas_Click(object sender, EventArgs e)
        {
            frmCursos_Practicas practicas = new frmCursos_Practicas(_cursoVer, _tipo);
            addPanel(practicas);
        }

        private void btnLLP2Practica2AgregarMaterial_Click(object sender, EventArgs e)
        {
            frmAgregarMaterial agregarMaterial = new frmAgregarMaterial(_cursoVer, _tipo, _indice);
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
            frmCursos_Filtro filtro = new frmCursos_Filtro();
            filtro.Show();
        }

        private void pBFiltro_Click(object sender, EventArgs e)
        {
            frmCursos_Filtro filtro = new frmCursos_Filtro();
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
