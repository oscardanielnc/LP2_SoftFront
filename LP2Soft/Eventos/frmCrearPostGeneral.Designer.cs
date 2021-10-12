
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSubirImagen = new System.Windows.Forms.Button();
            this.pbImagenPublicacion = new System.Windows.Forms.PictureBox();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPublicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCrearPublicacion
            // 
            this.lbCrearPublicacion.AutoSize = true;
            this.lbCrearPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrearPublicacion.Location = new System.Drawing.Point(12, 9);
            this.lbCrearPublicacion.Name = "lbCrearPublicacion";
            this.lbCrearPublicacion.Size = new System.Drawing.Size(148, 20);
            this.lbCrearPublicacion.TabIndex = 0;
            this.lbCrearPublicacion.Text = "Crear publicación";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 161);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 78);
            this.textBox1.TabIndex = 4;
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(311, 404);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(75, 23);
            this.btnPublicar.TabIndex = 7;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(96, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 16);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Antony Romero";
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnSubirImagen.BackgroundImage = global::LP2Soft.Properties.Resources.add__1_;
            this.btnSubirImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirImagen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirImagen.Location = new System.Drawing.Point(184, 290);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(42, 31);
            this.btnSubirImagen.TabIndex = 6;
            this.btnSubirImagen.UseVisualStyleBackColor = false;
            // 
            // pbImagenPublicacion
            // 
            this.pbImagenPublicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenPublicacion.Location = new System.Drawing.Point(16, 245);
            this.pbImagenPublicacion.Name = "pbImagenPublicacion";
            this.pbImagenPublicacion.Size = new System.Drawing.Size(370, 135);
            this.pbImagenPublicacion.TabIndex = 5;
            this.pbImagenPublicacion.TabStop = false;
            // 
            // pbPerfil
            // 
            this.pbPerfil.Image = global::LP2Soft.Properties.Resources.DSC_0498;
            this.pbPerfil.Location = new System.Drawing.Point(16, 48);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(74, 65);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 1;
            this.pbPerfil.TabStop = false;
            // 
            // frmCrearPostGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 448);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnSubirImagen);
            this.Controls.Add(this.pbImagenPublicacion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbQueEstasPensando);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.lbCrearPublicacion);
            this.Name = "frmCrearPostGeneral";
            this.Text = "frmCrearPublicacion";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPublicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCrearPublicacion;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lbQueEstasPensando;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbImagenPublicacion;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Button btnSubirImagen;
        private System.Windows.Forms.Label lblNombre;
    }
}