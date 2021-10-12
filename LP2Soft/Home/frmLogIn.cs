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
        public frmLogIn()
        {
            InitializeComponent();
        }
        public frmLogIn(Panel panel)
        {
            InitializeComponent();
            _panelPadre = panel;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            formHome.ShowDialog();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            _panelPadre.Controls.Clear();
            frmSignIn frmSignin = new frmSignIn(_panelPadre);
            frmSignin.TopLevel = false;
            _panelPadre.Controls.Add(frmSignin);
            frmSignin.Show();
        }
    }
}
