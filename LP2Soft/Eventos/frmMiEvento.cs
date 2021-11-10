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
        public frmMiEvento()
        {
            InitializeComponent();
        }

        public frmMiEvento(PublicacionesWS.evento e)
        {
            InitializeComponent();
            lblNombre.Text = frmHome.Usuario.nombre;
            lblFecha.Text = e.fechaRegistro.ToString("dd-MM-yyyy");
            lblTitulo.Text = e.nombreDelEvento;
            txtContenido.Text = e.contenido;
            lblZoom.Text = e.enlaceZoom;
            lblFechaRealizacion.Text = e.fechaDelEvento.ToString("dd de MMMM del yyyy");
            int hhi,mmi,hhf,mmf;
            hhi = e.horaInicio / 100;
            mmi = e.horaInicio % 100;
            hhf = e.horaFin / 100;
            mmf = e.horaFin % 100;
            lblHora.Text =hhi.ToString() + ":"+mmi.ToString() + " - "+ hhf.ToString() + ":" + mmf.ToString();
            
            if (e.archivo != null)
            {
                MemoryStream ms1 = new MemoryStream(e.archivo);
                pbImagen.Image = new Bitmap(ms1);
            }
        }
    }
}
