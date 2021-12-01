using LP2Soft.Eventos;
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
    public partial class frmPerfil_Publicaciones : Form
    {
        public static string fI, fF;
        public static int idCurso, flag;
        UsuarioWS.usuario _usuario = frmHome.Usuario;
        PublicacionesWS.PublicacionesWSClient _daoPost;
        BindingList<PublicacionesWS.postGenerico> _publicaciones;
        PublicacionesWS.postGenerico _postCreado;
        

        private static int _cantidadPost = 0;
        private static Form _formActivo = null;
        public frmPerfil_Publicaciones()
        {
            InitializeComponent();
            _usuario = frmHome.Usuario;
            string fechaIni = "01-01-2020";
            string fechaFin = "01-01-2022";
            listarPublicaciones(0, fechaIni, fechaFin,1);
            //abrirFormulario(new frmPostEvento());
        }
        public void abrirFormulario(Form formulario)
        {
            if (_formActivo != null) _formActivo.Close();
            _formActivo = formulario;
            _formActivo.TopLevel = false;
            _formActivo.FormBorderStyle = FormBorderStyle.None;
            /*_formActivo.Dock = DockStyle.Fill;*/
            pnPublicaciones.Controls.Add(_formActivo);
            _formActivo.Show();
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            frmFiltrarPublicaciones filtro = new frmFiltrarPublicaciones();
            if (filtro.ShowDialog() == DialogResult.OK)
            {
                pnPublicaciones.Controls.Clear();
                listarPublicaciones(idCurso, fI, fF, flag);
            }
        }

        public void listarPublicaciones(int idCurso, string fechaI, string fechaF, int conCurso)
        {
            pnPublicaciones.Controls.Clear();
            _daoPost = new PublicacionesWS.PublicacionesWSClient();
            PublicacionesWS.postGenerico[] posts = _daoPost.listarMisPublicaciones(_usuario.idUsuario , idCurso, fechaI, fechaF, conCurso);


            if (posts != null)
                _publicaciones = new BindingList<PublicacionesWS.postGenerico>(posts.ToList());
            else
                _publicaciones = null;
            if (_publicaciones != null)
            {
                foreach (PublicacionesWS.postGenerico p in _publicaciones)
                {
                    p.usuario.idUsuario = frmHome.Usuario.idUsuario;
                    p.usuario.nombre = frmHome.Usuario.nombre;
                    frmPostGeneral plantillaPost = new frmPostGeneral(p, _usuario);
                    plantillaPost.TopLevel = false;
                    plantillaPost.Dock = DockStyle.Top;
                    pnPublicaciones.Controls.Add(plantillaPost);
                    pnPublicaciones.Controls.SetChildIndex(plantillaPost, 0);
                    plantillaPost.Visible = true;
                    //_publicaciones.RemoveAt(_cantidadPost);
                    _cantidadPost++;
                }
            }
        }
    }
}
