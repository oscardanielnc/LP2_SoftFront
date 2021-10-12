﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Home
{
    public partial class frmLoginSingin : Form
    {
        private static Form _formActivo = null;
        private Panel _panelPrincipal;
        public frmLoginSingin(Panel panel)
        {
            InitializeComponent();
            _panelPrincipal = panel;
            abrirFormulario(new frmLogIn(panelContenido, _panelPrincipal));
        }
        public void abrirFormulario(Form formulario)
        {
            if (_formActivo != null) _formActivo.Close();
            _formActivo = formulario;
            _formActivo.TopLevel = false;
            _formActivo.FormBorderStyle = FormBorderStyle.None;
            _formActivo.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(_formActivo);
            _formActivo.Show();
        }
    }
}
