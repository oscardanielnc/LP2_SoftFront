
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCrearPublicacion = new System.Windows.Forms.TextBox();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.lblPublicacionesGenerales = new System.Windows.Forms.Label();
            this.panelTendenciasMateriales = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPublicacionesGenerales.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.panelTendenciasMateriales.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPublicacionesGenerales
            // 
            this.panelPublicacionesGenerales.AutoScroll = true;
            this.panelPublicacionesGenerales.Controls.Add(this.panel1);
            this.panelPublicacionesGenerales.Controls.Add(this.lblPublicacionesGenerales);
            this.panelPublicacionesGenerales.Location = new System.Drawing.Point(12, 12);
            this.panelPublicacionesGenerales.Name = "panelPublicacionesGenerales";
            this.panelPublicacionesGenerales.Size = new System.Drawing.Size(388, 565);
            this.panelPublicacionesGenerales.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtCrearPublicacion);
            this.panel1.Controls.Add(this.pbPerfil);
            this.panel1.Location = new System.Drawing.Point(33, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 37);
            this.panel1.TabIndex = 5;
            // 
            // txtCrearPublicacion
            // 
            this.txtCrearPublicacion.Location = new System.Drawing.Point(54, 9);
            this.txtCrearPublicacion.Name = "txtCrearPublicacion";
            this.txtCrearPublicacion.Size = new System.Drawing.Size(228, 20);
            this.txtCrearPublicacion.TabIndex = 3;
            this.txtCrearPublicacion.Text = "Crear publicaicón";
            // 
            // pbPerfil
            // 
            this.pbPerfil.Location = new System.Drawing.Point(3, 3);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(36, 30);
            this.pbPerfil.TabIndex = 2;
            this.pbPerfil.TabStop = false;
            // 
            // lblPublicacionesGenerales
            // 
            this.lblPublicacionesGenerales.AutoSize = true;
            this.lblPublicacionesGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicacionesGenerales.Location = new System.Drawing.Point(12, 16);
            this.lblPublicacionesGenerales.Name = "lblPublicacionesGenerales";
            this.lblPublicacionesGenerales.Size = new System.Drawing.Size(207, 20);
            this.lblPublicacionesGenerales.TabIndex = 4;
            this.lblPublicacionesGenerales.Text = "Publicaciones Generales";
            // 
            // panelTendenciasMateriales
            // 
            this.panelTendenciasMateriales.Controls.Add(this.label1);
            this.panelTendenciasMateriales.Location = new System.Drawing.Point(450, 12);
            this.panelTendenciasMateriales.Name = "panelTendenciasMateriales";
            this.panelTendenciasMateriales.Size = new System.Drawing.Size(263, 565);
            this.panelTendenciasMateriales.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tendencias en Materiales";
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 589);
            this.Controls.Add(this.panelTendenciasMateriales);
            this.Controls.Add(this.panelPublicacionesGenerales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomePage";
            this.Text = "frmHomePage";
            this.panelPublicacionesGenerales.ResumeLayout(false);
            this.panelPublicacionesGenerales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.panelTendenciasMateriales.ResumeLayout(false);
            this.panelTendenciasMateriales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPublicacionesGenerales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCrearPublicacion;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lblPublicacionesGenerales;
        private System.Windows.Forms.Panel panelTendenciasMateriales;
        private System.Windows.Forms.Label label1;
    }
}