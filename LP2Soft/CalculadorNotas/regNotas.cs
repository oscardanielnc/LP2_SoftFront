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
        private int _notaDelRegistro;
        private int _pesoRegistro;

        private bool _eliminaMasbaja;
        private BindingList<TextBox> _notas;
        public regNotas(string nombre, int peso, int cantidad, bool eliminarMasBaja)
        {
            _notas = new BindingList<TextBox>();
            _pesoRegistro = peso;
            _eliminaMasbaja = eliminarMasBaja;
            InitializeComponent();
            lblNombre.Text = nombre + " (" + peso.ToString() + ")";
            if (eliminarMasBaja) lblNombre.Text = lblNombre.Text + " *";
            generarCamposDeNotas(cantidad);
            
        }

        public int PesoRegistro { get => _pesoRegistro; set => _pesoRegistro = value; }

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
