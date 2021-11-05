using LP2Soft.Tarjetas;
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
using LP2Soft.Home;

namespace LP2Soft.Cursos
{
    public partial class frmCursos_Home : Form
    {
        int iLP1;
        int iLP2;
        int iLP3;
        // private BindingList<CursosWS.curso> _cursoMostrar;
        //private CursosWS.CursosWSClient _daoCurso;
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        public frmCursos_Home()
        {
            InitializeComponent();
            iLP1 = 0; iLP2 = 0; iLP3 = 0;
        }
        public frmCursos_Home(int idUsuario)
        {
            InitializeComponent();
            //_daoCurso = new CursosWS.CursosWSClient();
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            todosCursos(idUsuario);
        }

        private void todosCursos(int idUsuario) 
        {
            // si mi usuario no tiene sus cursos, los solicito a la BD
            if(frmHome.Usuario.cursos == null)
                frmHome.Usuario.cursos = _daoUsuario.listarCursos(idUsuario);

            List<int> i = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (UsuarioWS.curso u in frmHome.Usuario.cursos) 
            {
                tarjCurso tCurso = new tarjCurso(u);
                tCurso.TopLevel = false;
                tCurso.Location = generarCoordenadas(i[u.nivel-1],u.nivel);
                panel1.Controls.Add(tCurso);
                panel1.Controls.SetChildIndex(tCurso,0);
                tCurso.Visible = true;
                i[u.nivel-1]++;
            }
        }

        private Point generarCoordenadas(int i,int nivel) 
        {
            int x = (nivel-1) * 150;
            int y = i * 101 + 35;
            return new Point(x, y);
        }

        public void abrirCurso(CursosWS.curso _cursoVer) {
            frmCursos_VerCurso Ciclo7LP2 = new frmCursos_VerCurso(_cursoVer);
            // Ciclo7LP2.ShowDialog();
            addPanel(Ciclo7LP2);
        }
        private void btnLP2AgregarFavorito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se agrego a favorito");
        }

        private void btnLP2_Click(object sender, EventArgs e)
        {
            frmCursos_VerCurso Ciclo7LP2 = new frmCursos_VerCurso();
            //Ciclo7LP2.ShowDialog();
            //this.Close();
            addPanel(Ciclo7LP2);
            
        }
        
        private void btnCiclo7_Click(object sender, EventArgs e)
        {
            frmCursos_Ciclo Ciclo7 = new frmCursos_Ciclo();
            addPanel(Ciclo7);
        }

