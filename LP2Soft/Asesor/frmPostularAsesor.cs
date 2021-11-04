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
        private CursosWS.CursosWSClient _daoCurso;
        private BindingList<CursosWS.curso> _cursos;
        public frmPostularAsesor()
        {
            InitializeComponent();
            _daoCurso = new CursosWS.CursosWSClient();
            _cursos = new BindingList<CursosWS.curso>(_daoCurso.listarCursos(frmHome.Usuario.idUsuario));
            cboCurso.DataSource = _cursos;
            cboCurso.DisplayMember = "nombre";
            cboCurso.ValueMember = "idCurso"; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
