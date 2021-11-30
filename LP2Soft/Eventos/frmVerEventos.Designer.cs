
namespace LP2Soft.Eventos
{
    partial class frmVerEventos
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
            this.panelPublicacionesEventos = new System.Windows.Forms.Panel();
            this.lblPublicacionesEventos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelPublicacionesEventos
            // 
            this.panelPublicacionesEventos.AutoScroll = true;
            this.panelPublicacionesEventos.Location = new System.Drawing.Point(204, 52);
            this.panelPublicacionesEventos.Name = "panelPublicacionesEventos";
            this.panelPublicacionesEventos.Size = new System.Drawing.Size(408, 442);
            this.panelPublicacionesEventos.TabIndex = 6;
            this.panelPublicacionesEventos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panelPublicacionesEventos_Scroll);
            // 
            // lblPublicacionesEventos
            // 
            this.lblPublicacionesEventos.AutoSize = true;
            this.lblPublicacionesEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicacionesEventos.Location = new System.Drawing.Point(208, 18);
            this.lblPublicacionesEventos.Name = "lblPublicacionesEventos";
            this.lblPublicacionesEventos.Size = new System.Drawing.Size(107, 20);
            this.lblPublicacionesEventos.TabIndex = 8;
            this.lblPublicacionesEventos.Text = "Ver Eventos";
            // 
            // frmVerEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 495);
            this.Controls.Add(this.lblPublicacionesEventos);
            this.Controls.Add(this.panelPublicacionesEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerEventos";
            this.Text = "frmEventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelPublicacionesEventos;
        private System.Windows.Forms.Label lblPublicacionesEventos;
    }
}