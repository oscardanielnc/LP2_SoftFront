using LP2Soft.Cursos.Ciclo7.LP2.Practicas;
using LP2Soft.Eventos;
using LP2Soft.Home;
using LP2Soft.Tarjetas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Cursos.Ciclo7.LP2
{
    public partial class frmCursos_VerCurso : Form
    {
        private string _rutaFoto = "";
        private CursosWS.CursosWSClient _daoCurso;
        private CursosWS.curso _cursoAux;
        int AuxNivel;
        //post
        UsuarioWS.usuario _usuario;
        PublicacionesWS.PublicacionesWSClient _daoPost;
        BindingList<PublicacionesWS.postGenerico> _publicaciones;
        PublicacionesWS.postGenerico _postCreado;
        private static int _cantidadPost = 0;
        //
        public frmCursos_VerCurso()
        {
            InitializeComponent();
        }
        public frmCursos_VerCurso(CursosWS.curso cursoVer)
        {
            _cursoAux = cursoVer;
            _daoCurso = new CursosWS.CursosWSClient();
            InitializeComponent();
            AuxNivel = cursoVer.nivel;
            botonChevere1.Text = cursoVer.nombre;
            
            lblNombreCodigo.Text = cursoVer.nombre + " (" + cursoVer.codigo + ")";
            lblCreditos.Text = cursoVer.creditos.ToString("0.00");
            lblCreditosReq.Text = cursoVer.creditosRequeridos.ToString("0.00");
            lblDescripción.Text = cursoVer.descripcion;

            btnRCiclo.Text = "Ciclo " + cursoVer.nivel.ToString();
            if (cursoVer.cursosRequeridos != null)
            {
                foreach (CursosWS.curso c in cursoVer.cursosRequeridos)
                {
                    LinkLabel lblNombreCursoReq = new LinkLabel();
                    lblNombreCursoReq.Text = c.nombre;
                    lblNombreCursoReq.Dock = DockStyle.Top;
                    panelCursosrequeridos.Controls.Add(lblNombreCursoReq);
                    lblNombreCursoReq.Click += new System.EventHandler((object sender, EventArgs e) => this.verCurso(sender, e, c.idCurso));
                }
                lblDescripción.Text = lblDescripción.Text.TrimEnd(',');
            }
            //post
            _cantidadPost = 0;
            _usuario = frmHome.Usuario;

            listarPublicaciones();
            //post
            tipoMaterial(cursoVer);
        }

        private void tipoMaterial(CursosWS.curso _cursoVer) {
            int i = 0;
            if (_cursoVer.cantPc > 0)
            {
                tarjTipoMaterial tTipoMaterial = new tarjTipoMaterial(0, _cursoVer);
                tTipoMaterial.TopLevel = false;
                tTipoMaterial.Location = generarCoordenadas(i);
                panel1.Controls.Add(tTipoMaterial);
                panel1.Controls.SetChildIndex(tTipoMaterial, 0);
                tTipoMaterial.Visible = true;
                i++;
            }

            if (_cursoVer.cantLab > 0)
            {
                tarjTipoMaterial tTipoMaterial = new tarjTipoMaterial(1, _cursoVer);
                tTipoMaterial.TopLevel = false;
                tTipoMaterial.Location = generarCoordenadas(i);
                panel1.Controls.Add(tTipoMaterial);
                panel1.Controls.SetChildIndex(tTipoMaterial, 0);
                tTipoMaterial.Visible = true;
                i++;
            }

            if (_cursoVer.cantTA > 0)
            {
                tarjTipoMaterial tTipoMaterial = new tarjTipoMaterial(2, _cursoVer);
                tTipoMaterial.TopLevel = false;
                tTipoMaterial.Location = generarCoordenadas(i);
                panel1.Controls.Add(tTipoMaterial);
                panel1.Controls.SetChildIndex(tTipoMaterial, 0);
                tTipoMaterial.Visible = true;
                i++;
            }

            if (_cursoVer.cantEx > 0)
            {
                tarjTipoMaterial tTipoMaterial = new tarjTipoMaterial(3, _cursoVer);
                tTipoMaterial.TopLevel = false;
                tTipoMaterial.Location = generarCoordenadas(i);
                panel1.Controls.Add(tTipoMaterial);
                panel1.Controls.SetChildIndex(tTipoMaterial, 0);
                tTipoMaterial.Visible = true;
                i++;
            }
        }
        private Point generarCoordenadas(int i)
        {
            int x = 0;
            int y = (i) * 40;
            return new Point(x, y);
        }
        private void verCurso(object sender, EventArgs e, int idCurso)
        {
            frmPrincipal.startLoading();
            _cursoAux = _daoCurso.MostrarCurso(idCurso);
            if (_cursoAux != null)
            {
                frmHome.abrirFormulario(new frmCursos_VerCurso(_cursoAux));
            }
            frmPrincipal.endLoading();
        }
        private void btnLP2Ciclo7_Click(object sender, EventArgs e)
        {
            /*frmCursos_Ciclo frmCursos_Ciclo = new frmCursos_Ciclo(AuxNivel);
            addPanel(frmCursos_Ciclo);*/
            frmHome.abrirFormulario(new frmCursos_Ciclo(AuxNivel));
        }

        private void btnLP2Material_Click(object sender, EventArgs e)
        {
            /*frmCursos_Home cursosHome = new frmCursos_Home(frmHome.Usuario.idUsuario);
            addPanel(cursosHome);*/
            frmHome.abrirFormulario(new frmCursos_Home(frmHome.Usuario.idUsuario));
        }

        private void btnLP2DescargarPcs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void btnLP2CompartirPcs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        private void btnLP2Practicas_Click(object sender, EventArgs e)
        {
            /*frmCursos_Practicas practicas = new frmCursos_Practicas();
            addPanel(practicas);*/
            frmHome.abrirFormulario(new frmCursos_Practicas());
        }

        private void pBLP2DescargarLabs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2DescargarPcs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2DescargarParciales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2DescargarFinales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2DescargarLibros_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2DescargasExtras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }
        //post 
        public void listarPublicaciones()
        {
            panelPublicacionesGenerales.Controls.Clear();
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
            PublicacionesWS.postGenerico[] posts = _daoPost.listarXcurso(_cursoAux.idCurso);
            if (posts != null)
                _publicaciones = new BindingList<PublicacionesWS.postGenerico>(posts.ToList());
            else
                _publicaciones = null;
            if (_publicaciones != null)
            {
                foreach (PublicacionesWS.postGenerico p in _publicaciones)
                {
                    if (_cantidadPost == 3) break;
                    frmPostGeneral plantillaPost = new frmPostGeneral(p, _usuario);
                    plantillaPost.TopLevel = false;
                    plantillaPost.Dock = DockStyle.Top;
                    panelPublicacionesGenerales.Controls.Add(plantillaPost);
                    panelPublicacionesGenerales.Controls.SetChildIndex(plantillaPost, 0);
                    plantillaPost.Visible = true;
                    //_publicaciones.RemoveAt(_cantidadPost);
                    _cantidadPost++;
                }
            }
        }
        private void lblCrearPublicación_Click(object sender, EventArgs e)
        {
            frmCrearPostGeneral frmCrearPostGeneral = new frmCrearPostGeneral(_usuario, _cursoAux.idCurso);
            if (frmCrearPostGeneral.ShowDialog() == DialogResult.OK)
            {
                panelPublicacionesGenerales.Controls.Clear();
                _postCreado = frmCrearPostGeneral.PostCreado;
                _postCreado.fechaRegistro = DateTime.Today;
                _postCreado.usuario.nombre = _usuario.nombre;
                frmPostGeneral plantilla = new frmPostGeneral(_postCreado, _usuario);
                plantilla.TopLevel = false;
                plantilla.Dock = DockStyle.Top;
                panelPublicacionesGenerales.Controls.Add(plantilla);
                panelPublicacionesGenerales.Controls.SetChildIndex(plantilla, 0);
                plantilla.Visible = true;
                _cantidadPost = 0;
                int contador = 0;
                if (_publicaciones != null)
                {
                    foreach (PublicacionesWS.postGenerico p in _publicaciones)
                    {
                        if (contador == 2) break;
                        frmPostGeneral plantillaPost = new frmPostGeneral(p, _usuario);
                        plantillaPost.TopLevel = false;
                        plantillaPost.Dock = DockStyle.Top;
                        panelPublicacionesGenerales.Controls.Add(plantillaPost);
                        panelPublicacionesGenerales.Controls.SetChildIndex(plantillaPost, 0);
                        plantillaPost.Visible = true;
                        contador++;
                        _cantidadPost++;
                    }
                }
                //_cantidadPost++;
                /*PublicacionesWS.postGenerico[] posts = _daoPost.listarPost();
                if (posts != null)
                    _publicaciones = new BindingList<PublicacionesWS.postGenerico>(posts.ToList());
                else
                    _publicaciones = null;*/
            }
        }
        private void panelPublicacionesGenerales_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == panelPublicacionesGenerales.VerticalScroll.Maximum - panelPublicacionesGenerales.VerticalScroll.LargeChange + 1)
            {
                if (e.NewValue != e.OldValue) // Checking when the scrollbar is at bottom and user clicks/scrolls the scrollbar      
                {
                    int cantidadFinal = _cantidadPost + 3;
                    int contador = 0;

                    foreach (PublicacionesWS.postGenerico p in _publicaciones)
                    {
                        if (contador < _cantidadPost)
                        {
                            contador++;
                            continue;
                        }
                        else contador = 1000;

                        if (_cantidadPost == cantidadFinal) break;
                        frmPostGeneral plantillaPost = new frmPostGeneral(p, _usuario);
                        plantillaPost.TopLevel = false;
                        plantillaPost.Dock = DockStyle.Top;
                        panelPublicacionesGenerales.Controls.Add(plantillaPost);
                        panelPublicacionesGenerales.Controls.SetChildIndex(plantillaPost, 0);
                        plantillaPost.Visible = true;
                        //_publicaciones.RemoveAt(contador);
                        //contador++;
                        _cantidadPost++;
                    }
                }
            }
        }

        private void btnRMaterial_Click(object sender, EventArgs e)
        {
            frmHome.abrirFormulario(new frmCursos_Home(frmHome.Usuario.idUsuario));
        }

        private void btnRCiclo_Click(object sender, EventArgs e)
        {
            frmHome.abrirFormulario(new frmCursos_Ciclo(AuxNivel));
        }

        private void botonChevere1_Click(object sender, EventArgs e)
        {

        }
    }
}
