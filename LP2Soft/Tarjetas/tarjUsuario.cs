using LP2Soft.Home;
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

namespace LP2Soft.Tarjetas
{
    public partial class tarjUsuario : Form
    {
        private string _codigo;
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private UsuarioWS.usuario _usuarioVer;
        public tarjUsuario(UsuarioWS.usuario usuario)
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();
            _codigo = usuario.codigoPUCP;
            posicionarLabel(usuario);
            // aqui viene la foto
        }
        private void posicionarLabel(UsuarioWS.usuario usuario)
        {
            int tamanio = lblNombre.Size.Width;
            lblNombre.Text = usuario.nombre + " " + usuario.apellido;
            lblNombre.Location = new Point((int)((150 - tamanio) / 2), 64);
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            _usuarioVer = _daoUsuario.mostrarUsuario(_codigo, 1);
            if (_usuarioVer != null)
                frmHome.abrirFormulario(new frmPerfil(_usuarioVer, false));
        }
    }
}
