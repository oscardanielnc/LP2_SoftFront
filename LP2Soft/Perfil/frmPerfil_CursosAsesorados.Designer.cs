
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
            this.btnAniadirCurso = new System.Windows.Forms.Button();
            this.btnLP3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAniadirCurso
            // 
            this.btnAniadirCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnAniadirCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAniadirCurso.Location = new System.Drawing.Point(312, 185);
            this.btnAniadirCurso.Name = "btnAniadirCurso";
            this.btnAniadirCurso.Size = new System.Drawing.Size(164, 35);
            this.btnAniadirCurso.TabIndex = 6;
            this.btnAniadirCurso.Text = "+ Añadir nuevo curso";
            this.btnAniadirCurso.UseVisualStyleBackColor = false;
            this.btnAniadirCurso.Click += new System.EventHandler(this.btnAniadirCurso_Click);
            // 
            // btnLP3
            // 
            this.btnLP3.BackColor = System.Drawing.Color.DarkGray;
            this.btnLP3.Location = new System.Drawing.Point(87, 48);
            this.btnLP3.Name = "btnLP3";
            this.btnLP3.Size = new System.Drawing.Size(143, 101);
            this.btnLP3.TabIndex = 10;
            this.btnLP3.Text = "INF283\r\n\r\n\r\nLenguaje de Programación 3\r\n5.00 Créditos";
            this.btnLP3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLP3.UseVisualStyleBackColor = false;
            this.btnLP3.Click += new System.EventHandler(this.btnLP3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(323, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 101);
            this.button1.TabIndex = 11;
            this.button1.Text = "INF283\r\n\r\n\r\nLenguaje de Programación 3\r\n5.00 Créditos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(562, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 101);
            this.button2.TabIndex = 12;
            this.button2.Text = "INF283\r\n\r\n\r\nLenguaje de Programación 3\r\n5.00 Créditos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmPerfil_CursosAsesorados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 256);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLP3);
            this.Controls.Add(this.btnAniadirCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfil_CursosAsesorados";
            this.Text = "frmCursosReseniados";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAniadirCurso;
        private System.Windows.Forms.Button btnLP3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}