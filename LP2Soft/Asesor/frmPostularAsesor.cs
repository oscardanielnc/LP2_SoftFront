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
        private BindingList<UsuarioWS.curso> _cursosAsesorados;
        public frmPostularAsesor()
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();
            if (frmHome.Usuario.cursos == null)
                frmHome.Usuario.cursos = _daoUsuario.listarCursosPostular();
            cboCursos.DataSource = frmHome.Usuario.cursos;
            cboCursos.DisplayMember = "nombre";
            cboCursos.ValueMember = "idCurso";
            cboCursos.Texts = "Elegir curso";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int _flag;
            _flag = 0;
            UsuarioWS.curso _curso = cboCursos.SelectedItem as UsuarioWS.curso;
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            
            if (frmHome.Usuario.esAsesor == true)
            {
                _cursosAsesorados = null;
                _cursosAsesorados = new BindingList<UsuarioWS.curso>(_daoUsuario.listarCursosAsesorados(frmHome.Usuario.idUsuario));
                //renderizamos las tarjetas
                int i = 0;
                foreach (UsuarioWS.curso c in _cursosAsesorados)
                {
                    if(c.idCurso == _curso.idCurso)
                    {
                        _flag = 1;
                    }
                    i++;
                }
            }
            if(_flag == 0)
            {
                _asesor = new UsuarioWS.asesor();
                _asesor.precioPorHora = float.Parse(textBoxPrecio.Text);
                if (frmHome.Usuario.esAsesor == false)
                {
                    frmHome.Usuario.esAsesor = true;
                    frmHome.Usuario.asesor = _asesor;
                }
                frmHome.Usuario.asesor.idAsesor = _daoUsuario.insertarAsesor(_asesor, frmHome.Usuario.idUsuario, _curso.idCurso);
                this.Close();
            }
            else if(_flag == 1)
            {
                MessageBox.Show("Ya eres asesor de este curso, intenta postulando a otro curso", "Postular como asesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}