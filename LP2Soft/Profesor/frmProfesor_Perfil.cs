using LP2Soft.Enumerados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Profesor
{
    public partial class frmProfesor_Perfil : Form
    {
        private static Form _formActivo = null;
        private static MenuProfesor _menuSeleccionado;
        private CursosWS.profesor _profesor;
        private bool _propio;
        public frmProfesor_Perfil()
        {
            InitializeComponent();
        }
        public frmProfesor_Perfil(CursosWS.profesor profesor)
        {
            _profesor = profesor;
            InitializeComponent();
            btnInformacion.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
            lblTituloNombre.Text = profesor.nombre;
            _menuSeleccionado = MenuProfesor.Informacion;
            abrirFormulario(new frmProfesor_Perfil_Informacion(_profesor));
        }
        public void abrirFormulario(Form formulario)
        {
            if (_formActivo != null) _formActivo.Close();
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
            btnCursos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btnResenias.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuProfesor.Cursos)
            {
                inicializarColorBotones();
                btnCursos.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuProfesor.Cursos;
                abrirFormulario(new frmProfesor_Perfil_Cursos(_profesor));
            }

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuProfesor.Informacion)
            {
                inicializarColorBotones();
                btnInformacion.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuProfesor.Informacion;
                abrirFormulario(new frmProfesor_Perfil_Informacion(_profesor));
            }
        }

        private void btnResenias_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuProfesor.Resenias)
            {
                inicializarColorBotones();
                btnResenias.BackColor = System.Drawing.Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuProfesor.Resenias;
                abrirFormulario(new frmProfesor_Perfil_Reseña(_profesor));
            }
        }
    }
}
