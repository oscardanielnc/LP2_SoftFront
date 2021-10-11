
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
            this.labelinfo = new System.Windows.Forms.Label();
            this.btnNuevaResenia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevaResenia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Location = new System.Drawing.Point(260, 100);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(281, 13);
            this.labelinfo.TabIndex = 1;
            this.labelinfo.Text = "Aquí vienen las reseñas de quien sea que le tocó diseñar.";
            // 
            // btnNuevaResenia
            // 
            this.btnNuevaResenia.Image = global::LP2Soft.Properties.Resources.address_book;
            this.btnNuevaResenia.Location = new System.Drawing.Point(757, 12);
            this.btnNuevaResenia.Name = "btnNuevaResenia";
            this.btnNuevaResenia.Size = new System.Drawing.Size(30, 30);
            this.btnNuevaResenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNuevaResenia.TabIndex = 2;
            this.btnNuevaResenia.TabStop = false;
            // 
            // frmPerfil_Resenias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 225);
            this.Controls.Add(this.btnNuevaResenia);
            this.Controls.Add(this.labelinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfil_Resenias";
            this.Text = "frmPerfil_Resenias";
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevaResenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.PictureBox btnNuevaResenia;
    }
}