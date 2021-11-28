using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LP2Soft.Home
{
    public partial class frmPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private static Form _formActivo = null;
        private static Panel _panelPrincipal = null;
        private static Loading _loading;
        private static Thread _hilo = null;

        public static void startLoading()
        {
            if (_loading==null)
            {
                _loading = new Loading();
                _hilo = new Thread(_loading.run);
                _hilo.Start();
                _loading.Show();
            }
        }
        public static void endLoading()
        {
            if(_loading!=null)
                _loading.Close();
            _loading = null;
        }
        
        public frmPrincipal()
        {
            InitializeComponent();
            _panelPrincipal = panelPrincipal;
            abrirFormulario(new frmLoginSingin());
        }

        public static void abrirFormulario(Form formulario)
        {
            if (_formActivo != null) _formActivo.Close();
            _formActivo = null;
            _formActivo = formulario;
            _formActivo.TopLevel = false;
            _formActivo.FormBorderStyle = FormBorderStyle.None;
            /*_formActivo.Dock = DockStyle.Fill;*/
            _panelPrincipal.Controls.Add(formulario);
            _formActivo.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }
    }
}
