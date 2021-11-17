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
        private PublicacionesWS.comentario _comentario;
        private PublicacionesWS.PublicacionesWSClient _daoComentario;
        private frmPostGeneral _post=null;
        private frmPostEvento _evento=null;

        public frmComentario(PublicacionesWS.comentario comentario, frmPostGeneral post)
        {
            InitializeComponent();
            _post = post;
            _daoComentario = new PublicacionesWS.PublicacionesWSClient();
            _comentario = comentario;
            lblNombre.Text = comentario.usuario.nombre;
            lblComentario.Text = comentario.comentario1;
            if (comentario.usuario.idUsuario != frmHome.Usuario.idUsuario && frmHome.Usuario.esAdmin==false) btnModificar.Visible = false;
        }

        public frmComentario(PublicacionesWS.comentario comentario, frmPostEvento post)
        {
            InitializeComponent();
            _evento = post;
            _daoComentario = new PublicacionesWS.PublicacionesWSClient();
            _comentario = comentario;
            lblNombre.Text = comentario.usuario.nombre;
            lblComentario.Text = comentario.comentario1;
            if (comentario.usuario.idUsuario != frmHome.Usuario.idUsuario) btnModificar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int resultado;
            if (_post == null)
            {
                _evento.disminuirCantidadComentarios();
                this.Visible = false;
                resultado = _daoComentario.eliminarComentario(_comentario);
                if (resultado != 1) MessageBox.Show("Error al borrar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _evento.actualizarComentarios();
            }
            else
            {
                _post.disminuirCantidadComentarios();
                this.Visible = false;
                resultado = _daoComentario.eliminarComentario(_comentario);
                if (resultado != 1) MessageBox.Show("Error al borrar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _post.actualizarComentarios();
            }

        }
    }
}
