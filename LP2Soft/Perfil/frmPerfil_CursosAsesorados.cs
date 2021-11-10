using LP2Soft.Asesor;
using LP2Soft.Home;
using LP2Soft.Cursos.Ciclo7.LP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2Soft.Tarjetas;

namespace LP2Soft.Perfil
{
    public partial class frmPerfil_CursosAsesorados : Form
    {
        private CursosWS.CursosWSClient _daoCurso;
        private BindingList<CursosWS.curso> _cursosAsesorados;
        public frmPerfil_CursosAsesorados(UsuarioWS.usuario user)
        {
            InitializeComponent();
            _daoCurso = new CursosWS.CursosWSClient();
            if (user.esAsesor == true)
            {
                renderizarPanel(user.asesor.idAsesor);
            }
            else
            {
                MessageBox.Show("El usuario no es asesor", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void renderizarPanel(int idAsesor)
        {
            _cursosAsesorados = null;
            try
            {
                _cursosAsesorados = new BindingList<CursosWS.curso>(_daoCurso.listarCursosAsesorados(idAsesor));
                //renderizamos las tarjetas
                int i = 0;
                foreach (CursosWS.curso c in _cursosAsesorados)
                {
                    tarjCursoAsesorado tCurso = new tarjCursoAsesorado(c);
                    tCurso.TopLevel = false;
                    tCurso.Location = generarCoordenadas(i);
                    panelCursos.Controls.Add(tCurso);
                    panelCursos.Controls.SetChildIndex(tCurso, 0);
                    tCurso.Visible = true;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se han encontrado cursos asesorados por este usuario", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Point generarCoordenadas(int i)
        {
            int x = (i % 2) * 280 + 20;
            int y = ((int)i / 2) * 160 + 20;
            return new Point(x, y);
        }
        private void btnAniadirCurso_Click(object sender, EventArgs e)
        {
            frmPostularAsesor fromPostular = new frmPostularAsesor();
            fromPostular.ShowDialog();
        }
    }
}