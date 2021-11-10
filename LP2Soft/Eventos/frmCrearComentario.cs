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
    public partial class frmCrearComentario : Form
    {
        PublicacionesWS.comentario _comentario;
        PublicacionesWS.PublicacionesWSClient _daoComentario;
        PublicacionesWS.postGenerico _post;
        UsuarioWS.usuario _usuario;
        PublicacionesWS.comentario _comentarioCreado;

        public PublicacionesWS.comentario ComentarioCreado { get => _comentarioCreado; }

        public frmCrearComentario(PublicacionesWS.postGenerico post, UsuarioWS.usuario usuario)
        {
            InitializeComponent();
            _post = post;
            _usuario = usuario;
            if (_usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(_usuario.foto);
                pbPerfil.Image = new Bitmap(ms1);
            }
            _daoComentario = new PublicacionesWS.PublicacionesWSClient();
            _comentario = new PublicacionesWS.comentario();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            _comentario.usuario = new PublicacionesWS.usuario();
            _comentario.usuario.idUsuario = _usuario.idUsuario;
            _comentario.post = new PublicacionesWS.postGenerico();
            _comentario.post.idPost = _post.idPost;
            _comentario.comentario1 = txtComentario.Text;

            int resultado;

            resultado = _daoComentario.insertarComentario(_comentario);

            if (resultado != 0)
            {
                DialogResult = DialogResult.OK;
                _comentario.idComentario = resultado;
                _comentarioCreado = _comentario;
                
            }
            else
            {
                MessageBox.Show("Error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

