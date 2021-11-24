
namespace LP2Soft.Perfil
{
    partial class frmCrearReseniaProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearReseniaProfesor));
            this.btnPublicar = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lblResenia = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.imgEstrellas = new System.Windows.Forms.ImageList(this.components);
            this.estrella5 = new System.Windows.Forms.Label();
            this.estrella4 = new System.Windows.Forms.Label();
            this.estrella3 = new System.Windows.Forms.Label();
            this.estrella2 = new System.Windows.Forms.Label();
            this.estrella1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(349, 169);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(75, 23);
            this.btnPublicar.TabIndex = 20;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(96, 59);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(328, 79);
            this.txtContenido.TabIndex = 19;
            this.txtContenido.Text = "Escribe una reseña a Oscar Navarro";
            // 
            // lblResenia
            // 
            this.lblResenia.AutoSize = true;
            this.lblResenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResenia.Location = new System.Drawing.Point(14, 17);
            this.lblResenia.Name = "lblResenia";
            this.lblResenia.Size = new System.Drawing.Size(120, 20);
            this.lblResenia.TabIndex = 18;
            this.lblResenia.Text = "Crear Reseña";
            // 
            // pbPerfil
            // 
            this.pbPerfil.Image = global::LP2Soft.Properties.Resources.images;
            this.pbPerfil.Location = new System.Drawing.Point(18, 68);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(50, 46);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 17;
            this.pbPerfil.TabStop = false;
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
            this.estrella5.Location = new System.Drawing.Point(281, 158);
            this.estrella5.Name = "estrella5";
            this.estrella5.Size = new System.Drawing.Size(34, 34);
            this.estrella5.TabIndex = 83;
            this.estrella5.Click += new System.EventHandler(this.estrella5_Click);
            // 
            // estrella4
            // 
            this.estrella4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella4.ImageIndex = 0;
            this.estrella4.ImageList = this.imgEstrellas;
            this.estrella4.Location = new System.Drawing.Point(241, 158);
            this.estrella4.Name = "estrella4";
            this.estrella4.Size = new System.Drawing.Size(34, 34);
            this.estrella4.TabIndex = 82;
            this.estrella4.Click += new System.EventHandler(this.estrella4_Click);
            // 
            // estrella3
            // 
            this.estrella3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella3.ImageIndex = 0;
            this.estrella3.ImageList = this.imgEstrellas;
            this.estrella3.Location = new System.Drawing.Point(201, 158);
            this.estrella3.Name = "estrella3";
            this.estrella3.Size = new System.Drawing.Size(34, 34);
            this.estrella3.TabIndex = 81;
            this.estrella3.Click += new System.EventHandler(this.estrella3_Click);
            // 
            // estrella2
            // 
            this.estrella2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella2.ImageIndex = 0;
            this.estrella2.ImageList = this.imgEstrellas;
            this.estrella2.Location = new System.Drawing.Point(161, 158);
            this.estrella2.Name = "estrella2";
            this.estrella2.Size = new System.Drawing.Size(34, 34);
            this.estrella2.TabIndex = 80;
            this.estrella2.Click += new System.EventHandler(this.estrella2_Click);
            // 
            // estrella1
            // 
            this.estrella1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella1.ImageIndex = 0;
            this.estrella1.ImageList = this.imgEstrellas;
            this.estrella1.Location = new System.Drawing.Point(121, 158);
            this.estrella1.Name = "estrella1";
            this.estrella1.Size = new System.Drawing.Size(34, 34);
            this.estrella1.TabIndex = 79;
            this.estrella1.Click += new System.EventHandler(this.estrella1_Click);
            // 
            // frmCrearReseniaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 208);
            this.Controls.Add(this.estrella5);
            this.Controls.Add(this.estrella4);
            this.Controls.Add(this.estrella3);
            this.Controls.Add(this.estrella2);
            this.Controls.Add(this.estrella1);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.lblResenia);
            this.Controls.Add(this.pbPerfil);
            this.Name = "frmCrearReseniaProfesor";
            this.Text = "frmCrearReseniaProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label lblResenia;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.ImageList imgEstrellas;
        private System.Windows.Forms.Label estrella5;
        private System.Windows.Forms.Label estrella4;
        private System.Windows.Forms.Label estrella3;
        private System.Windows.Forms.Label estrella2;
        private System.Windows.Forms.Label estrella1;
    }
}