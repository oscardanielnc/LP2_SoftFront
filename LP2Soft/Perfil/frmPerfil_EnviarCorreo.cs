using LP2Soft.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Perfil
{
    public partial class frmPerfil_EnviarCorreo : Form
    {
        public frmPerfil_EnviarCorreo(UsuarioWS.usuario _asesor)
        {
            InitializeComponent();
            lblReceiverMail.Text = _asesor.correo;
            lblSenderMail.Text = frmHome.Usuario.correo;
        }

        private void btbCargarDocs_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "JPG Files(*.jpg) |*.jpg| PNG Files (*.png) |*.png| PDF Files (*.pdf) |*.pdf|All files (*.*)|*.*";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    txtArchivo.Text = op.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            string to, from, pass, mail, subject, filename;
            to = (lblReceiverMail.Text).ToString();
            from = (lblSenderMail.Text).ToString();
            pass = (txtContraseña.Text).ToString();
            mail = (txtMensaje.Text).ToString();
            subject = (txtAsunto.Text).ToString();
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = subject;
            filename = (txtArchivo.Text).ToString();
            if (filename.Length > 0)
            {
                Attachment file = new Attachment(filename);
                message.Attachments.Add(file);
            }
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from,pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Email enviado correctamente", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
