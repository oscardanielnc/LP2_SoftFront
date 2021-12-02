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

namespace LP2Soft.Perfil
{
    public partial class frmFiltrarPublicaciones : Form
    {
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private UsuarioWS.asesor _asesor;
        private int flag = 0;
        private DateTime dtF1, dtF2;
        public frmFiltrarPublicaciones()
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();
            if (frmHome.Usuario.cursos == null)
                frmHome.Usuario.cursos = _daoUsuario.listarCursos(frmHome.Usuario.idUsuario);
            cboCurso.DataSource = frmHome.Usuario.cursos;
            cboCurso.DisplayMember = "nombre";
            cboCurso.ValueMember = "idCurso";
            frmPerfil_Publicaciones.flag = 1;
            cboCurso.Enabled = false;
            checkbSi.Checked = false;
            checkBNo.Checked = false;
        }

        private void checkbSi_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkbSi.Checked == true)
            {
                checkBNo.Checked = false;
                cboCurso.Enabled = true;
                
                frmPerfil_Publicaciones.flag = 0;
            }
        }

        private void checkBNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBNo.Checked == true)
            {
                checkbSi.Checked = false;
                cboCurso.Enabled = false;
                frmPerfil_Publicaciones.flag = 1;
            }
        }

        private void btnCancelars_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {



            dtF1 = new DateTime(dTIni.Value.Year, dTIni.Value.Month, dTIni.Value.Day);
            frmPerfil_Publicaciones.fI = dtF1.ToString("dd-MM-yyyy");

            dtF2 = new DateTime(dTFin.Value.Year, dTFin.Value.Month, dTFin.Value.Day);
            frmPerfil_Publicaciones.fF = dtF2.ToString("dd-MM-yyyy");

            if (checkbSi.Checked == false && checkBNo.Checked == false)
            {
                MessageBox.Show("Elegir si desea filtrarlo por cursos");
            }
            else
            {
                UsuarioWS.curso _auxCurso = cboCurso.SelectedItem as UsuarioWS.curso;
                frmPerfil_Publicaciones.idCurso = _auxCurso.idCurso;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
