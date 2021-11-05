using LP2Soft.Cursos.Ciclo7.LP2.Practicas;
using LP2Soft.Home;
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
    public partial class frmCursos_VerCurso : Form
    {
        private CursosWS.CursosWSClient _daoCurso;
        private CursosWS.curso _cursoVer;
        int _idUsuario;
        public frmCursos_VerCurso()
        {
            InitializeComponent();
        }
        public frmCursos_VerCurso(CursosWS.curso _cursoVer)
        {
            _daoCurso = new CursosWS.CursosWSClient();
            InitializeComponent();
            lblLP2NombreCurso.Text = _cursoVer.nombre;
            btnLP2LP2.Text = _cursoVer.nombre;
            btnLP2Ciclo7.Text = "Ciclo : " + _cursoVer.nivel.ToString();
            lblLP2Descripcion.Text = "Código     : " + _cursoVer.codigo +
                                     "\nCréditos   : " + _cursoVer.creditos +
                                     "\nCarrera    : " + _cursoVer.especialidad +
                                     "\nDescripción: " + _cursoVer.descripcion +
                                     "\nCréditos Requeridos: " + _cursoVer.creditosRequeridos +
                                     "\nCursos Requisitos : ";
            if (_cursoVer.cursosRequeridos != null)
            {
                foreach (CursosWS.curso c in _cursoVer.cursosRequeridos)
                {
                    LinkLabel lblNombreCursoReq = new LinkLabel();
                    lblNombreCursoReq.Text = c.nombre;
                    lblNombreCursoReq.Dock = DockStyle.Top;
                    panelCursosrequeridos.Controls.Add(lblNombreCursoReq);
                    lblNombreCursoReq.Click += new System.EventHandler((object sender, EventArgs e) => this.verCurso( sender, e, c.idCurso));
                }
                lblLP2Descripcion.Text = lblLP2Descripcion.Text.TrimEnd(',');
            }

        }
        private void verCurso(object sender, EventArgs e, int idCurso)
        {
            
            _cursoVer = _daoCurso.MostrarCurso(idCurso);
            if (_cursoVer != null)
            {
                frmHome.abrirFormulario(new frmCursos_VerCurso(_cursoVer));
            }
        }
        private void btnLP2Ciclo7_Click(object sender, EventArgs e)
        {
            frmCursos_Ciclo ciclo7 = new frmCursos_Ciclo();
            //ciclo7.ShowDialog();
            //this.Close();
            addPanel(ciclo7);
        }
        
        private void btnLP2Material_Click(object sender, EventArgs e)
        {
            frmCursos_Home cursosHome = new frmCursos_Home(20186013);
            addPanel(cursosHome);
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
            frmCursos_Practicas practicas = new frmCursos_Practicas();
            addPanel(practicas);
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
