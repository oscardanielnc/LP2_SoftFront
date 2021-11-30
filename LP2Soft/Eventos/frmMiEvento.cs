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
    public partial class frmMiEvento : Form
    {
        private PublicacionesWS.evento _evento;
        private PublicacionesWS.evento _eventoModificado;
        public frmMiEvento()
        {
            InitializeComponent();
        }

        public frmMiEvento(PublicacionesWS.evento e)
        {
            InitializeComponent();
            _evento = e;
            lblNombre.Text = frmHome.Usuario.nombre + " " + frmHome.Usuario.apellido;
            mostrarDatos(e);
        }

        private void mostrarDatos(PublicacionesWS.evento e) {
            lblFecha.Text = e.fechaRegistro.ToString("dd-MM-yyyy");
            lblTitulo.Text = e.nombreDelEvento;
            txtContenido.Text = e.contenido;
            txtContenido.ReadOnly = true;
            txtContenido.BackColor = Color.White;
            lblZoom.Text = e.enlaceZoom;
            lblFechaRealizacion.Text = e.fechaDelEvento.ToString("dd/MMMM/yyyy");

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

            lblHora.Text = cadena;

            if (e.archivo != null)
            {
                MemoryStream ms1 = new MemoryStream(e.archivo);
                pbImagen.Image = new Bitmap(ms1);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarEvento formModificarEvento = new frmModificarEvento(_evento);
            if (formModificarEvento.ShowDialog() == DialogResult.OK) 
            {
                _eventoModificado = formModificarEvento.EventoModificado;
                if (_eventoModificado.idPost != -1)
                {
                    mostrarDatos(_eventoModificado);
                    lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
                }
                else this.Visible = false;
            }
        }
    }
}
