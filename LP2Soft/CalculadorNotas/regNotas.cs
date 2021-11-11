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
    public partial class regNotas : Form
    {
        private int _pesoRegistro;

        private bool _eliminaMasbaja;
        private BindingList<TextBox> _notas;
        public regNotas(string nombre, int peso, int cantidad, bool eliminarMasBaja)
        {
            _notas = new BindingList<TextBox>();
            _pesoRegistro = peso;
            _eliminaMasbaja = eliminarMasBaja;
            InitializeComponent();
            lblNombre.Text = (eliminarMasBaja) ? nombre + " *": nombre;
            txtPeso.Text = peso.ToString();
            generarCamposDeNotas(cantidad);
        }

        public int PesoRegistro { get => Int32.Parse(txtPeso.Text); set => _pesoRegistro = value; }

        public float calcularNotaFinal()
        {
            
            int notaMinima = 999999,sumaNotas=0,aux,cant;
            foreach(TextBox txt in _notas)
            {
                aux = Int32.Parse(txt.Text);
                sumaNotas = aux + sumaNotas;
                if (aux < notaMinima) notaMinima = aux;

            }
            //TextBox txt2 = _notas.Min();
            if (_eliminaMasbaja)
            {
                if (_notas.Count() - 1 == 0)
                {
                    cant = _notas.Count();
                    return sumaNotas / cant;
                }
                else
                {
                    cant = _notas.Count() - 1;
                    sumaNotas = sumaNotas - notaMinima;
                    return sumaNotas / cant;
                }

            }
            else
            {
                cant = _notas.Count();
                return sumaNotas / cant;

            }
        }
        public bool consultarValoresValidos()
        {
            int n;
            if(Int32.TryParse(txtPeso.Text, out n) && Int32.Parse(txtPeso.Text) > 0)
            {
                foreach (TextBox txt in _notas)
                {
                    if (!(Int32.TryParse(txt.Text, out n) && Int32.Parse(txt.Text) >= 0 && Int32.Parse(txt.Text) <= 20))
                    {
                        MessageBox.Show("No todas las notas ingresadas contienen valores enteros entre 0 y 20", "Warning",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

            } else {
                MessageBox.Show("El peso del registro debería ser un número entero positivo.", "Warning",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        

        private void generarCamposDeNotas(int cantidad)
        {
            for(int i=0; i<cantidad; i++)
            {
                // crear panel contenedor
                Panel panelNota = new Panel();
                panelNota.Size = new Size(168, 30);
                panelNota.Dock = DockStyle.Top;
                // agregar lbl y txt
                Label lbl = new Label();
                lbl.Text = "" + (i + 1).ToString() + ": ";
                lbl.Location = new Point(17,6);
                panelNota.Controls.Add(lbl);
                panelNota.Controls.SetChildIndex(lbl, 0);
                lbl.Visible = true;
                TextBox txt = new TextBox();
                txt.Text = "0";
                txt.Location = new Point(43, 3);
                panelNota.Controls.Add(txt);
                panelNota.Controls.SetChildIndex(txt, 0);
                txt.Visible = true;
                // necesitamos conocer los valores en los txt
                _notas.Add(txt);
                //agregar panel a la lista de paneles
                panelNotas.Controls.Add(panelNota);
                panelNotas.Controls.SetChildIndex(panelNota, 0);
                panelNota.Visible = true;
            }
        }
    }
}
