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
        int _idUsuario;
        public frmCiclo7LP2()
        {
            InitializeComponent();
        }
        public frmCiclo7LP2(CursosWS.curso _cursoVer)
        {
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
                foreach (CursosWS.curso u in _cursoVer.cursosRequeridos)
                {

                    lblLP2Descripcion.Text += u.nombre + " ,";

                }
                lblLP2Descripcion.Text = lblLP2Descripcion.Text.TrimEnd(',');
            }

        }
        private void btnLP2Ciclo7_Click(object sender, EventArgs e)
        {
            frmCiclo7 ciclo7 = new frmCiclo7();
            //ciclo7.ShowDialog();
            //this.Close();
            addPanel(ciclo7);
        }
        
        private void btnLP2Material_Click(object sender, EventArgs e)
        {
            frmCursosHome cursosHome = new frmCursosHome(20186013);
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
            frmPracticas practicas = new frmPracticas();
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
