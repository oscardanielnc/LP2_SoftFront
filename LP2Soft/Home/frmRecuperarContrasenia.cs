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
            _daoUser = new UsuarioWS.UsuariosWSClient();
            string codigoPUCP;
            codigoPUCP = txtCodigo.Text;
            _user = _daoUser.recuperarContrasenia(codigoPUCP);

            // enviar el correo de recuperacion de contraseña
            string to, from, pass, mail, subject;
            to = _user.correo;
            from = "infunablesLP2@gmail.com";
            pass = "infuLP2@";
            mail = "Su contraseña es " + "" + _user.contrasenia + " ";
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
}
