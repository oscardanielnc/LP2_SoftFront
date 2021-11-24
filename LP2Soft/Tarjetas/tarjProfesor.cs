using LP2Soft.Home;
using LP2Soft.Profesor;
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

namespace LP2Soft.Tarjetas
{
    public partial class tarjProfesor : Form
    {
        private int _idProfesor;
        private CursosWS.CursosWSClient _daoProfesor;
        private CursosWS.profesor _profesorVer;
        private BindingList<Label> _estrellas;

        public tarjProfesor(CursosWS.profesor profesor)
        {
            _daoProfesor = new CursosWS.CursosWSClient();
            InitializeComponent();
            _estrellas = new BindingList<Label>();
            _estrellas.Add(estrella1);
            _estrellas.Add(estrella2);
            _estrellas.Add(estrella3);
            _estrellas.Add(estrella4);
            _estrellas.Add(estrella5);

            _idProfesor = profesor.idProfesor;
            posicionarLabel(profesor);

            if (profesor.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(profesor.foto);
                imgProfesor.Image = new Bitmap(ms1);
            }
        }

        private void posicionarLabel(CursosWS.profesor profesor)
        {
            lblNombre.Text = profesor.nombre;
            int tamanio = lblNombre.Size.Width;
            lblNombre.Location = new Point(((int)(160 - tamanio) / 2), 99);

            float calificacion = (profesor.cantidadResenias == 0) ? 0 :
                    (float)profesor.sumatoriaResenias / profesor.cantidadResenias;
            pintarEstrellas(calificacion);
            lblCal.Text = calificacion.ToString("0.00");
        }

        private void btnVerPerfil_Click_1(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            _profesorVer = _daoProfesor.mostrarProfesor(_idProfesor);
            if (_profesorVer != null)
            {
                frmHome.abrirFormulario(new frmProfesor_Perfil(_profesorVer));
            }
            frmPrincipal.endLoading();
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
