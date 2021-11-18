using LP2Soft.CursosWS;
using LP2Soft.Home;
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
    public partial class frmCrearReseniaProfesor : Form
    {
        private CursosWS.CursosWSClient _daoProfesor;
        private CursosWS.resenia _resenia;
        private CursosWS.profesor _profesor;
        public frmCrearReseniaProfesor(CursosWS.profesor profesor)
        {
            InitializeComponent();
            txtContenido.Text = "Escribe una reseña a " + profesor.nombre;
            _profesor = profesor;
            if (frmHome.Usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(frmHome.Usuario.foto);
                pbPerfil.Image = new Bitmap(ms1);
            }
        }

        public resenia Resenia { get => _resenia; set => _resenia = value; }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            _daoProfesor = new CursosWS.CursosWSClient();
            _resenia = new CursosWS.resenia();
            _resenia.usuario = new CursosWS.usuario();
            _resenia.usuario.idUsuario = frmHome.Usuario.idUsuario;
            _resenia.profesor = _profesor;
            _resenia.calificacion = int.Parse(txtCali.Text);
            _resenia.contenido = txtContenido.Text;
            if (frmHome.Usuario.esAdmin == true)
            {
                _resenia.prioridad = 1;
            }
            else
            {
                _resenia.prioridad = 0;
            }
            int resultado = _daoProfesor.insertarReseniaProfesor(_resenia);
            Console.WriteLine(resultado);
            this.DialogResult = DialogResult.OK;
        }
    }
}
