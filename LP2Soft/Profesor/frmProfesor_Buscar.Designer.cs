
namespace LP2Soft.Profesor
{
    partial class frmProfesor_Buscar
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
            this.lblResultadosB = new System.Windows.Forms.Label();
            this.panelProfesores = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResultadosB
            // 
            this.lblResultadosB.AutoSize = true;
            this.lblResultadosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadosB.Location = new System.Drawing.Point(14, 9);
            this.lblResultadosB.Name = "lblResultadosB";
            this.lblResultadosB.Size = new System.Drawing.Size(236, 20);
            this.lblResultadosB.TabIndex = 35;
            this.lblResultadosB.Text = "Resultados de la búsqueda";
            // 
            // panelProfesores
            // 
            this.panelProfesores.Location = new System.Drawing.Point(18, 74);
            this.panelProfesores.Name = "panelProfesores";
            this.panelProfesores.Size = new System.Drawing.Size(768, 376);
            this.panelProfesores.TabIndex = 33;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(15, 38);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(147, 13);
            this.lblInfo.TabIndex = 36;
            this.lblInfo.Text = "Se encontraron 20 profesores";
            // 
            // frmProfesor_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.panelProfesores);
            this.Controls.Add(this.lblResultadosB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfesor_Buscar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultadosB;
        private System.Windows.Forms.Panel panelProfesores;
        private System.Windows.Forms.Label lblInfo;
    }
}