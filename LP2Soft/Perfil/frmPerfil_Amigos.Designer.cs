
namespace LP2Soft.Perfil
{
    partial class frmPerfil_Amigos
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
            this.txtBusquedaAmigos = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelAmigos = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusquedaAmigos
            // 
            this.txtBusquedaAmigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaAmigos.ForeColor = System.Drawing.Color.Gray;
            this.txtBusquedaAmigos.Location = new System.Drawing.Point(270, 12);
            this.txtBusquedaAmigos.Name = "txtBusquedaAmigos";
            this.txtBusquedaAmigos.Size = new System.Drawing.Size(240, 21);
            this.txtBusquedaAmigos.TabIndex = 0;
            this.txtBusquedaAmigos.Text = "Buscar amigos";
            this.txtBusquedaAmigos.Leave += new System.EventHandler(this.txtBusquedaAmigos_Leave);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(57, 44);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(137, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Se encontraron 123 amigos";
            // 
            // panelAmigos
            // 
            this.panelAmigos.AutoSize = true;
            this.panelAmigos.Location = new System.Drawing.Point(60, 69);
            this.panelAmigos.Name = "panelAmigos";
            this.panelAmigos.Size = new System.Drawing.Size(680, 163);
            this.panelAmigos.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::LP2Soft.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(519, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 25);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmPerfil_Amigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 315);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelAmigos);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtBusquedaAmigos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfil_Amigos";
            this.Text = "frmPerfil_Amigos";
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedaAmigos;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panelAmigos;
        private System.Windows.Forms.PictureBox btnBuscar;
    }
}