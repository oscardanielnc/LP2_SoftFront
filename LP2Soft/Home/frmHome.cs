using LP2Soft.Asesor;
using LP2Soft.Cursos;
using LP2Soft.Enumerados;
using LP2Soft.Eventos;
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
        private static MenuHome _menuSeleccionado;

        public frmHome()
        {
            InitializeComponent();
            btnNovedades.BackColor = System.Drawing.Color.FromArgb(0, 45, 86);
            _menuSeleccionado = MenuHome.Novedades; // se muestra el menu de perfil por defecto
            abrirFormulario(new frmHomePage());
        }
        private void inicializarColorBotones()
        {
            btnNovedades.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
            btnPerfil.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
            btnTodosMisCursos.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
            btnEventos.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
            btnAsesores.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
            btnProfesores.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
        }

        public void abrirFormulario(Form formulario)
        {
            if (_formActivo != null) _formActivo.Close();
            _formActivo = formulario;
            _formActivo.TopLevel = false; // para que el form no se salga, sino que se muestre dentro
            _formActivo.FormBorderStyle = FormBorderStyle.None; // para quitar el borde, en caso lo tuviera
            _formActivo.Dock = DockStyle.Fill; // para que el contenido se ajuste a todo el panel
            panelContenido.Controls.Add(_formActivo); // para que el contenedor contenga el formulario
            _formActivo.Show(); // ambos formularios deben ser independientes, no se cancelen sus controles
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            if (subPanelCursos.Visible == false)
                subPanelCursos.Visible = true;
            else subPanelCursos.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuHome.Perfil)
            {
                inicializarColorBotones();
                btnPerfil.BackColor = System.Drawing.Color.FromArgb(0, 45, 86);
                _menuSeleccionado = MenuHome.Perfil;
                abrirFormulario(new frmPerfil());
            }
        }

        private void btnNovedades_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuHome.Novedades)
            {
                inicializarColorBotones();
                btnNovedades.BackColor = System.Drawing.Color.FromArgb(0, 45, 86);
                _menuSeleccionado = MenuHome.Novedades;
                abrirFormulario(new frmHomePage());
            }
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuHome.Eventos)
            {
                inicializarColorBotones();
                btnEventos.BackColor = System.Drawing.Color.FromArgb(0, 45, 86);
                _menuSeleccionado = MenuHome.Eventos;
                abrirFormulario(new frmVerEventos());
            }
        }

        private void btnAsesores_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuHome.Asesores)
            {
                inicializarColorBotones();
                btnAsesores.BackColor = System.Drawing.Color.FromArgb(0, 45, 86);
                _menuSeleccionado = MenuHome.Asesores;
                abrirFormulario(new frmBuscarAsesor());
            }
        }

        private void btnTodosMisCursos_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuHome.CursosTodos)
            {
                inicializarColorBotones();
                btnTodosMisCursos.BackColor = System.Drawing.Color.FromArgb(0, 45, 86);
                _menuSeleccionado = MenuHome.Asesores;
                abrirFormulario(new frmCursosHome());
            }
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuHome.Profesores)
            {
                inicializarColorBotones();
                btnProfesores.BackColor = System.Drawing.Color.FromArgb(0, 45, 86);
                _menuSeleccionado = MenuHome.Profesores;
                abrirFormulario(new frmProfesores());
            }
        }
    }
}
