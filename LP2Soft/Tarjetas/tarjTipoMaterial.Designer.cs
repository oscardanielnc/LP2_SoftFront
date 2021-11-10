
namespace LP2Soft.Tarjetas
{
    partial class tarjTipoMaterial
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
            this.btnLP2TipoMaterial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLP2TipoMaterial
            // 
            this.btnLP2TipoMaterial.Location = new System.Drawing.Point(0, 0);
            this.btnLP2TipoMaterial.Name = "btnLP2TipoMaterial";
            this.btnLP2TipoMaterial.Size = new System.Drawing.Size(202, 35);
            this.btnLP2TipoMaterial.TabIndex = 17;
            this.btnLP2TipoMaterial.Text = "Laboratorios";
            this.btnLP2TipoMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLP2TipoMaterial.UseVisualStyleBackColor = true;
            this.btnLP2TipoMaterial.Click += new System.EventHandler(this.btnLP2TipoMaterial_Click);
            // 
            // tarjTipoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 35);
            this.Controls.Add(this.btnLP2TipoMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjTipoMaterial";
            this.Text = "tarjTipoMaterial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLP2TipoMaterial;
    }
}