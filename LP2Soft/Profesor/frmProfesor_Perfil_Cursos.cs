using LP2Soft.Tarjetas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Profesor
{
    public partial class frmProfesor_Perfil_Cursos : Form
    {
        private BindingList<CursosWS.curso> _cursosProfesor;
        private CursosWS.profesor _profesor;
        private CursosWS.CursosWSClient _daoProfesor;
        public frmProfesor_Perfil_Cursos()
        {
            InitializeComponent();
        }

        public frmProfesor_Perfil_Cursos(CursosWS.profesor profesor)
        {
            _profesor = profesor;
            InitializeComponent();
            _daoProfesor = new CursosWS.CursosWSClient();
            renderizarBusqueda("");
        }

        private void renderizarBusqueda(string nombreCodigo)
        {
            _cursosProfesor = null;
            //lblInfo.Text = "Buscando...";
            try
            {
                _cursosProfesor = new BindingList<CursosWS.curso>(_daoProfesor.listarCursoProfesor(_profesor.idProfesor));
                //renderizamos las tarjetas
                int i = 0;
                foreach (CursosWS.curso c in _cursosProfesor)
                {
                    tarjCurso tCursos = new tarjCurso(c);
                    tCursos.TopLevel = false;
                    tCursos.Location = generarCoordenadas(i);
                    /*tUsuario.Dock = DockStyle.Top;*/
                    panelCursos.Controls.Add(tCursos);
                    panelCursos.Controls.SetChildIndex(tCursos, 0);
                    tCursos.Visible = true;
                    i++;
                }
                lblInfo.Text = "El profesor dicta " + _cursosProfesor.Count + " cursos.";
            }
            catch (Exception ex)
            {
                lblInfo.Text = "El profesor actualmente no dicta cursos";
            }
        }

        private Point generarCoordenadas(int i)
        {
            int x = (i % 4) * 170;
            int y = ((int)i / 4) * 146;
            return new Point(x, y);
        }

        private void btnLP3_Click(object sender, EventArgs e)
        {

        }
    }
}
