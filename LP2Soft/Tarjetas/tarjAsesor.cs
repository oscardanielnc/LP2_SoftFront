using LP2Soft.Home;
using LP2Soft.Perfil;
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
using System.Drawing.Drawing2D;

namespace LP2Soft.Tarjetas
{
    public partial class tarjAsesor : Form
    {
        private string _codigo;
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private UsuarioWS.usuario _usuarioVer;
        private BindingList<Label> _estrellas;

        public tarjAsesor(UsuarioWS.usuario user)
        {
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            InitializeComponent();
            _estrellas = new BindingList<Label>();
            _estrellas.Add(estrella1);
            _estrellas.Add(estrella2);
            _estrellas.Add(estrella3);
            _estrellas.Add(estrella4);
            _estrellas.Add(estrella5);

            _codigo = user.codigoPUCP;
            posicionarLabel(user);

            if (user.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(user.foto);
                pctAsesor.Image = new Bitmap(ms1);
            }
        }
        private void posicionarLabel(UsuarioWS.usuario usuario)
        {
            lblNombre.Text = usuario.nombre + " " + usuario.apellido;
            int tamanio = lblNombre.Size.Width;
            lblNombre.Location = new Point(((int)(180 - tamanio) / 2), 80);

            float calificacion = (usuario.asesor.cantidadResenias == 0) ? 0 :
                    (float)usuario.asesor.sumatoriaResenias / usuario.asesor.cantidadResenias;
            pintarEstrellas(calificacion);
            lblCal.Text = calificacion.ToString("0.00");
        }
        private void pintarEstrellas(float nEstrellas)
        {
            for (float i = 0; i < 5; i++)
            {
                if (i < nEstrellas)
                {
                    if (i + 0.5 < nEstrellas)
                        _estrellas[(int)i].ImageIndex = 1;
                    else _estrellas[(int)i].ImageIndex = 2;
                }
                else _estrellas[(int)i].ImageIndex = 0;
            }
        }
        private void btnVerPerfil_Click_1(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            _usuarioVer = _daoUsuario.mostrarUsuario(_codigo, 1);
            if (_usuarioVer != null)
                frmHome.abrirFormulario(new frmPerfil(_usuarioVer));

            frmPrincipal.endLoading();
        }
    }
}

