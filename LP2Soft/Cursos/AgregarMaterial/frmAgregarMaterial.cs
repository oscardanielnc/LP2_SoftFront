using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Cursos.AgregarMaterial
{
    public partial class frmAgregarMaterial : Form
    {
        private CursosWS.CursosWSClient _daoCurso;
        private CursosWS.profesor[] _listaProfesor_Curso;
        private CursosWS.curso _cursoAux;
        private PublicacionesWS.material _material;

        public frmAgregarMaterial()
        {
            InitializeComponent();            
        }
        public frmAgregarMaterial(CursosWS.curso _cursoVer)
        {
            _cursoAux = _cursoVer;
            _daoCurso = new CursosWS.CursosWSClient();
            
            if (_listaProfesor_Curso == null)
                _listaProfesor_Curso = _daoCurso.listarProfesorXCurso(1);
            InitializeComponent();
            
            cboProfesores.DataSource = _listaProfesor_Curso;
            cboProfesores.DisplayMember = "nombre";
            cboProfesores.ValueMember = "idProfesor";
            cboProfesores.SelectedItem = -1;
            txtNota.Enabled = false;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Subio satisfactoriamente");
            _material.nombreArchivo = cboSemestre + "-" + cboCiclo;
            _material.profesor.nombre = (string)cboProfesores.SelectedItem;
            _material.contenido = txtComentario.Text;
            _material.sumatoriaCalificaiones = 0;
            _material.cantidadCalificaiones = 0;
            
            this.Close();          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //frmEstasSeguroDeCancelar estasSeguroDeCancelar = new frmEstasSeguroDeCancelar();
            //if(estasSeguroDeCancelar.ShowDialog()==DialogResult.OK)
            this.Close();    
        }

        private void btbCargarDocs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuadrito para seleccionar y subir");
        }

        private void checkbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbSi.Checked == true)
            {
                checkBNo.Checked = false;
                txtNota.Enabled = true;
            }
            
        }

        private void checkBNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBNo.Checked == true)
            {
                checkbSi.Checked = false;
                txtNota.Enabled = false;
            }
            
        }

        
    }
}
