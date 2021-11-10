using LP2Soft.Cursos.Ciclo7.LP2.Practicas.Practica2;
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
    public partial class tarjTipoMaterialIndice : Form
    {
        private String[] tipoMaterial = new String[] { "Practica", "Laboratorio", "Tarea Academica", "Examenes" };
        private int tipo,indice;
        private CursosWS.curso _cursoVer;
        public tarjTipoMaterialIndice()
        {
            InitializeComponent();
        }
        public tarjTipoMaterialIndice(int auxTipo, CursosWS.curso curso, int auxIndice)
        {
            InitializeComponent();
            tipo = auxTipo;
            indice = auxIndice;
            _cursoVer = curso;
            btnLP2Practicas.Text = tipoMaterial[auxTipo] + indice;
        }

        private void btnLP2Practicas_Click(object sender, EventArgs e)
        {
            frmCursos_VerPractica verMateriales = new frmCursos_VerPractica();
            frmHome.abrirFormulario(new frmCursos_VerPractica( _cursoVer, tipo, indice));
        }
    }
}
