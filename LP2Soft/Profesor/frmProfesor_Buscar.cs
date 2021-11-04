using LP2Soft.Tarjetas;
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
    public partial class frmProfesor_Buscar : Form
    {
        private BindingList<CursosWS.profesor> _profesoresBusqueda;
        private CursosWS.CursosWSClient _daoProfesor;
        public frmProfesor_Buscar(string nombre)
        {
            InitializeComponent();
            _daoProfesor = new CursosWS.CursosWSClient();

            renderizarBusqueda(nombre);
        }

        private void renderizarBusqueda(string nombre)
        {
            try
            {
                _profesoresBusqueda = new BindingList<CursosWS.profesor>(_daoProfesor.listarProfesoresNombre(nombre));
                lblInfo.Text = "Se han encontrado " + _profesoresBusqueda.Count + " profesores.";
                //renderizamos las tarjetas
                int i = 0;
                foreach (CursosWS.profesor p in _profesoresBusqueda)
                {
                    tarjProfesor tProfesor = new tarjProfesor(p);
                    tProfesor.TopLevel = false;
                    tProfesor.Location = generarCoordenadas(i);
                    /*tUsuario.Dock = DockStyle.Top;*/
                    panelProfesores.Controls.Add(tProfesor);
                    panelProfesores.Controls.SetChildIndex(tProfesor, 0);
                    tProfesor.Visible = true;
                    i++;
                }
            }
            catch (Exception ex)
            {
                lblInfo.Text = "No se han encontrado usuarios que coincidan con esta búsqueda.";
            }
        }

        private Point generarCoordenadas(int i)
        {
            int x = (i % 5) * 156;
            int y = ((int)i / 5) * 146;
            return new Point(x, y);
        }
    }
}
