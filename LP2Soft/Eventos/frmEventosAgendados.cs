using LP2Soft.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Eventos
{
    public partial class frmEventosAgendados : Form
    {
        //private DateTime holiday;
        private PublicacionesWS.PublicacionesWSClient _daoPost;
        private BindingList<PublicacionesWS.evento> _eventosAgendados;
        private BindingList<PublicacionesWS.evento> _eventosAgendadosFecha;

        public frmEventosAgendados()
        {
            InitializeComponent();
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
            PublicacionesWS.evento[] eventos = _daoPost.listarEventosAgendados(frmHome.Usuario.idUsuario);
            if (eventos != null)
                _eventosAgendados = new BindingList<PublicacionesWS.evento>(eventos.ToList());
            else
                _eventosAgendados = null;
            //holiday = new DateTime(2021,11,24);
            //monthCalendar1.AddBoldedDate(holiday);
            
            if (_eventosAgendados != null)
            {
                foreach (PublicacionesWS.evento p in _eventosAgendados)
                {
                    monthCalendar1.AddBoldedDate(p.fechaDelEvento);
                }
            }

            DateTime fecha = DateTime.Now;

            lblEventosAgendados.Text = "Eventos Agendados para el " + fecha.ToString("dd/MM/yyyy");

            PublicacionesWS.evento[] eventosFecha = _daoPost.listarEventosAgendadosFecha(frmHome.Usuario.idUsuario,fecha.ToString("dd-MM-yyyy"));

            int cantidad;
            if (eventosFecha != null) {
                _eventosAgendadosFecha = new BindingList<PublicacionesWS.evento>(eventosFecha.ToList());
                cantidad = _eventosAgendadosFecha.Count;
            }
            else {
                _eventosAgendadosFecha = null;
                cantidad = 0;
            }

            if (cantidad == 1)
                lblCantidadEventos.Text = cantidad.ToString() + " evento";
            else
                lblCantidadEventos.Text = cantidad.ToString() + " eventos";

            if (_eventosAgendadosFecha != null)
            {
                foreach (PublicacionesWS.evento p in _eventosAgendadosFecha)
                {
                    frmPostEvento plantillaPost = new frmPostEvento(p,this);
                    plantillaPost.TopLevel = false;
                    plantillaPost.Dock = DockStyle.Top;
                    panelPublicacionesEventos.Controls.Add(plantillaPost);
                    panelPublicacionesEventos.Controls.SetChildIndex(plantillaPost, 0);
                    plantillaPost.Visible = true;
                }

                _eventosAgendados = null;
            }
        }

        public void actualizarCalendario(DateTime holiday) {
            List<DateTime> lista = monthCalendar1.BoldedDates.ToList();
            lista.Remove(holiday);
            monthCalendar1.BoldedDates = lista.ToArray();
        }

        private void panelPublicacionesEventos_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == panelPublicacionesEventos.VerticalScroll.Maximum - panelPublicacionesEventos.VerticalScroll.LargeChange + 1)
            {
                if (e.NewValue != e.OldValue) // Checking when the scrollbar is at bottom and user clicks/scrolls the scrollbar      
                {
                    //MessageBox.Show("Test"); // Some operation
                    //List<DateTime> lista=monthCalendar1.BoldedDates.ToList();
                    //lista.Remove(holiday);
                    //monthCalendar1.BoldedDates = lista.ToArray();
                }
            }

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
            panelPublicacionesEventos.Controls.Clear();

            PublicacionesWS.evento[] eventosFecha = _daoPost.listarEventosAgendadosFecha(frmHome.Usuario.idUsuario, monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy"));

            int cantidad;

            if (eventosFecha != null)
            {
                _eventosAgendadosFecha = new BindingList<PublicacionesWS.evento>(eventosFecha.ToList());
                cantidad = _eventosAgendadosFecha.Count;
            }
            else
            {
                _eventosAgendadosFecha = null;
                cantidad = 0;
            }

            lblEventosAgendados.Text = "Eventos Agendados para el " + monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy");

            if(cantidad==1)
                lblCantidadEventos.Text = cantidad.ToString() + " evento";
            else
                lblCantidadEventos.Text = cantidad.ToString() + " eventos";

            if (_eventosAgendadosFecha != null)
            {
                foreach (PublicacionesWS.evento p in _eventosAgendadosFecha)
                {
                    frmPostEvento plantillaPost = new frmPostEvento(p, this);
                    plantillaPost.TopLevel = false;
                    plantillaPost.Dock = DockStyle.Top;
                    panelPublicacionesEventos.Controls.Add(plantillaPost);
                    panelPublicacionesEventos.Controls.SetChildIndex(plantillaPost, 0);
                    plantillaPost.Visible = true;
                }
                _eventosAgendadosFecha = null;
            }
        }
    }
}
