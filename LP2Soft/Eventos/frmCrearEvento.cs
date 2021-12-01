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
    public partial class frmCrearEvento : Form
    {
        private PublicacionesWS.evento _evento;
        private PublicacionesWS.PublicacionesWSClient _daoPost;
        private PublicacionesWS.evento _eventoCreado;
        private string _rutaFoto = "";

        public PublicacionesWS.evento EventoCreado { get => _eventoCreado; }

        public frmCrearEvento()
        {
            InitializeComponent();
            _evento = new PublicacionesWS.evento();
            _evento.usuario = new PublicacionesWS.usuario();
            _evento.usuario.idUsuario = frmHome.Usuario.idUsuario;
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

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            _evento.contenido = txtContenido.Text;
            if (frmHome.Usuario.esAdmin == true) _evento.prioridad = 1;
            else _evento.prioridad = 0;
            _evento.nombreDelEvento = txtTitulo.Text;
            _evento.enlaceZoom = txtZoom.Text;
            _evento.fechaDelEvento = dtpFecha.Value;
            _evento.fechaDelEventoSpecified = true;
            _evento.horaInicio = int.Parse(tphhi.Value.ToString("HH")) * 100 + int.Parse(tpmmi.Value.ToString("mm"));
            _evento.horaFin = int.Parse(tphhf.Value.ToString("HH")) * 100 + int.Parse(tpmmf.Value.ToString("mm"));

            int resultado = _daoPost.insertarEvento(_evento);

            if (resultado != 0)
            {
                _evento.idPost = resultado;
                _eventoCreado = _evento;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
