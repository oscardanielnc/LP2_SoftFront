using LP2Soft.Home;
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
    public partial class frmPostGeneral : Form
    {
        UsuarioWS.usuario _usuario;
        PublicacionesWS.postGenerico _post;
        PublicacionesWS.comentario _comentarioCreado;
        public frmPostGeneral()
        {
            InitializeComponent();
        }

        public frmPostGeneral(PublicacionesWS.postGenerico pp, UsuarioWS.usuario usuario)
        { 

            InitializeComponent();
            _usuario = usuario;
            _post = pp;
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
                
            }
        }

        private void lblComentarios_Click(object sender, EventArgs e)
        {

        }
    }
}

