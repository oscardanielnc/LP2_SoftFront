using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Notificaciones
{
    public partial class frmNotificaciones : Form
    {
        private NotificacionesWS.NotificacionesWSClient _daoNotificaiones;
        public frmNotificaciones()
        {
            _daoNotificaiones = new NotificacionesWS.NotificacionesWSClient();
            InitializeComponent();

            try
            {
/*                _mensajes = new BindingList<NotificacionesWS.mensaje>(
                    _daoMensajes.listarMensajesXAmigo(frmHome.Usuario.idUsuario, _amigo.idUsuario));

                lblInfo.Visible = false;

                foreach (NotificacionesWS.mensaje m in _mensajes)
                    agregarMensaje(m);*/

            }
            catch (Exception ex)
            {
                lblInfo.Visible = true;
                lblInfo.Text = "Usted aún no tiene ninguna notificación";
            }
        }
/*        private void agregarMensaje(NotificacionesWS.mensaje m)
        {
            tarjMensaje tMensaje = new tarjMensaje(m);
            tMensaje.TopLevel = false;
            tMensaje.Dock = DockStyle.Top;
            panelMensajes.Controls.Add(tMensaje);
            panelMensajes.Controls.SetChildIndex(tMensaje, 0);
            tMensaje.Visible = true;
        }*/
    }
}
