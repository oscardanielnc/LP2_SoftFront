
namespace LP2Soft.Perfil
{
    partial class frmPerfil_CursosAsesorados
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
            this.btnAniadirCurso = new System.Windows.Forms.Button();
            this.panelCursos = new System.Windows.Forms.Panel();
            this.lblNoAsesor = new System.Windows.Forms.Label();
            this.panelCursos.SuspendLayout();
            this.btnReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAniadirCurso
            // 
            this.btnAniadirCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnAniadirCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAniadirCurso.Location = new System.Drawing.Point(167, 205);
            this.btnAniadirCurso.Name = "btnAniadirCurso";
            this.btnAniadirCurso.Size = new System.Drawing.Size(164, 35);
            this.btnAniadirCurso.TabIndex = 6;
            this.btnAniadirCurso.Text = "+ Añadir nuevo curso";
            this.btnAniadirCurso.UseVisualStyleBackColor = false;
            this.btnAniadirCurso.Click += new System.EventHandler(this.btnAniadirCurso_Click);
            // 
            // panelCursos
            // 
            this.panelCursos.AutoScroll = true;
            this.panelCursos.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.panelCursos.Controls.Add(this.lblNoAsesor);
            this.panelCursos.Location = new System.Drawing.Point(87, 26);
            this.panelCursos.Name = "panelCursos";
            this.panelCursos.Size = new System.Drawing.Size(616, 165);
            this.panelCursos.TabIndex = 7;
            // 
            // lblNoAsesor
            // 
            this.lblNoAsesor.AutoSize = true;
            this.lblNoAsesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAsesor.Location = new System.Drawing.Point(3, 0);
            this.lblNoAsesor.Name = "lblNoAsesor";
            this.lblNoAsesor.Size = new System.Drawing.Size(221, 20);
            this.lblNoAsesor.TabIndex = 46;
            this.lblNoAsesor.Text = "Este Usuario no es asesor";
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporte.Location = new System.Drawing.Point(421, 205);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(164, 35);
            this.btnReporte.TabIndex = 8;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPerfil_CursosAsesorados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 256);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.panelCursos);
            this.Controls.Add(this.btnAniadirCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfil_CursosAsesorados";
            this.Text = "frmCursosReseniados";
            this.panelCursos.ResumeLayout(false);
            this.panelCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAniadirCurso;
        private System.Windows.Forms.Panel panelCursos;
        private System.Windows.Forms.Label lblNoAsesor;
        private System.Windows.Forms.Button btnReporte;
    }
}