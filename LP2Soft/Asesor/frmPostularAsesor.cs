using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2Soft.Home;

namespace LP2Soft.Asesor
{
    public partial class frmPostularAsesor : Form
    {
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private UsuarioWS.asesor _asesor;
        // private CursosWS.CursosWSClient _daoCurso;
        public frmPostularAsesor()
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();
            if (frmHome.Usuario.cursos == null)
                frmHome.Usuario.cursos = _daoUsuario.listarCursos(frmHome.Usuario.idUsuario);
            cboCursos.DataSource = frmHome.Usuario.cursos;
            cboCursos.DisplayMember = "nombre";
            cboCursos.ValueMember = "idCurso";
            cboCursos.Texts = "Elegir curso";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            frmHome.Usuario.esAsesor = true;
            _asesor = new UsuarioWS.asesor();
            _asesor.precioPorHora = float.Parse(textBoxPrecio.Text);
            frmHome.Usuario.asesor = _asesor;
            CursosWS.curso _curso = cboCursos.SelectedItem as CursosWS.curso;
            _daoUsuario.insertarAsesor(_asesor, frmHome.Usuario.idUsuario, _curso.idCurso);
            this.Close();
        }

        private void cboCursos_Enter(object sender, EventArgs e)
        {
            if (cboCursos.Text == "Elegir curso")
            {
                cboCursos.Text = "";
                cboCursos.ForeColor = Color.Black;
            }
        }

        private void cboCursos_Leave(object sender, EventArgs e)
        {
            if (cboCursos.Text == "")
            {
                cboCursos.Text = "Elegir curso";
                cboCursos.ForeColor = Color.Gray;
            }
        }
    }
}