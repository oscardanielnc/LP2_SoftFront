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
    public partial class frmModificarEvento : Form
    {
        private string _rutaFoto = "";
        private PublicacionesWS.evento _evento;
        private PublicacionesWS.PublicacionesWSClient _daoPost;
        private PublicacionesWS.evento _eventoModificado;

        public PublicacionesWS.evento EventoModificado { get => _eventoModificado; }

        public frmModificarEvento()
        {
            InitializeComponent();
        }

        public frmModificarEvento(PublicacionesWS.evento e)
        {
            InitializeComponent();
            _evento = e;
            txtTitulo.Text = e.nombreDelEvento;
            txtContenido.Text = e.contenido;
            if (e.archivo != null)
            {
                MemoryStream ms1 = new MemoryStream(e.archivo);
                pbImagenPublicacion.Image = new Bitmap(ms1);
            }
            txtLinkZoom.Text = e.enlaceZoom;
            dtpFecha.Value =e.fechaDelEvento;
            tphhi.Value = new DateTime(2016,7,15,e.horaInicio/100,16,57);
            tpmmi.Value = new DateTime(2016, 7, 15,14, e.horaInicio % 100, 57);
            tphhf.Value = new DateTime(2016, 7, 15, e.horaFin / 100, 16, 57);
            tpmmf.Value = new DateTime(2016, 7, 15, 14, e.horaFin % 100, 57);
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPerfil.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdPerfil.FileName;
                    pbImagenPublicacion.Image = Image.FromFile(_rutaFoto);
                    pbImagenPublicacion.Image = (Image)(new Bitmap(pbImagenPublicacion.Image, new Size(260, 180))); // resizeImage

                    FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _evento.archivo = br.ReadBytes((int)fs.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int resultado = _daoPost.eliminarEvento(_evento.idPost);
            if (resultado == 1)
            {
                _eventoModificado = new PublicacionesWS.evento();
                _eventoModificado.idPost = -1;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Error el eliminar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            _evento.contenido = txtContenido.Text;
            _evento.nombreDelEvento = txtTitulo.Text;
            _evento.enlaceZoom = txtLinkZoom.Text;
            _evento.fechaDelEvento = dtpFecha.Value;
            _evento.fechaDelEventoSpecified = true;
            _evento.horaInicio = int.Parse(tphhi.Value.ToString("HH")) * 100 + int.Parse(tpmmi.Value.ToString("mm"));
            _evento.horaFin = int.Parse(tphhf.Value.ToString("HH")) * 100 + int.Parse(tpmmf.Value.ToString("mm"));

            int resultado = _daoPost.modificarEvento(_evento);
            if (resultado == 1)
            {
                _eventoModificado = _evento;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Error al modificar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
