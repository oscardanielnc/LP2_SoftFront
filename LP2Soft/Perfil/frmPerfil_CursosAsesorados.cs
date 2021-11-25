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
using System.IO;

namespace LP2Soft.Perfil
{
    public partial class frmPerfil_CursosAsesorados : Form
    {
        private byte[] arreglo;
        private int _idAsesor;
        private UsuarioWS.UsuariosWSClient _daoAsesor;
        private UsuarioWS.usuario _usuario;
        private BindingList<UsuarioWS.curso> _cursosAsesorados;
        public frmPerfil_CursosAsesorados(UsuarioWS.usuario user)
        {
            InitializeComponent();
            _idAsesor = user.asesor.idAsesor;
            _usuario = user;
            _daoAsesor = new UsuarioWS.UsuariosWSClient();
            renderizarPanel(user.idUsuario);
            
        }
        private void renderizarPanel(int idUsuario)
        {
            _cursosAsesorados = null;
            try
            {
                _cursosAsesorados = new BindingList<UsuarioWS.curso>(_daoAsesor.listarCursosAsesorados(idUsuario));
                //renderizamos las tarjetas
                int i = 0;
                foreach (UsuarioWS.curso c in _cursosAsesorados)
                {
                    tarjCurso tCurso = new tarjCurso(c,true);
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
            int x = (i % 3) * 170 + 20;
            int y = ((int)i / 3) * 120 + 20;
            return new Point(x, y);
        }
        private void btnAniadirCurso_Click(object sender, EventArgs e)
        {
            frmPostularAsesor fromPostular = new frmPostularAsesor();
            fromPostular.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarjReporteAsesor formReporte = new tarjReporteAsesor(_usuario);
            formReporte.ShowDialog();
        }
    }
}