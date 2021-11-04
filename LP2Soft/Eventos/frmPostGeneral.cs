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

        public frmPostGeneral()
        {
            InitializeComponent();
        }

        public frmPostGeneral(PublicacionesWS.postGenerico pp, UsuarioWS.usuario usuario)
        { 

            InitializeComponent();
            _usuario = usuario;
            _post = pp;
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
                frmComentario plantilla = new frmComentario(_comentarioCreado, _usuario);
                plantilla.TopLevel = false;
                plantilla.Dock = DockStyle.Top;
                panelComentarios.Controls.Add(plantilla);
                panelComentarios.Controls.SetChildIndex(plantilla, 0);
                plantilla.Visible = true;
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
            }
        }

        private void lblComentarios_Click(object sender, EventArgs e)
        {

        }

        private void btnMeGustaDinamico_Click(object sender, EventArgs e)
        {
            if (btnMeGustaDinamico.ImageIndex == 0)
            {
                btnMeGustaDinamico.ImageIndex = 1;
                int cantidadLikes = int.Parse(lblCantidadMeGusta.Text) - 1;
                lblCantidadMeGusta.Text = cantidadLikes.ToString();

            }
            else
            {
                btnMeGustaDinamico.ImageIndex = 0;
                int cantidadLikes = int.Parse(lblCantidadMeGusta.Text) + 1;
                lblCantidadMeGusta.Text = cantidadLikes.ToString();
            }
        }
    }
}

