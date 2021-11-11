
namespace LP2Soft.Profesor
{
    partial class frmProfesor_Perfil_Cursos
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
            this.panelCursos = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelCursos
            // 
            this.panelCursos.AutoSize = true;
            this.panelCursos.Location = new System.Drawing.Point(62, 95);
            this.panelCursos.Name = "panelCursos";
            this.panelCursos.Size = new System.Drawing.Size(680, 163);
            this.panelCursos.TabIndex = 7;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(59, 70);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(137, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Se encontraron 123 amigos";
            // 
            // frmProfesor_Perfil_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCursos);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfesor_Perfil_Cursos";
            this.Text = "frmProfesor_Perfil_Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCursos;
        private System.Windows.Forms.Label lblInfo;
    }
}