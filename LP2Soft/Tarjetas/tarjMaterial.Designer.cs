
namespace LP2Soft.Tarjetas
{
    partial class tarjMaterial
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
            this.Descargar = new System.Windows.Forms.PictureBox();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.sfdArchivo = new System.Windows.Forms.SaveFileDialog();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Descargar)).BeginInit();
            this.SuspendLayout();
            // 
            // Descargar
            // 
            this.Descargar.Image = global::LP2Soft.Properties.Resources.download_regular_24;
            this.Descargar.Location = new System.Drawing.Point(758, 6);
            this.Descargar.Name = "Descargar";
            this.Descargar.Size = new System.Drawing.Size(24, 24);
            this.Descargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Descargar.TabIndex = 52;
            this.Descargar.TabStop = false;
            this.Descargar.Click += new System.EventHandler(this.Descargar_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(0, 0);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(782, 34);
            this.btnMaterial.TabIndex = 50;
            this.btnMaterial.Text = "Practica 2 2022-0 (zip)          Freddy  Paz                                 19  " +
    "                          Juan Lora                                          5.0" +
    "";
            this.btnMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Location = new System.Drawing.Point(174, 9);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(100, 13);
            this.lblNombreProfesor.TabIndex = 55;
            this.lblNombreProfesor.Text = "Nombre de profesor";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(328, 9);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 56;
            this.lblNota.Text = "Nota";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Location = new System.Drawing.Point(424, 11);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(57, 13);
            this.lblPropietario.TabIndex = 57;
            this.lblPropietario.Text = "Propietario";
            // 
            // tarjMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 34);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblNombreProfesor);
            this.Controls.Add(this.Descargar);
            this.Controls.Add(this.btnMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjMaterial";
            this.Text = "TarjMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.Descargar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Descargar;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.SaveFileDialog sfdArchivo;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblPropietario;
    }
}