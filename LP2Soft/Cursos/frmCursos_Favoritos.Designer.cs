
namespace LP2Soft.Cursos
{
    partial class frmCursos_Favoritos
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
            this.panelFavoritos = new System.Windows.Forms.Panel();
            this.lblFavoritos = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelFavoritos
            // 
            this.panelFavoritos.Location = new System.Drawing.Point(12, 63);
            this.panelFavoritos.Name = "panelFavoritos";
            this.panelFavoritos.Size = new System.Drawing.Size(780, 378);
            this.panelFavoritos.TabIndex = 25;
            // 
            // lblFavoritos
            // 
            this.lblFavoritos.AutoSize = true;
            this.lblFavoritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoritos.Location = new System.Drawing.Point(12, 9);
            this.lblFavoritos.Name = "lblFavoritos";
            this.lblFavoritos.Size = new System.Drawing.Size(184, 25);
            this.lblFavoritos.TabIndex = 24;
            this.lblFavoritos.Text = "Cursos favoritos";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(14, 44);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(324, 16);
            this.lblInfo.TabIndex = 26;
            this.lblInfo.Text = "Aún no has seleccionado ningún curso como favorito.";
            // 
            // frmCursos_Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 453);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblFavoritos);
            this.Controls.Add(this.panelFavoritos);
            this.Name = "frmCursos_Favoritos";
            this.Text = "frmHomeFavoritos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFavoritos;
        private System.Windows.Forms.Label lblFavoritos;
        private System.Windows.Forms.Label lblInfo;
    }
}