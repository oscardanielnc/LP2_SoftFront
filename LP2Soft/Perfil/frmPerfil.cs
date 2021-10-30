using LP2Soft.Enumerados;
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

namespace LP2Soft.Perfil
{
    public partial class frmPerfil : Form
    {
        private static Form _formActivo = null;
        private static MenuPerfil _menuSeleccionado;
        private UsuarioWS.usuario _usuario;
        public frmPerfil(UsuarioWS.usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            btnInformacion.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
            _menuSeleccionado = MenuPerfil.Informacion; // se muestra el menu de información por defecto
            actualizarPantallas();
            abrirFormulario(new frmPerfil_Informacion(_usuario));
        }
        private void actualizarPantallas()
        {
            lblTituloNombre.Text = _usuario.nombre + " " + _usuario.apellido;
            // aquí viene la foto
        }
        public void abrirFormulario(Form formulario)
        {
            if (_formActivo != null) _formActivo.Close();
            _formActivo = null;
            _formActivo = formulario;
            _formActivo.TopLevel = false;
            _formActivo.FormBorderStyle = FormBorderStyle.None;
            /*_formActivo.Dock = DockStyle.Fill;*/
            panelContenido.Controls.Add(_formActivo);
            _formActivo.Show();
        }
        private void inicializarColorBotones()
        {
            btnInformacion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btnPublicaciones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btnAmigos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btnCursos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btnResenias.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        }
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if(_menuSeleccionado != MenuPerfil.Informacion)
            {
                inicializarColorBotones();
                btnInformacion.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuPerfil.Informacion;
                abrirFormulario(new frmPerfil_Informacion(_usuario));
            }
        }

        private void btnPublicaciones_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuPerfil.Publicaciones)
            {
                inicializarColorBotones();
                btnPublicaciones.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuPerfil.Publicaciones;
                abrirFormulario(new frmPerfil_Publicaciones());
            }
        }

        private void btnAmigos_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuPerfil.Amigos)
            {
                inicializarColorBotones();
                btnAmigos.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuPerfil.Amigos;
                abrirFormulario(new frmPerfil_Amigos());
            }
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuPerfil.Cursos)
            {
                inicializarColorBotones();
                btnCursos.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuPerfil.Cursos;
                abrirFormulario(new frmPerfil_CursosAsesorados());
            }
        }

        private void btnResenias_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuPerfil.Resenias)
            {
                inicializarColorBotones();
                btnResenias.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuPerfil.Resenias;
                abrirFormulario(new frmPerfil_Resenias());
            }
        }
    }
}
