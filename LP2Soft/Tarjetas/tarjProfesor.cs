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
        
        
        public tarjProfesor(CursosWS.profesor profesor)
        {
            _daoProfesor = new CursosWS.CursosWSClient();
            InitializeComponent();

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
            lblPuntuacion.Text = profesor.calificacion.ToString();
            int tamanio = lblNombre.Size.Width;
            lblNombre.Location = new Point(((int)(160 - tamanio) / 2), 99);
        }

        private void btnVerPerfil_Click_1(object sender, EventArgs e)
        {
            
            _profesorVer = _daoProfesor.mostrarProfesor(_idProfesor);
            if (_profesorVer != null)
            {

            }
            frmHome.abrirFormulario(new frmProfesor_Perfil(_profesorVer));

        }

        private void imgProfesor_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblPuntuacion_Click(object sender, EventArgs e)
        {

        }
    }
}
