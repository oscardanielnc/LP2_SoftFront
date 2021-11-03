using LP2Soft.Tarjetas;
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
using System.Drawing.Drawing2D;

namespace LP2Soft.Asesor
{
    public partial class frmBuscarAsesor : Form
    {
        private UsuarioWS.UsuariosWSClient _daoUsuario;
        private BindingList<UsuarioWS.usuario> _usuariosBusqueda;
        private BindingList<UsuarioWS.usuario> _asesoresDestacados;

        private frmHome _formHome;
        public frmBuscarAsesor(frmHome formHome)
        {
            InitializeComponent();
            _formHome = formHome;
            _daoUsuario = new UsuarioWS.UsuariosWSClient();
            renderizarPantallaDestacados("");
        }

        private void renderizarPantalla(string nombre)
        {
            _usuariosBusqueda = null;
            try
            {
                _usuariosBusqueda = new BindingList<UsuarioWS.usuario>(_daoUsuario.listarXnombreYcurso(nombre));
                //renderizamos las tarjetas
                int i = 0;
                foreach (UsuarioWS.usuario u in _usuariosBusqueda)
                {
                    tarjAsesor tUsuario = new tarjAsesor(u);
                    tUsuario.TopLevel = false;
                    tUsuario.Location = generarCoordenadas(i);
                    panelBuscar.Controls.Add(tUsuario);
                    panelBuscar.Controls.SetChildIndex(tUsuario, 0);
                    tUsuario.Visible = true;
                    i++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private Point generarCoordenadas(int i)
        {
            int x = (i % 2) * 242 + 20;
            int y = ((int)i / 2) * 200 + 40;
            return new Point(x, y);
        }

        private void renderizarPantallaDestacados(string nombre)
        {
            _usuariosBusqueda = null;
            try
            {
                _asesoresDestacados = new BindingList<UsuarioWS.usuario>(_daoUsuario.listarXnombreYcurso(nombre));
                //renderizamos las tarjetas
                int i = 0;
                foreach (UsuarioWS.usuario u in _asesoresDestacados)
                {
                    tarjAsesor tUsuario = new tarjAsesor(u);
                    tUsuario.TopLevel = false;
                    tUsuario.Location = generarCoordenadasDestacados(i);
                    panelDestacados.Controls.Add(tUsuario);
                    panelDestacados.Controls.SetChildIndex(tUsuario, 0);
                    tUsuario.Visible = true;
                    i++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private Point generarCoordenadasDestacados(int i)
        {
            int x = 40;
            int y = ((int)i) * 200 + 40;
            return new Point(x, y);
        }

        private void btnPostular_Click(object sender, EventArgs e)
        {
            if (!txtBuscar.Text.Equals(""))
            {
                frmPostularAsesor formPostular = new frmPostularAsesor();
                formPostular.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe escribir el nombre de un asesor en el buscador", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        // Efecto Placeholder
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar a un asesor por su nombre")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar a un asesor por su nombre";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelBuscar.Controls.Clear();
            renderizarPantalla(txtBuscar.Text);
        }

        private void btnPostularAsesor_Click(object sender, EventArgs e)
        {
            frmPostularAsesor formPostular = new frmPostularAsesor();
            formPostular.ShowDialog();
        }
    }
    public class BotonChevere : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.Navy;

        //Properties
        [Category("Boton hecho por Renzo")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Boton hecho por Renzo")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Boton hecho por Renzo")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Boton hecho por Renzo")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Boton hecho por Renzo")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public BotonChevere()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
    }
}
