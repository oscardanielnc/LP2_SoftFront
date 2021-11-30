
namespace LP2Soft.Eventos
{
    partial class frmMisPublicaciones
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
            this.panelPublicacionesEventos = new System.Windows.Forms.Panel();
            this.lblMisEventos = new System.Windows.Forms.Label();
            this.panelCrearPublicacion = new System.Windows.Forms.Panel();
            this.lblCrearEvento = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.panelCrearPublicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPublicacionesEventos
            // 
            this.panelPublicacionesEventos.AutoScroll = true;
            this.panelPublicacionesEventos.Location = new System.Drawing.Point(199, 133);
            this.panelPublicacionesEventos.Name = "panelPublicacionesEventos";
            this.panelPublicacionesEventos.Size = new System.Drawing.Size(408, 359);
            this.panelPublicacionesEventos.TabIndex = 7;
            // 
            // lblMisEventos
            // 
            this.lblMisEventos.AutoSize = true;
            this.lblMisEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisEventos.Location = new System.Drawing.Point(195, 9);
            this.lblMisEventos.Name = "lblMisEventos";
            this.lblMisEventos.Size = new System.Drawing.Size(106, 20);
            this.lblMisEventos.TabIndex = 6;
            this.lblMisEventos.Text = "Mis Eventos";
            // 
            // panelCrearPublicacion
            // 
            this.panelCrearPublicacion.BackColor = System.Drawing.Color.White;
            this.panelCrearPublicacion.Controls.Add(this.lblCrearEvento);
            this.panelCrearPublicacion.Controls.Add(this.pbPerfil);
            this.panelCrearPublicacion.Location = new System.Drawing.Point(256, 56);
            this.panelCrearPublicacion.Name = "panelCrearPublicacion";
            this.panelCrearPublicacion.Size = new System.Drawing.Size(297, 57);
            this.panelCrearPublicacion.TabIndex = 11;
            // 
            // lblCrearEvento
            // 
            this.lblCrearEvento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrearEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearEvento.Location = new System.Drawing.Point(59, 17);
            this.lblCrearEvento.Name = "lblCrearEvento";
            this.lblCrearEvento.Size = new System.Drawing.Size(223, 23);
            this.lblCrearEvento.TabIndex = 22;
            this.lblCrearEvento.Text = "Crear evento";
            this.lblCrearEvento.Click += new System.EventHandler(this.lblCrearEvento_Click);
            // 
            // pbPerfil
            // 
            this.pbPerfil.Image = global::LP2Soft.Properties.Resources.images;
            this.pbPerfil.Location = new System.Drawing.Point(3, 6);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(50, 46);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 21;
            this.pbPerfil.TabStop = false;
            // 
            // frmMisPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 495);
            this.Controls.Add(this.panelCrearPublicacion);
            this.Controls.Add(this.lblMisEventos);
            this.Controls.Add(this.panelPublicacionesEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMisPublicaciones";
            this.Text = "frmMisEventos";
            this.panelCrearPublicacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPublicacionesEventos;
        private System.Windows.Forms.Label lblMisEventos;
        private System.Windows.Forms.Panel panelCrearPublicacion;
        private System.Windows.Forms.Label lblCrearEvento;
        private System.Windows.Forms.PictureBox pbPerfil;
    }
}