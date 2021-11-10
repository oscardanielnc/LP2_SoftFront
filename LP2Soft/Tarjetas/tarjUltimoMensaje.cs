using LP2Soft.Home;
using LP2Soft.Mensajes;
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

namespace LP2Soft.Tarjetas
{
    public partial class tarjUltimoMensaje : Form
    {
        private NotificacionesWS.ultimoMensaje _ultMensaje;
        public tarjUltimoMensaje(NotificacionesWS.ultimoMensaje ultimoMensaje)
        {
            _ultMensaje = ultimoMensaje;
            InitializeComponent();
            if (ultimoMensaje.amigo.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(ultimoMensaje.amigo.foto);
                imgAmigo.Image = new Bitmap(ms1);
            }
            lblContenido.Text = ultimoMensaje.mensaje.contenido;
            lblNombre.Text = ultimoMensaje.amigo.nombre + " " + ultimoMensaje.amigo.apellido;
            lblFechaHora.Text = ultimoMensaje.mensaje.fechayHora.ToString("dd MMMM yyyy hh:mm:ss");
        }

        private void btnVerChat_Click(object sender, EventArgs e)
        {
            UsuarioWS.usuario amigoCast = new UsuarioWS.usuario();
            amigoCast.idUsuario = _ultMensaje.amigo.idUsuario;
            amigoCast.nombre = _ultMensaje.amigo.nombre;
            amigoCast.apellido = _ultMensaje.amigo.apellido;
            amigoCast.foto = _ultMensaje.amigo.foto;

            frmHome.abrirFormulario(new frmMensajeChat(amigoCast));
        }
    }
}
