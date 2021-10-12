
namespace LP2Soft.Eventos
{
    partial class frmEventoProximo
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
            this.lblFechaEvento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgendarEvento = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombreEvento = new System.Windows.Forms.Label();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaEvento
            // 
            this.lblFechaEvento.AutoSize = true;
            this.lblFechaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEvento.Location = new System.Drawing.Point(97, 80);
            this.lblFechaEvento.Name = "lblFechaEvento";
            this.lblFechaEvento.Size = new System.Drawing.Size(141, 13);
            this.lblFechaEvento.TabIndex = 10;
            this.lblFechaEvento.Text = "31 de Octubre del 2021";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(51, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "FCI PUCP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAgendarEvento
            // 
            this.btnAgendarEvento.BackColor = System.Drawing.Color.Transparent;
            this.btnAgendarEvento.BackgroundImage = global::LP2Soft.Properties.Resources.anadir_evento;
            this.btnAgendarEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgendarEvento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgendarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarEvento.Location = new System.Drawing.Point(242, 3);
            this.btnAgendarEvento.Name = "btnAgendarEvento";
            this.btnAgendarEvento.Size = new System.Drawing.Size(24, 25);
            this.btnAgendarEvento.TabIndex = 30;
            this.btnAgendarEvento.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDescripcionEvento);
            this.panel2.Controls.Add(this.lblNombreEvento);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblFechaEvento);
            this.panel2.Controls.Add(this.btnAgendarEvento);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Location = new System.Drawing.Point(34, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 203);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "15:00  - 17:00";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(24, 102);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 32;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(17, 80);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvento.Location = new System.Drawing.Point(41, 55);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(198, 16);
            this.lblNombreEvento.TabIndex = 34;
            this.lblNombreEvento.Text = "Fiesta de Halloween en FCI";
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Location = new System.Drawing.Point(20, 130);
            this.txtDescripcionEvento.Multiline = true;
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(233, 61);
            this.txtDescripcionEvento.TabIndex = 35;
            this.txtDescripcionEvento.Text = "No te pierdas este 31 de Octubre ...";
            // 
            // frmEventoProximo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 265);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventoProximo";
            this.Text = "frmEventoProximo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFechaEvento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgendarEvento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.Label lblNombreEvento;
    }
}