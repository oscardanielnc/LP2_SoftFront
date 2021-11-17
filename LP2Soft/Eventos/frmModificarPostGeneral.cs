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
    public partial class frmModificarPostGeneral : Form
    {
        private PublicacionesWS.PublicacionesWSClient _daoPost;
        private PublicacionesWS.postGenerico _post;
        private PublicacionesWS.postGenerico _postModificado;

        public PublicacionesWS.postGenerico PostModificado { get => _postModificado; }

        public frmModificarPostGeneral(PublicacionesWS.postGenerico post)
        {
            InitializeComponent();
            _post = post;
            if (frmHome.Usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(frmHome.Usuario.foto);
                pbPerfil.Image = new Bitmap(ms1);
            }
            lblNombre.Text = post.usuario.nombre;
            txtContenido.Text = post.contenido;
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _post.contenido = txtContenido.Text; 
            int resultado = _daoPost.modificarPost(_post);
            if (resultado == 1)
            {
                _postModificado = _post;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Error al modificar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = _daoPost.eliminarPost(_post);
            if (resultado == 1)
            {
                _postModificado = new PublicacionesWS.postGenerico();
                _postModificado.idPost = -1;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Error el eliminar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
