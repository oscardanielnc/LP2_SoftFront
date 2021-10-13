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
    public partial class frmEventosAgendados : Form
    {
        public frmEventosAgendados()
        {
            InitializeComponent();
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            frmCrearEvento frmCrearEvento = new frmCrearEvento();
            frmCrearEvento.ShowDialog();
        }

        private void panelPublicacionesEventos_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == panelPublicacionesEventos.VerticalScroll.Maximum - panelPublicacionesEventos.VerticalScroll.LargeChange + 1)
            {
                if (e.NewValue != e.OldValue) // Checking when the scrollbar is at bottom and user clicks/scrolls the scrollbar      
                {
                    MessageBox.Show("Test"); // Some operation
                }
            }

        }

        private void btnAgendarEvento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se eliminó el evento de tu agenda", "Mensaje Confirmación",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
