
namespace LP2Soft.Tarjetas
{
    partial class tarjCursoxNivel
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
            this.btnCursoxNivel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCursoxNivel
            // 
            this.btnCursoxNivel.Location = new System.Drawing.Point(0, 0);
            this.btnCursoxNivel.Name = "btnCursoxNivel";
            this.btnCursoxNivel.Size = new System.Drawing.Size(783, 34);
            this.btnCursoxNivel.TabIndex = 9;
            this.btnCursoxNivel.Text = "nombre curso";
            this.btnCursoxNivel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursoxNivel.UseVisualStyleBackColor = true;
            this.btnCursoxNivel.Click += new System.EventHandler(this.btnCursoxNivel_Click);
            // 
            // tarjCursoxNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 34);
            this.Controls.Add(this.btnCursoxNivel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjCursoxNivel";
            this.Text = "tarjCursoxNivel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCursoxNivel;
    }
}