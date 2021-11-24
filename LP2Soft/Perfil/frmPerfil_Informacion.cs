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
        private BindingList<Label> _estrellas;
        public frmPerfil_Informacion(UsuarioWS.usuario usuario, bool propio)
        {
            _usuario = usuario;
            _estrellas = new BindingList<Label>();
            InitializeComponent();
            _estrellas.Add(estrella1);
            _estrellas.Add(estrella2);
            _estrellas.Add(estrella3);
            _estrellas.Add(estrella4);
            _estrellas.Add(estrella5);

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
                float calificacion = (_usuario.asesor.cantidadResenias == 0) ? 0 : 
                    _usuario.asesor.sumatoriaResenias / _usuario.asesor.cantidadResenias;
                pintarEstrellas((int)calificacion);
                lblCalificacion.Text = calificacion.ToString("0.00");
                lblPrecioHora.Text = _usuario.asesor.precioPorHora.ToString("0.00");
            }
            else
            {
                panelAsesor.Visible = false;
                this.Size = new Size(799, 260);
            }
        }
        private void pintarEstrellas(int nEstrellas)
        {
            for(int i=0; i<5; i++)
            {
                if (i < nEstrellas)
                    _estrellas[i].ImageIndex = 1;
                else _estrellas[i].ImageIndex = 0;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmHome.abrirFormulario(new frmPerfil_EditarInfo(_usuario));
        }
    }
}
