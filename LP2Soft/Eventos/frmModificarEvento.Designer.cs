﻿
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
            this.btnModificar = new LP2Soft.Asesor.BotonChevere();
            this.btnEliminar = new LP2Soft.Asesor.BotonChevere();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPublicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 616);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "Hora :";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(127, 580);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(62, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "Fecha :";
            // 
            // txtLinkZoom
            // 
            this.txtLinkZoom.Location = new System.Drawing.Point(127, 528);
            this.txtLinkZoom.Multiline = true;
            this.txtLinkZoom.Name = "txtLinkZoom";
            this.txtLinkZoom.Size = new System.Drawing.Size(280, 33);
            this.txtLinkZoom.TabIndex = 55;
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(34, 536);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(87, 16);
            this.lblZoom.TabIndex = 54;
            this.lblZoom.Text = "Link Zoom :";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(34, 276);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(145, 16);
            this.lblImagen.TabIndex = 51;
            this.lblImagen.Text = "Añade una imagen :";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(37, 133);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(356, 122);
            this.txtContenido.TabIndex = 50;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(34, 105);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(223, 16);
            this.lblDescripcion.TabIndex = 49;
            this.lblDescripcion.Text = "Añade descripción del evento :";
            // 
            // lblModificarEvento
            // 
            this.lblModificarEvento.AutoSize = true;
            this.lblModificarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEvento.Location = new System.Drawing.Point(8, 8);
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
            this.btnSubirImagen.Location = new System.Drawing.Point(309, 467);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(42, 31);
            this.btnSubirImagen.TabIndex = 53;
            this.btnSubirImagen.UseVisualStyleBackColor = false;
            this.btnSubirImagen.Click += new System.EventHandler(this.btnSubirImagen_Click);
            // 
            // pbImagenPublicacion
            // 
            this.pbImagenPublicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenPublicacion.Location = new System.Drawing.Point(97, 314);
            this.pbImagenPublicacion.Name = "pbImagenPublicacion";
            this.pbImagenPublicacion.Size = new System.Drawing.Size(256, 186);
            this.pbImagenPublicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPublicacion.TabIndex = 52;
            this.pbImagenPublicacion.TabStop = false;
            // 
            // tpmmf
            // 
            this.tpmmf.CustomFormat = "mm";
            this.tpmmf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpmmf.Location = new System.Drawing.Point(304, 615);
            this.tpmmf.Name = "tpmmf";
            this.tpmmf.ShowUpDown = true;
            this.tpmmf.Size = new System.Drawing.Size(40, 20);
            this.tpmmf.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = ":";
            // 
            // tphhf
            // 
            this.tphhf.CustomFormat = "HH";
            this.tphhf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tphhf.Location = new System.Drawing.Point(247, 615);
            this.tphhf.Name = "tphhf";
            this.tphhf.ShowUpDown = true;
            this.tphhf.Size = new System.Drawing.Size(40, 20);
            this.tphhf.TabIndex = 72;
            // 
            // tpmmi
            // 
            this.tpmmi.CustomFormat = "mm";
            this.tpmmi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpmmi.Location = new System.Drawing.Point(183, 615);
            this.tpmmi.Name = "tpmmi";
            this.tpmmi.ShowUpDown = true;
            this.tpmmi.Size = new System.Drawing.Size(40, 20);
            this.tpmmi.TabIndex = 71;
            // 
            // tphhi
            // 
            this.tphhi.CustomFormat = "HH";
            this.tphhi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tphhi.Location = new System.Drawing.Point(128, 615);
            this.tphhi.Name = "tphhi";
            this.tphhi.ShowUpDown = true;
            this.tphhi.Size = new System.Drawing.Size(40, 20);
            this.tphhi.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 618);
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
            this.txtTitulo.Location = new System.Drawing.Point(37, 60);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(356, 33);
            this.txtTitulo.TabIndex = 76;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(34, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 16);
            this.lblTitulo.TabIndex = 75;
            this.lblTitulo.Text = "Título del Evento :";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnModificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnModificar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnModificar.BorderRadius = 6;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(332, 665);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 78;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnEliminar.BorderRadius = 6;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(232, 665);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // frmModificarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 700);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tpmmf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tphhf);
            this.Controls.Add(this.tpmmi);
            this.Controls.Add(this.tphhi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
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
            this.Name = "frmModificarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar o Eliminar Evento";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPublicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Asesor.BotonChevere btnModificar;
        private Asesor.BotonChevere btnEliminar;
    }
}