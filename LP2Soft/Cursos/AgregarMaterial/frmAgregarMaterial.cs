using LP2Soft.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private PublicacionesWS.PublicacionesWSClient _daoMaterial;
        private PublicacionesWS.material _material;
        private int _tipo;
        private int _indice;
        private int _idCurso;
        private string _rutaArchivoPDF = "";
        public frmAgregarMaterial()
        {
            InitializeComponent();            
        }
        public frmAgregarMaterial(CursosWS.curso _cursoVer, int auxTipo, int auxIndice)
        {
            _cursoAux = _cursoVer;
            _tipo = auxTipo;
            _indice = auxIndice;
            _idCurso = _cursoAux.idCurso;
            _daoMaterial = new PublicacionesWS.PublicacionesWSClient();
            _daoCurso = new CursosWS.CursosWSClient();
            _material = new PublicacionesWS.material();

            if (_listaProfesor_Curso == null)
                _listaProfesor_Curso = _daoCurso.listarProfesorXCurso(_cursoAux.idCurso);
            InitializeComponent();
            Console.WriteLine(_cursoAux.idCurso);
            cboProfesores.DataSource = _listaProfesor_Curso;
            cboProfesores.DisplayMember = "nombre";
            cboProfesores.ValueMember = "idProfesor";
            //cboProfesores.SelectedItem = -1;
            txtNota.Enabled = false;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Subio satisfactoriamente");
            _material.nombreArchivo = cboSemestre + "-" + cboCiclo;
            _material.profesor = new PublicacionesWS.profesor();
            _material.curso = new PublicacionesWS.curso();
            CursosWS.profesor profesorAux = new CursosWS.profesor();

            profesorAux = (CursosWS.profesor)cboProfesores.SelectedItem;
            _material.profesor.idProfesor = profesorAux.idProfesor;
            _material.curso.idCurso = _idCurso;
            _material.contenido = txtComentario.Text;
            _material.sumatoriaCalificaiones = 0;
            _material.cantidadCalificaiones = 0;
            _material.tipoMaterial = _tipo;
            _material.indice_tipoMaterial = _indice;
            //post
            _material.contenido = txtComentario.Text;
            _material.prioridad = 1;
            _material.usuario = new PublicacionesWS.usuario();
            _material.usuario.idUsuario = frmHome.Usuario.idUsuario;
            ///int resultado = _daoMaterial.insertar_Material(_material);
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
            try
            {
                if (ofdArchivo.ShowDialog() == DialogResult.OK)
                {
                    _rutaArchivoPDF = ofdArchivo.FileName;
                    lblTituloPanel.Text = _rutaArchivoPDF;
                    FileStream fs = new FileStream(_rutaArchivoPDF, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    //Asignamos el archivo al objeto
                    _material.archivo = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al seleccionar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
