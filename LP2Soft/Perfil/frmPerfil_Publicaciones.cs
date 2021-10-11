using LP2Soft.Eventos;
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
    public partial class frmPerfil_Publicaciones : Form
    {
        private static Form _formActivo = null;
        public frmPerfil_Publicaciones()
        {
            InitializeComponent();
            abrirFormulario(new frmPostEvento());
        }
    public void abrirFormulario(Form formulario)
    {
        if (_formActivo != null) _formActivo.Close();
        _formActivo = formulario;
        _formActivo.TopLevel = false;
        _formActivo.FormBorderStyle = FormBorderStyle.None;
        /*_formActivo.Dock = DockStyle.Fill;*/
        panelPost1.Controls.Add(_formActivo);
        _formActivo.Show();
    }
    }
}
