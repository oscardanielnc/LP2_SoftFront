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

        private void button7_Click(object sender, EventArgs e)
        {
            frmProfesor_Perfil formPerfil = new frmProfesor_Perfil();
            formPerfil.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmEjemplo e1 = new frmEjemplo("Juan Perez", "Oscar Daniel", 2);
            e1.TopLevel = false;
            e1.Dock = DockStyle.Top;
            e1.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(e1);
            e1.Show();
        }
    }
}
