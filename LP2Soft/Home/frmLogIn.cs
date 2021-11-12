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
        private UsuarioWS.usuario _usuario;
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        public frmLogIn()
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correoCodigo = txtCorreoCodigo.Text;
            if(!correoCodigo.Equals(""))
            {
                string password = txtContrasenia.Text;
                if(!password.Equals(""))
                {
                    int n;
                    int isCode= (Int32.TryParse(correoCodigo, out n)) ? 1 : 0;

                    // Pantalla de carga
                    frmPrincipal.startLoading();
                    _usuario = _daoUsuario.mostrarUsuario(correoCodigo, isCode);

                    if (_usuario != null)
                    {
                        if(_usuario.contrasenia.Equals(password))
                        {
                            frmPrincipal.abrirFormulario(new frmHome(_usuario));
                            frmPrincipal.endLoading();
                        }
                        else
                        {
                            frmPrincipal.endLoading();
                            MessageBox.Show("El usuario y la contraseña no coinciden", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _usuario = null;
                        }
                    } else
                    {
                        frmPrincipal.endLoading();
                        MessageBox.Show("El usuario ingresado no existe en la Base de datos", "Warning", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else
                    MessageBox.Show("Ingrese su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
                MessageBox.Show("Ingrese su correo o CódigoPUCP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmLoginSingin.abrirFormulario(new frmSignIn());
        }
    }
}
