
namespace LP2Soft.Eventos
{
    partial class frmComentario
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
            this.panelComentario = new System.Windows.Forms.Panel();
            this.lblComentario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbOtroPerfil = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelComentario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOtroPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelComentario
            // 
            this.panelComentario.BackColor = System.Drawing.Color.White;
            this.panelComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelComentario.Controls.Add(this.btnModificar);
            this.panelComentario.Controls.Add(this.lblComentario);
            this.panelComentario.Controls.Add(this.lblNombre);
            this.panelComentario.Controls.Add(this.pbOtroPerfil);
            this.panelComentario.Location = new System.Drawing.Point(2, 3);
            this.panelComentario.Name = "panelComentario";
            this.panelComentario.Size = new System.Drawing.Size(328, 47);
            this.panelComentario.TabIndex = 42;
            // 
            // lblComentario
            // 
            this.lblComentario.Location = new System.Drawing.Point(52, 18);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(234, 23);
            this.lblComentario.TabIndex = 42;
            this.lblComentario.Text = "Muy Buena info";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(52, 5);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 13);
            this.lblNombre.TabIndex = 41;
            this.lblNombre.Text = "Antony Romero";
            // 
            // pbOtroPerfil
            // 
            this.pbOtroPerfil.Image = global::LP2Soft.Properties.Resources.images;
            this.pbOtroPerfil.Location = new System.Drawing.Point(5, 5);
            this.pbOtroPerfil.Name = "pbOtroPerfil";
            this.pbOtroPerfil.Size = new System.Drawing.Size(41, 37);
            this.pbOtroPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOtroPerfil.TabIndex = 40;
            this.pbOtroPerfil.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = global::LP2Soft.Properties.Resources.cross;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(298, 14);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(20, 18);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 53);
            this.Controls.Add(this.panelComentario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComentario";
            this.Text = "Comentario";
            this.panelComentario.ResumeLayout(false);
            this.panelComentario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOtroPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbOtroPerfil;
        private System.Windows.Forms.Panel panelComentario;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnModificar;
    }
}