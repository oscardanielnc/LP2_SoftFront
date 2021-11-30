using LP2Soft.Tarjetas;
using LP2Soft.Cursos.Ciclo7;
using LP2Soft.Cursos.Ciclo7.LP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2Soft.Home;
using LP2Soft.CalculadorNotas;

namespace LP2Soft.Cursos
{
    public partial class frmCursos_Home : Form
    {
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private static float _creditosTotales;
        private static Label _lblCreditos = null;

        private static BindingList<tarjCurso> _listaTarjCursos;
        public static BindingList<tarjCurso> ListarTarjCursos { get => _listaTarjCursos; }
        public static float CreditosTotales { get => _creditosTotales; set => _creditosTotales = value; }

        public frmCursos_Home(int idUsuario)
        {
            InitializeComponent();
            _lblCreditos = lblCreditos;
            _creditosTotales = 0;
            _listaTarjCursos = new BindingList<tarjCurso>();
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            todosCursos(idUsuario);
            _listaTarjCursos[0].actualizarEstados();
        }

        private void todosCursos(int idUsuario) 
        {
            // si mi usuario no tiene sus cursos, los solicito a la BD
            if(frmHome.Usuario.cursos == null)
                frmHome.Usuario.cursos = _daoUsuario.listarCursos(idUsuario);

            List<int> i = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (UsuarioWS.curso u in frmHome.Usuario.cursos) 
            {
                tarjCurso tCurso = new tarjCurso(u, false);
                tCurso.TopLevel = false;
                tCurso.Location = generarCoordenadas(i[u.nivel-1],u.nivel);
                panel1.Controls.Add(tCurso);
                panel1.Controls.SetChildIndex(tCurso,0);
                tCurso.Visible = true;
                i[u.nivel-1]++;
                _listaTarjCursos.Add(tCurso);
                if(u.estado==2)
                    _creditosTotales += u.creditos;
            }
            actualizarLlbCreditos();
        }
        public static void actualizarLlbCreditos()
        {
            _lblCreditos.Text = _creditosTotales.ToString("0.00");
        }

        private Point generarCoordenadas(int i,int nivel) 
        {
            int x = (nivel-1) * 150;
            int y = i * 107 + 35;
            return new Point(x, y);
        }

        public void addPanel(Form f)
        {
            while (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            f.TopLevel = false;
            this.panel2.Controls.Add(f);
            f.Show();
        }

        private void btnCiclo1_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(1));
        private void btnCiclo2_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(2));

        private void btnCiclo3_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(3));

        private void btnCiclo4_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(4));

        private void btnCiclo5_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(5));

        private void btnCiclo6_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(6));
        private void btnCiclo7_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(7));

        private void btnCiclo8_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(8));

        private void btnCiclo9_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(9));

        private void btnCiclo10_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(10));


        private void btnCaclculadorNotas_Click(object sender, EventArgs e)
        {
            frmHome.abrirFormulario(new frmCalculadorNotas());
        }

        private void btn1_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(1));

        private void btn2_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(2));

        private void btn3_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(3));

        private void btn4_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(4));

        private void btn5_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(5));

        private void btn6_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(6));

        private void btn7_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(7));

        private void btn8_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(8));

        private void bnt9_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(9));

        private void btn10_Click(object sender, EventArgs e) =>
            addPanel(new frmCursos_Ciclo(10));

        private void botonChevere1_Click(object sender, EventArgs e)
        {
            frmHome.abrirFormulario(new frmCalculadorNotas());
        }
    }
    
}
