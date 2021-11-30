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
            _rutaArchivoPDF = null;
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

            _material.profesor = new PublicacionesWS.profesor();
            _material.curso = new PublicacionesWS.curso();
            CursosWS.profesor profesorAux = new CursosWS.profesor();
            PublicacionesWS.curso cursoAux = new PublicacionesWS.curso();
            profesorAux = (CursosWS.profesor)cboProfesores.SelectedItem;
            _material.profesor.idProfesor = profesorAux.idProfesor;
            _material.profesor.nombre = profesorAux.nombre;
            cursoAux.idCurso = _idCurso;

            _material.idCurso = _idCurso;
            _material.curso = cursoAux;
            _material.tipoMaterial = _tipo + 1;
            _material.indice_tipoMaterial = _indice;
            if (cboSemestre.Text == "") {
                MessageBox.Show("Agregar un semestre");
            }else if (cboSemestre.Text == "")
            {
                MessageBox.Show("Agregar un ciclo");
            }

            if (lblPDF.Text == "Adjunte su PDF aquí -->               ") {
                MessageBox.Show("Agregar un archivo PDF");
            }
            
            //post

            _material.contenido = txtComentario.Text;
            _material.usuario = new PublicacionesWS.usuario();
            _material.usuario.idUsuario = frmHome.Usuario.idUsuario;
            _material.usuario.nombre = frmHome.Usuario.nombre;
            _material.usuario.apellido = frmHome.Usuario.apellido;

            if (checkBNo.Checked == true)
                _material.nota = "-";
            else if (txtNota.Text == "")
            {
                MessageBox.Show("Agregar una Nota");
            }
            else if (20 < Int32.Parse(txtNota.Text) || 0 > Int32.Parse(txtNota.Text))
                MessageBox.Show("Agregar una Nota entre 0 y 20");
            else
            {
                _material.nombreArchivo = cboSemestre.Text + "-" + cboCiclo.Text;
                _material.nota = txtNota.Text;
                int resultado = _daoMaterial.insertar_Material(_material);
                MessageBox.Show("Se Subio satisfactoriamente");
                this.Close();
            }
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
                    lblPDF.Text = _rutaArchivoPDF;
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

        private void botonChevere1_Click(object sender, EventArgs e)
        {
            _material.profesor = new PublicacionesWS.profesor();
            _material.curso = new PublicacionesWS.curso();
            CursosWS.profesor profesorAux = new CursosWS.profesor();
            PublicacionesWS.curso cursoAux = new PublicacionesWS.curso();
            profesorAux = (CursosWS.profesor)cboProfesores.SelectedItem;
            _material.profesor.idProfesor = profesorAux.idProfesor;
            _material.profesor.nombre = profesorAux.nombre;
            cursoAux.idCurso = _idCurso;

            _material.idCurso = _idCurso;
            _material.curso = cursoAux;
            _material.tipoMaterial = _tipo + 1;
            _material.indice_tipoMaterial = _indice;
            if (cboSemestre.Text == "")
            {
                MessageBox.Show("Agregar un semestre");
            }
            else if (cboSemestre.Text == "")
            {
                MessageBox.Show("Agregar un ciclo");
            }

            if (lblPDF.Text == "Adjunte su PDF aquí -->               ")
            {
                MessageBox.Show("Agregar un archivo PDF");
            }

            //post

            _material.contenido = txtComentario.Text;
            _material.usuario = new PublicacionesWS.usuario();
            _material.usuario.idUsuario = frmHome.Usuario.idUsuario;
            _material.usuario.nombre = frmHome.Usuario.nombre;
            _material.usuario.apellido = frmHome.Usuario.apellido;

            if (checkBNo.Checked == true)
                _material.nota = "-";
            else if (txtNota.Text == "")
            {
                MessageBox.Show("Agregar una Nota");
            }
            else if (20 < Int32.Parse(txtNota.Text) || 0 > Int32.Parse(txtNota.Text))
                MessageBox.Show("Agregar una Nota entre 0 y 20");
            else
            {
                _material.nombreArchivo = cboSemestre.Text + "-" + cboCiclo.Text;
                _material.nota = txtNota.Text;
                int resultado = _daoMaterial.insertar_Material(_material);
                MessageBox.Show("Se Subio satisfactoriamente");
                this.Close();
            }
        }

        private void btnRCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
