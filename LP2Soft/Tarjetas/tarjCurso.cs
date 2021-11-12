using LP2Soft.Cursos;
using LP2Soft.Cursos.Ciclo7.LP2;
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

namespace LP2Soft.Tarjetas
{
    public partial class tarjCurso : Form
    {
        private int _idCurso;
        private CursosWS.CursosWSClient _daoCurso;
        private CursosWS.curso _cursoVer;
        public tarjCurso(UsuarioWS.curso curso)
        {
            _daoCurso = new CursosWS.CursosWSClient();
            InitializeComponent();
            _idCurso = curso.idCurso;
            posicionarLabel(curso);
        }
        public tarjCurso(UsuarioWS.curso curso, bool onlyRead)
        {
            _daoCurso = new CursosWS.CursosWSClient();
            InitializeComponent();
            _idCurso = curso.idCurso;
            posicionarLabel(curso);

            if(onlyRead)
            {
                pBLP3CorazonVacio.Visible = false; //
                pictureAgregarLP3.Visible = false;
                btnLP3.BackColor = Color.DarkGray;
            }
        }

        private void posicionarLabel(UsuarioWS.curso curso)
        {
            btnLP3.Text = curso.codigo + "\n\n\n" + curso.nombre + "\nCredito: " + curso.creditos;
        }

        private void btnLP3_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            _cursoVer = _daoCurso.MostrarCurso(_idCurso);
            if (_cursoVer != null)
            {
                frmHome.abrirFormulario(new frmCursos_VerCurso(_cursoVer));
            }
            frmPrincipal.endLoading();
        }

    }
}
