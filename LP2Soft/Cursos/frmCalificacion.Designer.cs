
namespace LP2Soft.Cursos.Calificación
{
    partial class frmCalificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalificacion));
            this.lblCalificación = new System.Windows.Forms.Label();
            this.imgCalificacion = new System.Windows.Forms.ImageList(this.components);
            this.lblEstrella1 = new System.Windows.Forms.Label();
            this.lblEstrella2 = new System.Windows.Forms.Label();
            this.lblEstrella3 = new System.Windows.Forms.Label();
            this.lblEstrella4 = new System.Windows.Forms.Label();
            this.lblEstrella5 = new System.Windows.Forms.Label();
            this.btnCalificacionAceptar = new System.Windows.Forms.Button();
            this.btnCalificacioCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalificación
            // 
            this.lblCalificación.AutoSize = true;
            this.lblCalificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificación.Location = new System.Drawing.Point(82, 43);
            this.lblCalificación.Name = "lblCalificación";
            this.lblCalificación.Size = new System.Drawing.Size(419, 25);
            this.lblCalificación.TabIndex = 0;
            this.lblCalificación.Text = "¿Qué calificación le desea dar al material?";
            // 
            // imgCalificacion
            // 
            this.imgCalificacion.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCalificacion.ImageStream")));
            this.imgCalificacion.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCalificacion.Images.SetKeyName(0, "star-empty.png");
            this.imgCalificacion.Images.SetKeyName(1, "star-full.png");
            // 
            // lblEstrella1
            // 
            this.lblEstrella1.ImageIndex = 0;
            this.lblEstrella1.ImageList = this.imgCalificacion;
            this.lblEstrella1.Location = new System.Drawing.Point(183, 92);
            this.lblEstrella1.Name = "lblEstrella1";
            this.lblEstrella1.Size = new System.Drawing.Size(36, 36);
            this.lblEstrella1.TabIndex = 1;
            this.lblEstrella1.Click += new System.EventHandler(this.lblEstrellas_Click);
            // 
            // lblEstrella2
            // 
            this.lblEstrella2.ImageIndex = 0;
            this.lblEstrella2.ImageList = this.imgCalificacion;
            this.lblEstrella2.Location = new System.Drawing.Point(225, 92);
            this.lblEstrella2.Name = "lblEstrella2";
            this.lblEstrella2.Size = new System.Drawing.Size(36, 36);
            this.lblEstrella2.TabIndex = 2;
            this.lblEstrella2.Click += new System.EventHandler(this.lblEstrella2_Click);
            // 
            // lblEstrella3
            // 
            this.lblEstrella3.ImageIndex = 0;
            this.lblEstrella3.ImageList = this.imgCalificacion;
            this.lblEstrella3.Location = new System.Drawing.Point(267, 92);
            this.lblEstrella3.Name = "lblEstrella3";
            this.lblEstrella3.Size = new System.Drawing.Size(36, 36);
            this.lblEstrella3.TabIndex = 3;
            this.lblEstrella3.Click += new System.EventHandler(this.lblEstrella3_Click);
            // 
            // lblEstrella4
            // 
            this.lblEstrella4.ImageIndex = 0;
            this.lblEstrella4.ImageList = this.imgCalificacion;
            this.lblEstrella4.Location = new System.Drawing.Point(309, 92);
            this.lblEstrella4.Name = "lblEstrella4";
            this.lblEstrella4.Size = new System.Drawing.Size(36, 36);
            this.lblEstrella4.TabIndex = 4;
            this.lblEstrella4.Click += new System.EventHandler(this.lblEstrella4_Click);
            // 
            // lblEstrella5
            // 
            this.lblEstrella5.ImageIndex = 0;
            this.lblEstrella5.ImageList = this.imgCalificacion;
            this.lblEstrella5.Location = new System.Drawing.Point(351, 92);
            this.lblEstrella5.Name = "lblEstrella5";
            this.lblEstrella5.Size = new System.Drawing.Size(36, 36);
            this.lblEstrella5.TabIndex = 5;
            this.lblEstrella5.Click += new System.EventHandler(this.lblEstrella5_Click);
            // 
            // btnCalificacionAceptar
            // 
            this.btnCalificacionAceptar.Location = new System.Drawing.Point(143, 165);
            this.btnCalificacionAceptar.Name = "btnCalificacionAceptar";
            this.btnCalificacionAceptar.Size = new System.Drawing.Size(117, 38);
            this.btnCalificacionAceptar.TabIndex = 6;
            this.btnCalificacionAceptar.Text = "Aceptar";
            this.btnCalificacionAceptar.UseVisualStyleBackColor = true;
            this.btnCalificacionAceptar.Click += new System.EventHandler(this.btnCalificacionAceptar_Click);
            // 
            // btnCalificacioCancelar
            // 
            this.btnCalificacioCancelar.Location = new System.Drawing.Point(311, 165);
            this.btnCalificacioCancelar.Name = "btnCalificacioCancelar";
            this.btnCalificacioCancelar.Size = new System.Drawing.Size(117, 38);
            this.btnCalificacioCancelar.TabIndex = 7;
            this.btnCalificacioCancelar.Text = "Cancelar";
            this.btnCalificacioCancelar.UseVisualStyleBackColor = true;
            this.btnCalificacioCancelar.Click += new System.EventHandler(this.btnCalificacioCancelar_Click);
            // 
            // frmCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 215);
            this.Controls.Add(this.btnCalificacioCancelar);
            this.Controls.Add(this.btnCalificacionAceptar);
            this.Controls.Add(this.lblEstrella5);
            this.Controls.Add(this.lblEstrella4);
            this.Controls.Add(this.lblEstrella3);
            this.Controls.Add(this.lblEstrella2);
            this.Controls.Add(this.lblEstrella1);
            this.Controls.Add(this.lblCalificación);
            this.Name = "frmCalificacion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalificación;
        private System.Windows.Forms.ImageList imgCalificacion;
        private System.Windows.Forms.Label lblEstrella1;
        private System.Windows.Forms.Label lblEstrella2;
        private System.Windows.Forms.Label lblEstrella3;
        private System.Windows.Forms.Label lblEstrella4;
        private System.Windows.Forms.Label lblEstrella5;
        private System.Windows.Forms.Button btnCalificacionAceptar;
        private System.Windows.Forms.Button btnCalificacioCancelar;
    }
}