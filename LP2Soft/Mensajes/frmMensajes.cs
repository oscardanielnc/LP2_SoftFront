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
        private Panel _panelPadre;
        public frmMensajes()
        {
            InitializeComponent();
        }
        public frmMensajes(Panel panel)
        {
            InitializeComponent();
            _panelPadre = panel;
        }

        private void pictureBoxUser1_Click(object sender, EventArgs e)
        {
            _panelPadre.Controls.Clear();
            frmMensajeChat frmChat = new frmMensajeChat(_panelPadre);
            frmChat.TopLevel = false;
            _panelPadre.Controls.Add(frmChat);
            frmChat.Show();
        }
    }
}
