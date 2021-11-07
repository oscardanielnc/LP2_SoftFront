
namespace LP2Soft.Tarjetas
{
    partial class tarjNotificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarjNotificacion));
            this.panelMensaje = new System.Windows.Forms.Panel();
            this.imgNotif = new System.Windows.Forms.Label();
            this.imgNotificacion = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.btnPostularAsesor = new LP2Soft.Asesor.BotonChevere();
            this.panelMensaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMensaje
            // 
            this.panelMensaje.AutoSize = true;
            this.panelMensaje.BackColor = System.Drawing.Color.White;
            this.panelMensaje.Controls.Add(this.btnPostularAsesor);
            this.panelMensaje.Controls.Add(this.imgNotif);
            this.panelMensaje.Controls.Add(this.pictureBox1);
            this.panelMensaje.Controls.Add(this.lblFechaHora);
            this.panelMensaje.Controls.Add(this.lblContenido);
            this.panelMensaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMensaje.Location = new System.Drawing.Point(5, 5);
            this.panelMensaje.Name = "panelMensaje";
            this.panelMensaje.Size = new System.Drawing.Size(730, 70);
            this.panelMensaje.TabIndex = 22;
            // 
            // imgNotif
            // 
            this.imgNotif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgNotif.ImageIndex = 0;
            this.imgNotif.ImageList = this.imgNotificacion;
            this.imgNotif.Location = new System.Drawing.Point(55, 40);
            this.imgNotif.Name = "imgNotif";
            this.imgNotif.Size = new System.Drawing.Size(22, 22);
            this.imgNotif.TabIndex = 24;
            // 
            // imgNotificacion
            // 
            this.imgNotificacion.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNotificacion.ImageStream")));
            this.imgNotificacion.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNotificacion.Images.SetKeyName(0, "cog.png");
            this.imgNotificacion.Images.SetKeyName(1, "user.png");
            this.imgNotificacion.Images.SetKeyName(2, "book.png");
            this.imgNotificacion.Images.SetKeyName(3, "calendar.png");
            this.imgNotificacion.Images.SetKeyName(4, "newspaper.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LP2Soft.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(16, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(590, 40);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(137, 26);
            this.lblFechaHora.TabIndex = 17;
            this.lblFechaHora.Text = "\r\n19/10/2020 a las 23:20 hrs";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(88, 16);
            this.lblContenido.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(431, 16);
            this.lblContenido.TabIndex = 15;
            this.lblContenido.Text = "Felicidades ¡Te has convertido en administrador del sistema!";
            // 
            // btnPostularAsesor
            // 
            this.btnPostularAsesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnPostularAsesor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnPostularAsesor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnPostularAsesor.BorderRadius = 6;
            this.btnPostularAsesor.BorderSize = 0;
            this.btnPostularAsesor.FlatAppearance.BorderSize = 0;
            this.btnPostularAsesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostularAsesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostularAsesor.ForeColor = System.Drawing.Color.White;
            this.btnPostularAsesor.Location = new System.Drawing.Point(631, 14);
            this.btnPostularAsesor.Name = "btnPostularAsesor";
            this.btnPostularAsesor.Size = new System.Drawing.Size(69, 23);
            this.btnPostularAsesor.TabIndex = 25;
            this.btnPostularAsesor.Text = "Ver";
            this.btnPostularAsesor.TextColor = System.Drawing.Color.White;
            this.btnPostularAsesor.UseVisualStyleBackColor = false;
            // 
            // tarjNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 80);
            this.Controls.Add(this.panelMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjNotificacion";
            this.Text = "tarjNotificacion";
            this.panelMensaje.ResumeLayout(false);
            this.panelMensaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMensaje;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imgNotificacion;
        private System.Windows.Forms.Label imgNotif;
        private Asesor.BotonChevere btnPostularAsesor;
    }
}