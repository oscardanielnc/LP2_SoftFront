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
    public partial class frmPerfil_Resenias : Form
    {
        public frmPerfil_Resenias()
        {
            InitializeComponent();
        }

        private void btnNuevaResenia_Click(object sender, EventArgs e)
        {
            frmCrearResenia formCrearResenia = new frmCrearResenia();
            formCrearResenia.ShowDialog();
        }
    }
}
