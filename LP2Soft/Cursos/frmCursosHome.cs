using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Cursos
{
    public partial class frmCursosHome : Form
    {
        public frmCursosHome()
        {
            InitializeComponent();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puede agregar a favoritos con el botón + " +
                "así te llegarán las notificaciones si existe nuevo material");
        }

        private void btnLP2Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void btnLP2Compartir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        private void btnLP2AgregarFavorito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se agrego a favorito");
        }
    }
}
