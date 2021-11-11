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
            lblMsg.Visible = false;
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
            try
            {
                agregarNuevoRegistro(txtNombre.Text, Int32.Parse(txtPeso.Text),
                Int32.Parse(txtCantidad.Text), checkBoxEliminarNotaBaja.Checked);
            }
            catch
            {
                lblMsg.Visible = true;
            }
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int sumaPesos = 0,pesoFinal=0,flag=0;
            float notaFinal;
            float total = 0.0f,promedioFinal,totalFinal=0.0f,mevoyFinal;
            foreach (regNotas reg in _notasFinales)
            {
                total = total + reg.PesoRegistro * reg.calcularNotaFinal();

                sumaPesos = reg.PesoRegistro + sumaPesos;
                if (flag == 0)
                {
                    pesoFinal = reg.PesoRegistro;
                    flag++;
                }
                else
                {
                   totalFinal = totalFinal + reg.PesoRegistro * reg.calcularNotaFinal();
                    
                }
                
            }
            
            promedioFinal = total / sumaPesos;
            mevoyFinal = (10.5f * sumaPesos - totalFinal)/pesoFinal;
            lblPromedio.Text = promedioFinal.ToString();
            label1.Text = mevoyFinal.ToString();
            
        }
    }
}
