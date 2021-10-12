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
    public partial class frmEjemplo : Form
    {
        public frmEjemplo()
        {
            InitializeComponent();
        }
        public frmEjemplo(string docente1, string docente2, int n)
        {
            InitializeComponent();
            if(n==2)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
            }
            lblNombreProfesor.Text = docente1;
            lblProfesor2.Text = docente2;
        }
    }
}
