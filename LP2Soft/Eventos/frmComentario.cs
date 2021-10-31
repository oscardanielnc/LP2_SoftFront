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
        public frmComentario(ComentarioWS.comentario comentario, UsuarioWS.usuario usuario)
        {
            InitializeComponent();
            lblNombre.Text = usuario.nombre;
            lblComentario.Text = comentario.comentario1;
        }
    }
}
