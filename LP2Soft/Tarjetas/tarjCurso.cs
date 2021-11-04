﻿using LP2Soft.Cursos;
using LP2Soft.Cursos.Ciclo7.LP2;
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

namespace LP2Soft.Tarjetas
{
    public partial class tarjCurso : Form
    {
        private int _idCurso;
        private CursosWS.CursosWSClient _daoCurso;
        private CursosWS.curso _cursoVer;
        public tarjCurso(CursosWS.curso curso)
        {
            _daoCurso = new CursosWS.CursosWSClient();
            InitializeComponent();
            _idCurso = curso.idCurso;
            posicionarLabel(curso);
        }

        private void posicionarLabel(CursosWS.curso curso)
        {
            btnLP3.Text = curso.codigo + "\n\n\n" + curso.nombre + "\nCredito: " + curso.creditos; 
        }

        private void btnLP3_Click(object sender, EventArgs e)
        {
            _cursoVer = _daoCurso.MostrarCurso(_idCurso);
            if (_cursoVer != null)
            {
                frmHome.abrirFormulario(new frmCiclo7LP2(_cursoVer));
            }
                
        }
        
    }
}
