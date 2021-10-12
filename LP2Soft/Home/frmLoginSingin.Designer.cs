
namespace LP2Soft.Home
{
    partial class frmLoginSingin
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
            this.panelContenido = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelContenido.Location = new System.Drawing.Point(505, 46);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(400, 440);
            this.panelContenido.TabIndex = 5;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::LP2Soft.Properties.Resources.Logo_INFunables;
            this.imgLogo.Location = new System.Drawing.Point(71, 63);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(340, 175);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "¡Bienvenido a INFUNABLES, una página \r\ndónde podrás encontrar todo lo que necesit" +
    "as \r\npara triunfar en la universidad!";
            // 
            // frmLoginSingin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(964, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.imgLogo);
            this.Name = "frmLoginSingin";
            this.Text = "frmLoginSingin";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label label1;
    }
}