using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Asesor
{
    public partial class frmPostularAsesor : Form
    {
        private CursosWS.CursosWSClient _daoCurso;
        public frmPostularAsesor()
        {
            InitializeComponent();
            _daoCurso = new CursosWS.CursosWSClient();
            //cboCurso.DataSource = _daoCurso.listarCursos();
            //cboCurso.DisplayMember = "nombre";
            //cboCurso.ValueMember = "idCurso"; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
