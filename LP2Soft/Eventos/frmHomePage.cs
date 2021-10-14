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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            frmCrearComentario frmCrearComentario = new frmCrearComentario();
            frmCrearComentario.ShowDialog();
        }

        private void lblComentar_Click(object sender, EventArgs e)
        {
            frmCrearComentario frmCrearComentario = new frmCrearComentario();
            frmCrearComentario.ShowDialog();
        }

        private void lblCrearPublicación_Click(object sender, EventArgs e)
        {
            frmCrearPostGeneral frmCrearPostGeneral = new frmCrearPostGeneral();
            frmCrearPostGeneral.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmCrearComentario frmCrearComentario = new frmCrearComentario();
            frmCrearComentario.ShowDialog();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            frmCrearComentario frmCrearComentario = new frmCrearComentario();
            frmCrearComentario.ShowDialog();
        }
    }
}
