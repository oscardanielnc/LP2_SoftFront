
namespace LP2Soft.Tarjetas
{
    partial class tarjMensaje
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
            this.panelMensaje = new System.Windows.Forms.Panel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.panelMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMensaje
            // 
            this.panelMensaje.AutoSize = true;
            this.panelMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(248)))), ((int)(((byte)(198)))));
            this.panelMensaje.Controls.Add(this.lblFechaHora);
            this.panelMensaje.Controls.Add(this.lblContenido);
            this.panelMensaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMensaje.Location = new System.Drawing.Point(93, 6);
            this.panelMensaje.Name = "panelMensaje";
            this.panelMensaje.Size = new System.Drawing.Size(700, 53);
            this.panelMensaje.TabIndex = 21;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFechaHora.Location = new System.Drawing.Point(0, 18);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(137, 26);
            this.lblFechaHora.TabIndex = 17;
            this.lblFechaHora.Text = "\r\n19/10/2020 a las 23:20 hrs";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(0, 0);
            this.lblContenido.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(294, 18);
            this.lblContenido.TabIndex = 15;
            this.lblContenido.Text = "Hola papu, sale su maraton de One Piece? ";
            // 
            // tarjMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(799, 65);
            this.Controls.Add(this.panelMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjMensaje";
            this.Text = "tarjMensaje";
            this.panelMensaje.ResumeLayout(false);
            this.panelMensaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMensaje;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblContenido;
    }
}