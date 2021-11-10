﻿using LP2Soft.Home;
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
    public partial class frmMisPublicaciones : Form
    {
        private static int _cantidadPost = 0;
        PublicacionesWS.PublicacionesWSClient _daoPost;
        BindingList<PublicacionesWS.evento> _eventos;
        public frmMisPublicaciones()
        {
            InitializeComponent();
            listarMisEventos();
        }

        public void listarMisEventos() 
        {
            panelPublicacionesEventos.Controls.Clear();
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
            PublicacionesWS.evento[] posts = _daoPost.listarMisEventos(frmHome.Usuario.idUsuario);
            if (posts != null)
                _eventos = new BindingList<PublicacionesWS.evento>(posts.ToList());
            else
                _eventos = null;
            if (_eventos != null)
            {
                foreach (PublicacionesWS.evento p in _eventos)
                {
                    if (_cantidadPost == 3) break;
                    frmMiEvento plantillaPost = new frmMiEvento(p);
                    plantillaPost.TopLevel = false;
                    plantillaPost.Dock = DockStyle.Top;
                    panelPublicacionesEventos.Controls.Add(plantillaPost);
                    panelPublicacionesEventos.Controls.SetChildIndex(plantillaPost, 0);
                    plantillaPost.Visible = true;
                    _cantidadPost++;
                }
            }
        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            frmCrearEvento frmCrearEvento = new frmCrearEvento();
            if (frmCrearEvento.ShowDialog() == DialogResult.OK) 
            {
                listarMisEventos();
            }
        }
    }
}
