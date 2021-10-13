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
    public partial class frmSignIn : Form
    {
        private Panel _panelPadre;
        private frmPrincipal _formPrincipal;

        public frmSignIn(Panel panelPadre, frmPrincipal formPrincipal)
        {
            InitializeComponent();
            _panelPadre = panelPadre;
            _formPrincipal = formPrincipal;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            _formPrincipal.PanelPrincipal.Controls.Clear();
            frmHome formHome = new frmHome();
            formHome.TopLevel = false;
            formHome.FormBorderStyle = FormBorderStyle.None;
            _formPrincipal.PanelPrincipal.Controls.Add(formHome);
            formHome.Show();
        }


        private void linkLblRegresarLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _panelPadre.Controls.Clear();
            frmLogIn frmLogin = new frmLogIn(_panelPadre, _formPrincipal);
            frmLogin.TopLevel = false;
            _panelPadre.Controls.Add(frmLogin);
            frmLogin.Show();
        }
    }
}
