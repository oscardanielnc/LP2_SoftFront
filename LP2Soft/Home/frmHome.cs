using LP2Soft.Asesor;
using LP2Soft.Cursos;
using LP2Soft.Eventos;
using LP2Soft.Perfil;
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

        public frmHome()
        {
            InitializeComponent();
            abrirFormulario(new frmPerfil());
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
            abrirFormulario(new frmCursosHome());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmPerfil());
        }

        private void btnNovedades_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmHomePage());
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmVerEventos());
        }

        private void btnAsesores_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmBuscarAsesor());
        }
    }
}
