using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Cursos.Calificación
{
    public partial class frmCalificacion : Form
    {
        private int star1;
        private int star2;
        private int star3;
        private int star4;
        private int star5;
        public frmCalificacion()
        {
            InitializeComponent();
            star1 = 0;
            star2 = 0;
            star3 = 0;
            star4 = 0;
            star5 = 0;
        }

        private void btnCalificacionAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se envió la calificación");
            this.Close();
        }

        private void btnCalificacioCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEstrellas_Click(object sender, EventArgs e)
        {
            star1++;
            if (star1 % 2 == 1)
            {
                star1 = 1;
                lblEstrella1.ImageIndex = 1;
            }
            else 
            {
                star1 = 0;
                star2 = 0;
                star3 = 0;
                star4 = 0;
                star5 = 0;
                lblEstrella1.ImageIndex = 0;
                lblEstrella2.ImageIndex = 0;
                lblEstrella3.ImageIndex = 0;
                lblEstrella4.ImageIndex = 0;
                lblEstrella5.ImageIndex = 0;
            }
        }

        private void lblEstrella2_Click(object sender, EventArgs e)
        {
            star2++;
            if (star2 % 2 == 1)
            {
                star1= 1;
                star2 = 1;
                lblEstrella2.ImageIndex = 1;
                lblEstrella1.ImageIndex = 1;
            }
            else
            {
                star2 = 0;
                star3 = 0;
                star4 = 0;
                star5 = 0;
                lblEstrella2.ImageIndex = 0;
                lblEstrella3.ImageIndex = 0;
                lblEstrella4.ImageIndex = 0;
                lblEstrella5.ImageIndex = 0;
            }
        }

        private void lblEstrella3_Click(object sender, EventArgs e)
        {
            star3++;
            if (star3 % 2 == 1)
            {
                star1 = 1;
                star2 = 1;
                star3 = 1;
                lblEstrella1.ImageIndex = 1;
                lblEstrella2.ImageIndex = 1;
                lblEstrella3.ImageIndex = 1;
            }
            else
            {
                star3 = 0;
                star4 = 0;
                star5 = 0;
                lblEstrella3.ImageIndex = 0;
                lblEstrella4.ImageIndex = 0;
                lblEstrella5.ImageIndex = 0;
            }
        }

        private void lblEstrella4_Click(object sender, EventArgs e)
        {
            star4++;
            if (star4 % 2 == 1)
            {
                star1 = 1;
                star2 = 1;
                star3 = 1;
                star4 = 1;
                lblEstrella1.ImageIndex = 1;
                lblEstrella2.ImageIndex = 1;
                lblEstrella3.ImageIndex = 1;
                lblEstrella4.ImageIndex = 1;
            }
            else
            {
                star4 = 0;
                star5 = 0;
                lblEstrella4.ImageIndex = 0;
                lblEstrella5.ImageIndex = 0;
            }
        }

        private void lblEstrella5_Click(object sender, EventArgs e)
        {
            star5++;
            if (star5 % 2 == 1)
            {
                star1 = 1;
                star2 = 1;
                star3 = 1;
                star4 = 1;
                star5 = 1;
                lblEstrella1.ImageIndex = 1;
                lblEstrella2.ImageIndex = 1;
                lblEstrella3.ImageIndex = 1;
                lblEstrella4.ImageIndex = 1;
                lblEstrella5.ImageIndex = 1;
            }
            else
            {
                star5 = 0;
                lblEstrella5.ImageIndex = 0;
            }
        }
    }
}
