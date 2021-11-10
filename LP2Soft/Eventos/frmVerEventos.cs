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
    public partial class frmVerEventos : Form
    {
        public frmVerEventos()
        {
            InitializeComponent();
        }

        private void panelPublicacionesEventos_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == panel1.VerticalScroll.Maximum - panel1.VerticalScroll.LargeChange + 1)
            {
                if (e.NewValue != e.OldValue) // Checking when the scrollbar is at bottom and user clicks/scrolls the scrollbar      
                {
                    MessageBox.Show("Test"); // Some operation
                }
            }

        }
    }
}
