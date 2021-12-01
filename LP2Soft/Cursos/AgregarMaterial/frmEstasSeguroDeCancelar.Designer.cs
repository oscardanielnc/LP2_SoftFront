
namespace LP2Soft.Cursos.AgregarMaterial
{
    partial class frmEstasSeguroDeCancelar
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
            this.lblDeseaCancelar = new System.Windows.Forms.Label();
            this.lblAceptaCancelar = new System.Windows.Forms.Button();
            this.btnCancelaCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeseaCancelar
            // 
            this.lblDeseaCancelar.AutoSize = true;
            this.lblDeseaCancelar.Location = new System.Drawing.Point(26, 39);
            this.lblDeseaCancelar.Name = "lblDeseaCancelar";
            this.lblDeseaCancelar.Size = new System.Drawing.Size(349, 13);
            this.lblDeseaCancelar.TabIndex = 0;
            this.lblDeseaCancelar.Text = "Se perderá todos los documentos y datos ingresados, ¿Desea cancelar?";
            this.lblDeseaCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAceptaCancelar
            // 
            this.lblAceptaCancelar.Location = new System.Drawing.Point(86, 98);
            this.lblAceptaCancelar.Name = "lblAceptaCancelar";
            this.lblAceptaCancelar.Size = new System.Drawing.Size(91, 28);
            this.lblAceptaCancelar.TabIndex = 1;
            this.lblAceptaCancelar.Text = "Aceptar";
            this.lblAceptaCancelar.UseVisualStyleBackColor = true;
            this.lblAceptaCancelar.Click += new System.EventHandler(this.lblAceptaCancelar_Click);
            // 
            // btnCancelaCancelar
            // 
            this.btnCancelaCancelar.Location = new System.Drawing.Point(228, 98);
            this.btnCancelaCancelar.Name = "btnCancelaCancelar";
            this.btnCancelaCancelar.Size = new System.Drawing.Size(91, 28);
            this.btnCancelaCancelar.TabIndex = 2;
            this.btnCancelaCancelar.Text = "Cancelar";
            this.btnCancelaCancelar.UseVisualStyleBackColor = true;
            this.btnCancelaCancelar.Click += new System.EventHandler(this.btnCancelaCancelar_Click);
            // 
            // frmEstasSeguroDeCancelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 151);
            this.Controls.Add(this.btnCancelaCancelar);
            this.Controls.Add(this.lblAceptaCancelar);
            this.Controls.Add(this.lblDeseaCancelar);
            this.Name = "frmEstasSeguroDeCancelar";
            this.Text = "Estas Segruo De Cancelar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeseaCancelar;
        private System.Windows.Forms.Button lblAceptaCancelar;
        private System.Windows.Forms.Button btnCancelaCancelar;
    }
}