using LP2Soft.Asesor;
using LP2Soft.Cursos;
using LP2Soft.Enumerados;
using LP2Soft.Eventos;
using LP2Soft.Mensajes;
using LP2Soft.Notificaciones;
using LP2Soft.Perfil;
using LP2Soft.Profesor;
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

namespace LP2Soft.Home
{
    public partial class frmHome : Form
    {
        private static Form _formActivo = null;
        private static Panel _panelContenido = null;
        private static Label _lblNombreUsuario = null;
        private static PictureBox _imgUsuario = null;

        private static UsuarioWS.usuario _usuario;
        public static UsuarioWS.usuario Usuario { get => _usuario; set => _usuario = value; }
        public frmHome(UsuarioWS.usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            _lblNombreUsuario = lblNombreUsuario;
            _imgUsuario = imgUsuario;
            _panelContenido = panelContenido;
            /*abrirFormularioHome(new frmHomePage(_usuario), MenuHome.Novedades);*/ // sección de novedades por defecto
            abrirFormularioHome(new frmPerfil(_usuario), MenuHome.Perfil);
            generarNotificacionEventoParaHoy();

            actualizarInfoPantallas(usuario);
        }
        private void generarNotificacionEventoParaHoy()
        {
            try
            {
                PublicacionesWS.PublicacionesWSClient _daoPublicaciones = new PublicacionesWS.PublicacionesWSClient();
                BindingList<PublicacionesWS.evento> listaEventosHoy = new BindingList < PublicacionesWS.evento > (
                    _daoPublicaciones.listarEventosAgendadosFecha(frmHome.Usuario.idUsuario, DateTime.Now.ToString("dd-MM-yyyy")));

                if (listaEventosHoy != null)
                {
                    NotificacionesWS.NotificacionesWSClient _daoNotificaciones = new NotificacionesWS.NotificacionesWSClient();
                    BindingList<NotificacionesWS.notificacion> listaNotificaciones = new BindingList<NotificacionesWS.notificacion>(
                        _daoNotificaciones.listarNotificaciones(frmHome.Usuario.idUsuario));
                    foreach(PublicacionesWS.evento e in listaEventosHoy)
                    {
                        if (_daoNotificaciones.existeEventoAgendado(frmHome.Usuario.idUsuario, e.idPost) != 1)
                            _daoNotificaciones.insertarNotificacion(frmHome.Usuario.idUsuario, 3, 0, -1, -1, e.idPost, e.idPost);

                    }
                }
            } catch (Exception ex)
            {

            }
        }
        public static void actualizarInfoPantallas(UsuarioWS.usuario usuario)
        {
            // actualizamos en nuestro usuario de Home con la nueva información
            _usuario.nombre = usuario.nombre; //
            _usuario.apellido = usuario.apellido; //
            _usuario.fechaNacimiento = usuario.fechaNacimiento; ; //
            _usuario.descripcion = usuario.descripcion; //
            _usuario.contrasenia = usuario.contrasenia; ; //
            _usuario.foto = usuario.foto; ; //


            _lblNombreUsuario.Text = _usuario.nombre + " " + _usuario.apellido;
            int tamanio = _lblNombreUsuario.Size.Height;
            _lblNombreUsuario.Location = new Point(840, ((int)(62 - tamanio) / 2));

            if (_usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(_usuario.foto);
                _imgUsuario.Image = new Bitmap(ms1);
            }
        }
        private void inicializarColorBotones()
        {
            btnNovedades.BackColor = Color.FromArgb(28, 103, 179);
            btnPerfil.BackColor = Color.FromArgb(28, 103, 179);
            btnTodosMisCursos.BackColor = Color.FromArgb(28, 103, 179);
            btnCursosFavoritos.BackColor = Color.FromArgb(28, 103, 179);
            btnVerEventos.BackColor = Color.FromArgb(28, 103, 179);
            btnEventosAgendados.BackColor = Color.FromArgb(28, 103, 179);
            btnMisEventos.BackColor = Color.FromArgb(28, 103, 179);
            btnAsesores.BackColor = Color.FromArgb(28, 103, 179);
            btnProfesores.BackColor = Color.FromArgb(28, 103, 179);
        }

