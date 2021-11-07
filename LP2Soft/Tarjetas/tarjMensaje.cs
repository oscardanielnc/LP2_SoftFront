using LP2Soft.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Tarjetas
{
    public partial class tarjMensaje : Form
    {
        public tarjMensaje(NotificacionesWS.mensaje mensaje)
        {
            InitializeComponent();
            lblContenido.Text = mensaje.contenido;
            lblFechaHora.Text = '\n' + mensaje.fechayHora.ToString("dd MMMM yyyy hh:mm:ss");
            if(mensaje.idRemitente == frmHome.Usuario.idUsuario) // propio
            {
                panelMensaje.Location = new Point(93, 6);
                panelMensaje.BackColor = Color.FromArgb(220, 248, 198);
            } else
            {
                panelMensaje.Location = new Point(6, 6);
                panelMensaje.BackColor = Color.White;
            }
        }
    }
}
