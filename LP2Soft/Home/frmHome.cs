﻿using LP2Soft.Asesor;
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
        private MenuHome _menuSeleccionado;
        private static Label _lblNombreUsuario = null;

        private static UsuarioWS.usuario _usuario;
        public static UsuarioWS.usuario Usuario { get => _usuario; set => _usuario = value; }
        public frmHome()
        {
            InitializeComponent();
            _panelContenido = panelContenido;
            abrirFormularioHome(new frmHomePage(), MenuHome.Novedades); // sección de novedades por defecto
        }
        public frmHome(UsuarioWS.usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            _lblNombreUsuario = lblNombreUsuario;
            _panelContenido = panelContenido;
            abrirFormularioHome(new frmHomePage(), MenuHome.Novedades); // sección de novedades por defecto

            actualizarInfoPantallas();
        }
        public static void actualizarInfoPantallas ()
        {
            _lblNombreUsuario.Text = _usuario.nombre + " " + _usuario.apellido + " - " + _usuario.idUsuario;
            // aquí viene la foto
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
                _menuSeleccionado = menuSeleccionar;
                abrirFormulario(formulario);
        }


        public void btnPerfil_Click(object sender, EventArgs e) =>
            abrirFormularioHome(new frmPerfil(), MenuHome.Perfil);


        public void btnNovedades_Click(object sender, EventArgs e) =>
            abrirFormularioHome(new frmHomePage(), MenuHome.Novedades);

        public void btnCursos_Click(object sender, EventArgs e)
        {
            if (subPanelCursos.Visible == false)
                subPanelCursos.Visible = true;
            else subPanelCursos.Visible = false;
        }

        public void btnTodosMisCursos_Click(object sender, EventArgs e) => 
            abrirFormularioHome(new frmCursosHome(), MenuHome.CursosTodos);
        private void btnCursosFavoritos_Click(object sender, EventArgs e) =>
            abrirFormularioHome(new frmHomeFavoritos(), MenuHome.CursosFavoritos);

        public void btnMensajes_Click(object sender, EventArgs e) =>
            abrirFormularioHome(new frmMensajes(/*this*/), MenuHome.Mensajes);

        public void btnEventos_Click(object sender, EventArgs e)
        {
            if (subPanelEventos.Visible == false)
                subPanelEventos.Visible = true;
            else subPanelEventos.Visible = false;
        }

        public void btnVerEventos_Click(object sender, EventArgs e) =>
            abrirFormularioHome(new frmVerEventos(), MenuHome.VerEventos);

        public void btnEventosAgendados_Click(object sender, EventArgs e) =>
            abrirFormularioHome(new frmEventosAgendados(), MenuHome.EventosAgendados);

        private void btnMisEventos_Click(object sender, EventArgs e) =>
            abrirFormularioHome(new frmMisPublicaciones(), MenuHome.MisEventos);
        public void btnAsesores_Click(object sender, EventArgs e) =>
            abrirFormularioHome(new frmBuscarAsesor(this), MenuHome.Asesores);

        public void btnProfesores_Click(object sender, EventArgs e) =>
            abrirFormularioHome(new frmProfesores(), MenuHome.Profesores);

        public void btnCerrar_Click(object sender, EventArgs e) =>
            frmPrincipal.abrirFormulario(new frmLoginSingin());

        public void btnNotificaciones_Click(object sender, EventArgs e) =>
            abrirFormularioHome(new frmNotificaciones(), MenuHome.Notificaciones);

    }
}
