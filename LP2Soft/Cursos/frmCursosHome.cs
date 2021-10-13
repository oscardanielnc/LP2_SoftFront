using LP2Soft.Cursos.Ciclo7;
using LP2Soft.Cursos.Ciclo7.LP2;
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
              
        private void btnLP2AgregarFavorito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se agrego a favorito");
        }

        private void btnLP2_Click(object sender, EventArgs e)
        {
            frmCiclo7LP2 Ciclo7LP2 = new frmCiclo7LP2();
            Ciclo7LP2.ShowDialog();
            this.Close();
        }

        private void btnCiclo7_Click(object sender, EventArgs e)
        {
            frmCiclo7 Ciclo7 = new frmCiclo7();
            Ciclo7.ShowDialog();
            this.Close();
        }

        

        

        private void pictureLP2Compartir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        

        

        private void pictureLP2Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        

        
        private void pictureLP2Favorito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se agregó a favoritos");
        }

        

        

        private void pictureInformativo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puede agregar a favoritos con el botón + " +
                "así te llegarán las notificaciones si existe nuevo material");
        }
    }

        
    
}
