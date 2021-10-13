
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
            this.btnLP2 = new System.Windows.Forms.Button();
            this.btnCiclo7 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnLP2);
            this.panel1.Controls.Add(this.btnCiclo7);
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 216);
            this.panel1.TabIndex = 3;
            // 
            // btnLP2
            // 
            this.btnLP2.Location = new System.Drawing.Point(0, 41);
            this.btnLP2.Name = "btnLP2";
            this.btnLP2.Size = new System.Drawing.Size(143, 101);
            this.btnLP2.TabIndex = 5;
            this.btnLP2.Text = "INF282\r\n\r\n\r\nLenguaje de Programación\r\n5.00 Créditos";
            this.btnLP2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLP2.UseVisualStyleBackColor = true;
            this.btnLP2.Click += new System.EventHandler(this.btnLP2_Click);
            // 
            // btnCiclo7
            // 
            this.btnCiclo7.Location = new System.Drawing.Point(0, 0);
            this.btnCiclo7.Name = "btnCiclo7";
            this.btnCiclo7.Size = new System.Drawing.Size(143, 35);
            this.btnCiclo7.TabIndex = 4;
            this.btnCiclo7.Text = "Ciclo 7";
            this.btnCiclo7.UseVisualStyleBackColor = true;
            this.btnCiclo7.Click += new System.EventHandler(this.btnCiclo7_Click);
            // 
            // frmCursosHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnFavorito);
            this.Name = "frmCursosHome";
            this.Text = "frmCursosHome";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFavorito;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLP2;
        private System.Windows.Forms.Button btnCiclo7;
    }
}