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
        public frmPerfil_Informacion()
        {
            InitializeComponent();
            actualizarpantallas();
        }
        private void actualizarpantallas()
        {
            lblCodigo.Text = frmHome.Usuario.codigoPUCP;
            lblCorreo.Text = frmHome.Usuario.correo;
            // aquí viene la fecha de nacimiento
            rtbDescripcion.Text = frmHome.Usuario.descripcion;
            
            if(frmHome.Usuario.esAsesor)
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
