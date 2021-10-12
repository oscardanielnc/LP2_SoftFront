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
        public frmProfesor_Perfil()
        {
            InitializeComponent();
            abrirFormulario(new frmProfesor_Perfil_Informacion());
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
    }
}
