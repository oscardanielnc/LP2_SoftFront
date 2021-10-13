using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Cursos.AgregarMaterial
{
    public partial class frmEstasSeguroDeCancelar : Form
    {
        int _cancelar;
        public frmEstasSeguroDeCancelar()
        {
            InitializeComponent();
        }
        
        private void btnCancelaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAceptaCancelar_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
        }
    }
}

