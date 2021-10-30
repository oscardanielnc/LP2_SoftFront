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
        public frmPerfil_Informacion(UsuarioWS.usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            actualizarpantallas();
        }
        private void actualizarpantallas()
        {
            lblCodigo.Text = _usuario.codigoPUCP;
            lblCorreo.Text = _usuario.correo;
            // aquí viene la fecha de nacimiento
            rtbDescripcion.Text = _usuario.descripcion;
            
            if(_usuario.esAsesor)
            {
                imgVineta2.Visible = true;
                lblInfAsesor.Visible = true;
                infoCalificacion.Visible = true;
                infoPrecio.Visible = true;
                lblPrecioHora.Visible = true;
                lblCalificacion.Visible = true;

                // aquí viene la definición de valores del asesor
            }
        }
    }
}
