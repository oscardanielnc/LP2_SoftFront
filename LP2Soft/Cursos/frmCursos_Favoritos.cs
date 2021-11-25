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

namespace LP2Soft.Cursos
{
    public partial class frmCursos_Favoritos : Form
    {
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        public frmCursos_Favoritos()
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();

            if (frmHome.Usuario.cursos == null)
                frmHome.Usuario.cursos = _daoUsuario.listarCursos(frmHome.Usuario.idUsuario);

            int i = 0;
            foreach (UsuarioWS.curso u in frmHome.Usuario.cursos)
            {
                if(u.favorito)
                {
                    tarjCurso tCurso = new tarjCurso(u, true);
                    tCurso.TopLevel = false;
                    tCurso.Location = new Point((i%5)*152, (i/5)*110);
                    panelFavoritos.Controls.Add(tCurso);
                    panelFavoritos.Controls.SetChildIndex(tCurso, 0);
                    tCurso.Visible = true;
                    i++;
                }
            }
            if (i == 0) lblInfo.Visible = true;
            else lblInfo.Visible = false;
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            /*frmHome.abrirFormulario();*/
        }
    }
}
