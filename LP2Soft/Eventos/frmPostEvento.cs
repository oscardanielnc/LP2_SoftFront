using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Eventos
{
    public partial class frmPostEvento : Form
    {
        public frmPostEvento()
        {
            InitializeComponent();
        }

        private void btnAgendarEvento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se agendó el evento", "Mensaje Confirmación",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
