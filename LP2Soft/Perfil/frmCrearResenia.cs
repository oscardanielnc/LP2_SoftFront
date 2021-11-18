using LP2Soft.Home;
using LP2Soft.UsuarioWS;
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

namespace LP2Soft.Perfil
{
    public partial class frmCrearResenia : Form
    {
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private UsuarioWS.resenia _resenia;
        private UsuarioWS.usuario _asesor;
        public frmCrearResenia(UsuarioWS.usuario asesor)
        {
            InitializeComponent();
            txtContenido.Text = "Escribe una reseña a " + asesor.nombre + " " + asesor.apellido;
            _asesor = asesor;
            if (frmHome.Usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(frmHome.Usuario.foto);
                pbPerfil.Image = new Bitmap(ms1);
            }
        }

        public resenia Resenia { get => _resenia; set => _resenia = value; }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            _resenia = new UsuarioWS.resenia();
            _resenia.usuario = new UsuarioWS.usuario();
            _resenia.usuario = frmHome.Usuario;
            _resenia.usuarioReseniado = new UsuarioWS.usuario();
            _resenia.usuarioReseniado = _asesor;            
            _resenia.calificacion = int.Parse(txtCali.Text);
            _resenia.contenido = txtContenido.Text;
            if (frmHome.Usuario.esAdmin == true)
            {
                _resenia.prioridad = 1;
            }
            else
            {
                _resenia.prioridad = 0;
            }
            int resultado = _daoUsuario.insertarReseniaAsesor(_resenia);
            Console.WriteLine(resultado);
            this.DialogResult=DialogResult.OK;
        }

        private void txtContenido_Enter(object sender, EventArgs e)
        {
            if (txtContenido.Text == "Escribe una reseña a " + _asesor.nombre + " " + _asesor.apellido)
            {
                txtContenido.Text = "";
                txtContenido.ForeColor = Color.Black;
            }
        }

        private void txtContenido_Leave(object sender, EventArgs e)
        {
            if (txtContenido.Text == "")
            {
                txtContenido.Text = "Escribe una reseña a " + _asesor.nombre + " " + _asesor.apellido;
                txtContenido.ForeColor = Color.Gray;
            }
        }
    }
}
