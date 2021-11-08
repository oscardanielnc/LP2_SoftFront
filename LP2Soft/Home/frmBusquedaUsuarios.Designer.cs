
namespace LP2Soft.Home
{
    partial class frmBusquedaUsuarios
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblResultadosB
            // 
            this.lblResultadosB.AutoSize = true;
            this.lblResultadosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadosB.Location = new System.Drawing.Point(17, 23);
            this.lblResultadosB.Name = "lblResultadosB";
            this.lblResultadosB.Size = new System.Drawing.Size(242, 20);
            this.lblResultadosB.TabIndex = 0;
            this.lblResultadosB.Text = "Resultados de la búsqueda:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(18, 53);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(137, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Se encontraron 20 usuarios";
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.AutoSize = true;
            this.panelUsuarios.Location = new System.Drawing.Point(21, 83);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(780, 390);
            this.panelUsuarios.TabIndex = 3;
            // 
            // frmBusquedaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(823, 505);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblResultadosB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusquedaUsuarios";
            this.Text = "frmBusquedaUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultadosB;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panelUsuarios;
    }
}