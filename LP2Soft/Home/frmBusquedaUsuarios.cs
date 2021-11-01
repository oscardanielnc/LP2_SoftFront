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
            try
            {
                _usuariosBusqueda = new BindingList<UsuarioWS.usuario>(_daoUsuario.listarUsuariosNombreCodigo(codigoNombre));
                lblInfo.Text = "Se han encontrado " + _usuariosBusqueda.Count + " usuarios.";
                //renderizamos las tarjetas
                int i = 0;
                foreach (UsuarioWS.usuario u in _usuariosBusqueda)
                {
                    tarjUsuario tUsuario = new tarjUsuario(u);
                    tUsuario.TopLevel = false;
                    tUsuario.Location = generarCoordenadas(i);
                    /*tUsuario.Dock = DockStyle.Top;*/
                    panelUsuarios.Controls.Add(tUsuario);
                    panelUsuarios.Controls.SetChildIndex(tUsuario, 0);
                    tUsuario.Visible = true;
                    i++;
                }
            }
            catch (Exception ex)
            {
                lblInfo.Text = "No se han encontrado usuarios que coincidan con esta búsqueda.";
            }
        }
        private Point generarCoordenadas(int i)
        {
            int x = (i % 5) * 156;
            int y = ((int)i / 5) * 146;
            return new Point(x, y);
        }

    }
}

