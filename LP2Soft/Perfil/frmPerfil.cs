using LP2Soft.Enumerados;
using LP2Soft.Home;
using LP2Soft.Mensajes;
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

namespace LP2Soft.Perfil
{
    public partial class frmPerfil : Form
    {
        private static Form _formActivo = null;
        private static MenuPerfil _menuSeleccionado;
        private UsuarioWS.usuario _usuario;
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private NotificacionesWS.NotificacionesWSClient _daoNotificacion;
        private bool _propio;
        private bool _esAmigo;
        public frmPerfil(UsuarioWS.usuario usuario)
        {
            _daoNotificacion = new NotificacionesWS.NotificacionesWSClient();
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            _usuario = usuario;
            if (usuario.idUsuario == frmHome.Usuario.idUsuario)
                _propio = true;
            else _propio = false;
            InitializeComponent();
            btnInformacion.BackColor = Color.FromArgb(28, 103, 179);
            _menuSeleccionado = MenuPerfil.Informacion; // se muestra el menu de información por defecto


            actualizarPantallas();
            actualizarIconosAdministrador();

            if (_propio)
            {
                btnAmigo.Visible = false;
                btnMensaje.Visible = false;
            }
            else
            {
                int resultado = _daoUsuario.esAmigo(frmHome.Usuario.idUsuario, _usuario.idUsuario);
                // 0Noamigo, ni quiere ser; 1 es amigo; 2 No amigo, envió solicitud; 3 No amigo, yo envié solicitud
                actualizarBotonesDelPerfil(resultado);
            }

            abrirFormulario(new frmPerfil_Informacion(_usuario, _propio));
        }
        private void actualizarBotonesDelPerfil(int resultado)
        {
            _esAmigo = false;
            switch (resultado)
            {
                case 1:
                    _esAmigo = true;
                    btnAmigo.Visible = true;
                    btnCancelarSoli.Visible = false;
                    btnRechazar.Visible = false;
                    btnAceptar.Visible = false;
                    btnAmigo.ImageIndex = 0;
                    break;
                case 2:
                    btnAmigo.Visible = false;
                    btnCancelarSoli.Visible = false;
                    btnRechazar.Visible = true;
                    btnAceptar.Visible = true;
                    break;
                case 3:
                    btnAmigo.Visible = false;
                    btnCancelarSoli.Visible = true;
                    btnRechazar.Visible = false;
                    btnAceptar.Visible = false;
                    break;
                default:
                    btnAmigo.Visible = true;
                    btnCancelarSoli.Visible = false;
                    btnRechazar.Visible = false;
                    btnAceptar.Visible = false;
                    btnAmigo.ImageIndex = 1;
                    break;
            }
            if (_esAmigo || _usuario.esAsesor) btnMensaje.Visible = true;
            else btnMensaje.Visible = false;
        }
        private void actualizarPantallas()
        {
            lblTituloNombre.Text = _usuario.nombre + " " + _usuario.apellido;
            if (_usuario.foto != null)
            {
                MemoryStream ms1 = new MemoryStream(_usuario.foto);
                imgPerfil.Image = new Bitmap(ms1);
            }
        }
        private void actualizarIconosAdministrador()
        {
            if(_usuario.esAdmin)
            {
                imgAdmin.Visible = true;
                btnHacerAdmin.Visible = false;
            } else {
                imgAdmin.Visible = false;
                if(frmHome.Usuario.esAdmin)
                    btnHacerAdmin.Visible = true;
                else btnHacerAdmin.Visible = false;
            }
        }
        public void abrirFormulario(Form formulario)
        {
            if (_formActivo != null) _formActivo.Close();
            _formActivo = null;
            _formActivo = formulario;
            _formActivo.TopLevel = false;
            _formActivo.FormBorderStyle = FormBorderStyle.None;
            /*_formActivo.Dock = DockStyle.Fill;*/
            panelContenido.Controls.Add(_formActivo);
            _formActivo.Show();
        }
        private void inicializarColorBotones()
        {
            btnInformacion.BackColor = SystemColors.ControlDarkDark;
            btnPublicaciones.BackColor = SystemColors.ControlDarkDark;
            btnAmigos.BackColor = SystemColors.ControlDarkDark;
            btnCursos.BackColor = SystemColors.ControlDarkDark;
            btnResenias.BackColor = SystemColors.ControlDarkDark;
        }
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuPerfil.Informacion)
            {
                inicializarColorBotones();
                btnInformacion.BackColor = Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuPerfil.Informacion;
                abrirFormulario(new frmPerfil_Informacion(_usuario, _propio));
            }
        }

        private void btnPublicaciones_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuPerfil.Publicaciones)
            {
                frmPrincipal.startLoading();
                inicializarColorBotones();
                btnPublicaciones.BackColor = Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuPerfil.Publicaciones;
                abrirFormulario(new frmPerfil_Publicaciones());
                frmPrincipal.endLoading();
            }
        }

        private void btnAmigos_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuPerfil.Amigos)
            {
                frmPrincipal.startLoading();
                inicializarColorBotones();
                btnAmigos.BackColor = Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuPerfil.Amigos;
                abrirFormulario(new frmPerfil_Amigos(_usuario));
                frmPrincipal.endLoading();
            }
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuPerfil.Cursos)
            {
                frmPrincipal.startLoading();
                inicializarColorBotones();
                btnCursos.BackColor = Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuPerfil.Cursos;
                abrirFormulario(new frmPerfil_CursosAsesorados(_usuario));
                frmPrincipal.endLoading();
            }
        }

        private void btnResenias_Click(object sender, EventArgs e)
        {
            if (_menuSeleccionado != MenuPerfil.Resenias)
            {
                frmPrincipal.startLoading();
                inicializarColorBotones();
                btnResenias.BackColor = Color.FromArgb(28, 103, 179);
                _menuSeleccionado = MenuPerfil.Resenias;
                abrirFormulario(new frmPerfil_Resenias(_usuario));
                frmPrincipal.endLoading();
            }
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            frmHome.abrirFormulario(new frmMensajeChat(_usuario));
            frmPrincipal.endLoading();
        }

        private void btnAmigo_Click(object sender, EventArgs e)
        {
            if (_esAmigo)
            {
                // eleminar Amigo
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar a " + _usuario.nombre + " de su lista de amigos?",
                    "Confirmación", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        frmPrincipal.startLoading();
                        if (_daoUsuario.eliminarAmigo(frmHome.Usuario.idUsuario, _usuario.idUsuario) == 1)
                        {
                            frmPrincipal.endLoading();
                            string mensaje = _usuario.nombre + " " + _usuario.apellido + " se ha eliminado de tu lista de amigos.";
                            MessageBox.Show(mensaje, "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            actualizarBotonesDelPerfil(0);
                        }
                    }
                    catch (Exception ex)
                    {
                        frmPrincipal.endLoading();
                        MessageBox.Show("Ha ocurrido un error al tratar de poner fin a tu amistad", 
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // agregarAmigo
                DialogResult result = MessageBox.Show("¿Está seguro que desea agregar a " + _usuario.nombre + " de su lista de amigos?",
                    "Confirmación", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        frmPrincipal.startLoading();
                        if (_daoNotificacion.insertarNotificacion(_usuario.idUsuario, 1, 0, frmHome.Usuario.idUsuario, -1,-1,-1)==1)
                        {
                            frmPrincipal.endLoading();
                            string mensaje = " Se ha enviado una solicitud de amistad a " + _usuario.nombre + " " + _usuario.apellido;
                            MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizarBotonesDelPerfil(3);
                        }
                    } catch(Exception ex)
                    {
                        frmPrincipal.endLoading();
                        MessageBox.Show("Ha ocurrido un error al tratar de enviar la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelarSoli_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar su solicitud de amistad?",
                "Confirmación", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    frmPrincipal.startLoading();
                    if (_daoNotificacion.eliminarSolicitudAmistad(_usuario.idUsuario, frmHome.Usuario.idUsuario) == 1)
                    {
                        frmPrincipal.endLoading();
                        MessageBox.Show("Has cancelado tu solicitud de amistad", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarBotonesDelPerfil(0);
                    }
                }
                catch (Exception ex)
                {
                    frmPrincipal.endLoading();
                    MessageBox.Show("Ha ocurrido un error al tratar de cacelar la solicitud",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            try
            {
                if (_daoNotificacion.eliminarSolicitudAmistad(frmHome.Usuario.idUsuario, _usuario.idUsuario) == 1)
                {
                    frmPrincipal.endLoading();
                    MessageBox.Show("Has rechazado la solicitud de amistad de " + _usuario.nombre, 
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarBotonesDelPerfil(0);
                }
            }
            catch (Exception ex)
            {
                frmPrincipal.endLoading();
                MessageBox.Show("Ha ocurrido un error al tratar de rechazar la solicitud",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmPrincipal.startLoading();
            try
            {
                if(_daoUsuario.agregarAmigo(frmHome.Usuario.idUsuario, _usuario.idUsuario) == 1)
                {
                    _daoNotificacion.eliminarSolicitudAmistad(frmHome.Usuario.idUsuario, _usuario.idUsuario);
                    if (_daoNotificacion.insertarNotificacion(_usuario.idUsuario, 1, 1, frmHome.Usuario.idUsuario, -1, -1, -1) == 1)
                    {
                        frmPrincipal.endLoading();
                        MessageBox.Show("¡Has agregado a " + _usuario.nombre + " a tu lista de amigos!",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        frmPrincipal.endLoading();
                        MessageBox.Show("¡Has agregado a " + _usuario.nombre + " a tu lista de amigos. Pero no se le pudo notificar.",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    actualizarBotonesDelPerfil(1);
                } else MessageBox.Show("Ocurrió un problema inesperado al tratar de agregar a " + _usuario.nombre + " a tu lista de amigos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                frmPrincipal.endLoading();
                MessageBox.Show("Ha ocurrido un error inesperado en el servidor :(",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHacerAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de convertir a " + _usuario.nombre + " en administrador?",
                "Confirmación", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                frmPrincipal.startLoading();
                try
                {
                    if (_daoUsuario.hacerAdmin(_usuario.idUsuario) == 1)
                    {
                        _usuario.esAdmin = true;
                        actualizarIconosAdministrador();
                        int resultado = _daoNotificacion.insertarNotificacion(_usuario.idUsuario, 0, -1, -1, -1, -1, -1);
                        frmPrincipal.endLoading();

                        if (resultado == 1)
                            MessageBox.Show(_usuario.nombre + " se ha convertido en administrador exitosamente!",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show(_usuario.nombre + " se ha convertido en administrador, pero no fue posible notificarle",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        frmPrincipal.endLoading();
                        MessageBox.Show("Ha ocurrido un error al tratar de actualizar los datos de " + _usuario.nombre,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    frmPrincipal.endLoading();
                    MessageBox.Show("Ha ocurrido un error inesperado en el servidor!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}