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
        public frmSignIn()
        {
            InitializeComponent();
        }
        public frmSignIn(Panel panel)
        {
            InitializeComponent();
            _panelPadre = panel;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            formHome.ShowDialog();
        }

        private void linkLblRegresarLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _panelPadre.Controls.Clear();
            frmLogIn frmLogin = new frmLogIn(_panelPadre);
            frmLogin.TopLevel = false;
            _panelPadre.Controls.Add(frmLogin);
            frmLogin.Show();
        }
    }
}
