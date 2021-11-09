
namespace LP2Soft.Tarjetas
{
    partial class tarjUltimoMensaje
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
            this.panelMensaje = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.imgAmigo = new System.Windows.Forms.PictureBox();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.btnVerChat = new LP2Soft.Asesor.BotonChevere();
            this.panelMensaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAmigo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMensaje
            // 
            this.panelMensaje.AutoSize = true;
            this.panelMensaje.BackColor = System.Drawing.Color.White;
            this.panelMensaje.Controls.Add(this.lblNombre);
            this.panelMensaje.Controls.Add(this.btnVerChat);
            this.panelMensaje.Controls.Add(this.imgAmigo);
            this.panelMensaje.Controls.Add(this.lblFechaHora);
            this.panelMensaje.Controls.Add(this.lblContenido);
            this.panelMensaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMensaje.Location = new System.Drawing.Point(5, 5);
            this.panelMensaje.Name = "panelMensaje";
            this.panelMensaje.Size = new System.Drawing.Size(730, 65);
            this.panelMensaje.TabIndex = 23;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(95, 9);
            this.lblNombre.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(201, 16);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Oscar Daniel Navarro Cieza";
            // 
            // imgAmigo
            // 
            this.imgAmigo.Image = global::LP2Soft.Properties.Resources.images;
            this.imgAmigo.Location = new System.Drawing.Point(16, 7);
            this.imgAmigo.Name = "imgAmigo";
            this.imgAmigo.Size = new System.Drawing.Size(50, 50);
            this.imgAmigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAmigo.TabIndex = 18;
            this.imgAmigo.TabStop = false;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(582, 41);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(137, 13);
            this.lblFechaHora.TabIndex = 17;
            this.lblFechaHora.Text = "19/10/2020 a las 23:20 hrs";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.ForeColor = System.Drawing.Color.Black;
            this.lblContenido.Location = new System.Drawing.Point(95, 30);
            this.lblContenido.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(371, 16);
            this.lblContenido.TabIndex = 15;
            this.lblContenido.Text = "Felicidades ¡Te has convertido en administrador del sistema!";
            // 
            // btnVerChat
            // 
            this.btnVerChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnVerChat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnVerChat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnVerChat.BorderRadius = 6;
            this.btnVerChat.BorderSize = 0;
            this.btnVerChat.FlatAppearance.BorderSize = 0;
            this.btnVerChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerChat.ForeColor = System.Drawing.Color.White;
            this.btnVerChat.Location = new System.Drawing.Point(611, 9);
            this.btnVerChat.Name = "btnVerChat";
            this.btnVerChat.Size = new System.Drawing.Size(86, 23);
            this.btnVerChat.TabIndex = 25;
            this.btnVerChat.Text = "Ver Chat";
            this.btnVerChat.TextColor = System.Drawing.Color.White;
            this.btnVerChat.UseVisualStyleBackColor = false;
            this.btnVerChat.Click += new System.EventHandler(this.btnVerChat_Click);
            // 
            // tarjUltimoMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 75);
            this.Controls.Add(this.panelMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjUltimoMensaje";
            this.Text = "tarjUltimoMensaje";
            this.panelMensaje.ResumeLayout(false);
            this.panelMensaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAmigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMensaje;
        private Asesor.BotonChevere btnVerChat;
        private System.Windows.Forms.PictureBox imgAmigo;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblNombre;
    }
}