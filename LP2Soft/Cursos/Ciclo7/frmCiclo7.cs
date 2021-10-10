using LP2Soft.Cursos.Ciclo7.LP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Cursos.Ciclo7
{
    public partial class frmCiclo7 : Form
    {
        public frmCiclo7()
        {
            InitializeComponent();
        }

        private void btnCiclo7LP2_Click(object sender, EventArgs e)
        {
            frmCiclo7LP2 ciclo7LP2 = new frmCiclo7LP2();
            ciclo7LP2.ShowDialog();
        }

        private void btnCiclo7Material_Click(object sender, EventArgs e)
        {
            frmCursosHome cursosHome = new frmCursosHome();
            cursosHome.ShowDialog();
        }
    }
}
