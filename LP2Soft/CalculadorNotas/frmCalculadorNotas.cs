using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.CalculadorNotas
{
    public partial class frmCalculadorNotas : Form
    {
        private int _cantidadRegistros;
        private BindingList<regNotas> _notasFinales;
        public frmCalculadorNotas()
        {
            _notasFinales = new BindingList<regNotas>();
            _cantidadRegistros = 0;
            InitializeComponent();
            agregarNuevoRegistro("Examen Final", 2, 1, false);
        }
        private void agregarNuevoRegistro(string nombre, int peso, int cantidad, bool eliminarMasBaja)
        {
            regNotas nuevoregistro = new regNotas(nombre, peso, cantidad, eliminarMasBaja);
            nuevoregistro.TopLevel = false;
            nuevoregistro.Location = new Point(180*_cantidadRegistros, 0);
            /*tUsuario.Dock = DockStyle.Top;*/
            panelNotas.Controls.Add(nuevoregistro);
            panelNotas.Controls.SetChildIndex(nuevoregistro, 0);
            nuevoregistro.Visible = true;
            _notasFinales.Add(nuevoregistro);
            _cantidadRegistros++;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarNuevoRegistro(txtNombre.Text, Int32.Parse(txtPeso.Text), 
                Int32.Parse(txtCantidad.Text), checkBoxEliminarNotaBaja.Checked);
        }
    }
}
