
namespace LP2Soft.Cursos.Calificación
{
    partial class Calificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calificacion));
            this.lblCalificación = new System.Windows.Forms.Label();
            this.imgCalificacion = new System.Windows.Forms.ImageList(this.components);
            this.lblEstrellas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // lblEstrellas
            // 
            this.lblEstrellas.ImageIndex = 0;
            this.lblEstrellas.ImageList = this.imgCalificacion;
            this.lblEstrellas.Location = new System.Drawing.Point(183, 92);
            this.lblEstrellas.Name = "lblEstrellas";
            this.lblEstrellas.Size = new System.Drawing.Size(36, 36);
            this.lblEstrellas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.imgCalificacion;
            this.label2.Location = new System.Drawing.Point(225, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 36);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.imgCalificacion;
            this.label3.Location = new System.Drawing.Point(267, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 36);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.ImageIndex = 0;
            this.label4.ImageList = this.imgCalificacion;
            this.label4.Location = new System.Drawing.Point(309, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 36);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.ImageIndex = 0;
            this.label5.ImageList = this.imgCalificacion;
            this.label5.Location = new System.Drawing.Point(351, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 36);
            this.label5.TabIndex = 5;
            // 
            // btnCalificacionAceptar
            // 
            this.btnCalificacionAceptar.Location = new System.Drawing.Point(143, 165);
            this.btnCalificacionAceptar.Name = "btnCalificacionAceptar";
            this.btnCalificacionAceptar.Size = new System.Drawing.Size(117, 38);
            this.btnCalificacionAceptar.TabIndex = 6;
            this.btnCalificacionAceptar.Text = "Aceptar";
            this.btnCalificacionAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCalificacioCancelar
            // 
            this.btnCalificacioCancelar.Location = new System.Drawing.Point(311, 165);
            this.btnCalificacioCancelar.Name = "btnCalificacioCancelar";
            this.btnCalificacioCancelar.Size = new System.Drawing.Size(117, 38);
            this.btnCalificacioCancelar.TabIndex = 7;
            this.btnCalificacioCancelar.Text = "Cancelar";
            this.btnCalificacioCancelar.UseVisualStyleBackColor = true;
            // 
            // Calificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 215);
            this.Controls.Add(this.btnCalificacioCancelar);
            this.Controls.Add(this.btnCalificacionAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEstrellas);
            this.Controls.Add(this.lblCalificación);
            this.Name = "Calificacion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalificación;
        private System.Windows.Forms.ImageList imgCalificacion;
        private System.Windows.Forms.Label lblEstrellas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalificacionAceptar;
        private System.Windows.Forms.Button btnCalificacioCancelar;
    }
}