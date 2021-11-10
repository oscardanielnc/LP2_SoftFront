
namespace LP2Soft.Eventos
{
    partial class frmMisPublicaciones
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
            this.lblMisEventos = new System.Windows.Forms.Label();
            this.btnCrearEvento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPublicacionesEventos
            // 
            this.panelPublicacionesEventos.AutoScroll = true;
            this.panelPublicacionesEventos.Location = new System.Drawing.Point(170, 43);
            this.panelPublicacionesEventos.Name = "panelPublicacionesEventos";
            this.panelPublicacionesEventos.Size = new System.Drawing.Size(453, 449);
            this.panelPublicacionesEventos.TabIndex = 7;
            // 
            // lblMisEventos
            // 
            this.lblMisEventos.AutoSize = true;
            this.lblMisEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisEventos.Location = new System.Drawing.Point(182, 9);
            this.lblMisEventos.Name = "lblMisEventos";
            this.lblMisEventos.Size = new System.Drawing.Size(106, 20);
            this.lblMisEventos.TabIndex = 6;
            this.lblMisEventos.Text = "Mis Eventos";
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.Location = new System.Drawing.Point(510, 9);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(86, 23);
            this.btnCrearEvento.TabIndex = 10;
            this.btnCrearEvento.Text = "Crear Evento";
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            this.btnCrearEvento.Click += new System.EventHandler(this.btnCrearEvento_Click);
            // 
            // frmMisPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 495);
            this.Controls.Add(this.btnCrearEvento);
            this.Controls.Add(this.lblMisEventos);
            this.Controls.Add(this.panelPublicacionesEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMisPublicaciones";
            this.Text = "frmMisEventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPublicacionesEventos;
        private System.Windows.Forms.Label lblMisEventos;
        private System.Windows.Forms.Button btnCrearEvento;
    }
}