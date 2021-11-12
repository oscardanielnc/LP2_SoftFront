using LP2Soft.Home;
using LP2Soft.Tarjetas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Perfil
{
    public partial class frmPerfil_Amigos : Form
    {
        private BindingList<UsuarioWS.usuario> _usuariosBusqueda;
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private UsuarioWS.usuario _usuario;
        public frmPerfil_Amigos(UsuarioWS.usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            _daoUsuario = new UsuarioWS.UsuariosWSClient();

            renderizarBusqueda("");
        }
        private void renderizarBusqueda(string nombreCodigo)
        {
            _usuariosBusqueda = null;
            lblInfo.Text = "Buscando...";
            try
            {
                _usuariosBusqueda = new BindingList<UsuarioWS.usuario>(_daoUsuario.listarAmigosNombreCodigo(_usuario.idUsuario, nombreCodigo));
                //renderizamos las tarjetas
                int i = 0;
                foreach (UsuarioWS.usuario u in _usuariosBusqueda)
                {
                    tarjUsuario tUsuario = new tarjUsuario(u);
                    tUsuario.TopLevel = false;
                    tUsuario.Location = generarCoordenadas(i);
                    /*tUsuario.Dock = DockStyle.Top;*/
                    panelAmigos.Controls.Add(tUsuario);
                    panelAmigos.Controls.SetChildIndex(tUsuario, 0);
                    tUsuario.Visible = true;
                    i++;
                }
                lblInfo.Text = "Se han encontrado " + _usuariosBusqueda.Count + " amigos.";
            }
            catch (Exception ex)
            {
                lblInfo.Text = "No se han encontrado a los amigos de " + _usuario.nombre + " que coincidan con esta búsqueda.";
            }
        }
        private Point generarCoordenadas(int i)
        {
            int x = (i % 4) * 170;
            int y = ((int)i / 4) * 146;
            return new Point(x, y);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            panelAmigos.Controls.Clear();
            renderizarBusqueda(txtBusquedaAmigos.Text);
            frmPrincipal.endLoading();
        }

        // Efecto Placeholder
        private void txtBusquedaAmigos_Leave(object sender, EventArgs e)
        {
            if (txtBusquedaAmigos.Text == "")
            {
                txtBusquedaAmigos.Text = "Buscar amigos";
                txtBusquedaAmigos.ForeColor = Color.Gray;
            }
        }

        private void txtBusquedaAmigos_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaAmigos.Text == "Buscar amigos")
            {
                txtBusquedaAmigos.Text = "";
                txtBusquedaAmigos.ForeColor = Color.Black;
            }
        }
    }
}
