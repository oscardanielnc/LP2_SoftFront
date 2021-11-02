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
    public partial class frmPerfil_Informacion : Form
    {
        private UsuarioWS.usuario _usuario;
        public frmPerfil_Informacion(UsuarioWS.usuario usuario, bool propio)
        {
            _usuario = usuario;
            InitializeComponent();
            if (!propio) btnEditar.Visible = false;
            actualizarpantallas();
        }
        private void actualizarpantallas()
        {
            lblCodigo.Text = _usuario.codigoPUCP;
            lblCorreo.Text = _usuario.correo;
            // aquí viene la fecha de nacimiento
            lblFechaNacimiento.Text = _usuario.fechaNacimiento.ToString("dd MMMM yyyy");
            rtbDescripcion.Text = _usuario.descripcion;

            if (_usuario.esAsesor)
            {
                panelAsesor.Visible = true;
                // aquí viene la definición de valores del asesor
            }
            else
            {
                panelAsesor.Visible = false;
                this.Size = new Size(799, 260);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmHome.abrirFormulario(new frmPerfil_EditarInfo(_usuario));
        }
    }
}
