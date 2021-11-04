namespace LP2Soft.Asesor
{
    partial class frmBuscarAsesor
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
            this.lblBuscarAsesor = new System.Windows.Forms.Label();
            this.panelDestacados = new System.Windows.Forms.Panel();
            this.lblAsesoresRecomendados = new System.Windows.Forms.Label();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.btnPostularAsesor = new LP2Soft.Asesor.BotonChevere();
            this.panelDestacados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarAsesor
            // 
            this.lblBuscarAsesor.AutoSize = true;
            this.lblBuscarAsesor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBuscarAsesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarAsesor.Location = new System.Drawing.Point(8, 15);
            this.lblBuscarAsesor.Name = "lblBuscarAsesor";
            this.lblBuscarAsesor.Size = new System.Drawing.Size(209, 29);
            this.lblBuscarAsesor.TabIndex = 2;
            this.lblBuscarAsesor.Text = "Buscar Asesores";
            // 
            // panelDestacados
            // 
            this.panelDestacados.AutoScroll = true;
            this.panelDestacados.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelDestacados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDestacados.Controls.Add(this.lblAsesoresRecomendados);
            this.panelDestacados.Location = new System.Drawing.Point(516, 15);
            this.panelDestacados.Name = "panelDestacados";
            this.panelDestacados.Size = new System.Drawing.Size(295, 465);
            this.panelDestacados.TabIndex = 5;
            // 
            // lblAsesoresRecomendados
            // 
            this.lblAsesoresRecomendados.AutoSize = true;
            this.lblAsesoresRecomendados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAsesoresRecomendados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsesoresRecomendados.Location = new System.Drawing.Point(3, 6);
            this.lblAsesoresRecomendados.Name = "lblAsesoresRecomendados";
            this.lblAsesoresRecomendados.Size = new System.Drawing.Size(250, 24);
            this.lblAsesoresRecomendados.TabIndex = 6;
            this.lblAsesoresRecomendados.Text = "Asesores Recomendados";
            // 
            // panelBuscar
            // 
            this.panelBuscar.AutoScroll = true;
            this.panelBuscar.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBuscar.Location = new System.Drawing.Point(13, 49);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(484, 394);
            this.panelBuscar.TabIndex = 7;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBuscar.Location = new System.Drawing.Point(220, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(249, 20);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.Text = "Buscar a un asesor por su nombre";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::LP2Soft.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(475, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(22, 22);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPostularAsesor
            // 
            this.btnPostularAsesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnPostularAsesor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnPostularAsesor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnPostularAsesor.BorderRadius = 6;
            this.btnPostularAsesor.BorderSize = 0;
            this.btnPostularAsesor.FlatAppearance.BorderSize = 0;
            this.btnPostularAsesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostularAsesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostularAsesor.ForeColor = System.Drawing.Color.White;
            this.btnPostularAsesor.Location = new System.Drawing.Point(83, 458);
            this.btnPostularAsesor.Name = "btnPostularAsesor";
            this.btnPostularAsesor.Size = new System.Drawing.Size(350, 29);
            this.btnPostularAsesor.TabIndex = 0;
            this.btnPostularAsesor.Text = "Postular como asesor a un curso";
            this.btnPostularAsesor.TextColor = System.Drawing.Color.White;
            this.btnPostularAsesor.UseVisualStyleBackColor = false;
            this.btnPostularAsesor.Click += new System.EventHandler(this.btnPostularAsesor_Click);
            // 
            // frmBuscarAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(823, 492);
            this.Controls.Add(this.btnPostularAsesor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.panelDestacados);
            this.Controls.Add(this.lblBuscarAsesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarAsesor";
            this.Text = "frmBuscarAsesor";
            this.panelDestacados.ResumeLayout(false);
            this.panelDestacados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarAsesor;
        private System.Windows.Forms.Panel panelDestacados;
        private System.Windows.Forms.Label lblAsesoresRecomendados;
        private System.Windows.Forms.Panel panelBuscar;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private BotonChevere btnPostularAsesor;
    }
}
