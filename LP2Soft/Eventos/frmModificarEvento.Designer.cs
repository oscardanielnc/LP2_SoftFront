
namespace LP2Soft.Eventos
{
    partial class frmModificarEvento
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLinkZoom = new System.Windows.Forms.TextBox();
            this.lblZoom = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblModificarEvento = new System.Windows.Forms.Label();
            this.btnSubirImagen = new System.Windows.Forms.Button();
            this.pbImagenPublicacion = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tpmmf = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tphhf = new System.Windows.Forms.DateTimePicker();
            this.tpmmi = new System.Windows.Forms.DateTimePicker();
            this.tphhi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ofdPerfil = new System.Windows.Forms.OpenFileDialog();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPublicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(443, 821);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 66;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(95, 758);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "Hora :";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(169, 714);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(83, 714);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "Fecha :";
            // 
            // txtLinkZoom
            // 
            this.txtLinkZoom.Location = new System.Drawing.Point(169, 650);
            this.txtLinkZoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLinkZoom.Multiline = true;
            this.txtLinkZoom.Name = "txtLinkZoom";
            this.txtLinkZoom.Size = new System.Drawing.Size(372, 40);
            this.txtLinkZoom.TabIndex = 55;
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(45, 660);
            this.lblZoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(87, 16);
            this.lblZoom.TabIndex = 54;
            this.lblZoom.Text = "Link Zoom :";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(45, 340);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(145, 16);
            this.lblImagen.TabIndex = 51;
            this.lblImagen.Text = "Añade una imagen :";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(49, 164);
            this.txtContenido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(473, 149);
            this.txtContenido.TabIndex = 50;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(45, 129);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(223, 16);
            this.lblDescripcion.TabIndex = 49;
            this.lblDescripcion.Text = "Añade descripción del evento :";
            // 
            // lblModificarEvento
            // 
            this.lblModificarEvento.AutoSize = true;
            this.lblModificarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEvento.Location = new System.Drawing.Point(11, 10);
            this.lblModificarEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModificarEvento.Name = "lblModificarEvento";
            this.lblModificarEvento.Size = new System.Drawing.Size(143, 20);
            this.lblModificarEvento.TabIndex = 48;
            this.lblModificarEvento.Text = "Modificar Evento";
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnSubirImagen.BackgroundImage = global::LP2Soft.Properties.Resources.add__1_;
            this.btnSubirImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirImagen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirImagen.Location = new System.Drawing.Point(412, 575);
            this.btnSubirImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(56, 38);
            this.btnSubirImagen.TabIndex = 53;
            this.btnSubirImagen.UseVisualStyleBackColor = false;
            this.btnSubirImagen.Click += new System.EventHandler(this.btnSubirImagen_Click);
            // 
            // pbImagenPublicacion
            // 
            this.pbImagenPublicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenPublicacion.Location = new System.Drawing.Point(129, 386);
            this.pbImagenPublicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagenPublicacion.Name = "pbImagenPublicacion";
            this.pbImagenPublicacion.Size = new System.Drawing.Size(341, 228);
            this.pbImagenPublicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPublicacion.TabIndex = 52;
            this.pbImagenPublicacion.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(312, 821);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 67;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tpmmf
            // 
            this.tpmmf.CustomFormat = "mm";
            this.tpmmf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpmmf.Location = new System.Drawing.Point(405, 757);
            this.tpmmf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpmmf.Name = "tpmmf";
            this.tpmmf.ShowUpDown = true;
            this.tpmmf.Size = new System.Drawing.Size(52, 22);
            this.tpmmf.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 761);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = ":";
            // 
            // tphhf
            // 
            this.tphhf.CustomFormat = "HH";
            this.tphhf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tphhf.Location = new System.Drawing.Point(329, 757);
            this.tphhf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tphhf.Name = "tphhf";
            this.tphhf.ShowUpDown = true;
            this.tphhf.Size = new System.Drawing.Size(52, 22);
            this.tphhf.TabIndex = 72;
            // 
            // tpmmi
            // 
            this.tpmmi.CustomFormat = "mm";
            this.tpmmi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpmmi.Location = new System.Drawing.Point(244, 757);
            this.tpmmi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpmmi.Name = "tpmmi";
            this.tpmmi.ShowUpDown = true;
            this.tpmmi.Size = new System.Drawing.Size(52, 22);
            this.tpmmi.TabIndex = 71;
            // 
            // tphhi
            // 
            this.tphhi.CustomFormat = "HH";
            this.tphhi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tphhi.Location = new System.Drawing.Point(171, 757);
            this.tphhi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tphhi.Name = "tphhi";
            this.tphhi.ShowUpDown = true;
            this.tphhi.Size = new System.Drawing.Size(52, 22);
            this.tphhi.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 761);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 761);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "-";
            // 
            // ofdPerfil
            // 
            this.ofdPerfil.FileName = "openFileDialog1";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(49, 74);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(473, 40);
            this.txtTitulo.TabIndex = 76;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(45, 44);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 16);
            this.lblTitulo.TabIndex = 75;
            this.lblTitulo.Text = "Título del Evento :";
            // 
            // frmModificarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 862);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tpmmf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tphhf);
            this.Controls.Add(this.tpmmi);
            this.Controls.Add(this.tphhi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLinkZoom);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.btnSubirImagen);
            this.Controls.Add(this.pbImagenPublicacion);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblModificarEvento);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmModificarEvento";
            this.Text = "frmModificarEvento";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPublicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLinkZoom;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Button btnSubirImagen;
        private System.Windows.Forms.PictureBox pbImagenPublicacion;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblModificarEvento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker tpmmf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tphhf;
        private System.Windows.Forms.DateTimePicker tpmmi;
        private System.Windows.Forms.DateTimePicker tphhi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog ofdPerfil;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}