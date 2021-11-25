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

namespace LP2Soft.Tarjetas
{
    public partial class tarjResenia : Form
    {
        private UsuarioWS.UsuariosWSClient _daoResenia;
        private CursosWS.CursosWSClient _daoReseniaC;
        private UsuarioWS.resenia _resenia;
        private CursosWS.resenia _reseniaC;
        private UsuarioWS.usuario _usuarioAsesor;
        private CursosWS.profesor _profesor;

        private BindingList<Label> _estrellas;
        public tarjResenia(UsuarioWS.resenia re, UsuarioWS.usuario usuarioAsesor)
        {
            InitializeComponent();
            _estrellas = new BindingList<Label>();
            _estrellas.Add(estrella1);
            _estrellas.Add(estrella2);
            _estrellas.Add(estrella3);
            _estrellas.Add(estrella4);
            _estrellas.Add(estrella5);

            _resenia = re;
            _usuarioAsesor = usuarioAsesor;
            _daoResenia = new UsuarioWS.UsuariosWSClient();
            btnEliminar.Visible = false;
            if (re.usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(re.usuario.foto);
                picUsuario.Image = new Bitmap(ms1);
            }
            lblUsuario.Text = " " + re.usuario.nombre + " " + re.usuario.apellido;
            lblDescripcion.Text = re.contenido;
            lblDate.Text = re.fechaRegistro.ToString("yyyy-MM-dd HH:mm:ss");
            lblAsesor.Text = " " + re.usuarioReseniado.nombre + " " + re.usuarioReseniado.apellido;

            pintarEstrellas(re.calificacion);
            calificacion.Text = re.calificacion.ToString("0.00");

            if(frmHome.Usuario.idUsuario == re.usuario.idUsuario)
            {
                btnEliminar.Visible = true;
            }
        }

        public tarjResenia(CursosWS.resenia re, CursosWS.profesor profesor)
        {
            InitializeComponent();
            _estrellas = new BindingList<Label>();
            _estrellas.Add(estrella1);
            _estrellas.Add(estrella2);
            _estrellas.Add(estrella3);
            _estrellas.Add(estrella4);
            _estrellas.Add(estrella5);

            _profesor = profesor;
            _reseniaC = re;
            _daoReseniaC = new CursosWS.CursosWSClient();
            btnEliminar.Visible = false;
            if (re.usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(re.usuario.foto);
                picUsuario.Image = new Bitmap(ms1);
            }
            lblUsuario.Text = " " + re.usuario.nombre + " " + re.usuario.apellido;
            lblDescripcion.Text = re.contenido;
            lblDate.Text = re.fechaRegistro.ToString("yyyy-MM-dd HH:mm:ss");
            lblAsesor.Text = re.profesor.nombre;
            label1.Text = "Profesor: ";
            pintarEstrellas(re.calificacion);

            calificacion.Text = re.calificacion.ToString("0.00");
            if (frmHome.Usuario.idUsuario == re.usuario.idUsuario)
            {
                btnEliminar.Visible = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro que deseas eliminar tu resenia?",
                    "Confirmación", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (_resenia != null)
                {
                    _daoResenia.eliminarReseniaAsesor(_resenia.idPost);
                    _usuarioAsesor.asesor.cantidadResenias--;
                    _usuarioAsesor.asesor.sumatoriaResenias -= _resenia.calificacion;
                }
                else
                {
                    _daoReseniaC.eliminarReseniasProfesor(_reseniaC.idPost);
                    _profesor.cantidadResenias--;
                    _profesor.sumatoriaResenias -= _reseniaC.calificacion;
                }
                this.Visible = false;
            }
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
