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
        public frmSignIn()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmPrincipal.abrirFormulario(new frmHome());
        }


        private void linkLblRegresarLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLoginSingin.abrirFormulario(new frmLogIn());
        }
    }
}
