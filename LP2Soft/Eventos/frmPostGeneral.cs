using LP2Soft.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Eventos
{
    public partial class frmPostGeneral : Form
    {
        UsuarioWS.usuario _usuario;
        PublicacionesWS.postGenerico _post;
        PublicacionesWS.comentario _comentarioCreado;
        PublicacionesWS.postGenerico _postModificado;
        PublicacionesWS.PublicacionesWSClient _daoPost;
        BindingList<PublicacionesWS.comentario> _coments;
        private int _cantidadComent=0;

        public frmPostGeneral()
        {
            InitializeComponent();
        }

        public frmPostGeneral(PublicacionesWS.postGenerico pp, UsuarioWS.usuario usuario)
        { 

            InitializeComponent();
            _usuario = usuario;
            _post = pp;
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
            //if (pp.usuario.foto != null)
            //{
            //    MemoryStream ms1 = new MemoryStream(pp.usuario.foto);
            //    pbPerfil.Image = new Bitmap(ms1);
            //}
            btnMeGustaDinamico.ImageIndex = 1;
            lblNombre.Text = pp.usuario.nombre;
            lblFechaHoraCreacion.Text = pp.fechaRegistro.ToString("dd-MM-yyyy");
            txtContenido.Text = pp.contenido;
            lblCantidadMeGusta.Text = pp.likes.ToString();
            lblCantidadComentarios.Text = pp.numeroComent.ToString();

            if (frmHome.Usuario.idUsuario == pp.usuario.idUsuario)
                btnModificar.Visible = true;
            else
                btnModificar.Visible = false;

            panelComentarios.Controls.Clear();
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
            PublicacionesWS.comentario[] _comentarios = _daoPost.listarComentarios(_post.idPost);
            if (_comentarios != null)
                _coments = new BindingList<PublicacionesWS.comentario>(_comentarios.ToList());
            else
                _coments = null;

            _cantidadComent = 0;

            if (_coments != null)
            {
                foreach (PublicacionesWS.comentario p in _coments)
                {
                    if (_cantidadComent == 2) break;
                    frmComentario plantilla = new frmComentario(p,this);
                    plantilla.TopLevel = false;
                    plantilla.Dock = DockStyle.Top;
                    panelComentarios.Controls.Add(plantilla);
                    panelComentarios.Controls.SetChildIndex(plantilla, 0);
                    plantilla.Visible = true;
                    _cantidadComent++;
                }
            }

        }

        private void btnComentarDinamico_Click(object sender, EventArgs e)
        {
            frmCrearComentario formCrearComentario = new frmCrearComentario(_post, _usuario);

            if (formCrearComentario.ShowDialog() == DialogResult.OK)
            {
                int cantidadComentarios = int.Parse(lblCantidadComentarios.Text) + 1;
                lblCantidadComentarios.Text = cantidadComentarios.ToString();
                panelComentarios.Controls.Clear();
                _comentarioCreado = formCrearComentario.ComentarioCreado;
                _comentarioCreado.usuario.nombre = _usuario.nombre;
                frmComentario plantilla = new frmComentario(_comentarioCreado,this);
                plantilla.TopLevel = false;
                plantilla.Dock = DockStyle.Top;
                panelComentarios.Controls.Add(plantilla);
                panelComentarios.Controls.SetChildIndex(plantilla, 0);
                plantilla.Visible = true;

                _cantidadComent = 0;
                if (_coments != null)
                {
                    foreach (PublicacionesWS.comentario p in _coments)
                    {
                        plantilla = new frmComentario(p,this);
                        plantilla.TopLevel = false;
                        plantilla.Dock = DockStyle.Top;
                        panelComentarios.Controls.Add(plantilla);
                        panelComentarios.Controls.SetChildIndex(plantilla, 0);
                        plantilla.Visible = true;
                        _cantidadComent++;
                        break;
                    }
                }

                _cantidadComent++;
                _daoPost = new PublicacionesWS.PublicacionesWSClient();
                PublicacionesWS.comentario[] _comentarios = _daoPost.listarComentarios(_post.idPost);
                if (_comentarios != null)
                    _coments = new BindingList<PublicacionesWS.comentario>(_comentarios.ToList());
                else
                    _coments = null;
            }

            // formCrearComentario = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarPostGeneral formModificarPost = new frmModificarPostGeneral(_post);

            if (formModificarPost.ShowDialog() == DialogResult.OK) 
            {
                _postModificado = formModificarPost.PostModificado;
                if (_postModificado.idPost != -1)
                {
                    txtContenido.Text = _postModificado.contenido;
                    lblFechaHoraCreacion.Text = _postModificado.fechaRegistro.ToString("dd-MM-yyyy");
                }
                else 
                {
                    this.Visible = false;
                }
            }
        }

        private void lblComentarios_Click(object sender, EventArgs e)
        {
            if (_coments != null)
            {
                int contador = 0;
                bool flag = true;
                foreach (PublicacionesWS.comentario p in _coments)
                {
                    if (flag)
                    {
                        if (contador < _cantidadComent) { contador++; continue; }
                        flag = false;
                    }
                    frmComentario plantilla = new frmComentario(p,this);
                    plantilla.TopLevel = false;
                    plantilla.Dock = DockStyle.Top;
                    panelComentarios.Controls.Add(plantilla);
                    panelComentarios.Controls.SetChildIndex(plantilla, 0);
                    plantilla.Visible = true;
                    _cantidadComent++;
                }
            }
        }

        private void btnMeGustaDinamico_Click(object sender, EventArgs e)
        {
            if (btnMeGustaDinamico.ImageIndex == 0)
            {
                btnMeGustaDinamico.ImageIndex = 1;
                int cantidadLikes = int.Parse(lblCantidadMeGusta.Text) - 1;
                int resultado = _daoPost.disminuirLikes(_post.idPost);
                lblCantidadMeGusta.Text = cantidadLikes.ToString();
                
            }
            else
            {
                btnMeGustaDinamico.ImageIndex = 0;
                int cantidadLikes = int.Parse(lblCantidadMeGusta.Text) + 1;
                int resultado = _daoPost.aumentarLikes(_post.idPost);
                lblCantidadMeGusta.Text = cantidadLikes.ToString();
                
            }
        }

        public void disminuirCantidadComentarios() {
            int cantidadComentarios = int.Parse(lblCantidadComentarios.Text) - 1;
            lblCantidadComentarios.Text = cantidadComentarios.ToString();
        }

        public void actualizarComentarios() {
            _cantidadComent--;

            _daoPost = new PublicacionesWS.PublicacionesWSClient();
            PublicacionesWS.comentario[] _comentarios = _daoPost.listarComentarios(_post.idPost);
            if (_comentarios != null)
                _coments = new BindingList<PublicacionesWS.comentario>(_comentarios.ToList());
            else
                _coments = null;

            if (_coments != null)
            {
                int contador = 0;
                bool flag=true;
                foreach (PublicacionesWS.comentario p in _coments)
                {
                    if (_cantidadComent == 2) break;
                    if (flag)
                    {
                        if (contador < _cantidadComent) { contador++; continue; }
                        flag = false;
                    }
                    frmComentario plantilla = new frmComentario(p, this);
                    plantilla.TopLevel = false;
                    plantilla.Dock = DockStyle.Top;
                    panelComentarios.Controls.Add(plantilla);
                    panelComentarios.Controls.SetChildIndex(plantilla, 0);
                    plantilla.Visible = true;
                    _cantidadComent++;
                }
            }
        }
    }
}