        public static void abrirFormulario(Form formulario)
        {
            if (_formActivo != null) _formActivo.Close();
            _formActivo = null;
            _formActivo = formulario;
            _formActivo.TopLevel = false; // para que el form no se salga, sino que se muestre dentro
            _formActivo.FormBorderStyle = FormBorderStyle.None; // para quitar el borde, en caso lo tuviera
            _formActivo.Dock = DockStyle.Fill; // para que el contenido se ajuste a todo el panel
            _panelContenido.Controls.Add(_formActivo); // para que el contenedor contenga el formulario
            _formActivo.Show(); // ambos formularios deben ser independientes, no se cancelen sus controles
        }
        private Button obtenerBoton(MenuHome menuSeleccionar)
        {
            switch (menuSeleccionar)
            {
                case MenuHome.Perfil: return btnPerfil;
                case MenuHome.CursosFavoritos: return btnCursosFavoritos;
                case MenuHome.CursosTodos: return btnTodosMisCursos;
                case MenuHome.VerEventos: return btnVerEventos;
                case MenuHome.EventosAgendados: return btnEventosAgendados;
                case MenuHome.MisEventos: return btnMisEventos;
                case MenuHome.Asesores: return btnAsesores;
                case MenuHome.Profesores: return btnProfesores;
                default: return btnNovedades;
            }
        }
        public void abrirFormularioHome(Form formulario, MenuHome menuSeleccionar)
        {
            inicializarColorBotones();
            obtenerBoton(menuSeleccionar).BackColor = Color.FromArgb(0, 45, 86);
            abrirFormulario(formulario);
        }


        public void btnPerfil_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            abrirFormularioHome(new frmPerfil(_usuario), MenuHome.Perfil);
            frmPrincipal.endLoading();
        }


        public void btnNovedades_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            abrirFormularioHome(new frmHomePage(_usuario), MenuHome.Novedades);
            frmPrincipal.endLoading();
        }

        public void btnCursos_Click(object sender, EventArgs e)
        {
            if (subPanelCursos.Visible == false)
                subPanelCursos.Visible = true;
            else subPanelCursos.Visible = false;
        }

        public void btnTodosMisCursos_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            abrirFormularioHome(new frmCursos_Home(_usuario.idUsuario), MenuHome.CursosTodos);
            frmPrincipal.endLoading();
        }
        private void btnCursosFavoritos_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            abrirFormularioHome(new frmCursos_Favoritos(), MenuHome.CursosFavoritos);
            frmPrincipal.endLoading();
        }

        public void btnMensajes_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            abrirFormularioHome(new frmMensajes(), MenuHome.Mensajes);
            frmPrincipal.endLoading();
        }

        public void btnEventos_Click(object sender, EventArgs e)
        {
            if (subPanelEventos.Visible == false)
                subPanelEventos.Visible = true;
            else subPanelEventos.Visible = false;
        }

        public void btnVerEventos_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            abrirFormularioHome(new frmVerEventos(), MenuHome.VerEventos);
            frmPrincipal.endLoading();
        }

        public void btnEventosAgendados_Click(object sender, EventArgs e) {
            frmPrincipal.startLoading();
            abrirFormularioHome(new frmEventosAgendados(), MenuHome.EventosAgendados);
            frmPrincipal.endLoading();
        }

        private void btnMisEventos_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            abrirFormularioHome(new frmMisPublicaciones(), MenuHome.MisEventos);
            frmPrincipal.endLoading();
        }
        public void btnAsesores_Click(object sender, EventArgs e) {
            frmPrincipal.startLoading();
            abrirFormularioHome(new frmBuscarAsesor(this), MenuHome.Asesores);
            frmPrincipal.endLoading();
        }

        public void btnProfesores_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            abrirFormularioHome(new frmProfesores(), MenuHome.Profesores);
            frmPrincipal.endLoading();
        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            frmPrincipal.abrirFormulario(new frmLoginSingin());
            frmPrincipal.endLoading();
        }

        public void btnNotificaciones_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            abrirFormularioHome(new frmNotificaciones(), MenuHome.Notificaciones);
            frmPrincipal.endLoading();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBusqueda.Text;
            if (!textoBusqueda.Equals(""))
            {
                frmPrincipal.startLoading();
                abrirFormularioHome(new frmBusquedaUsuarios(textoBusqueda), MenuHome.BuscarUsuarios); //
                frmPrincipal.endLoading();
            }
            else
                MessageBox.Show("Debe escribir un nombre u código PUCP en el buscador", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Efecto Placeholder
        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "Buscar a un usuario")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }
        }
        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                txtBusqueda.Text = "Buscar a un usuario";
                txtBusqueda.ForeColor = Color.Gray;
            }
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                btnBuscar_Click(sender, e);
        }
    }
}
