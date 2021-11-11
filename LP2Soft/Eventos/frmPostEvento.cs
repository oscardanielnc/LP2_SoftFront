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

namespace LP2Soft.Eventos
{
    public partial class frmPostEvento : Form
    {
        PublicacionesWS.PublicacionesWSClient _daoPost;
        BindingList<PublicacionesWS.comentario> _coments;
        private int _cantidadComent = 0;
        private PublicacionesWS.evento _evento;
        PublicacionesWS.comentario _comentarioCreado;
        public frmPostEvento()
        {
            InitializeComponent();
        }

        public frmPostEvento(PublicacionesWS.evento e)
        {
            InitializeComponent();
            _evento = e;
            
            btnMeGusta.ImageIndex = 1;
            lblNombre.Text = e.usuario.nombre;
            lblFechaHoraCreacion.Text = e.fechaRegistro.ToString("dd-MM-yyyy");
            lblTitulo.Text = e.nombreDelEvento;
            txtDescripcionEvento.Text = e.contenido;
            lblLinkZoom.Text = e.enlaceZoom;
            lblFechaEvento.Text = e.fechaDelEvento.ToString("dd/MMMM/yyyy");
            int hhi, mmi, hhf, mmf;
            hhi = e.horaInicio / 100;
            mmi = e.horaInicio % 100;
            hhf = e.horaFin / 100;
            mmf = e.horaFin % 100;

            string cadena = "";
            if (hhi < 10) cadena += "0";
            cadena += hhi.ToString() + ":";
            if (mmi < 10) cadena += "0";
            cadena += mmi.ToString() + " - ";

            if (hhf < 10) cadena += "0";
            cadena += hhf.ToString() + ":";
            if (mmf < 10) cadena += "0";
            cadena += mmf.ToString();

            lblHoraEvento.Text = cadena;

            lblCantidadLikes.Text = e.likes.ToString();
            lblCantidadComentarios.Text = e.numeroComent.ToString();

            if (e.archivo != null)
            {
                MemoryStream ms1 = new MemoryStream(e.archivo);
                pbImagen.Image = new Bitmap(ms1);
            }

            panelComentarios.Controls.Clear();
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
            PublicacionesWS.comentario[] _comentarios = _daoPost.listarComentarios(e.idPost);
            if (_comentarios != null)
                _coments = new BindingList<PublicacionesWS.comentario>(_comentarios.ToList());
            else
                _coments = null;

            _cantidadComent = 0;

            if (_coments != null)
            {
                foreach (PublicacionesWS.comentario p in _coments)
                {
                    if (_cantidadComent == 2) break;
                    frmComentario plantilla = new frmComentario(p, this);
                    plantilla.TopLevel = false;
                    plantilla.Dock = DockStyle.Top;
                    panelComentarios.Controls.Add(plantilla);
                    panelComentarios.Controls.SetChildIndex(plantilla, 0);
                    plantilla.Visible = true;
                    _cantidadComent++;
                }
            }
        }

        private void btnAgendarEvento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se agendó el evento", "Mensaje Confirmación",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            frmCrearComentario formCrearComentario = new frmCrearComentario(_evento);

            if (formCrearComentario.ShowDialog() == DialogResult.OK)
            {
                int cantidadComentarios = int.Parse(lblCantidadComentarios.Text) + 1;
                lblCantidadComentarios.Text = cantidadComentarios.ToString();
                panelComentarios.Controls.Clear();
                _comentarioCreado = formCrearComentario.ComentarioCreado;
                _comentarioCreado.usuario.nombre = frmHome.Usuario.nombre;
                frmComentario plantilla = new frmComentario(_comentarioCreado, this);
                plantilla.TopLevel = false;
                plantilla.Dock = DockStyle.Top;
                panelComentarios.Controls.Add(plantilla);
                panelComentarios.Controls.SetChildIndex(plantilla, 0);
                plantilla.Visible = true;

                _cantidadComent = 0;
                if (_coments != null)
                {
                    foreach (PublicacionesWS.comentario p in _coments)
                    {
                        plantilla = new frmComentario(p, this);
                        plantilla.TopLevel = false;
                        plantilla.Dock = DockStyle.Top;
                        panelComentarios.Controls.Add(plantilla);
                        panelComentarios.Controls.SetChildIndex(plantilla, 0);
                        plantilla.Visible = true;
                        _cantidadComent++;
                        break;
                    }
                }

                _cantidadComent++;
                _daoPost = new PublicacionesWS.PublicacionesWSClient();
                PublicacionesWS.comentario[] _comentarios = _daoPost.listarComentarios(_evento.idPost);
                if (_comentarios != null)
                    _coments = new BindingList<PublicacionesWS.comentario>(_comentarios.ToList());
                else
                    _coments = null;
            }
        }

        private void lblComentarios_Click(object sender, EventArgs e)
        {
            if (_coments != null)
            {
                int contador = 0;
                bool flag = true;
                foreach (PublicacionesWS.comentario p in _coments)
                {
                    if (flag)
                    {
                        if (contador < _cantidadComent) { contador++; continue; }
                        flag = false;
                    }
                    frmComentario plantilla = new frmComentario(p, this);
                    plantilla.TopLevel = false;
                    plantilla.Dock = DockStyle.Top;
                    panelComentarios.Controls.Add(plantilla);
                    panelComentarios.Controls.SetChildIndex(plantilla, 0);
                    plantilla.Visible = true;
                    _cantidadComent++;
                }
            }
        }

        private void btnMeGusta_Click(object sender, EventArgs e)
        {
            if (btnMeGusta.ImageIndex == 0)
            {
                btnMeGusta.ImageIndex = 1;
                int cantidadLikes = int.Parse(lblCantidadLikes.Text) - 1;
                int resultado = _daoPost.disminuirLikes(_evento.idPost);
                lblCantidadLikes.Text = cantidadLikes.ToString();

            }
            else
            {
                btnMeGusta.ImageIndex = 0;
                int cantidadLikes = int.Parse(lblCantidadLikes.Text) + 1;
                int resultado = _daoPost.aumentarLikes(_evento.idPost);
                lblCantidadLikes.Text = cantidadLikes.ToString();

            }
        }

        public void disminuirCantidadComentarios()
        {
            int cantidadComentarios = int.Parse(lblCantidadComentarios.Text) - 1;
            lblCantidadComentarios.Text = cantidadComentarios.ToString();
        }

        public void actualizarComentarios()
        {
            _cantidadComent--;

            _daoPost = new PublicacionesWS.PublicacionesWSClient();
            PublicacionesWS.comentario[] _comentarios = _daoPost.listarComentarios(_evento.idPost);
            if (_comentarios != null)
                _coments = new BindingList<PublicacionesWS.comentario>(_comentarios.ToList());
            else
                _coments = null;

            if (_coments != null)
            {
                int contador = 0;
                bool flag = true;
                foreach (PublicacionesWS.comentario p in _coments)
                {
                    if (_cantidadComent == 2) break;
                    if (flag)
                    {
                        if (contador < _cantidadComent) { contador++; continue; }
                        flag = false;
                    }
                    frmComentario plantilla = new frmComentario(p, this);
                    plantilla.TopLevel = false;
                    plantilla.Dock = DockStyle.Top;
                    panelComentarios.Controls.Add(plantilla);
                    panelComentarios.Controls.SetChildIndex(plantilla, 0);
                    plantilla.Visible = true;
                    _cantidadComent++;
                }
            }
        }
    }
}
