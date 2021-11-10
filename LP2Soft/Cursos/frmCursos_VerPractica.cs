﻿using LP2Soft.Cursos.AgregarMaterial;
using LP2Soft.Cursos.Calificación;
using LP2Soft.Cursos.Flitro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Cursos.Ciclo7.LP2.Practicas.Practica2
{
    public partial class frmCursos_VerPractica : Form
    {
        private CursosWS.curso _cursoVer;
        private int tipo;
        private String[] tipoMaterial = new String[] { "Practica", "Laboratorio", "Tarea Academica", "Examenes" };
        public frmCursos_VerPractica()
        {
            InitializeComponent();
        }

        public frmCursos_VerPractica(CursosWS.curso curso, int auxTipo, int indice)
        {
            InitializeComponent();
            _cursoVer = curso;
            tipo = auxTipo;
            btnLP2Practica2Ciclo7.Text = "Ciclo " + curso.nivel;
            btnLP2Practica2LP2.Text = curso.nombre;
            btnLLP2Practica2Practicas.Text = tipoMaterial[auxTipo];
            btnLLP2Practica2Practica2.Text = tipoMaterial[auxTipo] +" "+ indice;
        }

        private void btnLP2Practica2Material_Click(object sender, EventArgs e)
        {
            frmCursos_Home cursosHome = new frmCursos_Home(20186013);
            addPanel(cursosHome);
        }

        private void btnLP2Practica2Ciclo7_Click(object sender, EventArgs e)
        {
            frmCursos_Ciclo ciclo7 = new frmCursos_Ciclo(_cursoVer.nivel);
            addPanel(ciclo7);
        }

        private void btnLP2Practica2LP2_Click(object sender, EventArgs e)
        {
            frmCursos_VerCurso ciclo7LP2 = new frmCursos_VerCurso(_cursoVer);
            addPanel(ciclo7LP2);
        }

        private void btnLLP2Practica2Practicas_Click(object sender, EventArgs e)
        {
            frmCursos_Practicas practicas = new frmCursos_Practicas(_cursoVer, tipo);
            addPanel(practicas);
        }

        private void btnLLP2Practica2AgregarMaterial_Click(object sender, EventArgs e)
        {
            frmAgregarMaterial agregarMaterial = new frmAgregarMaterial(_cursoVer);
            agregarMaterial.ShowDialog();
        }

        private void btnestrella1_Click(object sender, EventArgs e)
        {
            frmCalificacion calificacion = new frmCalificacion();
            calificacion.ShowDialog();
        }

        private void pBLP2Practica4Compartir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        private void pBLP2Practica4Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2Practica3Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2Practica2Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2Practica1Descargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descargando");
        }

        private void pBLP2Practica3Compartir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        private void pBLP2Practica2Compartir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        private void pBLP2Practica1Compartir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compartiendo");
        }

        private void btnLLP2Practica2Filtrar_Click(object sender, EventArgs e)
        {
            frmCursos_Filtro filtro = new frmCursos_Filtro();
            filtro.Show();
        }

        private void pBFiltro_Click(object sender, EventArgs e)
        {
            frmCursos_Filtro filtro = new frmCursos_Filtro();
            filtro.Show();
        }
        public void addPanel(Form f)
        {
            while (this.panel4.Controls.Count > 0)
            {
                this.panel4.Controls.RemoveAt(0);
            }
            f.TopLevel = false;
            this.panel4.Controls.Add(f);
            f.Show();
        }
    }
}
