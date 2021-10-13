using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Eventos
{
    public partial class frmMisPublicaciones : Form
    {
        public frmMisPublicaciones()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarEvento frmModificarEvento = new frmModificarEvento();
            frmModificarEvento.ShowDialog();
        }
    }
}