        private void pictureInformativo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puede agregar a favoritos con el botón + " +
                "así te llegarán las notificaciones si existe nuevo material");
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void agregarAFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pBLP1CorazonLleno.Visible = true;
        }

        private void quitarDeFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pBLP1CorazonLleno.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pBLP2CorazonLleno.Visible = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pBLP2CorazonLleno.Visible = false;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            pBLP3CorazonLleno.Visible = true;

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            pBLP3CorazonLleno.Visible = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pictureInformativo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Con el + puedes cambiar de color de curso. Además" +
                "puedes agregar a favoritos dando clic en el corazón");
        }

        

        private void pictureAgregarLP1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureAgregarLP1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureAgregarLP1_Click(object sender, EventArgs e)
        {
            iLP1++;
            Color aprobadoColor = Color.FromArgb(0, 221, 125);
            Color PuedeLlevardoColor = Color.FromArgb(64, 161, 237);
            Color NoPuedeLlevarColor = Color.FromArgb(237, 64, 64);
            if (iLP1 == 1)
            {                
                pictureAgregarLP1.BackColor = aprobadoColor;
                btnLP1.BackColor = aprobadoColor;
                pBLP1CorazonVacio.BackColor = aprobadoColor;
                pBLP1CorazonLleno.BackColor = aprobadoColor;
                //abre LP2
                pictureAgregarLP2.BackColor = PuedeLlevardoColor;
                btnLP2.BackColor = PuedeLlevardoColor;
                pBLP2CorazonVacio.BackColor = PuedeLlevardoColor;
                pBLP2CorazonLleno.BackColor = PuedeLlevardoColor;

            }
            else if (iLP1 == 2)
            {                
                pictureAgregarLP1.BackColor = PuedeLlevardoColor;
                btnLP1.BackColor = PuedeLlevardoColor;
                pBLP1CorazonVacio.BackColor = PuedeLlevardoColor;
                pBLP1CorazonLleno.BackColor = PuedeLlevardoColor;
                //dependecia
                pictureAgregarLP2.BackColor = NoPuedeLlevarColor;
                btnLP2.BackColor = NoPuedeLlevarColor;
                pBLP2CorazonVacio.BackColor = NoPuedeLlevarColor;
                pBLP2CorazonLleno.BackColor = NoPuedeLlevarColor;
            }
            else 
            {                
                pictureAgregarLP1.BackColor = NoPuedeLlevarColor;
                btnLP1.BackColor = NoPuedeLlevarColor;
                pBLP1CorazonVacio.BackColor = NoPuedeLlevarColor;
                pBLP1CorazonLleno.BackColor = NoPuedeLlevarColor;
                //dependencia
                pictureAgregarLP2.BackColor = NoPuedeLlevarColor;
                btnLP2.BackColor = NoPuedeLlevarColor;
                pBLP2CorazonVacio.BackColor = NoPuedeLlevarColor;
                pBLP2CorazonLleno.BackColor = NoPuedeLlevarColor;
                iLP1 = 0;
            }

        }
        private void pBLP3CorazonVacio_Click(object sender, EventArgs e)
        {
            pBLP3CorazonVacio.Visible = false;
            pBLP3CorazonLleno.Visible = true;
        }

        private void pBLP3CorazonLleno_Click(object sender, EventArgs e)
        {
            pBLP3CorazonVacio.Visible = true;
            pBLP3CorazonLleno.Visible = false;
        }

        private void pBLP2CorazonVacio_Click(object sender, EventArgs e)
        {
            pBLP2CorazonVacio.Visible = false;
            pBLP2CorazonLleno.Visible = true;
        }

        private void pBLP2CorazonLleno_Click(object sender, EventArgs e)
        {
            pBLP2CorazonVacio.Visible = true;
            pBLP2CorazonLleno.Visible = false;
        }

        private void pBLP1CorazonVacio_Click(object sender, EventArgs e)
        {
            pBLP1CorazonVacio.Visible = false;
            pBLP1CorazonLleno.Visible = true;
        }

        private void pBLP1CorazonLleno_Click(object sender, EventArgs e)
        {
            pBLP1CorazonVacio.Visible = true;
            pBLP1CorazonLleno.Visible = false;
        }

        private void pictureAgregarLP2_Click(object sender, EventArgs e)
        {
            iLP2++;
            Color aprobadoColor = Color.FromArgb(0, 221, 125);
            Color PuedeLlevardoColor = Color.FromArgb(64, 161, 237);
            Color NoPuedeLlevarColor = Color.FromArgb(237, 64, 64);
            if (iLP2 == 1)
            {
                pictureAgregarLP2.BackColor = aprobadoColor;
                btnLP2.BackColor = aprobadoColor;
                pBLP2CorazonVacio.BackColor = aprobadoColor;
                pBLP2CorazonLleno.BackColor = aprobadoColor;
                //apruebo LP1
                pictureAgregarLP1.BackColor = aprobadoColor;
                btnLP1.BackColor = aprobadoColor;
                pBLP1CorazonVacio.BackColor = aprobadoColor;
                pBLP1CorazonLleno.BackColor = aprobadoColor;
                //abre LP1
                pictureAgregarLP3.BackColor = PuedeLlevardoColor;
                btnLP3.BackColor = PuedeLlevardoColor;
                pBLP3CorazonVacio.BackColor = PuedeLlevardoColor;
                pBLP3CorazonLleno.BackColor = PuedeLlevardoColor;

            }
            else if (iLP2 == 2)
            {
                pictureAgregarLP2.BackColor = PuedeLlevardoColor;
                btnLP2.BackColor = PuedeLlevardoColor;
                pBLP2CorazonVacio.BackColor = PuedeLlevardoColor;
                pBLP2CorazonLleno.BackColor = PuedeLlevardoColor;
                //aprobolP1
                pictureAgregarLP1.BackColor = aprobadoColor;
                btnLP1.BackColor = aprobadoColor;
                pBLP1CorazonVacio.BackColor = aprobadoColor;
                pBLP1CorazonLleno.BackColor = aprobadoColor;
                //dependecia
                pictureAgregarLP3.BackColor = NoPuedeLlevarColor;
                btnLP3.BackColor = NoPuedeLlevarColor;
                pBLP3CorazonVacio.BackColor = NoPuedeLlevarColor;
                pBLP3CorazonLleno.BackColor = NoPuedeLlevarColor;
            }
            else
            {
                pictureAgregarLP1.BackColor = PuedeLlevardoColor;
                btnLP1.BackColor = PuedeLlevardoColor;
                pBLP1CorazonVacio.BackColor = PuedeLlevardoColor;
                pBLP1CorazonLleno.BackColor = PuedeLlevardoColor;
                //dependencia
                pictureAgregarLP2.BackColor = NoPuedeLlevarColor;
                btnLP2.BackColor = NoPuedeLlevarColor;
                pBLP2CorazonVacio.BackColor = NoPuedeLlevarColor;
                pBLP2CorazonLleno.BackColor = NoPuedeLlevarColor;
                //no llevar lP3
                pictureAgregarLP3.BackColor = NoPuedeLlevarColor;
                btnLP3.BackColor = NoPuedeLlevarColor;
                pBLP3CorazonVacio.BackColor = NoPuedeLlevarColor;
                pBLP3CorazonLleno.BackColor = NoPuedeLlevarColor;
                iLP2 = 0;
            }
        }

        private void pictureAgregarLP3_Click(object sender, EventArgs e)
        {
            iLP3++;
            Color aprobadoColor = Color.FromArgb(0, 221, 125);
            Color PuedeLlevardoColor = Color.FromArgb(64, 161, 237);
            Color NoPuedeLlevarColor = Color.FromArgb(237, 64, 64);
            if (iLP3 == 1)
            {
                pictureAgregarLP2.BackColor = aprobadoColor;
                btnLP2.BackColor = aprobadoColor;
                pBLP2CorazonVacio.BackColor = aprobadoColor;
                pBLP2CorazonLleno.BackColor = aprobadoColor;
                //apruebo LP1
                pictureAgregarLP1.BackColor = aprobadoColor;
                btnLP1.BackColor = aprobadoColor;
                pBLP1CorazonVacio.BackColor = aprobadoColor;
                pBLP1CorazonLleno.BackColor = aprobadoColor;
                //abre LP1
                pictureAgregarLP3.BackColor = aprobadoColor;
                btnLP3.BackColor = aprobadoColor;
                pBLP3CorazonVacio.BackColor = aprobadoColor;
                pBLP3CorazonLleno.BackColor = aprobadoColor;

            }
            else if (iLP3 == 2)
            {
                pictureAgregarLP2.BackColor = aprobadoColor;
                btnLP2.BackColor = aprobadoColor;
                pBLP2CorazonVacio.BackColor = aprobadoColor;
                pBLP2CorazonLleno.BackColor = aprobadoColor;
                //aprobolP1
                pictureAgregarLP1.BackColor = aprobadoColor;
                btnLP1.BackColor = aprobadoColor;
                pBLP1CorazonVacio.BackColor = aprobadoColor;
                pBLP1CorazonLleno.BackColor = aprobadoColor;
                //dependecia
                pictureAgregarLP3.BackColor = PuedeLlevardoColor;
                btnLP3.BackColor = PuedeLlevardoColor;
                pBLP3CorazonVacio.BackColor = PuedeLlevardoColor;
                pBLP3CorazonLleno.BackColor = PuedeLlevardoColor;
            }
            else
            {
                pictureAgregarLP1.BackColor = aprobadoColor;
                btnLP1.BackColor = aprobadoColor;
                pBLP1CorazonVacio.BackColor = aprobadoColor;
                pBLP1CorazonLleno.BackColor = aprobadoColor;
                //dependencia
                pictureAgregarLP2.BackColor = PuedeLlevardoColor;
                btnLP2.BackColor = PuedeLlevardoColor;
                pBLP2CorazonVacio.BackColor = PuedeLlevardoColor;
                pBLP2CorazonLleno.BackColor = PuedeLlevardoColor;
                //no llevar lP3
                pictureAgregarLP3.BackColor = NoPuedeLlevarColor;
                btnLP3.BackColor = NoPuedeLlevarColor;
                pBLP3CorazonVacio.BackColor = NoPuedeLlevarColor;
                pBLP3CorazonLleno.BackColor = NoPuedeLlevarColor;
                iLP3 = 0;
            }
        }
        public void addPanel(Form f)
        {
            while (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            f.TopLevel = false;
            this.panel2.Controls.Add(f);
            f.Show();
        }

        
    }

        
    
}
