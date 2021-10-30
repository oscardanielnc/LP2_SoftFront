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
    public partial class frmBusquedaUsuarios : Form
    {
        private BindingList<UsuarioWS.usuario> _usuariosBusqueda;
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        public frmBusquedaUsuarios(string codigoNombre)
        {
            InitializeComponent();
            _daoUsuario = new UsuarioWS.UsuariosWSClient();

            renderizarBusqueda(codigoNombre);
        }
        private void renderizarBusqueda(string codigoNombre)
        {
            _usuariosBusqueda = new BindingList<UsuarioWS.usuario>(_daoUsuario.listarUsuariosNombreCodigo(codigoNombre));
            if(_usuariosBusqueda != null)
            {
                lblInfo.Text = "Se han encontrado " + _usuariosBusqueda.Count + " usuarios.";
                //renderizamos las tarjetas
            } else
                lblInfo.Text = "No se han encontrado usuarios que coincidan con esta búsqueda.";
        }
    }
}
