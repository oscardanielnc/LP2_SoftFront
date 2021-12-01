
namespace LP2Soft.Eventos
{
    partial class frmCrearPostGeneral
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
            this.lbCrearPublicacion = new System.Windows.Forms.Label();
            this.lbQueEstasPensando = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.btnPublicar = new LP2Soft.Asesor.BotonChevere();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCrearPublicacion
            // 
            this.lbCrearPublicacion.AutoSize = true;
            this.lbCrearPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrearPublicacion.Location = new System.Drawing.Point(12, 9);
            this.lbCrearPublicacion.Name = "lbCrearPublicacion";
            this.lbCrearPublicacion.Size = new System.Drawing.Size(149, 20);
            this.lbCrearPublicacion.TabIndex = 0;
            this.lbCrearPublicacion.Text = "Crear Publicación";
            // 
            // lbQueEstasPensando
            // 
            this.lbQueEstasPensando.AutoSize = true;
            this.lbQueEstasPensando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQueEstasPensando.Location = new System.Drawing.Point(12, 131);
            this.lbQueEstasPensando.Name = "lbQueEstasPensando";
            this.lbQueEstasPensando.Size = new System.Drawing.Size(167, 16);
            this.lbQueEstasPensando.TabIndex = 3;
            this.lbQueEstasPensando.Text = "¿Qué estás pensando?";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(16, 161);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(370, 78);
            this.txtContenido.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(96, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 16);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Oscar Navarro";
            // 
            // pbPerfil
            // 
            this.pbPerfil.Image = global::LP2Soft.Properties.Resources.images;
            this.pbPerfil.Location = new System.Drawing.Point(16, 48);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(74, 65);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 1;
            this.pbPerfil.TabStop = false;
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnPublicar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnPublicar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnPublicar.BorderRadius = 6;
            this.btnPublicar.BorderSize = 0;
            this.btnPublicar.FlatAppearance.BorderSize = 0;
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.ForeColor = System.Drawing.Color.White;
            this.btnPublicar.Location = new System.Drawing.Point(311, 273);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(75, 23);
            this.btnPublicar.TabIndex = 36;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.TextColor = System.Drawing.Color.White;
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click_1);
            // 
            // frmCrearPostGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 308);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.lbQueEstasPensando);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.lbCrearPublicacion);
            this.Name = "frmCrearPostGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Publicación";
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCrearPublicacion;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lbQueEstasPensando;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label lblNombre;
        private Asesor.BotonChevere btnPublicar;
    }
}