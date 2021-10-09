
namespace LP2Soft.Cursos
{
    partial class frmCursosHome
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
            this.btnFavorito = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLP2Descargar = new System.Windows.Forms.Button();
            this.btnLP2Compartir = new System.Windows.Forms.Button();
            this.btnLP2AgregarFavorito = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCiclo7 = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFavorito
            // 
            this.btnFavorito.Location = new System.Drawing.Point(15, 12);
            this.btnFavorito.Name = "btnFavorito";
            this.btnFavorito.Size = new System.Drawing.Size(143, 35);
            this.btnFavorito.TabIndex = 0;
            this.btnFavorito.Text = "Favoritos";
            this.btnFavorito.UseVisualStyleBackColor = true;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(15, 53);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(143, 35);
            this.btnMaterial.TabIndex = 2;
            this.btnMaterial.Text = "Material";
            this.btnMaterial.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLP2Descargar);
            this.panel1.Controls.Add(this.btnLP2Compartir);
            this.panel1.Controls.Add(this.btnLP2AgregarFavorito);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCiclo7);
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 216);
            this.panel1.TabIndex = 3;
            // 
            // btnLP2Descargar
            // 
            this.btnLP2Descargar.Image = global::LP2Soft.Properties.Resources.download_regular_24;
            this.btnLP2Descargar.Location = new System.Drawing.Point(76, 41);
            this.btnLP2Descargar.Name = "btnLP2Descargar";
            this.btnLP2Descargar.Size = new System.Drawing.Size(33, 34);
            this.btnLP2Descargar.TabIndex = 6;
            this.btnLP2Descargar.UseVisualStyleBackColor = true;
            this.btnLP2Descargar.Click += new System.EventHandler(this.btnLP2Descargar_Click);
            // 
            // btnLP2Compartir
            // 
            this.btnLP2Compartir.Image = global::LP2Soft.Properties.Resources.share_alt_regular_24;
            this.btnLP2Compartir.Location = new System.Drawing.Point(110, 41);
            this.btnLP2Compartir.Name = "btnLP2Compartir";
            this.btnLP2Compartir.Size = new System.Drawing.Size(33, 34);
            this.btnLP2Compartir.TabIndex = 4;
            this.btnLP2Compartir.UseVisualStyleBackColor = true;
            this.btnLP2Compartir.Click += new System.EventHandler(this.btnLP2Compartir_Click);
            // 
            // btnLP2AgregarFavorito
            // 
            this.btnLP2AgregarFavorito.Image = global::LP2Soft.Properties.Resources.plus_circle_regular_24;
            this.btnLP2AgregarFavorito.Location = new System.Drawing.Point(110, 108);
            this.btnLP2AgregarFavorito.Name = "btnLP2AgregarFavorito";
            this.btnLP2AgregarFavorito.Size = new System.Drawing.Size(33, 34);
            this.btnLP2AgregarFavorito.TabIndex = 5;
            this.btnLP2AgregarFavorito.UseVisualStyleBackColor = true;
            this.btnLP2AgregarFavorito.Click += new System.EventHandler(this.btnLP2AgregarFavorito_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 101);
            this.button2.TabIndex = 5;
            this.button2.Text = "INF282\r\n\r\n\r\nLenguaje de Programación\r\n5.00 Créditos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCiclo7
            // 
            this.btnCiclo7.Location = new System.Drawing.Point(0, 0);
            this.btnCiclo7.Name = "btnCiclo7";
            this.btnCiclo7.Size = new System.Drawing.Size(143, 35);
            this.btnCiclo7.TabIndex = 4;
            this.btnCiclo7.Text = "Ciclo 7";
            this.btnCiclo7.UseVisualStyleBackColor = true;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Image = global::LP2Soft.Properties.Resources.error_circle_regular_24;
            this.btnInformacion.Location = new System.Drawing.Point(164, 13);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(33, 34);
            this.btnInformacion.TabIndex = 1;
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // frmCursosHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnFavorito);
            this.Name = "frmCursosHome";
            this.Text = "frmCursosHome";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFavorito;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLP2Descargar;
        private System.Windows.Forms.Button btnLP2Compartir;
        private System.Windows.Forms.Button btnLP2AgregarFavorito;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCiclo7;
    }
}