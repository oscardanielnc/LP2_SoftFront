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

namespace LP2Soft.Mensajes
{
    public partial class frmMensajes : Form
    {
        private NotificacionesWS.NotificacionesWSClient _daoNotificaiones;
        private BindingList<NotificacionesWS.ultimoMensaje> _mensajasUltimos;
        public frmMensajes()
        {
            _daoNotificaiones = new NotificacionesWS.NotificacionesWSClient();
            InitializeComponent();

            try
            {
                _mensajasUltimos = new BindingList<NotificacionesWS.ultimoMensaje>(
                    _daoNotificaiones.listarMensajesUltimos(frmHome.Usuario.idUsuario));

                lblInfo.Visible = false;

                foreach (NotificacionesWS.ultimoMensaje n in _mensajasUltimos)
                    agregarMensajeUltimo(n);
                /*lblInfo.Visible = true;
                lblInfo.Text = "Usted aún no tiene " + _mensajasUltimos.Count + " mesnajes";*/
            }
            catch (Exception ex)
            {
                lblInfo.Visible = true;
                lblInfo.Text = "Usted aún no tiene ninguna notificación";
            }
        }
        private void agregarMensajeUltimo(NotificacionesWS.ultimoMensaje u)
        {
            tarjUltimoMensaje tUltMensage = new tarjUltimoMensaje(u);
            tUltMensage.TopLevel = false;
            tUltMensage.Dock = DockStyle.Top;
            panelMensajes.Controls.Add(tUltMensage);
            panelMensajes.Controls.SetChildIndex(tUltMensage, 0);
            tUltMensage.Visible = true;
        }

    }
}
