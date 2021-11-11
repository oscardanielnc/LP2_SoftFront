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
    public partial class frmCrearPostGeneral : Form
    {
        UsuarioWS.usuario _usuario;
        PublicacionesWS.postGenerico _postGenerico;
        PublicacionesWS.PublicacionesWSClient _daoPost;
        PublicacionesWS.postGenerico _postCreado;

        public PublicacionesWS.postGenerico PostCreado { get => _postCreado; }

        public frmCrearPostGeneral()
        {
            InitializeComponent();
        }

        public frmCrearPostGeneral(UsuarioWS.usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            if (_usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(_usuario.foto);
                pbPerfil.Image = new Bitmap(ms1);
            }
            lblNombre.Text = _usuario.nombre + " " + _usuario.apellido;
            _postGenerico = new PublicacionesWS.postGenerico();
            _postGenerico.usuario = new PublicacionesWS.usuario();
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            int resultado;
            _postGenerico.usuario.idUsuario = _usuario.idUsuario;
            if (_usuario.esAdmin == true) _postGenerico.prioridad = 1;
            else _postGenerico.prioridad = 0;
            _postGenerico.contenido = txtContenido.Text;

            // En un usuario falta un atributo para saber si es un grupo o alumno
            //_postGenerico.prioridad = 1;
            //_postGenerico.fechaRegistro = DateTime.Now;

            resultado = _daoPost.insertarPost(_postGenerico);

            if (resultado != 0)
            {
                _postGenerico.idPost = resultado;
                _postCreado = _postGenerico;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
