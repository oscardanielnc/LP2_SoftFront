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
    public partial class frmPrincipal : Form
    {
        private Form _formActivo = null;
        private Panel _panelPrincipal;
        public frmPrincipal()
        {
            InitializeComponent();
            abrirFormulario(new frmLoginSingin(this));
            _panelPrincipal = panelPrincipal;
        }

        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }

        public void abrirFormulario(Form formulario)
        {
            if (_formActivo != null) _formActivo.Close();
            _formActivo = formulario;
            _formActivo.TopLevel = false;
            _formActivo.FormBorderStyle = FormBorderStyle.None;
            /*_formActivo.Dock = DockStyle.Fill;*/
            panelPrincipal.Controls.Add(_formActivo);
            _formActivo.Show();
        }
    }
}
