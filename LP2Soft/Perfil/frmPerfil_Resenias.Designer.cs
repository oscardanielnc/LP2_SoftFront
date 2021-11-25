
namespace LP2Soft.Perfil
{
    partial class frmPerfil_Resenias
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
            this.panelResenias = new System.Windows.Forms.Panel();
            this.btnReseniar = new LP2Soft.Asesor.BotonChevere();
            this.lblNoresenia = new System.Windows.Forms.Label();
            this.lblNoAsesor = new System.Windows.Forms.Label();
            this.panelResenias.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResenias
            // 
            this.panelResenias.AutoScrollMargin = new System.Drawing.Size(0, 18);
            this.panelResenias.AutoSize = true;
            this.panelResenias.BackColor = System.Drawing.SystemColors.Control;
            this.panelResenias.Controls.Add(this.lblNoresenia);
            this.panelResenias.Location = new System.Drawing.Point(43, 68);
            this.panelResenias.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panelResenias.Name = "panelResenias";
            this.panelResenias.Size = new System.Drawing.Size(709, 191);
            this.panelResenias.TabIndex = 43;
            // 
            // btnReseniar
            // 
            this.btnReseniar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnReseniar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnReseniar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnReseniar.BorderRadius = 6;
            this.btnReseniar.BorderSize = 0;
            this.btnReseniar.FlatAppearance.BorderSize = 0;
            this.btnReseniar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReseniar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReseniar.ForeColor = System.Drawing.Color.White;
            this.btnReseniar.Location = new System.Drawing.Point(69, 21);
            this.btnReseniar.Name = "btnReseniar";
            this.btnReseniar.Size = new System.Drawing.Size(122, 30);
            this.btnReseniar.TabIndex = 42;
            this.btnReseniar.Text = "Crear Reseña";
            this.btnReseniar.TextColor = System.Drawing.Color.White;
            this.btnReseniar.UseVisualStyleBackColor = false;
            this.btnReseniar.Click += new System.EventHandler(this.btnReseniar_Click);
            // 
            // lblNoresenia
            // 
            this.lblNoresenia.AutoSize = true;
            this.lblNoresenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoresenia.Location = new System.Drawing.Point(13, 11);
            this.lblNoresenia.Name = "lblNoresenia";
            this.lblNoresenia.Size = new System.Drawing.Size(336, 20);
            this.lblNoresenia.TabIndex = 44;
            this.lblNoresenia.Text = "Este Usuario no cuenta con reseñas aún";
            // 
            // lblNoAsesor
            // 
            this.lblNoAsesor.AutoSize = true;
            this.lblNoAsesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAsesor.Location = new System.Drawing.Point(56, 25);
            this.lblNoAsesor.Name = "lblNoAsesor";
            this.lblNoAsesor.Size = new System.Drawing.Size(221, 20);
            this.lblNoAsesor.TabIndex = 45;
            this.lblNoAsesor.Text = "Este Usuario no es asesor";
            // 
            // frmPerfil_Resenias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(799, 278);
            this.Controls.Add(this.panelResenias);
            this.Controls.Add(this.btnReseniar);
            this.Controls.Add(this.lblNoAsesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfil_Resenias";
            this.Text = "frmPerfil_Resenias";
            this.panelResenias.ResumeLayout(false);
            this.panelResenias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Asesor.BotonChevere btnReseniar;
        private System.Windows.Forms.Panel panelResenias;
        private System.Windows.Forms.Label lblNoresenia;
        private System.Windows.Forms.Label lblNoAsesor;
    }
}