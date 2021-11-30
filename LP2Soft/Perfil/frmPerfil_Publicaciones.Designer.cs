
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
            this.btnFiltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnPublicaciones
            // 
            this.pnPublicaciones.AutoScroll = true;
            this.pnPublicaciones.Location = new System.Drawing.Point(174, 83);
            this.pnPublicaciones.Name = "pnPublicaciones";
            this.pnPublicaciones.Size = new System.Drawing.Size(448, 473);
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
            // btnFiltar
            // 
            this.btnFiltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnFiltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltar.Location = new System.Drawing.Point(531, 24);
            this.btnFiltar.Name = "btnFiltar";
            this.btnFiltar.Size = new System.Drawing.Size(91, 30);
            this.btnFiltar.TabIndex = 23;
            this.btnFiltar.Text = "Filtrar";
            this.btnFiltar.UseVisualStyleBackColor = false;
            this.btnFiltar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmPerfil_Publicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 580);
            this.Controls.Add(this.btnFiltar);
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
        private System.Windows.Forms.Button btnFiltar;
    }
}