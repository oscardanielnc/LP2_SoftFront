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
        private Panel _panelPrincipal;
        public frmLogIn()
        {
            InitializeComponent();
        }
        public frmLogIn(Panel panelPadre, Panel panelPrincipal)
        {
            InitializeComponent();
            _panelPadre = panelPadre;
            _panelPrincipal = panelPrincipal;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            _panelPrincipal.Controls.Clear();
            frmHome formHome = new frmHome();
            formHome.TopLevel = false;
            formHome.FormBorderStyle = FormBorderStyle.None;
            _panelPrincipal.Controls.Add(formHome);
            formHome.Show();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            _panelPadre.Controls.Clear();
            frmSignIn frmSignin = new frmSignIn(_panelPadre, _panelPrincipal);
            frmSignin.TopLevel = false;
            _panelPadre.Controls.Add(frmSignin);
            frmSignin.Show();
        }
    }
}
