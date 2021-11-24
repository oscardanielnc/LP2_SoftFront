
namespace LP2Soft.Perfil
{
    partial class frmPerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResenias = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnAmigos = new System.Windows.Forms.Button();
            this.btnPublicaciones = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.imgAmigo = new System.Windows.Forms.ImageList(this.components);
            this.btnAmigo = new System.Windows.Forms.Label();
            this.btnMensaje = new System.Windows.Forms.PictureBox();
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelNombre = new System.Windows.Forms.Panel();
            this.btnAceptar = new LP2Soft.Asesor.BotonChevere();
            this.btnRechazar = new LP2Soft.Asesor.BotonChevere();
            this.btnCancelarSoli = new LP2Soft.Asesor.BotonChevere();
            this.btnHacerAdmin = new System.Windows.Forms.PictureBox();
            this.imgAdmin = new System.Windows.Forms.PictureBox();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.tooltipPerfil = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHacerAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnResenias);
            this.panel1.Controls.Add(this.btnCursos);
            this.panel1.Controls.Add(this.btnAmigos);
            this.panel1.Controls.Add(this.btnPublicaciones);
            this.panel1.Controls.Add(this.btnInformacion);
            this.panel1.Location = new System.Drawing.Point(50, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 31);
            this.panel1.TabIndex = 10;
            // 
            // btnResenias
            // 
            this.btnResenias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResenias.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResenias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(86)))), ((int)(((byte)(171)))));
            this.btnResenias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResenias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResenias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResenias.Location = new System.Drawing.Point(560, 0);
            this.btnResenias.Name = "btnResenias";
            this.btnResenias.Size = new System.Drawing.Size(140, 31);
            this.btnResenias.TabIndex = 4;
            this.btnResenias.Text = "Reseñas";
            this.btnResenias.UseVisualStyleBackColor = true;
            this.btnResenias.Click += new System.EventHandler(this.btnResenias_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCursos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(86)))), ((int)(((byte)(171)))));
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCursos.Location = new System.Drawing.Point(420, 0);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(140, 31);
            this.btnCursos.TabIndex = 3;
            this.btnCursos.Text = "Cursos Asesorados";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnAmigos
            // 
            this.btnAmigos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmigos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAmigos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(86)))), ((int)(((byte)(171)))));
            this.btnAmigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmigos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAmigos.Location = new System.Drawing.Point(280, 0);
            this.btnAmigos.Name = "btnAmigos";
            this.btnAmigos.Size = new System.Drawing.Size(140, 31);
            this.btnAmigos.TabIndex = 2;
            this.btnAmigos.Text = "Amigos";
            this.btnAmigos.UseVisualStyleBackColor = true;
            this.btnAmigos.Click += new System.EventHandler(this.btnAmigos_Click);
            // 
            // btnPublicaciones
            // 
            this.btnPublicaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublicaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPublicaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(86)))), ((int)(((byte)(171)))));
            this.btnPublicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPublicaciones.Location = new System.Drawing.Point(140, 0);
            this.btnPublicaciones.Name = "btnPublicaciones";
            this.btnPublicaciones.Size = new System.Drawing.Size(140, 31);
            this.btnPublicaciones.TabIndex = 1;
            this.btnPublicaciones.Text = "Publicaciones";
            this.btnPublicaciones.UseVisualStyleBackColor = true;
            this.btnPublicaciones.Click += new System.EventHandler(this.btnPublicaciones_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(86)))), ((int)(((byte)(171)))));
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInformacion.Location = new System.Drawing.Point(0, 0);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(140, 31);
            this.btnInformacion.TabIndex = 0;
            this.btnInformacion.Text = "Información";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.AutoSize = true;
            this.panelContenido.BackColor = System.Drawing.SystemColors.Window;
            this.panelContenido.Location = new System.Drawing.Point(1, 249);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(796, 231);
            this.panelContenido.TabIndex = 11;
            // 
            // imgAmigo
            // 
            this.imgAmigo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAmigo.ImageStream")));
            this.imgAmigo.TransparentColor = System.Drawing.Color.Transparent;
            this.imgAmigo.Images.SetKeyName(0, "user-minus.png");
            this.imgAmigo.Images.SetKeyName(1, "user-plus.png");
            // 
            // btnAmigo
            // 
            this.btnAmigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmigo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAmigo.ImageIndex = 1;
            this.btnAmigo.ImageList = this.imgAmigo;
            this.btnAmigo.Location = new System.Drawing.Point(460, 0);
            this.btnAmigo.Name = "btnAmigo";
            this.btnAmigo.Size = new System.Drawing.Size(30, 30);
            this.btnAmigo.TabIndex = 14;
            this.tooltipPerfil.SetToolTip(this.btnAmigo, "Agregar/eliminar amigo");
            this.btnAmigo.Click += new System.EventHandler(this.btnAmigo_Click);
            // 
            // btnMensaje
            // 
            this.btnMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMensaje.Image = global::LP2Soft.Properties.Resources.bubble;
            this.btnMensaje.Location = new System.Drawing.Point(688, 185);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(30, 30);
            this.btnMensaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMensaje.TabIndex = 13;
            this.btnMensaje.TabStop = false;
            this.tooltipPerfil.SetToolTip(this.btnMensaje, "Abrir chat");
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // imgPerfil
            // 
            this.imgPerfil.Image = global::LP2Soft.Properties.Resources.images;
            this.imgPerfil.Location = new System.Drawing.Point(106, 135);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(80, 80);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerfil.TabIndex = 8;
            this.imgPerfil.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LP2Soft.Properties.Resources.campus_pucp_cia_letras_2020_03_1920x1080_1___copia;
            this.pictureBox2.Location = new System.Drawing.Point(78, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(640, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panelNombre
            // 
            this.panelNombre.AutoSize = true;
            this.panelNombre.BackColor = System.Drawing.SystemColors.Control;
            this.panelNombre.Controls.Add(this.btnAceptar);
            this.panelNombre.Controls.Add(this.btnRechazar);
            this.panelNombre.Controls.Add(this.btnCancelarSoli);
            this.panelNombre.Controls.Add(this.btnHacerAdmin);
            this.panelNombre.Controls.Add(this.imgAdmin);
            this.panelNombre.Controls.Add(this.btnAmigo);
            this.panelNombre.Controls.Add(this.lblTituloNombre);
            this.panelNombre.Location = new System.Drawing.Point(192, 185);
            this.panelNombre.Name = "panelNombre";
            this.panelNombre.Size = new System.Drawing.Size(490, 30);
            this.panelNombre.TabIndex = 14;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnAceptar.BorderRadius = 5;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(202, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(69, 30);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.Color.White;
            this.btnRechazar.BackgroundColor = System.Drawing.Color.White;
            this.btnRechazar.BorderColor = System.Drawing.Color.White;
            this.btnRechazar.BorderRadius = 5;
            this.btnRechazar.BorderSize = 0;
            this.btnRechazar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRechazar.FlatAppearance.BorderSize = 0;
            this.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.ForeColor = System.Drawing.Color.Black;
            this.btnRechazar.Location = new System.Drawing.Point(271, 0);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(69, 30);
            this.btnRechazar.TabIndex = 29;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.TextColor = System.Drawing.Color.Black;
            this.btnRechazar.UseVisualStyleBackColor = false;
            this.btnRechazar.Visible = false;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnCancelarSoli
            // 
            this.btnCancelarSoli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnCancelarSoli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnCancelarSoli.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnCancelarSoli.BorderRadius = 5;
            this.btnCancelarSoli.BorderSize = 0;
            this.btnCancelarSoli.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelarSoli.FlatAppearance.BorderSize = 0;
            this.btnCancelarSoli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarSoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSoli.ForeColor = System.Drawing.Color.White;
            this.btnCancelarSoli.Location = new System.Drawing.Point(340, 0);
            this.btnCancelarSoli.Name = "btnCancelarSoli";
            this.btnCancelarSoli.Size = new System.Drawing.Size(120, 30);
            this.btnCancelarSoli.TabIndex = 28;
            this.btnCancelarSoli.Text = "Cancelar Solicitud";
            this.btnCancelarSoli.TextColor = System.Drawing.Color.White;
            this.btnCancelarSoli.UseVisualStyleBackColor = false;
            this.btnCancelarSoli.Visible = false;
            this.btnCancelarSoli.Click += new System.EventHandler(this.btnCancelarSoli_Click);
            // 
            // btnHacerAdmin
            // 
            this.btnHacerAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHacerAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHacerAdmin.Image = global::LP2Soft.Properties.Resources.chevrons_up_solid_24;
            this.btnHacerAdmin.Location = new System.Drawing.Point(148, 0);
            this.btnHacerAdmin.Name = "btnHacerAdmin";
            this.btnHacerAdmin.Size = new System.Drawing.Size(25, 30);
            this.btnHacerAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHacerAdmin.TabIndex = 17;
            this.btnHacerAdmin.TabStop = false;
            this.tooltipPerfil.SetToolTip(this.btnHacerAdmin, "Hacer administrador");
            this.btnHacerAdmin.Click += new System.EventHandler(this.btnHacerAdmin_Click);
            // 
            // imgAdmin
            // 
            this.imgAdmin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imgAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgAdmin.Image = global::LP2Soft.Properties.Resources.badge_check_solid_24;
            this.imgAdmin.Location = new System.Drawing.Point(123, 0);
            this.imgAdmin.Name = "imgAdmin";
            this.imgAdmin.Size = new System.Drawing.Size(25, 30);
            this.imgAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAdmin.TabIndex = 16;
            this.imgAdmin.TabStop = false;
            this.tooltipPerfil.SetToolTip(this.imgAdmin, "Insignia de administrador");
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombre.Location = new System.Drawing.Point(0, 0);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(123, 20);
            this.lblTituloNombre.TabIndex = 7;
            this.lblTituloNombre.Text = "Oscar Navarro";
            // 
            // tooltipPerfil
            // 
            this.tooltipPerfil.Tag = "";
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(823, 492);
            this.Controls.Add(this.panelNombre);
            this.Controls.Add(this.btnMensaje);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgPerfil);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfil";
            this.Text = "frmPerfil";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelNombre.ResumeLayout(false);
            this.panelNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHacerAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgPerfil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnResenias;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnAmigos;
        private System.Windows.Forms.Button btnPublicaciones;
        private System.Windows.Forms.PictureBox btnMensaje;
        private System.Windows.Forms.Label btnAmigo;
        private System.Windows.Forms.ImageList imgAmigo;
        private System.Windows.Forms.Panel panelNombre;
        private System.Windows.Forms.PictureBox btnHacerAdmin;
        private System.Windows.Forms.PictureBox imgAdmin;
        private System.Windows.Forms.Label lblTituloNombre;
        private Asesor.BotonChevere btnAceptar;
        private Asesor.BotonChevere btnRechazar;
        private Asesor.BotonChevere btnCancelarSoli;
        private System.Windows.Forms.ToolTip tooltipPerfil;
    }
}