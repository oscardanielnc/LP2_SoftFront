
namespace LP2Soft.Tarjetas
{
    partial class tarjTipoMaterialIndice
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
            this.btnLP2Practicas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLP2Practicas
            // 
            this.btnLP2Practicas.Location = new System.Drawing.Point(0, 0);
            this.btnLP2Practicas.Name = "btnLP2Practicas";
            this.btnLP2Practicas.Size = new System.Drawing.Size(783, 34);
            this.btnLP2Practicas.TabIndex = 9;
            this.btnLP2Practicas.Text = "       Práctica 1";
            this.btnLP2Practicas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLP2Practicas.UseVisualStyleBackColor = true;
            this.btnLP2Practicas.Click += new System.EventHandler(this.btnLP2Practicas_Click);
            // 
            // tarjTipoMaterialIndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 34);
            this.Controls.Add(this.btnLP2Practicas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjTipoMaterialIndice";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.tarjTipoMaterialIndice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLP2Practicas;
    }
}