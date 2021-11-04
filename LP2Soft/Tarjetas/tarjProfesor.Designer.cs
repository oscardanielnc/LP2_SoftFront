
namespace LP2Soft.Tarjetas
{
    partial class tarjProfesor
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
            this.imgProfesor = new System.Windows.Forms.PictureBox();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // imgProfesor
            // 
            this.imgProfesor.Image = global::LP2Soft.Properties.Resources.images;
            this.imgProfesor.Location = new System.Drawing.Point(49, 12);
            this.imgProfesor.Name = "imgProfesor";
            this.imgProfesor.Size = new System.Drawing.Size(80, 80);
            this.imgProfesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProfesor.TabIndex = 26;
            this.imgProfesor.TabStop = false;
            this.imgProfesor.Click += new System.EventHandler(this.imgProfesor_Click);
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Location = new System.Drawing.Point(81, 139);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(13, 13);
            this.lblPuntuacion.TabIndex = 23;
            this.lblPuntuacion.Text = "5";
            this.lblPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPuntuacion.Click += new System.EventHandler(this.lblPuntuacion_Click);
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.SystemColors.Window;
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerPerfil.FlatAppearance.BorderSize = 2;
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(86)))), ((int)(((byte)(171)))));
            this.btnVerPerfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerPerfil.Location = new System.Drawing.Point(49, 165);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 24;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click_1);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(53, 100);
            this.lblNombre.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 13);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Freddy Paz";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // tarjProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(180, 200);
            this.Controls.Add(this.imgProfesor);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjProfesor";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgProfesor;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Button btnVerPerfil;
        private System.Windows.Forms.Label lblNombre;
    }
}