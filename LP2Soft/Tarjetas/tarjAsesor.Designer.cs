
namespace LP2Soft.Tarjetas
{
    partial class tarjAsesor
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
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pctAsesor = new System.Windows.Forms.PictureBox();
            this.lblCal = new System.Windows.Forms.Label();
            this.btnVerPerfil = new LP2Soft.Asesor.BotonChevere();
            ((System.ComponentModel.ISupportInitialize)(this.pctAsesor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(29, 125);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(80, 16);
            this.lblCalificacion.TabIndex = 17;
            this.lblCalificacion.Text = "Calificación:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(38, 78);
            this.lblNombre.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(116, 20);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Renzo Richle";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pctAsesor
            // 
            this.pctAsesor.Image = global::LP2Soft.Properties.Resources.images;
            this.pctAsesor.Location = new System.Drawing.Point(63, 15);
            this.pctAsesor.Name = "pctAsesor";
            this.pctAsesor.Size = new System.Drawing.Size(60, 60);
            this.pctAsesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAsesor.TabIndex = 15;
            this.pctAsesor.TabStop = false;
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCal.Location = new System.Drawing.Point(110, 125);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(15, 16);
            this.lblCal.TabIndex = 19;
            this.lblCal.Text = "4";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnVerPerfil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnVerPerfil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnVerPerfil.BorderRadius = 6;
            this.btnVerPerfil.BorderSize = 0;
            this.btnVerPerfil.FlatAppearance.BorderSize = 0;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.ForeColor = System.Drawing.Color.White;
            this.btnVerPerfil.Location = new System.Drawing.Point(55, 151);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 26);
            this.btnVerPerfil.TabIndex = 20;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.TextColor = System.Drawing.Color.White;
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click_1);
            // 
            // tarjAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(180, 191);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pctAsesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjAsesor";
            this.Text = "tarjAsesor";
            ((System.ComponentModel.ISupportInitialize)(this.pctAsesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pctAsesor;
        private System.Windows.Forms.Label lblCal;
        private Asesor.BotonChevere btnVerPerfil;
    }
}