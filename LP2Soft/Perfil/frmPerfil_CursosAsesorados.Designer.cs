
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
            this.labelinfo = new System.Windows.Forms.Label();
            this.btnAniadirCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Location = new System.Drawing.Point(298, 66);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(184, 13);
            this.labelinfo.TabIndex = 0;
            this.labelinfo.Text = "Este usuario no asesora ningún curso";
            // 
            // btnAniadirCurso
            // 
            this.btnAniadirCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnAniadirCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAniadirCurso.Location = new System.Drawing.Point(309, 112);
            this.btnAniadirCurso.Name = "btnAniadirCurso";
            this.btnAniadirCurso.Size = new System.Drawing.Size(164, 35);
            this.btnAniadirCurso.TabIndex = 6;
            this.btnAniadirCurso.Text = "+ Añadir nuevo curso";
            this.btnAniadirCurso.UseVisualStyleBackColor = false;
            // 
            // frmPerfil_CursosAsesorados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 236);
            this.Controls.Add(this.btnAniadirCurso);
            this.Controls.Add(this.labelinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfil_CursosAsesorados";
            this.Text = "frmCursosReseniados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Button btnAniadirCurso;
    }
}