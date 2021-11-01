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
        UsuarioWS.usuario _usuario;
        PublicacionesWS.PublicacionesWSClient _daoPost;
        BindingList<PublicacionesWS.postGenerico> _publicaciones;
        PublicacionesWS.postGenerico _postCreado;
        private int _cantidadPost;
        public frmHomePage()
        {
            InitializeComponent();
        }

        public frmHomePage(UsuarioWS.usuario usuario)
        {
            InitializeComponent();
            _cantidadPost = 0;
            _usuario = usuario;
            panelPublicacionesGenerales.Controls.Clear();
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
            PublicacionesWS.postGenerico[] posts = _daoPost.listarPost();
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
            frmCrearPostGeneral frmCrearPostGeneral = new frmCrearPostGeneral(_usuario);
            if (frmCrearPostGeneral.ShowDialog() == DialogResult.OK)
            {
                panelPublicacionesGenerales.Controls.Clear();
                _postCreado = frmCrearPostGeneral.PostCreado;
                _postCreado.usuario.nombre = _usuario.nombre;
                frmPostGeneral plantilla = new frmPostGeneral(_postCreado, _usuario);
                plantilla.TopLevel = false;
                plantilla.Dock = DockStyle.Top;
                panelPublicacionesGenerales.Controls.Add(plantilla);
                panelPublicacionesGenerales.Controls.SetChildIndex(plantilla, 0);
                plantilla.Visible = true;

                if (_publicaciones != null)
                {
                    foreach (PublicacionesWS.postGenerico p in _publicaciones)
                    {
                        frmPostGeneral plantillaPost = new frmPostGeneral(p, _usuario);
                        plantillaPost.TopLevel = false;
                        plantillaPost.Dock = DockStyle.Top;
                        panelPublicacionesGenerales.Controls.Add(plantillaPost);
                        panelPublicacionesGenerales.Controls.SetChildIndex(plantillaPost, 0);
                        plantillaPost.Visible = true;
                    }
                }
            }
        }

        private void panelPublicacionesGenerales_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == panelPublicacionesGenerales.VerticalScroll.Maximum - panelPublicacionesGenerales.VerticalScroll.LargeChange + 1)
            {
                if (e.NewValue != e.OldValue) // Checking when the scrollbar is at bottom and user clicks/scrolls the scrollbar      
                {
                    int cantidadFinal = _cantidadPost + 3;
                    int contador=0;
                    foreach (PublicacionesWS.postGenerico p in _publicaciones)
                    {
                        if (contador < _cantidadPost)
                        {
                            contador++;
                            continue;
                        }
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
    }
}
