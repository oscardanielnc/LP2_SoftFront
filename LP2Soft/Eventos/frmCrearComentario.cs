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
    public partial class frmCrearComentario : Form
    {
        private PublicacionesWS.comentario _comentario;
        private PublicacionesWS.PublicacionesWSClient _daoComentario;
        private PublicacionesWS.post _post;
        private PublicacionesWS.comentario _comentarioCreado;

        public PublicacionesWS.comentario ComentarioCreado { get => _comentarioCreado; }

        public frmCrearComentario(PublicacionesWS.post post)
        {
            InitializeComponent();
            _post = post;
            if (frmHome.Usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(frmHome.Usuario.foto);
                pbPerfil.Image = new Bitmap(ms1);
            }
            _daoComentario = new PublicacionesWS.PublicacionesWSClient();
            _comentario = new PublicacionesWS.comentario();
        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            if (txtComentario.Text != "")
            {
                _comentario.usuario = new PublicacionesWS.usuario();
                _comentario.usuario.idUsuario = frmHome.Usuario.idUsuario;
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
            else {
                MessageBox.Show("Comentario sin contenido", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

