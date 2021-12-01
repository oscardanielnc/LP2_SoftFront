
namespace LP2Soft.Perfil
{
    partial class frmPerfil_Publicaciones
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
            this.pnPublicaciones = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFiltros = new LP2Soft.Asesor.BotonChevere();
            this.SuspendLayout();
            // 
            // pnPublicaciones
            // 
            this.pnPublicaciones.AutoScroll = true;
            this.pnPublicaciones.Location = new System.Drawing.Point(174, 60);
            this.pnPublicaciones.Name = "pnPublicaciones";
            this.pnPublicaciones.Size = new System.Drawing.Size(448, 508);
            this.pnPublicaciones.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(169, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(318, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Historial de Publicaciones";
            // 
            // btnFiltros
            // 
            this.btnFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnFiltros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnFiltros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnFiltros.BorderRadius = 6;
            this.btnFiltros.BorderSize = 0;
            this.btnFiltros.FlatAppearance.BorderSize = 0;
            this.btnFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltros.ForeColor = System.Drawing.Color.White;
            this.btnFiltros.Location = new System.Drawing.Point(531, 24);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(91, 30);
            this.btnFiltros.TabIndex = 34;
            this.btnFiltros.Text = "Filtrar";
            this.btnFiltros.TextColor = System.Drawing.Color.White;
            this.btnFiltros.UseVisualStyleBackColor = false;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // frmPerfil_Publicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 580);
            this.Controls.Add(this.btnFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnPublicaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfil_Publicaciones";
            this.Text = "frmPerfil_Publicaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnPublicaciones;
        private System.Windows.Forms.Label lblTitulo;
        private Asesor.BotonChevere btnFiltros;
    }
}