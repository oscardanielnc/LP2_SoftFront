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
    public partial class frmCrearComentario : Form
    {
        ComentarioWS.comentario _comentario;
        ComentarioWS.ComentarioWSClient _daoComentario;
        PublicacionesWS.postGenerico _post;
        UsuarioWS.usuario _usuario;
        ComentarioWS.comentario _comentarioCreado;

        public ComentarioWS.comentario ComentarioCreado { get => _comentarioCreado; }

        public frmCrearComentario(PublicacionesWS.postGenerico post, UsuarioWS.usuario usuario)
        {
            InitializeComponent();
            _post = post;
            _usuario = usuario;
            _daoComentario = new ComentarioWS.ComentarioWSClient();
            _comentario = new ComentarioWS.comentario();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            _comentario.usuario = new ComentarioWS.usuario();
            _comentario.usuario.idUsuario = _usuario.idUsuario;
            _comentario.post = new ComentarioWS.post();
            _comentario.post.idPost = _post.idPost;
            _comentario.comentario1 = txtComentario.Text;

            int resultado;

            resultado = _daoComentario.insertarComentario(_comentario);

            if (resultado != 0)
            {
                DialogResult = DialogResult.OK;
                _comentarioCreado = _comentario;
            }
            else
            {
                MessageBox.Show("Error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

