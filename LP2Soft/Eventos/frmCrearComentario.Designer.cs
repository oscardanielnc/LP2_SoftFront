
namespace LP2Soft.Eventos
{
    partial class frmCrearComentario
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
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lbComentario = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.btnCrearEvento = new LP2Soft.Asesor.BotonChevere();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(92, 49);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(328, 79);
            this.txtComentario.TabIndex = 4;
            // 
            // lbComentario
            // 
            this.lbComentario.AutoSize = true;
            this.lbComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComentario.Location = new System.Drawing.Point(12, 9);
            this.lbComentario.Name = "lbComentario";
            this.lbComentario.Size = new System.Drawing.Size(147, 20);
            this.lbComentario.TabIndex = 6;
            this.lbComentario.Text = "Crear comentario";
            // 
            // pbPerfil
            // 
            this.pbPerfil.Image = global::LP2Soft.Properties.Resources.images;
            this.pbPerfil.Location = new System.Drawing.Point(15, 66);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(50, 46);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 3;
            this.pbPerfil.TabStop = false;
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnCrearEvento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnCrearEvento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnCrearEvento.BorderRadius = 6;
            this.btnCrearEvento.BorderSize = 0;
            this.btnCrearEvento.FlatAppearance.BorderSize = 0;
            this.btnCrearEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEvento.ForeColor = System.Drawing.Color.White;
            this.btnCrearEvento.Location = new System.Drawing.Point(345, 135);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(75, 23);
            this.btnCrearEvento.TabIndex = 58;
            this.btnCrearEvento.Text = "Publicar";
            this.btnCrearEvento.TextColor = System.Drawing.Color.White;
            this.btnCrearEvento.UseVisualStyleBackColor = false;
            this.btnCrearEvento.Click += new System.EventHandler(this.btnCrearEvento_Click);
            // 
            // frmCrearComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 170);
            this.Controls.Add(this.btnCrearEvento);
            this.Controls.Add(this.lbComentario);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.pbPerfil);
            this.Name = "frmCrearComentario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Comentario";
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lbComentario;
        private Asesor.BotonChevere btnCrearEvento;
    }
}