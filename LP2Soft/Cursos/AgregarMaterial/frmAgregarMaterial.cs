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
    public partial class frmAgregarMaterial : Form
    {
        int _cancelar;
        public frmAgregarMaterial()
        {
            InitializeComponent();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (txtProfesor.Text.Length == 0)
            {
                lblProfesorMsj.Text = "Debe completar el campo profesor";
                
            }
            else {
                MessageBox.Show("Se Subio satisfactoriamente");
                this.Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtProfesor.Text.Length != 0)
            {
                frmEstasSeguroDeCancelar estasSeguroDeCancelar = new frmEstasSeguroDeCancelar();
                if(estasSeguroDeCancelar.ShowDialog()==DialogResult.OK)
                    this.Close();
                
            }
            
            
        }

        private void btbCargarDocs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuadrito para seleccionar y subir");
        }

        
    }
}
