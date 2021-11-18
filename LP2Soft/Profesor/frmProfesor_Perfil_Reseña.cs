using LP2Soft.Perfil;
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
    public partial class frmProfesor_Perfil_Reseña : Form
    {
        private CursosWS.profesor _profesor;
        private CursosWS.CursosWSClient _daoProfesor;
        private BindingList<CursosWS.resenia> _resenias;
        public frmProfesor_Perfil_Reseña(CursosWS.profesor profesor)
        {
            InitializeComponent();
            _profesor = profesor;
            _daoProfesor = new CursosWS.CursosWSClient();
            _resenias = new BindingList<CursosWS.resenia>();
            renderizarResenias(_profesor);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReseniar_Click(object sender, EventArgs e)
        {
            frmCrearReseniaProfesor formCrearResenia = new frmCrearReseniaProfesor(_profesor);
            formCrearResenia.ShowDialog();
        }

        private void renderizarResenias(CursosWS.profesor _profesor)
        {
            _resenias = null;
            try
            {
                _resenias = new BindingList<CursosWS.resenia>(_daoProfesor.listarReseniasProfesor(_profesor.idProfesor));
                //renderizamos las tarjetas
                int i = 0;
                foreach (CursosWS.resenia re in _resenias)
                {
                    tarjResenia tProfesor = new tarjResenia(re);
                    tProfesor.TopLevel = false;
                    tProfesor.Location = generarCoordenadas(i);
                    panelResenias.Controls.Add(tProfesor);
                    panelResenias.Controls.SetChildIndex(tProfesor, 0);
                    tProfesor.Visible = true;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El profesor no cuenta con reseñas por el momento", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Point generarCoordenadas(int i)
        {
            int x = 15;
            int y = ((int)i) * 160 + 10;
            return new Point(x, y);
        }
    }
}
