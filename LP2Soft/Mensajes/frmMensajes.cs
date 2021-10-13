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

namespace LP2Soft.Mensajes
{
    public partial class frmMensajes : Form
    {
        private frmHome _formHome;

        public frmMensajes(frmHome formHome)
        {
            InitializeComponent();
            _formHome = formHome;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _formHome.abrirFormulario(new frmMensajeChat());
        }
    }
}
