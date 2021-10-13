using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Profesor
{
    public partial class frmProfesores : Form
    {
        public frmProfesores()
        {
            InitializeComponent();
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            frmProfesor_Perfil formPerfil = new frmProfesor_Perfil();
            formPerfil.Show();
        }
    }
}
