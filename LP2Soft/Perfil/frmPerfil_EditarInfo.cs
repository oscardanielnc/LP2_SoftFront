﻿using LP2Soft.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Perfil
{
    public partial class frmPerfil_EditarInfo : Form
    {
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private UsuarioWS.usuario _usuarioActual;
        private UsuarioWS.usuario _usuarioModificado;

        private string _rutaFoto = "";
        public frmPerfil_EditarInfo(UsuarioWS.usuario usuario)
        {
            _usuarioActual = usuario;
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();

            lblCodigo.Text = _usuarioActual.codigoPUCP;
            lblCorreo.Text = _usuarioActual.correo;
            dtpFechaNacimiento.Value = _usuarioActual.fechaNacimiento;
            rtbDescripcion.Text = _usuarioActual.descripcion;
            txtNombre.Text = _usuarioActual.nombre;
            txtApellido.Text = _usuarioActual.apellido;
            if (_usuarioActual.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(_usuarioActual.foto);
                imgPerfil.Image = new Bitmap(ms1);
            }
            // portada
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmHome.abrirFormulario(new frmPerfil(_usuarioActual));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            _usuarioModificado = new UsuarioWS.usuario();
            _usuarioModificado.idUsuario = _usuarioActual.idUsuario;
            _usuarioModificado.nombre = txtNombre.Text; //
            _usuarioModificado.apellido = txtApellido.Text; //
            _usuarioModificado.codigoPUCP = lblCodigo.Text;
            // aquí viene la fecha de nacimiento
            _usuarioModificado.fechaNacimiento = dtpFechaNacimiento.Value; //
            _usuarioModificado.fechaNacimientoSpecified = true;

            _usuarioModificado.correo = lblCorreo.Text; 
            _usuarioModificado.especialidad = _usuarioActual.especialidad;
            _usuarioModificado.descripcion = rtbDescripcion.Text; //
            _usuarioModificado.esAsesor = _usuarioActual.esAsesor;
            _usuarioModificado.esAdmin = _usuarioActual.esAdmin;
            _usuarioModificado.foto = _usuarioActual.foto; //
            _usuarioModificado.asesor = _usuarioActual.asesor;
            // portada
            int resultado = _daoUsuario.modificarUsuario(_usuarioModificado);
            if (resultado == 0)
            {
                frmPrincipal.endLoading();
                MessageBox.Show("Ha ocurrido un error en el registro. Intentelo de nuevo más tarde.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmHome.actualizarInfoPantallas(_usuarioModificado);
                frmHome.abrirFormulario(new frmPerfil(_usuarioModificado));
                frmPrincipal.endLoading();
            }
        }

        private void btnSubirPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPerfil.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdPerfil.FileName;
                    imgPerfil.Image = Image.FromFile(_rutaFoto);
                    imgPerfil.Image = (Image)(new Bitmap(imgPerfil.Image, new Size(60, 60))); // resizeImage

                    FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _usuarioActual.foto = br.ReadBytes((int)fs.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnCambiarCon_Click(object sender, EventArgs e)
        {
            frmCambiarContrasenia formContrasenia = new frmCambiarContrasenia();
            formContrasenia.ShowDialog();
        }
    }
}
