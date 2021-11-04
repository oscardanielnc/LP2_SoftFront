
namespace LP2Soft.Tarjetas
{
    partial class tarjCurso
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
            this.pBLP3CorazonVacio = new System.Windows.Forms.PictureBox();
            this.pBLP3CorazonLleno = new System.Windows.Forms.PictureBox();
            this.pictureAgregarLP3 = new System.Windows.Forms.PictureBox();
            this.btnLP3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBLP3CorazonVacio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLP3CorazonLleno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAgregarLP3)).BeginInit();
            this.SuspendLayout();
            // 
            // pBLP3CorazonVacio
            // 
            this.pBLP3CorazonVacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pBLP3CorazonVacio.Image = global::LP2Soft.Properties.Resources.like1;
            this.pBLP3CorazonVacio.Location = new System.Drawing.Point(114, 4);
            this.pBLP3CorazonVacio.Name = "pBLP3CorazonVacio";
            this.pBLP3CorazonVacio.Size = new System.Drawing.Size(24, 24);
            this.pBLP3CorazonVacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBLP3CorazonVacio.TabIndex = 22;
            this.pBLP3CorazonVacio.TabStop = false;
            // 
            // pBLP3CorazonLleno
            // 
            this.pBLP3CorazonLleno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pBLP3CorazonLleno.Image = global::LP2Soft.Properties.Resources.heart_solid_24;
            this.pBLP3CorazonLleno.Location = new System.Drawing.Point(114, 4);
            this.pBLP3CorazonLleno.Name = "pBLP3CorazonLleno";
            this.pBLP3CorazonLleno.Size = new System.Drawing.Size(24, 24);
            this.pBLP3CorazonLleno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBLP3CorazonLleno.TabIndex = 21;
            this.pBLP3CorazonLleno.TabStop = false;
            this.pBLP3CorazonLleno.Visible = false;
            // 
            // pictureAgregarLP3
            // 
            this.pictureAgregarLP3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureAgregarLP3.Image = global::LP2Soft.Properties.Resources.plus_circle_regular_24;
            this.pictureAgregarLP3.Location = new System.Drawing.Point(114, 71);
            this.pictureAgregarLP3.Name = "pictureAgregarLP3";
            this.pictureAgregarLP3.Size = new System.Drawing.Size(24, 24);
            this.pictureAgregarLP3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureAgregarLP3.TabIndex = 20;
            this.pictureAgregarLP3.TabStop = false;
            // 
            // btnLP3
            // 
            this.btnLP3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLP3.Location = new System.Drawing.Point(0, -1);
            this.btnLP3.Name = "btnLP3";
            this.btnLP3.Size = new System.Drawing.Size(143, 101);
            this.btnLP3.TabIndex = 19;
            this.btnLP3.Text = "INF283\r\n\r\n\r\nLenguaje de Programación 3\r\n5.00 Créditos";
            this.btnLP3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLP3.UseVisualStyleBackColor = false;
            this.btnLP3.Click += new System.EventHandler(this.btnLP3_Click);
            // 
            // tarjCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 101);
            this.Controls.Add(this.pBLP3CorazonVacio);
            this.Controls.Add(this.pBLP3CorazonLleno);
            this.Controls.Add(this.pictureAgregarLP3);
            this.Controls.Add(this.btnLP3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjCurso";
            this.Text = "tarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.pBLP3CorazonVacio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLP3CorazonLleno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAgregarLP3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBLP3CorazonVacio;
        private System.Windows.Forms.PictureBox pBLP3CorazonLleno;
        private System.Windows.Forms.PictureBox pictureAgregarLP3;
        private System.Windows.Forms.Button btnLP3;
    }
}