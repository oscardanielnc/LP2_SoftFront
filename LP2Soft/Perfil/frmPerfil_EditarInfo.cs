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
    public partial class frmPerfil_EditarInfo : Form
    {
        private UsuarioWS.usuario _usuario;
        public frmPerfil_EditarInfo(UsuarioWS.usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();

            if (_usuario.esAsesor)
            {
                imgVineta2.Visible = true;
                lblInfAsesor.Visible = true;
                infoCalificacion.Visible = true;
                infoPrecio.Visible = true;
                txtPrecioHora.Visible = true;
                lblCalificacion.Visible = true;

                // aquí viene la definición de valores del asesor
            }
            lblCodigo.Text = _usuario.codigoPUCP;
            lblCorreo.Text = _usuario.correo;
            // aquí viene la fecha de nacimiento
            rtbDescripcion.Text = _usuario.descripcion;
            txtNombre.Text = _usuario.nombre;
            txtApellido.Text = _usuario.apellido;
            // foto
            // portada
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmHome.abrirFormulario(new frmPerfil(_usuario, true));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _usuario.nombre = txtNombre.Text;
            _usuario.apellido = txtApellido.Text;
            _usuario.codigoPUCP = lblCodigo.Text;
            // aquí viene la fecha de nacimiento
            _usuario.correo = lblCorreo.Text;
            _usuario.descripcion = rtbDescripcion.Text;
            // foto
            // portada

            frmHome.actualizarInfoPantallas(_usuario);
            frmHome.abrirFormulario(new frmPerfil(_usuario, true));
        }
    }
}
