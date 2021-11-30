using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Home
{
    public partial class frmRecuperarContrasenia : Form
    {
        private UsuarioWS.UsuariosWSClient _daoUser;
        private UsuarioWS.usuario _user;
        public frmRecuperarContrasenia()
        {
            InitializeComponent();
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            int resultado=0;
            String newPass= "12345";
            _daoUser = new UsuarioWS.UsuariosWSClient();
            string codigoPUCP;
            codigoPUCP = txtCodigo.Text;
            _user = _daoUser.recuperarContrasenia(codigoPUCP);
            resultado = _daoUser.modificarContrasenia(_user.idUsuario,Encriptador.GetSHA256(newPass));
            if (resultado==0)
            {
                MessageBox.Show("No se pudo cambiar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // enviar el correo de recuperacion de contraseña
                string to, from, pass, mail, subject;
                to = _user.correo;
                from = "infunablesLP2@gmail.com";
                pass = "infuLP2@";
                mail = "Su contraseña temporal es: 12345 \nRecuerde cambiar su contraseña al ingresar al sistema.";
                subject = "Recuperación de contraseña, sistema INFunables";
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mail;
                message.Subject = subject;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Contraseña enviada correctamente", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                btnEnviarCorreo_Click(sender, e);
        }
    }
}
