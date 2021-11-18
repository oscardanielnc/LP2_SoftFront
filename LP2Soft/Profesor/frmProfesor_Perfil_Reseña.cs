using LP2Soft.Home;
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
        private void btnReseniar_Click(object sender, EventArgs e)
        {
            frmCrearReseniaProfesor formCrearResenia = new frmCrearReseniaProfesor(_profesor);
            formCrearResenia.ShowDialog();
            if (formCrearResenia.DialogResult == DialogResult.OK)
            {
                formCrearResenia.Resenia.fechaRegistro = DateTime.Now;
                formCrearResenia.Resenia.usuario = new CursosWS.usuario();
                formCrearResenia.Resenia.usuario.idUsuario = frmHome.Usuario.idUsuario;
                formCrearResenia.Resenia.usuario.nombre = frmHome.Usuario.nombre;
                formCrearResenia.Resenia.usuario.apellido = frmHome.Usuario.apellido;
                formCrearResenia.Resenia.usuario.foto = frmHome.Usuario.foto;

                agregarResenia(formCrearResenia.Resenia);
            }
        }

        private void renderizarResenias(CursosWS.profesor _profesor)
        {
            _resenias = null;
            try
            {
                _resenias = new BindingList<CursosWS.resenia>(_daoProfesor.listarReseniasProfesor(_profesor.idProfesor));
                //renderizamos las tarjetas
                foreach (CursosWS.resenia re in _resenias)
                {
                    agregarResenia(re);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El profesor no cuenta con reseñas por el momento", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarResenia(CursosWS.resenia re)
        {
            tarjResenia tProfesor = new tarjResenia(re);
            tProfesor.TopLevel = false;
            tProfesor.Dock = DockStyle.Top;
            panelResenias.Controls.Add(tProfesor);
            panelResenias.Controls.SetChildIndex(tProfesor, 0);
            tProfesor.Visible = true;
        }
    }
}
