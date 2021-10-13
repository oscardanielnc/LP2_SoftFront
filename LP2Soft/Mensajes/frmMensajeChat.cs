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
    public partial class frmMensajeChat : Form
    {
        private Panel _panelPadre;
        public frmMensajeChat()
        {
            InitializeComponent();
        }
        public frmMensajeChat(Panel panel)
        {
            InitializeComponent();
            _panelPadre = panel;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            _panelPadre.Controls.Clear();
            frmMensajes frmMensaje = new frmMensajes(_panelPadre);
            frmMensaje.TopLevel = false;
            _panelPadre.Controls.Add(frmMensaje);
            frmMensaje.Show();
        }
    }
}
