
namespace LP2Soft.Asesor
{
    partial class frmMisAsesores
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
            this.lblMisAsesores = new System.Windows.Forms.Label();
            this.btnBuscarAsesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMisAsesores
            // 
            this.lblMisAsesores.AutoSize = true;
            this.lblMisAsesores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMisAsesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisAsesores.Location = new System.Drawing.Point(12, 9);
            this.lblMisAsesores.Name = "lblMisAsesores";
            this.lblMisAsesores.Size = new System.Drawing.Size(189, 31);
            this.lblMisAsesores.TabIndex = 3;
            this.lblMisAsesores.Text = "Mis Asesores";
            // 
            // btnBuscarAsesores
            // 
            this.btnBuscarAsesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnBuscarAsesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAsesores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarAsesores.Location = new System.Drawing.Point(269, 232);
            this.btnBuscarAsesores.Name = "btnBuscarAsesores";
            this.btnBuscarAsesores.Size = new System.Drawing.Size(284, 28);
            this.btnBuscarAsesores.TabIndex = 9;
            this.btnBuscarAsesores.Text = "Buscar Asesores";
            this.btnBuscarAsesores.UseVisualStyleBackColor = false;
            // 
            // frmMisAsesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(823, 492);
            this.Controls.Add(this.btnBuscarAsesores);
            this.Controls.Add(this.lblMisAsesores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMisAsesores";
            this.Text = "frmMisAsesores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMisAsesores;
        private System.Windows.Forms.Button btnBuscarAsesores;
    }
}