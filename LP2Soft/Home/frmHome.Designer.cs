
namespace LP2Soft.Home
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.lblNumMensajes = new System.Windows.Forms.Label();
            this.lblNumNotificaciones = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.subPanelCursos = new System.Windows.Forms.Panel();
            this.btnCursosFavoritos = new System.Windows.Forms.Button();
            this.btnTodosMisCursos = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.btnMensajes = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.btnNotificaciones = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnAsesores = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnNovedades = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.subPanelCursos.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumMensajes
            // 
            this.lblNumMensajes.AutoSize = true;
            this.lblNumMensajes.Location = new System.Drawing.Point(738, 9);
            this.lblNumMensajes.Name = "lblNumMensajes";
            this.lblNumMensajes.Size = new System.Drawing.Size(13, 13);
            this.lblNumMensajes.TabIndex = 21;
            this.lblNumMensajes.Text = "2";
            // 
            // lblNumNotificaciones
            // 
            this.lblNumNotificaciones.AutoSize = true;
            this.lblNumNotificaciones.Location = new System.Drawing.Point(670, 9);
            this.lblNumNotificaciones.Name = "lblNumNotificaciones";
            this.lblNumNotificaciones.Size = new System.Drawing.Size(19, 13);
            this.lblNumNotificaciones.TabIndex = 20;
            this.lblNumNotificaciones.Text = "10";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(185, 22);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(300, 21);
            this.txtBusqueda.TabIndex = 16;
            this.txtBusqueda.Text = "Buscar a un usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(835, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(97, 30);
            this.lblNombreUsuario.TabIndex = 15;
            this.lblNombreUsuario.Text = "Oscar Daniel\r\nNavarro Cieza";
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelContenido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelContenido.Location = new System.Drawing.Point(185, 61);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(823, 492);
            this.panelContenido.TabIndex = 12;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.panelMenu.Controls.Add(this.btnCerrar);
            this.panelMenu.Controls.Add(this.btnProfesores);
            this.panelMenu.Controls.Add(this.btnAsesores);
            this.panelMenu.Controls.Add(this.subPanelCursos);
            this.panelMenu.Controls.Add(this.btnCursos);
            this.panelMenu.Controls.Add(this.btnEventos);
            this.panelMenu.Controls.Add(this.btnPerfil);
            this.panelMenu.Controls.Add(this.btnNovedades);
            this.panelMenu.Location = new System.Drawing.Point(0, 61);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(179, 492);
            this.panelMenu.TabIndex = 11;
            // 
            // subPanelCursos
            // 
            this.subPanelCursos.AutoSize = true;
            this.subPanelCursos.Controls.Add(this.btnCursosFavoritos);
            this.subPanelCursos.Controls.Add(this.btnTodosMisCursos);
            this.subPanelCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelCursos.Location = new System.Drawing.Point(0, 200);
            this.subPanelCursos.Name = "subPanelCursos";
            this.subPanelCursos.Size = new System.Drawing.Size(179, 62);
            this.subPanelCursos.TabIndex = 14;
            this.subPanelCursos.Visible = false;
            // 
            // btnCursosFavoritos
            // 
            this.btnCursosFavoritos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursosFavoritos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCursosFavoritos.FlatAppearance.BorderSize = 2;
            this.btnCursosFavoritos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnCursosFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursosFavoritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursosFavoritos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCursosFavoritos.Location = new System.Drawing.Point(0, 31);
            this.btnCursosFavoritos.Name = "btnCursosFavoritos";
            this.btnCursosFavoritos.Size = new System.Drawing.Size(179, 31);
            this.btnCursosFavoritos.TabIndex = 1;
            this.btnCursosFavoritos.Text = "Favoritos";
            this.btnCursosFavoritos.UseVisualStyleBackColor = true;
            // 
            // btnTodosMisCursos
            // 
            this.btnTodosMisCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTodosMisCursos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTodosMisCursos.FlatAppearance.BorderSize = 2;
            this.btnTodosMisCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnTodosMisCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosMisCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosMisCursos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTodosMisCursos.Location = new System.Drawing.Point(0, 0);
            this.btnTodosMisCursos.Name = "btnTodosMisCursos";
            this.btnTodosMisCursos.Size = new System.Drawing.Size(179, 31);
            this.btnTodosMisCursos.TabIndex = 0;
            this.btnTodosMisCursos.Text = "Todos mis cursos";
            this.btnTodosMisCursos.UseVisualStyleBackColor = true;
            this.btnTodosMisCursos.Click += new System.EventHandler(this.btnTodosMisCursos_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Window;
            this.panelHeader.Controls.Add(this.lblNombreUsuario);
            this.panelHeader.Controls.Add(this.imgLogo);
            this.panelHeader.Controls.Add(this.lblNumMensajes);
            this.panelHeader.Controls.Add(this.imgUsuario);
            this.panelHeader.Controls.Add(this.lblNumNotificaciones);
            this.panelHeader.Controls.Add(this.btnMensajes);
            this.panelHeader.Controls.Add(this.txtBusqueda);
            this.panelHeader.Controls.Add(this.btnBuscar);
            this.panelHeader.Controls.Add(this.btnNotificaciones);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1008, 62);
            this.panelHeader.TabIndex = 13;
            // 
            // imgLogo
            // 
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgLogo.Image = global::LP2Soft.Properties.Resources.Logo_INFunables;
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(120, 62);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 13;
            this.imgLogo.TabStop = false;
            // 
            // imgUsuario
            // 
            this.imgUsuario.Image = global::LP2Soft.Properties.Resources.DSC_0498;
            this.imgUsuario.Location = new System.Drawing.Point(779, 5);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(50, 50);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUsuario.TabIndex = 14;
            this.imgUsuario.TabStop = false;
            // 
            // btnMensajes
            // 
            this.btnMensajes.Image = global::LP2Soft.Properties.Resources.bubble;
            this.btnMensajes.Location = new System.Drawing.Point(711, 16);
            this.btnMensajes.Name = "btnMensajes";
            this.btnMensajes.Size = new System.Drawing.Size(30, 30);
            this.btnMensajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMensajes.TabIndex = 19;
            this.btnMensajes.TabStop = false;
            this.btnMensajes.Click += new System.EventHandler(this.btnMensajes_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::LP2Soft.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(491, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 30);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.TabStop = false;
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Image = global::LP2Soft.Properties.Resources.bell;
            this.btnNotificaciones.Location = new System.Drawing.Point(643, 16);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(30, 30);
            this.btnNotificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNotificaciones.TabIndex = 18;
            this.btnNotificaciones.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(0, 362);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(179, 50);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "Cerrar sesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfesores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProfesores.FlatAppearance.BorderSize = 2;
            this.btnProfesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfesores.Image = ((System.Drawing.Image)(resources.GetObject("btnProfesores.Image")));
            this.btnProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesores.Location = new System.Drawing.Point(0, 312);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(179, 50);
            this.btnProfesores.TabIndex = 17;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnAsesores
            // 
            this.btnAsesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsesores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAsesores.FlatAppearance.BorderSize = 2;
            this.btnAsesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnAsesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsesores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsesores.Image = ((System.Drawing.Image)(resources.GetObject("btnAsesores.Image")));
            this.btnAsesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsesores.Location = new System.Drawing.Point(0, 262);
            this.btnAsesores.Name = "btnAsesores";
            this.btnAsesores.Size = new System.Drawing.Size(179, 50);
            this.btnAsesores.TabIndex = 16;
            this.btnAsesores.Text = "Asesores";
            this.btnAsesores.UseVisualStyleBackColor = true;
            this.btnAsesores.Click += new System.EventHandler(this.btnAsesores_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCursos.FlatAppearance.BorderSize = 2;
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCursos.Image = ((System.Drawing.Image)(resources.GetObject("btnCursos.Image")));
            this.btnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.Location = new System.Drawing.Point(0, 150);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(179, 50);
            this.btnCursos.TabIndex = 12;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEventos.FlatAppearance.BorderSize = 2;
            this.btnEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEventos.Image = ((System.Drawing.Image)(resources.GetObject("btnEventos.Image")));
            this.btnEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventos.Location = new System.Drawing.Point(0, 100);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(179, 50);
            this.btnEventos.TabIndex = 11;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPerfil.FlatAppearance.BorderSize = 2;
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(0, 50);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(179, 50);
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnNovedades
            // 
            this.btnNovedades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovedades.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovedades.FlatAppearance.BorderSize = 2;
            this.btnNovedades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnNovedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovedades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovedades.Image = ((System.Drawing.Image)(resources.GetObject("btnNovedades.Image")));
            this.btnNovedades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovedades.Location = new System.Drawing.Point(0, 0);
            this.btnNovedades.Name = "btnNovedades";
            this.btnNovedades.Size = new System.Drawing.Size(179, 50);
            this.btnNovedades.TabIndex = 0;
            this.btnNovedades.Text = "Novedades";
            this.btnNovedades.UseVisualStyleBackColor = true;
            this.btnNovedades.Click += new System.EventHandler(this.btnNovedades_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.subPanelCursos.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumMensajes;
        private System.Windows.Forms.Label lblNumNotificaciones;
        private System.Windows.Forms.PictureBox btnMensajes;
        private System.Windows.Forms.PictureBox btnNotificaciones;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnNovedades;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnAsesores;
        private System.Windows.Forms.Panel subPanelCursos;
        private System.Windows.Forms.Button btnCursosFavoritos;
        private System.Windows.Forms.Button btnTodosMisCursos;
    }
}