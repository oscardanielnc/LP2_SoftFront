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
        private int _calificacion;
        private BindingList<Label> _estrellas;
        public frmCrearReseniaProfesor(CursosWS.profesor profesor)
        {
            _calificacion = 0;
            InitializeComponent();
            _estrellas = new BindingList<Label>();
            _estrellas.Add(estrella1);
            _estrellas.Add(estrella2);
            _estrellas.Add(estrella3);
            _estrellas.Add(estrella4);
            _estrellas.Add(estrella5);

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
            if (_calificacion != 0)
            {
                _daoProfesor = new CursosWS.CursosWSClient();
                _resenia = new CursosWS.resenia();
                _resenia.usuario = new CursosWS.usuario();
                _resenia.usuario.idUsuario = frmHome.Usuario.idUsuario;
                _resenia.profesor = _profesor;
                _resenia.calificacion = _calificacion;
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
                _profesor.cantidadResenias++;
                _profesor.sumatoriaResenias += _calificacion;
                this.DialogResult = DialogResult.OK;
            }else
            {
                MessageBox.Show("Debe brindar alguna calificación para este profesor", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void estrella1_Click(object sender, EventArgs e)
        {
            _calificacion = 1;
            pintarEstrellas(_calificacion);
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

        private void estrella2_Click(object sender, EventArgs e)
        {
            _calificacion = 2;
            pintarEstrellas(_calificacion);
        }

        private void estrella3_Click(object sender, EventArgs e)
        {
            _calificacion = 3;
            pintarEstrellas(_calificacion);
        }

        private void estrella4_Click(object sender, EventArgs e)
        {
            _calificacion = 4;
            pintarEstrellas(_calificacion);
        }

        private void estrella5_Click(object sender, EventArgs e)
        {
            _calificacion = 5;
            pintarEstrellas(_calificacion);
        }
    }
}
