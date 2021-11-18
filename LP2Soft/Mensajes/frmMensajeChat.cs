using LP2Soft.Home;
using LP2Soft.Tarjetas;
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

namespace LP2Soft.Mensajes
{
    public partial class frmMensajeChat : Form
    {
        private UsuarioWS.usuario _amigo;
        private NotificacionesWS.NotificacionesWSClient _daoMensajes;
        private BindingList <NotificacionesWS.mensaje> _mensajes;
        public frmMensajeChat(UsuarioWS.usuario amigo)
        {
            _amigo = amigo;
            _daoMensajes = new NotificacionesWS.NotificacionesWSClient();
            InitializeComponent();

            lblNombreAmigo.Text = _amigo.nombre + " " + _amigo.apellido;
            if (_amigo.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(_amigo.foto);
                imgAmigo.Image = new Bitmap(ms1);
            }

            try
            {
                _mensajes = new BindingList<NotificacionesWS.mensaje>(
                    _daoMensajes.listarMensajesXAmigo(frmHome.Usuario.idUsuario, _amigo.idUsuario));

                lblInfo.Visible = false;

                foreach (NotificacionesWS.mensaje m in _mensajes)
                    agregarMensaje(m);

            } catch(Exception ex)
            {
                lblInfo.Visible = true;
                lblInfo.Text = "Usted aún no tiene ningún mensaje con este usuario. Pruebe decir 'Hola :D' ";
            }
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            if(txtMensaje.Text == "" || txtMensaje.Text== "Escribe aquí tu mensaje")
            {
                MessageBox.Show("Debe escribir un mensaje", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                try
                {
                    NotificacionesWS.mensaje m = new NotificacionesWS.mensaje();
                    m.idRemitente = frmHome.Usuario.idUsuario;
                    m.idDestinatario = _amigo.idUsuario;
                    m.contenido = txtMensaje.Text;
                    m.fechayHora = DateTime.Now;
                    agregarMensaje(m);
                    _daoMensajes.enviarMensaje(m.idRemitente, m.idDestinatario, txtMensaje.Text);
                    txtMensaje.Text = "";
                } catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error en el servidor al tratar de enviar el mensaje. Intentelo de nuevo más tarde",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void agregarMensaje(NotificacionesWS.mensaje m)
        {
            tarjMensaje tMensaje = new tarjMensaje(m);
            tMensaje.TopLevel = false;
            tMensaje.Dock = DockStyle.Top;
            panelMensajes.Controls.Add(tMensaje);
            panelMensajes.Controls.SetChildIndex(tMensaje, 0);
            tMensaje.Visible = true;
        }

        private void txtMensaje_Enter(object sender, EventArgs e)
        {
            if (txtMensaje.Text == "Escribe aquí tu mensaje")
            {
                txtMensaje.Text = "";
                txtMensaje.ForeColor = Color.Black;
            }
        }

        private void txtMensaje_Leave(object sender, EventArgs e)
        {
            if (txtMensaje.Text == "")
            {
                txtMensaje.Text = "Escribe aquí tu mensaje";
                txtMensaje.ForeColor = Color.Gray;
            }
        }

        private void txtMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                btnEnviarMensaje_Click(sender, e);
        }
    }
}
