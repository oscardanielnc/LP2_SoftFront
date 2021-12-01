using LP2Soft.Home;
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
    public partial class frmCambiarContrasenia : Form
    {
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        public frmCambiarContrasenia()
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtActual.UseSystemPasswordChar)
                txtActual.UseSystemPasswordChar = false;
            else txtActual.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtNueva.UseSystemPasswordChar)
                txtNueva.UseSystemPasswordChar = false;
            else txtNueva.UseSystemPasswordChar = true;
        }

        private void btnCambiarCon_Click(object sender, EventArgs e)
        {
            if(!txtActual.Text.Equals("") && !txtNueva.Text.Equals(""))
            {
                if(frmHome.Usuario.contrasenia == Encriptador.GetSHA256(txtActual.Text))
                {
                    frmPrincipal.startLoading();
                    try
                    {
                        _daoUsuario.modificarContrasenia(frmHome.Usuario.idUsuario, Encriptador.GetSHA256(txtNueva.Text));
                        frmHome.Usuario.contrasenia = Encriptador.GetSHA256(txtNueva.Text);
                        frmPrincipal.endLoading();
                        this.Close();
                    } catch(Exception ex)
                    {
                        frmPrincipal.endLoading();
                        MessageBox.Show("No se pudo cambiar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña Actual es incorrecta", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Las contraseñas actual y nueva no pueden estar vacías", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
