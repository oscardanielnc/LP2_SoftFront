
namespace LP2Soft.Eventos
{
    partial class frmHomePage
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
            this.panelPublicacionesGenerales = new System.Windows.Forms.Panel();
            this.panelCrearPublicacion = new System.Windows.Forms.Panel();
            this.lblCrearPublicación = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.lblPublicacionesGenerales = new System.Windows.Forms.Label();
            this.panelCrearPublicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPublicacionesGenerales
            // 
            this.panelPublicacionesGenerales.AutoScroll = true;
            this.panelPublicacionesGenerales.Location = new System.Drawing.Point(213, 121);
            this.panelPublicacionesGenerales.Name = "panelPublicacionesGenerales";
            this.panelPublicacionesGenerales.Size = new System.Drawing.Size(408, 372);
            this.panelPublicacionesGenerales.TabIndex = 3;
            this.panelPublicacionesGenerales.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panelPublicacionesGenerales_Scroll);
            // 
            // panelCrearPublicacion
            // 
            this.panelCrearPublicacion.BackColor = System.Drawing.Color.White;
            this.panelCrearPublicacion.Controls.Add(this.lblCrearPublicación);
            this.panelCrearPublicacion.Controls.Add(this.pbPerfil);
            this.panelCrearPublicacion.Location = new System.Drawing.Point(271, 51);
            this.panelCrearPublicacion.Name = "panelCrearPublicacion";
            this.panelCrearPublicacion.Size = new System.Drawing.Size(297, 57);
            this.panelCrearPublicacion.TabIndex = 7;
            // 
            // lblCrearPublicación
            // 
            this.lblCrearPublicación.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrearPublicación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearPublicación.Location = new System.Drawing.Point(59, 17);
            this.lblCrearPublicación.Name = "lblCrearPublicación";
            this.lblCrearPublicación.Size = new System.Drawing.Size(223, 23);
            this.lblCrearPublicación.TabIndex = 22;
            this.lblCrearPublicación.Text = "Crear publicación";
            this.lblCrearPublicación.Click += new System.EventHandler(this.lblCrearPublicación_Click);
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
            // lblPublicacionesGenerales
            // 
            this.lblPublicacionesGenerales.AutoSize = true;
            this.lblPublicacionesGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicacionesGenerales.Location = new System.Drawing.Point(211, 9);
            this.lblPublicacionesGenerales.Name = "lblPublicacionesGenerales";
            this.lblPublicacionesGenerales.Size = new System.Drawing.Size(207, 20);
            this.lblPublicacionesGenerales.TabIndex = 6;
            this.lblPublicacionesGenerales.Text = "Publicaciones Generales";
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 495);
            this.Controls.Add(this.panelCrearPublicacion);
            this.Controls.Add(this.lblPublicacionesGenerales);
            this.Controls.Add(this.panelPublicacionesGenerales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomePage";
            this.Text = "frmHomePage";
            this.panelCrearPublicacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPublicacionesGenerales;
        private System.Windows.Forms.Panel panelCrearPublicacion;
        private System.Windows.Forms.Label lblCrearPublicación;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lblPublicacionesGenerales;
    }
}