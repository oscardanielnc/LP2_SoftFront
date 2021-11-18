
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pBLP2Practica4Compartir = new System.Windows.Forms.PictureBox();
            this.Descargar = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.sfdArchivo = new System.Windows.Forms.SaveFileDialog();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLP2Practica4Compartir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Descargar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LP2Soft.Properties.Resources.star_full_1;
            this.pictureBox4.Location = new System.Drawing.Point(571, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 54;
            this.pictureBox4.TabStop = false;
            // 
            // pBLP2Practica4Compartir
            // 
            this.pBLP2Practica4Compartir.Image = global::LP2Soft.Properties.Resources.share_alt_regular_24;
            this.pBLP2Practica4Compartir.Location = new System.Drawing.Point(728, 6);
            this.pBLP2Practica4Compartir.Name = "pBLP2Practica4Compartir";
            this.pBLP2Practica4Compartir.Size = new System.Drawing.Size(24, 24);
            this.pBLP2Practica4Compartir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBLP2Practica4Compartir.TabIndex = 53;
            this.pBLP2Practica4Compartir.TabStop = false;
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
            // button3
            // 
            this.button3.Image = global::LP2Soft.Properties.Resources.star_full;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 34);
            this.button3.TabIndex = 51;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(32, 0);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(750, 34);
            this.btnMaterial.TabIndex = 50;
            this.btnMaterial.Text = "Practica 2 2022-0 (zip)          Freddy  Paz                                 19  " +
    "                          Juan Lora                                          5.0" +
    "";
            this.btnMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.UseVisualStyleBackColor = true;
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
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(601, 11);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(13, 13);
            this.lblPuntaje.TabIndex = 58;
            this.lblPuntaje.Text = "0";
            // 
            // tarjMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 34);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblNombreProfesor);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pBLP2Practica4Compartir);
            this.Controls.Add(this.Descargar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjMaterial";
            this.Text = "TarjMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLP2Practica4Compartir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Descargar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pBLP2Practica4Compartir;
        private System.Windows.Forms.PictureBox Descargar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.SaveFileDialog sfdArchivo;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label lblPuntaje;
    }
}