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
            string codigoPucp = txtCodigo.Text;
            string correo = txtCorreo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string contrasenia1 = txtContrasenia.Text;
            string contrasenia2 = txtRepetirContrasenia.Text;
            string formatofecha = dtpFechaNacimiento.Value.ToString("dd-MM-yyyy");
            DateTime fechaNacimiento = DateTime.Parse(formatofecha);

            if(!codigoPucp.Equals("") && !correo.Equals("") && !nombre.Equals("")
                 && !apellido.Equals("") && !contrasenia1.Equals("") && !contrasenia2.Equals(""))
            {
                if(contrasenia1.Equals(contrasenia2))
                {
                    _usuario = new UsuarioWS.usuario();
                    _usuario.codigoPUCP = codigoPucp;
                    _usuario.correo = correo;
                    _usuario.nombre = nombre;
                    _usuario.apellido = apellido;
                    _usuario.contrasenia = contrasenia1;
                    _usuario.fechaNacimiento = fechaNacimiento;
                    _usuario.especialidad = "Ing. Informática";
                    _usuario.esAdmin = false;
                    _usuario.esAsesor = false;
                    _usuario.activo = true;
                    _usuario.creditosTotales = 0;

                    int resultado = _daoUsuario.insertarUsuario(_usuario);
                    if(resultado < 0)
                    {
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
                    }
                } else
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void linkLblRegresarLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLoginSingin.abrirFormulario(new frmLogIn());
        }
    }
}
