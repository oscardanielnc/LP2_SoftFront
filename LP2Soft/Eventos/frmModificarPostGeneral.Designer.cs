
namespace LP2Soft.Eventos
{
    partial class frmModificarPostGeneral
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lbQueEstasPensando = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.lblModificarPublicacion = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(96, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 16);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Oscar Navarro";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(311, 273);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(16, 160);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(370, 78);
            this.txtContenido.TabIndex = 12;
            // 
            // lbQueEstasPensando
            // 
            this.lbQueEstasPensando.AutoSize = true;
            this.lbQueEstasPensando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQueEstasPensando.Location = new System.Drawing.Point(12, 130);
            this.lbQueEstasPensando.Name = "lbQueEstasPensando";
            this.lbQueEstasPensando.Size = new System.Drawing.Size(167, 16);
            this.lbQueEstasPensando.TabIndex = 11;
            this.lbQueEstasPensando.Text = "¿Qué estás pensando?";
            // 
            // pbPerfil
            // 
            this.pbPerfil.Image = global::LP2Soft.Properties.Resources.images;
            this.pbPerfil.Location = new System.Drawing.Point(16, 47);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(74, 65);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 10;
            this.pbPerfil.TabStop = false;
            // 
            // lblModificarPublicacion
            // 
            this.lblModificarPublicacion.AutoSize = true;
            this.lblModificarPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarPublicacion.Location = new System.Drawing.Point(12, 8);
            this.lblModificarPublicacion.Name = "lblModificarPublicacion";
            this.lblModificarPublicacion.Size = new System.Drawing.Size(178, 20);
            this.lblModificarPublicacion.TabIndex = 9;
            this.lblModificarPublicacion.Text = "Modificar Publicación";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(219, 273);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmModificarPostGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 308);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.lbQueEstasPensando);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.lblModificarPublicacion);
            this.Name = "frmModificarPostGeneral";
            this.Text = "frmModificarPostGeneral";
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label lbQueEstasPensando;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lblModificarPublicacion;
        private System.Windows.Forms.Button btnEliminar;
    }
}