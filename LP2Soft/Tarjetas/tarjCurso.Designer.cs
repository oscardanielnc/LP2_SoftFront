
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarjCurso));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.toolTipCurso = new System.Windows.Forms.ToolTip(this.components);
            this.btnNewState = new System.Windows.Forms.PictureBox();
            this.imgCorazones = new System.Windows.Forms.ImageList(this.components);
            this.btnCorazon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewState)).BeginInit();
            this.SuspendLayout();
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
            this.toolTipCurso.SetToolTip(this.btnNewState, "Marcar como Aprobado/No aprobado");
            this.btnNewState.Click += new System.EventHandler(this.btnNewState_Click);
            // 
            // imgCorazones
            // 
            this.imgCorazones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCorazones.ImageStream")));
            this.imgCorazones.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCorazones.Images.SetKeyName(0, "star-empty.png");
            this.imgCorazones.Images.SetKeyName(1, "star-full.png");
            // 
            // btnCorazon
            // 
            this.btnCorazon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorazon.ImageIndex = 0;
            this.btnCorazon.ImageList = this.imgCorazones;
            this.btnCorazon.Location = new System.Drawing.Point(114, 4);
            this.btnCorazon.Name = "btnCorazon";
            this.btnCorazon.Size = new System.Drawing.Size(24, 24);
            this.btnCorazon.TabIndex = 26;
            this.btnCorazon.Click += new System.EventHandler(this.btnCorazon_Click);
            // 
            // tarjCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(143, 101);
            this.Controls.Add(this.btnCorazon);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnNewState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjCurso";
            this.Text = "tarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.btnNewState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnNewState;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.ToolTip toolTipCurso;
        private System.Windows.Forms.ImageList imgCorazones;
        private System.Windows.Forms.Label btnCorazon;
    }
}