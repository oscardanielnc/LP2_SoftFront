
namespace LP2Soft.Perfil
{
    partial class frmCrearResenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearResenia));
            this.lblResenia = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.imgEstrellas = new System.Windows.Forms.ImageList(this.components);
            this.estrella5 = new System.Windows.Forms.Label();
            this.estrella4 = new System.Windows.Forms.Label();
            this.estrella3 = new System.Windows.Forms.Label();
            this.estrella2 = new System.Windows.Forms.Label();
            this.estrella1 = new System.Windows.Forms.Label();
            this.btnPublicar = new LP2Soft.Asesor.BotonChevere();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResenia
            // 
            this.lblResenia.AutoSize = true;
            this.lblResenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResenia.Location = new System.Drawing.Point(12, 9);
            this.lblResenia.Name = "lblResenia";
            this.lblResenia.Size = new System.Drawing.Size(120, 20);
            this.lblResenia.TabIndex = 8;
            this.lblResenia.Text = "Crear Reseña";
            // 
            // pbPerfil
            // 
            this.pbPerfil.Image = global::LP2Soft.Properties.Resources.images;
            this.pbPerfil.Location = new System.Drawing.Point(16, 60);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(50, 46);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 7;
            this.pbPerfil.TabStop = false;
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(94, 51);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(328, 79);
            this.txtContenido.TabIndex = 9;
            this.txtContenido.Text = "Escribe una reseña a Oscar Navarro";
            this.txtContenido.Enter += new System.EventHandler(this.txtContenido_Enter);
            this.txtContenido.Leave += new System.EventHandler(this.txtContenido_Leave);
            // 
            // imgEstrellas
            // 
            this.imgEstrellas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgEstrellas.ImageStream")));
            this.imgEstrellas.TransparentColor = System.Drawing.Color.Transparent;
            this.imgEstrellas.Images.SetKeyName(0, "star-regular-24.png");
            this.imgEstrellas.Images.SetKeyName(1, "star-solid-24.png");
            this.imgEstrellas.Images.SetKeyName(2, "star-half-solid-24.png");
            // 
            // estrella5
            // 
            this.estrella5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella5.ImageIndex = 0;
            this.estrella5.ImageList = this.imgEstrellas;
            this.estrella5.Location = new System.Drawing.Point(269, 150);
            this.estrella5.Name = "estrella5";
            this.estrella5.Size = new System.Drawing.Size(34, 34);
            this.estrella5.TabIndex = 78;
            this.estrella5.Click += new System.EventHandler(this.estrella5_Click);
            // 
            // estrella4
            // 
            this.estrella4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella4.ImageIndex = 0;
            this.estrella4.ImageList = this.imgEstrellas;
            this.estrella4.Location = new System.Drawing.Point(229, 150);
            this.estrella4.Name = "estrella4";
            this.estrella4.Size = new System.Drawing.Size(34, 34);
            this.estrella4.TabIndex = 77;
            this.estrella4.Click += new System.EventHandler(this.estrella4_Click);
            // 
            // estrella3
            // 
            this.estrella3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella3.ImageIndex = 0;
            this.estrella3.ImageList = this.imgEstrellas;
            this.estrella3.Location = new System.Drawing.Point(189, 150);
            this.estrella3.Name = "estrella3";
            this.estrella3.Size = new System.Drawing.Size(34, 34);
            this.estrella3.TabIndex = 76;
            this.estrella3.Click += new System.EventHandler(this.estrella3_Click);
            // 
            // estrella2
            // 
            this.estrella2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella2.ImageIndex = 0;
            this.estrella2.ImageList = this.imgEstrellas;
            this.estrella2.Location = new System.Drawing.Point(149, 150);
            this.estrella2.Name = "estrella2";
            this.estrella2.Size = new System.Drawing.Size(34, 34);
            this.estrella2.TabIndex = 75;
            this.estrella2.Click += new System.EventHandler(this.estrella2_Click);
            // 
            // estrella1
            // 
            this.estrella1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella1.ImageIndex = 0;
            this.estrella1.ImageList = this.imgEstrellas;
            this.estrella1.Location = new System.Drawing.Point(109, 150);
            this.estrella1.Name = "estrella1";
            this.estrella1.Size = new System.Drawing.Size(34, 34);
            this.estrella1.TabIndex = 74;
            this.estrella1.Click += new System.EventHandler(this.estrella1_Click);
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
            this.btnPublicar.Location = new System.Drawing.Point(347, 155);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(75, 23);
            this.btnPublicar.TabIndex = 85;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.TextColor = System.Drawing.Color.White;
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click_1);
            // 
            // frmCrearResenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 206);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.estrella5);
            this.Controls.Add(this.estrella4);
            this.Controls.Add(this.estrella3);
            this.Controls.Add(this.estrella2);
            this.Controls.Add(this.estrella1);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.lblResenia);
            this.Controls.Add(this.pbPerfil);
            this.Name = "frmCrearResenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Resenia";
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResenia;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.ImageList imgEstrellas;
        private System.Windows.Forms.Label estrella5;
        private System.Windows.Forms.Label estrella4;
        private System.Windows.Forms.Label estrella3;
        private System.Windows.Forms.Label estrella2;
        private System.Windows.Forms.Label estrella1;
        private Asesor.BotonChevere btnPublicar;
    }
}