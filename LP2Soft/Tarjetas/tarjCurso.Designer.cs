
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
            this.btnCorazon = new System.Windows.Forms.PictureBox();
            this.pBLP3CorazonLleno = new System.Windows.Forms.PictureBox();
            this.btnNewState = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCorazon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLP3CorazonLleno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewState)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCorazon
            // 
            this.btnCorazon.BackColor = System.Drawing.Color.DarkGray;
            this.btnCorazon.Image = global::LP2Soft.Properties.Resources.like1;
            this.btnCorazon.Location = new System.Drawing.Point(114, 4);
            this.btnCorazon.Name = "btnCorazon";
            this.btnCorazon.Size = new System.Drawing.Size(24, 24);
            this.btnCorazon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCorazon.TabIndex = 22;
            this.btnCorazon.TabStop = false;
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
            // btnNewState
            // 
            this.btnNewState.BackColor = System.Drawing.Color.DarkGray;
            this.btnNewState.Image = global::LP2Soft.Properties.Resources.plus_circle_regular_24;
            this.btnNewState.Location = new System.Drawing.Point(114, 71);
            this.btnNewState.Name = "btnNewState";
            this.btnNewState.Size = new System.Drawing.Size(24, 24);
            this.btnNewState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnNewState.TabIndex = 20;
            this.btnNewState.TabStop = false;
            this.btnNewState.Click += new System.EventHandler(this.btnNewState_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(43, 4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 16);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "INF248";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(10, 30);
            this.lblNombre.MaximumSize = new System.Drawing.Size(123, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 39);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Estructuras discrites y programación metódica";
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.Location = new System.Drawing.Point(55, 76);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(32, 16);
            this.lblCreditos.TabIndex = 25;
            this.lblCreditos.Text = "5.00";
            // 
            // tarjCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(143, 101);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCorazon);
            this.Controls.Add(this.pBLP3CorazonLleno);
            this.Controls.Add(this.btnNewState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjCurso";
            this.Text = "tarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.btnCorazon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLP3CorazonLleno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCorazon;
        private System.Windows.Forms.PictureBox pBLP3CorazonLleno;
        private System.Windows.Forms.PictureBox btnNewState;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCreditos;
    }
}