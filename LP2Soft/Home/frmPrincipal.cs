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
        private static Form _formActivo = null;
        private static Panel _panelPrincipal = null;
        public frmPrincipal()
        {
            InitializeComponent();
            _panelPrincipal = panelPrincipal;
            abrirFormulario(new frmLoginSingin());
        }

        public static void abrirFormulario(Form formulario)
        {
            if (_formActivo != null) _formActivo.Close();
            _formActivo = null;
            _formActivo = formulario;
            _formActivo.TopLevel = false;
            _formActivo.FormBorderStyle = FormBorderStyle.None;
            /*_formActivo.Dock = DockStyle.Fill;*/
            _panelPrincipal.Controls.Add(formulario);
            _formActivo.Show();
        }
    }
}
