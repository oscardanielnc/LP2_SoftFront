using LP2Soft.Tarjetas;
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
    public partial class frmProfesores : Form
    {
        private BindingList<CursosWS.profesor> _profesoresBusqueda;
        private CursosWS.CursosWSClient _daoProfesor;
        private CursosWS.profesor _profesor;
        private static Form _formActivo = null;
        private static Panel _panelContenido = null;
        public frmProfesores()
        {
            
            InitializeComponent();
            _daoProfesor = new CursosWS.CursosWSClient();
            renderizarBusqueda(" ");
        }
        public frmProfesores(CursosWS.profesor profesor)
        {
            _profesor = profesor;
            InitializeComponent();
            _daoProfesor = new CursosWS.CursosWSClient();

            renderizarBusqueda(" ");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            frmProfesor_Perfil formPerfil = new frmProfesor_Perfil();
            formPerfil.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelProfesores.Controls.Clear();
            renderizarBusqueda(txtProfesores.Text);
        }

        private void renderizarBusqueda(string nombre )
        {
            _profesoresBusqueda = null;
            lblInfo.Text = "Buscando...";
            try
            {
                _profesoresBusqueda = new BindingList<CursosWS.profesor>(_daoProfesor.listarProfesoresNombre(nombre));
                //renderizamos las tarjetas
                int i = 0;
                foreach (CursosWS.profesor p in _profesoresBusqueda)
                {
                    tarjProfesor tProfesor = new tarjProfesor(p);
                    tProfesor.TopLevel = false;
                    tProfesor.Location = generarCoordenadas(i);
                    /*tUsuario.Dock = DockStyle.Top;*/
                    panelProfesores.Controls.Add(tProfesor);
                    panelProfesores.Controls.SetChildIndex(tProfesor, 0);
                    tProfesor.Visible = true;
                    i++;
                }
                lblInfo.Text = "Se han encontrado " + _profesoresBusqueda.Count + " profesores.";
            }
            catch (Exception ex)
            {
                lblInfo.Text = "No se han encontrado al profesor " + nombre;
            }
        }

        private Point generarCoordenadas(int i)
        {
            int x = (i % 4) * 185;
            int y = ((int)i / 4) * 205;
            return new Point(x, y);
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
    }
}
