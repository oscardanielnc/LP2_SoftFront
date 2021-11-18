using LP2Soft.Home;
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
            if (cboNombre.Text != "" && txtCantidad.Text!="" && txtPeso.Text!="")
            {
                int n;
                if (Int32.TryParse(txtCantidad.Text, out n) && Int32.TryParse(txtPeso.Text, out n)
                    && Int32.Parse(txtCantidad.Text)>0 && Int32.Parse(txtPeso.Text) > 0)
                {
                    if(Int32.Parse(txtCantidad.Text)==1 && checkBoxEliminarNotaBaja.Checked)
                    {
                        MessageBox.Show("No puede eliminar la nota más baja si solo tiene una nota.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else
                    {
                        agregarNuevoRegistro(cboNombre.Text, Int32.Parse(txtPeso.Text),
                            Int32.Parse(txtCantidad.Text), checkBoxEliminarNotaBaja.Checked);
                        cboNombre.Text = "";
                        txtCantidad.Text = "";
                        txtPeso.Text = "";

                    }
                } else
                {
                    MessageBox.Show("Los campos de cantidad y peso del registro necesitan ser valores enteros positivos.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe de completar todos los campos para poder agragar un nuevo registro de notas.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(todasLasNotasValidas())
            {
                int sumaPesos = 0,pesoFinal=0,flag=0;
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
                       totalFinal = totalFinal + reg.PesoRegistro * reg.calcularNotaFinal();
                
                }
            
                promedioFinal = total / sumaPesos;
                mevoyFinal = (10.5f * sumaPesos - totalFinal)/pesoFinal;
                lblPromedio.Text = promedioFinal.ToString("0.00");
                lblNotaMinima.Text = mevoyFinal.ToString("0.00");
            }
        }
        private bool todasLasNotasValidas()
        {
            foreach (regNotas reg in _notasFinales)
            {
                if (!reg.consultarValoresValidos()) return false;
            }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            frmHome.abrirFormulario(new frmCalculadorNotas());
        }
    }
}
