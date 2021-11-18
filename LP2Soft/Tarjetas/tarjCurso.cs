using LP2Soft.Cursos;
using LP2Soft.Cursos.Ciclo7.LP2;
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

namespace LP2Soft.Tarjetas
{
    public partial class tarjCurso : Form
    {
        private int _idCurso;
        private float _creditos;
        private CursosWS.CursosWSClient _daoCurso;
        private CursosWS.curso _cursoVer;

        public tarjCurso(UsuarioWS.curso curso, bool onlyRead)
        {
            _daoCurso = new CursosWS.CursosWSClient();
            InitializeComponent();
            _idCurso = curso.idCurso;
            _creditos = curso.creditos;

            lblCodigo.Text = curso.codigo;
            lblNombre.Text = curso.nombre;
            lblCreditos.Text = curso.creditos.ToString("0.00");
            lblNombre.Location = posicionarLabel();

            this.Click += new EventHandler((object sender, EventArgs e) =>  this.mostrarCurso());
            lblCodigo.Click += new EventHandler((object sender, EventArgs e) => this.mostrarCurso());
            lblNombre.Click += new EventHandler((object sender, EventArgs e) => this.mostrarCurso());
            lblCreditos.Click += new EventHandler((object sender, EventArgs e) => this.mostrarCurso());

            cambiarColor(curso.estado);
            if (onlyRead)
            {
                btnCorazon.Visible = false; //
                btnNewState.Visible = false;
                this.BackColor = Color.DarkGray;
            }
        }

        private Point posicionarLabel()
        {
            int x = (143 - lblNombre.Size.Width) /2 ;
            return new Point(x,30);
        }
        private void mostrarCurso()
        {
            frmPrincipal.startLoading();

            _cursoVer = _daoCurso.MostrarCurso(_idCurso);
            if (_cursoVer != null)
                frmHome.abrirFormulario(new frmCursos_VerCurso(_cursoVer));

            frmPrincipal.endLoading();
        }
        public void cambiarColor(int estado)
        {
            if (estado == 2)
            {
                this.BackColor = Color.FromArgb(0, 221, 125);
                btnCorazon.BackColor = Color.FromArgb(0, 221, 125);
                btnNewState.BackColor = Color.FromArgb(0, 221, 125);
            }
            else if (estado == 1)
            {
                this.BackColor = Color.FromArgb(28, 103, 179);
                btnCorazon.BackColor = Color.FromArgb(28, 103, 179);
                btnNewState.BackColor = Color.FromArgb(28, 103, 179);
            }
            else
            {
                this.BackColor = Color.FromArgb(237, 64, 64);
                btnCorazon.BackColor = Color.FromArgb(237, 64, 64);
                btnNewState.BackColor = Color.FromArgb(237, 64, 64);
            }
        }

        private void btnNewState_Click(object sender, EventArgs e)
        {
            if(frmHome.Usuario.cursos[_idCurso-1].estado == 1)
            {
                frmHome.Usuario.cursos[_idCurso - 1].estado = 2;
                cambiarColor(2);
                frmCursos_Home.CreditosTotales += _creditos;
                frmCursos_Home.actualizarLlbCreditos();
                actualizarEstados();
            }
            else if (frmHome.Usuario.cursos[_idCurso - 1].estado == 2)
            {
                frmHome.Usuario.cursos[_idCurso - 1].estado = 1;
                cambiarColor(1);
                frmCursos_Home.CreditosTotales -= _creditos;
                frmCursos_Home.actualizarLlbCreditos();
                actualizarEstados();
            }
        }
        public void actualizarEstados()
        {
            foreach(UsuarioWS.curso cursoBase in frmHome.Usuario.cursos)
            {
                if(cursoBase.estado==0 || cursoBase.estado == 1)
                {
                    if(cursoBase.creditosRequeridos<=frmCursos_Home.CreditosTotales)
                    {
                        bool permitido = true;
                        if(cursoBase.cursosRequeridos != null)
                        {
                            foreach(UsuarioWS.curso cursoReq in cursoBase.cursosRequeridos)
                            {
                                if (frmHome.Usuario.cursos[cursoReq.idCurso-1].estado != 2)
                                    permitido = false;
                            }
                        }
                        if (permitido)
                        {
                            frmHome.Usuario.cursos[cursoBase.idCurso - 1].estado = 1;
                            frmCursos_Home.ListarTarjCursos[cursoBase.idCurso - 1].cambiarColor(1);
                        } else
                        {
                            cursoBase.estado = 0;
                            frmHome.Usuario.cursos[cursoBase.idCurso - 1].estado = 0;
                            frmCursos_Home.ListarTarjCursos[cursoBase.idCurso - 1].cambiarColor(0);
                        }
                    } else
                    {
                        frmCursos_Home.ListarTarjCursos[cursoBase.idCurso - 1].cambiarColor(frmHome.Usuario.cursos[cursoBase.idCurso - 1].estado);
                    }
                }
            }
        }
    }
}
