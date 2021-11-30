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
        private UsuarioWS.usuario _usuario;
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        public frmSignIn()
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmTerminosyCondiciones formTyC = new frmTerminosyCondiciones();
            if (formTyC.ShowDialog() == DialogResult.OK)
            {
                if(!txtCodigo.Text.Equals("") && !txtCorreo.Text.Equals("") && !txtNombre.Text.Equals("")
                     && !txtApellido.Text.Equals("") && !txtContrasenia.Text.Equals("") && !txtRepetirContrasenia.Text.Equals(""))
                {
                    if(txtContrasenia.Text.Equals(txtRepetirContrasenia.Text))
                    {
                        String cad;
                        frmPrincipal.startLoading();
                        _usuario = new UsuarioWS.usuario();
                        _usuario.codigoPUCP = txtCodigo.Text;
                        _usuario.correo = txtCorreo.Text;
                        _usuario.nombre = txtNombre.Text;
                        _usuario.apellido = txtApellido.Text;
                        cad = txtContrasenia.Text;
                        _usuario.contrasenia = Encriptador.GetSHA256(cad);
                        _usuario.fechaNacimiento = dtpFechaNacimiento.Value;
                        _usuario.fechaNacimientoSpecified = true;
                        _usuario.especialidad = "Ing. Informática";
                        _usuario.esAdmin = false;
                        _usuario.esAsesor = false;
                        _usuario.activo = true;
                        _usuario.creditosTotales = 0;

                        int resultado = _daoUsuario.insertarUsuario(_usuario);
                        if(resultado < 0)
                        {
                            frmPrincipal.endLoading();
                            // Falla
                            if (resultado == -10)
                                MessageBox.Show("Este código ya se encuentra registrado", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else if (resultado == -20)
                                MessageBox.Show("Este correo ya se encuentra registrado", "Warning", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show("Ocurrió un error inserperado en el servidor", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _usuario = null;
                        } else
                        {
                            // No hay falla. Registro Exitoso
                            _usuario.idUsuario = resultado;
                            frmPrincipal.abrirFormulario(new frmHome(_usuario));
                            frmPrincipal.endLoading();
                        }
                    } else
                        MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void linkLblRegresarLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLoginSingin.abrirFormulario(new frmLogIn());
        }
    }
}
