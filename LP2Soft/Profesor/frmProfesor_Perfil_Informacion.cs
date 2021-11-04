using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Profesor
{
    public partial class frmProfesor_Perfil_Informacion : Form
    {
        private CursosWS.profesor _profesor;
        public frmProfesor_Perfil_Informacion()
        {
            InitializeComponent();
        }
        public frmProfesor_Perfil_Informacion(CursosWS.profesor profesor)
        {
            _profesor = profesor;
            InitializeComponent();
            actualizarpantallas();
        }

        private void actualizarpantallas()
        {
            lblCorreo.Text = _profesor.correo;
            // aquí viene la fecha de nacimiento
            //lblFechaNacimiento.Text = _usuario.fechaNacimiento.ToString("dd MMMM yyyy");
            rtbDescripcion.Text = _profesor.descripcion;
            lblCalificacion.Text = _profesor.calificacion.ToString();
            
        }
    }
}
