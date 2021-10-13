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
    public partial class frmLogIn : Form
    {
        private Panel _panelPadre;
        private frmPrincipal _formPrincipal;
        public frmLogIn()
        {
            InitializeComponent();
        }

        public frmLogIn(Panel panelPadre, frmPrincipal formPrincipal)
        {
            InitializeComponent();
            _panelPadre = panelPadre;
            _formPrincipal = formPrincipal;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            _formPrincipal.abrirFormulario(new frmHome(_formPrincipal));
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            _panelPadre.Controls.Clear();
            frmSignIn frmSignin = new frmSignIn(_panelPadre, _formPrincipal);
            frmSignin.TopLevel = false;
            _panelPadre.Controls.Add(frmSignin);
            frmSignin.Show();
        }
    }
}
