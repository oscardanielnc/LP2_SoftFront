
namespace LP2Soft.Profesor
{
    partial class frmProfesores
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
            this.txtProfesores = new System.Windows.Forms.TextBox();
            this.panelProfesores = new System.Windows.Forms.Panel();
            this.lblResultadosB = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProfesores
            // 
            this.txtProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesores.Location = new System.Drawing.Point(309, 30);
            this.txtProfesores.Name = "txtProfesores";
            this.txtProfesores.Size = new System.Drawing.Size(234, 21);
            this.txtProfesores.TabIndex = 27;
            // 
            // panelProfesores
            // 
            this.panelProfesores.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panelProfesores.AutoSize = true;
            this.panelProfesores.Location = new System.Drawing.Point(36, 73);
            this.panelProfesores.Margin = new System.Windows.Forms.Padding(10);
            this.panelProfesores.Name = "panelProfesores";
            this.panelProfesores.Size = new System.Drawing.Size(768, 314);
            this.panelProfesores.TabIndex = 29;
            // 
            // lblResultadosB
            // 
            this.lblResultadosB.AutoSize = true;
            this.lblResultadosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadosB.Location = new System.Drawing.Point(32, 9);
            this.lblResultadosB.Name = "lblResultadosB";
            this.lblResultadosB.Size = new System.Drawing.Size(167, 20);
            this.lblResultadosB.TabIndex = 31;
            this.lblResultadosB.Text = "Buscar Profesores";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::LP2Soft.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(551, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 30);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(33, 43);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(147, 13);
            this.lblInfo.TabIndex = 37;
            this.lblInfo.Text = "Se encontraron 20 profesores";
            // 
            // frmProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(852, 399);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblResultadosB);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelProfesores);
            this.Controls.Add(this.txtProfesores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfesores";
            this.Text = "frmProfesores";
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProfesores;
        private System.Windows.Forms.Panel panelProfesores;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label lblResultadosB;
        private System.Windows.Forms.Label lblInfo;
    }
}