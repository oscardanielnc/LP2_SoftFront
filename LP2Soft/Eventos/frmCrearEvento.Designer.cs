
namespace LP2Soft.Eventos
{
    partial class frmCrearEvento
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
            this.lblNuevoEvento = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnSubirImagen = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            this.txtZoom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.ofdPerfil = new System.Windows.Forms.OpenFileDialog();
            this.pbImagenPublicacion = new System.Windows.Forms.PictureBox();
            this.tphhi = new System.Windows.Forms.DateTimePicker();
            this.tpmmi = new System.Windows.Forms.DateTimePicker();
            this.lblGuion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tphhf = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tpmmf = new System.Windows.Forms.DateTimePicker();
            this.btnCrearEvento = new LP2Soft.Asesor.BotonChevere();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPublicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevoEvento
            // 
            this.lblNuevoEvento.AutoSize = true;
            this.lblNuevoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoEvento.Location = new System.Drawing.Point(12, 9);
            this.lblNuevoEvento.Name = "lblNuevoEvento";
            this.lblNuevoEvento.Size = new System.Drawing.Size(120, 20);
            this.lblNuevoEvento.TabIndex = 7;
            this.lblNuevoEvento.Text = "Nuevo Evento";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(38, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(223, 16);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Añade descripción del evento :";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(41, 128);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(356, 122);
            this.txtContenido.TabIndex = 9;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(38, 271);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(145, 16);
            this.lblImagen.TabIndex = 10;
            this.lblImagen.Text = "Añade una imagen :";
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnSubirImagen.BackgroundImage = global::LP2Soft.Properties.Resources.add__1_;
            this.btnSubirImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirImagen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirImagen.Location = new System.Drawing.Point(316, 462);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(42, 31);
            this.btnSubirImagen.TabIndex = 12;
            this.btnSubirImagen.UseVisualStyleBackColor = false;
            this.btnSubirImagen.Click += new System.EventHandler(this.btnSubirImagen_Click);
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(38, 531);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(87, 16);
            this.lblZoom.TabIndex = 33;
            this.lblZoom.Text = "Link Zoom :";
            // 
            // txtZoom
            // 
            this.txtZoom.Location = new System.Drawing.Point(131, 523);
            this.txtZoom.Multiline = true;
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Size = new System.Drawing.Size(280, 33);
            this.txtZoom.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(66, 575);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Fecha :";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(131, 575);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(75, 611);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Hora :";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(38, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 16);
            this.lblTitulo.TabIndex = 48;
            this.lblTitulo.Text = "Título del Evento :";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(41, 59);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(356, 33);
            this.txtTitulo.TabIndex = 49;
            // 
            // ofdPerfil
            // 
            this.ofdPerfil.FileName = "ofdPerfil";
            // 
            // pbImagenPublicacion
            // 
            this.pbImagenPublicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenPublicacion.Location = new System.Drawing.Point(94, 308);
            this.pbImagenPublicacion.Name = "pbImagenPublicacion";
            this.pbImagenPublicacion.Size = new System.Drawing.Size(265, 186);
            this.pbImagenPublicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPublicacion.TabIndex = 50;
            this.pbImagenPublicacion.TabStop = false;
            // 
            // tphhi
            // 
            this.tphhi.CustomFormat = "HH";
            this.tphhi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tphhi.Location = new System.Drawing.Point(131, 611);
            this.tphhi.Name = "tphhi";
            this.tphhi.ShowUpDown = true;
            this.tphhi.Size = new System.Drawing.Size(40, 20);
            this.tphhi.TabIndex = 51;
            // 
            // tpmmi
            // 
            this.tpmmi.CustomFormat = "mm";
            this.tpmmi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpmmi.Location = new System.Drawing.Point(186, 611);
            this.tpmmi.Name = "tpmmi";
            this.tpmmi.ShowUpDown = true;
            this.tpmmi.Size = new System.Drawing.Size(40, 20);
            this.tpmmi.TabIndex = 52;
            // 
            // lblGuion
            // 
            this.lblGuion.AutoSize = true;
            this.lblGuion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuion.Location = new System.Drawing.Point(233, 614);
            this.lblGuion.Name = "lblGuion";
            this.lblGuion.Size = new System.Drawing.Size(11, 13);
            this.lblGuion.TabIndex = 43;
            this.lblGuion.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = ":";
            // 
            // tphhf
            // 
            this.tphhf.CustomFormat = "HH";
            this.tphhf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tphhf.Location = new System.Drawing.Point(250, 611);
            this.tphhf.Name = "tphhf";
            this.tphhf.ShowUpDown = true;
            this.tphhf.Size = new System.Drawing.Size(40, 20);
            this.tphhf.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = ":";
            // 
            // tpmmf
            // 
            this.tpmmf.CustomFormat = "mm";
            this.tpmmf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpmmf.Location = new System.Drawing.Point(307, 611);
            this.tpmmf.Name = "tpmmf";
            this.tpmmf.ShowUpDown = true;
            this.tpmmf.Size = new System.Drawing.Size(40, 20);
            this.tpmmf.TabIndex = 56;
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnCrearEvento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnCrearEvento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnCrearEvento.BorderRadius = 6;
            this.btnCrearEvento.BorderSize = 0;
            this.btnCrearEvento.FlatAppearance.BorderSize = 0;
            this.btnCrearEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEvento.ForeColor = System.Drawing.Color.White;
            this.btnCrearEvento.Location = new System.Drawing.Point(322, 657);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(75, 23);
            this.btnCrearEvento.TabIndex = 57;
            this.btnCrearEvento.Text = "Publicar";
            this.btnCrearEvento.TextColor = System.Drawing.Color.White;
            this.btnCrearEvento.UseVisualStyleBackColor = false;
            this.btnCrearEvento.Click += new System.EventHandler(this.btnCrearEvento_Click);
            // 
            // frmCrearEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 692);
            this.Controls.Add(this.btnCrearEvento);
            this.Controls.Add(this.tpmmf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tphhf);
            this.Controls.Add(this.tpmmi);
            this.Controls.Add(this.tphhi);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGuion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtZoom);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.btnSubirImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNuevoEvento);
            this.Controls.Add(this.pbImagenPublicacion);
            this.Name = "frmCrearEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Evento";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPublicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoEvento;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnSubirImagen;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.TextBox txtZoom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.OpenFileDialog ofdPerfil;
        private System.Windows.Forms.PictureBox pbImagenPublicacion;
        private System.Windows.Forms.DateTimePicker tphhi;
        private System.Windows.Forms.DateTimePicker tpmmi;
        private System.Windows.Forms.Label lblGuion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tphhf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tpmmf;
        private Asesor.BotonChevere btnCrearEvento;
    }
}