using LP2Soft.Cursos.Ciclo7.LP2.Practicas;
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
    public partial class tarjTipoMaterial : Form
    {
        private CursosWS.curso _cursoVer;
        private String[] tipoMaterial = new String[]{"Prácticas", "Laboratorios","Tareas Académicas" , "Exámenes"};
        private int tipo;
        public tarjTipoMaterial()
        {
            InitializeComponent();
            
        }

        public tarjTipoMaterial(int auxTipo, CursosWS.curso curso)
        {
            InitializeComponent();
            _cursoVer = curso;
            tipo = auxTipo;
            btnLP2TipoMaterial.Text = tipoMaterial[auxTipo];            
        }

        private void btnLP2TipoMaterial_Click(object sender, EventArgs e)
        {
            frmCursos_Practicas cursos_Practicas= new frmCursos_Practicas();
            frmHome.abrirFormulario(new frmCursos_Practicas(_cursoVer,tipo));
        }
    }
}
