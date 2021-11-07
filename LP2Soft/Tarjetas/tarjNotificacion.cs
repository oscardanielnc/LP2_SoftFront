using LP2Soft.Home;
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
    public partial class tarjNotificacion : Form
    {
        private NotificacionesWS.notificacion _notificacion;
        public tarjNotificacion(NotificacionesWS.notificacion notificacion)
        {
            _notificacion = notificacion;
            InitializeComponent();
            mostarSugunTipoNotificacion();
        }
        private void mostarSugunTipoNotificacion()
        {
            imgNotif.ImageIndex = _notificacion.tipo;
            _notificacion.fechaSpecified = true;
            lblFechaHora.Text = _notificacion.fecha.ToString("dd MMMM yyyy hh:mm:ss");

            if(_notificacion.tipo==1)
            {
                if (_notificacion.usuarioNotificador.foto != null)
                {
                    MemoryStream ms1 = new MemoryStream(_notificacion.usuarioNotificador.foto);
                    imgNotific.Image = new Bitmap(ms1);
                }
                if (_notificacion.subTipo==1)
                    lblContenido.Text = "¡" + _notificacion.usuarioNotificador.nombre + " ha aceptado tu solicitud de amistad!";
                else lblContenido.Text = _notificacion.usuarioNotificador.nombre + " te ha enviado una solicitud de amistad!";
            } else
            {
                if (frmHome.Usuario.foto != null)
                {
                    MemoryStream ms1 = new MemoryStream(frmHome.Usuario.foto);
                    imgNotific.Image = new Bitmap(ms1);
                }
                lblContenido.Text = "¡Felicidades. Te has convertido en administrador del sistema!";
            }
        }

        private void btnPostularAsesor_Click(object sender, EventArgs e)
        {

        }
    }
}
