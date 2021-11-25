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
        private BindingList<Label> _estrellas;

        public frmProfesor_Perfil_Informacion(CursosWS.profesor profesor)
        {
            _profesor = profesor;
            InitializeComponent();
            _estrellas = new BindingList<Label>();
            _estrellas.Add(estrella1);
            _estrellas.Add(estrella2);
            _estrellas.Add(estrella3);
            _estrellas.Add(estrella4);
            _estrellas.Add(estrella5);
            actualizarpantallas();
        }

        private void actualizarpantallas()
        {
            lblCorreo.Text = _profesor.correo;
            // aquí viene la fecha de nacimiento
            //lblFechaNacimiento.Text = _usuario.fechaNacimiento.ToString("dd MMMM yyyy");
            lblDescripcion.Text = _profesor.descripcion;

            float calificacion = (_profesor.cantidadResenias == 0) ? 0 :
                    (float)_profesor.sumatoriaResenias / _profesor.cantidadResenias;
            pintarEstrellas(calificacion);
            lblCalificacion.Text = calificacion.ToString("0.00");
        }
        private void pintarEstrellas(float nEstrellas)
        {
            for (float i = 0; i < 5; i++)
            {
                if (i < nEstrellas)
                {
                    if (i + 0.5 < nEstrellas)
                        _estrellas[(int)i].ImageIndex = 1;
                    else _estrellas[(int)i].ImageIndex = 2;
                }
                else _estrellas[(int)i].ImageIndex = 0;
            }
        }
    }
}
