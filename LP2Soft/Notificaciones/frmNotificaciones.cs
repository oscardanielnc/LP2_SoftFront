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

namespace LP2Soft.Notificaciones
{
    public partial class frmNotificaciones : Form
    {
        private NotificacionesWS.NotificacionesWSClient _daoNotificaiones;
        private BindingList<NotificacionesWS.notificacion> _notificaciones;
        public frmNotificaciones()
        {
            _daoNotificaiones = new NotificacionesWS.NotificacionesWSClient();
            InitializeComponent();

            try
            {
                _notificaciones = new BindingList<NotificacionesWS.notificacion>(
                    _daoNotificaiones.listarNotificaciones(frmHome.Usuario.idUsuario));

                lblInfo.Visible = false;

                foreach (NotificacionesWS.notificacion n in _notificaciones)
                    agregarNotificacion(n);

            }
            catch (Exception ex)
            {
                lblInfo.Visible = true;
                lblInfo.Text = "Usted aún no tiene ninguna notificación";
            }
        }
        private void agregarNotificacion(NotificacionesWS.notificacion n)
        {
            tarjNotificacion tNotificacion = new tarjNotificacion(n);
            tNotificacion.TopLevel = false;
            tNotificacion.Dock = DockStyle.Top;
            panelNotificaciones.Controls.Add(tNotificacion);
            panelNotificaciones.Controls.SetChildIndex(tNotificacion, 0);
            tNotificacion.Visible = true;
        }
    }
}
