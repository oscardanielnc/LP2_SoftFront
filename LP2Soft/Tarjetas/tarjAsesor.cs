using LP2Soft.Home;
using LP2Soft.Perfil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LP2Soft.Tarjetas
{
    public partial class tarjAsesor : Form
    {
        private string _codigo;
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private UsuarioWS.usuario _usuarioVer;
        public tarjAsesor(UsuarioWS.usuario user)
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();
            _codigo = user.codigoPUCP;
            posicionarLabel(user);

            if (user.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(user.foto);
                pctAsesor.Image = new Bitmap(ms1);
            }
        }
        private void posicionarLabel(UsuarioWS.usuario usuario)
        {
            lblNombre.Text = usuario.nombre + " " + usuario.apellido;
            int tamanio = lblNombre.Size.Width;
            lblCal.Text = " " + usuario.asesor.calificacion.ToString("0.0") + " ";
            lblNombre.Location = new Point(((int)(170 - tamanio) / 2), 80);
        }
        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            _usuarioVer = _daoUsuario.mostrarUsuario(_codigo, 1);
            if (_usuarioVer != null)
                frmHome.abrirFormulario(new frmPerfil(_usuarioVer));
        }

        private void btnVerPerfil_Click_1(object sender, EventArgs e)
        {
            _usuarioVer = _daoUsuario.mostrarUsuario(_codigo, 1);
            if (_usuarioVer != null)
                frmHome.abrirFormulario(new frmPerfil(_usuarioVer));
        }
    }
}

