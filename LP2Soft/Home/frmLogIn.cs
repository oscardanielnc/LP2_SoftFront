using LP2Soft.Perfil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Home
{
    public partial class frmLogIn : Form
    {
        private UsuarioWS.usuario _usuario;
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        public frmLogIn()
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            _usuario = _daoUsuario.mostrarUsuario("20186008", "oscar123", 1);
            frmPrincipal.abrirFormulario(new frmHome(_usuario));
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmLoginSingin.abrirFormulario(new frmSignIn());
        }
    }
}
