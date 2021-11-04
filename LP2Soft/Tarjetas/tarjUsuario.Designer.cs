
namespace LP2Soft.Tarjetas
{
    partial class tarjUsuario
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
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // imgUsuario
            // 
            this.imgUsuario.Image = global::LP2Soft.Properties.Resources.images;
            this.imgUsuario.Location = new System.Drawing.Point(50, 12);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(50, 50);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUsuario.TabIndex = 7;
            this.imgUsuario.TabStop = false;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnVerPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerPerfil.FlatAppearance.BorderSize = 0;
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(86)))), ((int)(((byte)(171)))));
            this.btnVerPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerPerfil.Location = new System.Drawing.Point(35, 112);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(80, 26);
            this.btnVerPerfil.TabIndex = 9;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(10, 67);
            this.lblNombre.MaximumSize = new System.Drawing.Size(130, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 26);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Oscar Daniel Navarro Cieza";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(44, 95);
            this.lblCodigo.MaximumSize = new System.Drawing.Size(130, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "(87654321)";
            // 
            // tarjUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(150, 140);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.imgUsuario);
            this.Controls.Add(this.btnVerPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjUsuario";
            this.Text = "tarjUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.Button btnVerPerfil;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}