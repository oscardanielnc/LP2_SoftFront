using LP2Soft.Home;
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

namespace LP2Soft.Perfil
{
    public partial class frmPerfil_Resenias : Form
    {
        private UsuarioWS.usuario _asesor;
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private BindingList<UsuarioWS.resenia> _resenias;
        public frmPerfil_Resenias(UsuarioWS.usuario asesor)
        {
            InitializeComponent();
            _asesor = asesor;
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            _resenias = new BindingList<UsuarioWS.resenia>();
            renderizarResenias(_asesor);
            if (asesor.idUsuario == frmHome.Usuario.idUsuario || !asesor.esAsesor)
                btnReseniar.Visible = false;
        }
        private void btnReseniar_Click(object sender, EventArgs e)
        {
            frmCrearResenia formCrearResenia = new frmCrearResenia(_asesor);
            formCrearResenia.ShowDialog();
            if(formCrearResenia.DialogResult==DialogResult.OK)
            {
                formCrearResenia.Resenia.fechaRegistro = DateTime.Now;
                agregarResenia(formCrearResenia.Resenia);
            }
        }

        private void renderizarResenias(UsuarioWS.usuario _asesor)
        {
            _resenias = null;
            if(_asesor.esAsesor)
            {
                try
                {
                    _resenias = new BindingList<UsuarioWS.resenia>(_daoUsuario.listarReseniasAsesor(_asesor.asesor.idAsesor));
                    //renderizamos las tarjetas
                    foreach (UsuarioWS.resenia re in _resenias)
                    {
                        agregarResenia(re);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El usuario asesor no cuenta con reseñas por el momento", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void agregarResenia(UsuarioWS.resenia re)
        {
            tarjResenia tUsuario = new tarjResenia(re);
            tUsuario.TopLevel = false;
            tUsuario.Dock = DockStyle.Top;
            panelResenias.Controls.Add(tUsuario);
            panelResenias.Controls.SetChildIndex(tUsuario, 0);
            tUsuario.Visible = true;
        }

    }
}
