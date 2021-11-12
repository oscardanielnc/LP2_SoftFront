using LP2Soft.Cursos.Ciclo7.LP2;
using LP2Soft.CursosWS;
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
    public partial class tarjCursoxNivel : Form
    {
        private int _idCurso;
        private CursosWS.CursosWSClient _daoCurso;
        private CursosWS.curso _cursoVer;
        public tarjCursoxNivel(CursosWS.curso u)
        {
            _daoCurso = new CursosWS.CursosWSClient();
            InitializeComponent();
            _idCurso = u.idCurso;
            btnCursoxNivel.Text = u.nombre;
        }

        private void btnCursoxNivel_Click(object sender, EventArgs e)
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
