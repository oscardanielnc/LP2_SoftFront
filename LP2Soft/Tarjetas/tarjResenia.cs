using LP2Soft.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Tarjetas
{
    public partial class tarjResenia : Form
    {
        private UsuarioWS.UsuariosWSClient _daoResenia;
        private CursosWS.CursosWSClient _daoReseniaC;
        private UsuarioWS.resenia _resenia;
        private CursosWS.resenia _reseniaC;
        public tarjResenia(UsuarioWS.resenia re)
        {
            InitializeComponent();
            _resenia = re;
            _daoResenia = new UsuarioWS.UsuariosWSClient();
            btnEliminar.Visible = false;
            if (re.usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(re.usuario.foto);
                picUsuario.Image = new Bitmap(ms1);
            }
            lblUsuario.Text = " " + re.usuario.nombre + " " + re.usuario.apellido;
            lblDescripcion.Text = re.contenido;
            lblDate.Text = re.fechaRegistro.ToString("yyyy-MM-dd HH:mm:ss");
            lblAsesor.Text = " " + re.usuarioReseniado.nombre + " " + re.usuarioReseniado.apellido;
            calificacion.Text = re.calificacion.ToString();
            if(frmHome.Usuario.idUsuario == re.usuario.idUsuario)
            {
                btnEliminar.Visible = true;
            }
        }

        public tarjResenia(CursosWS.resenia re)
        {
            InitializeComponent();
            _reseniaC = re;
            _daoReseniaC = new CursosWS.CursosWSClient();
            btnEliminar.Visible = false;
            if (re.usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(re.usuario.foto);
                picUsuario.Image = new Bitmap(ms1);
            }
            lblUsuario.Text = " " + re.usuario.nombre + " " + re.usuario.apellido;
            lblDescripcion.Text = re.contenido;
            lblDate.Text = re.fechaRegistro.ToString("yyyy-MM-dd HH:mm:ss");
            lblAsesor.Text = re.profesor.nombre;
            label1.Text = "Profesor: ";
            calificacion.Text = re.calificacion.ToString();
            if (frmHome.Usuario.idUsuario == re.usuario.idUsuario)
            {
                btnEliminar.Visible = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro que deseas eliminar tu resenia?",
                    "Confirmación", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (_resenia != null)
                    _daoResenia.eliminarReseniaAsesor(_resenia.idPost);
                else
                    _daoReseniaC.eliminarReseniasProfesor(_reseniaC.idPost);
            }
        }

        private void lblAsesor_Click(object sender, EventArgs e)
        {

        }
    }
}
