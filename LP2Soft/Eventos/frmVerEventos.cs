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
    public partial class frmVerEventos : Form
    {
        PublicacionesWS.PublicacionesWSClient _daoPost;
        BindingList<PublicacionesWS.evento> _eventos;
        private static int _cantidadPost = 0;
        public frmVerEventos()
        {
            InitializeComponent();
            listarEventos();
        }

        public void listarEventos()
        {
            panelPublicacionesEventos.Controls.Clear();
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
            PublicacionesWS.evento[] evento = _daoPost.listarEventos();
            if (evento != null)
                _eventos = new BindingList<PublicacionesWS.evento>(evento.ToList());
            else
                _eventos = null;
            if (_eventos != null)
            {
                foreach (PublicacionesWS.evento p in _eventos)
                {
                    if (_cantidadPost == 3) break;
                    frmPostEvento plantillaPost = new frmPostEvento(p);
                    plantillaPost.TopLevel = false;
                    plantillaPost.Dock = DockStyle.Top;
                    panelPublicacionesEventos.Controls.Add(plantillaPost);
                    panelPublicacionesEventos.Controls.SetChildIndex(plantillaPost, 0);
                    plantillaPost.Visible = true;
                    _cantidadPost++;
                }
            }
        }

        private void panelPublicacionesEventos_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == panelPublicacionesEventos.VerticalScroll.Maximum - panelPublicacionesEventos.VerticalScroll.LargeChange + 1)
            {
                if (e.NewValue != e.OldValue) // Checking when the scrollbar is at bottom and user clicks/scrolls the scrollbar      
                {
                    int cantidadFinal = _cantidadPost + 3;
                    int contador = 0;
                    bool flag = true;
                    foreach (PublicacionesWS.evento p in _eventos)
                    {
                        if (contador < _cantidadPost)
                        {
                            contador++;
                            continue;
                        }
                        else contador = 1000;

                        if (_cantidadPost == cantidadFinal) break;
                        frmPostEvento plantillaPost = new frmPostEvento(p);
                        plantillaPost.TopLevel = false;
                        plantillaPost.Dock = DockStyle.Top;
                        panelPublicacionesEventos.Controls.Add(plantillaPost);
                        panelPublicacionesEventos.Controls.SetChildIndex(plantillaPost, 0);
                        plantillaPost.Visible = true;
                        _cantidadPost++;
                    }
                }
            }

        }
    }
}
