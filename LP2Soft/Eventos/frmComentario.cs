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
    public partial class frmComentario : Form
    {
        PublicacionesWS.comentario _comentario;
        PublicacionesWS.PublicacionesWSClient _daoComentario;
        frmPostGeneral _post;

        public frmComentario(PublicacionesWS.comentario comentario, frmPostGeneral post)
        {
            InitializeComponent();
            _post = post;
            _daoComentario = new PublicacionesWS.PublicacionesWSClient();
            _comentario = comentario;
            lblNombre.Text = comentario.usuario.nombre;
            lblComentario.Text = comentario.comentario1;
            if (comentario.usuario.idUsuario != frmHome.Usuario.idUsuario) btnModificar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _post.disminuirCantidadComentarios();
            this.Visible = false;
            int resultado = _daoComentario.eliminarComentario(_comentario);
            if(resultado!=1) MessageBox.Show("Error al borrar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _post.actualizarComentarios();
        }
    }
}
