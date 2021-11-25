
namespace LP2Soft.Tarjetas
{
    partial class tarjResenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarjResenia));
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.calificacion = new System.Windows.Forms.Label();
            this.imgEstrellas = new System.Windows.Forms.ImageList(this.components);
            this.estrella5 = new System.Windows.Forms.Label();
            this.estrella4 = new System.Windows.Forms.Label();
            this.estrella3 = new System.Windows.Forms.Label();
            this.estrella2 = new System.Windows.Forms.Label();
            this.estrella1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(32, 95);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(596, 26);
            this.lblDescripcion.TabIndex = 50;
            this.lblDescripcion.Text = "Gran asesor del curso de Sistemas Operativos. Se toma el tiempo de explicarte en " +
    "caso no hayas entendido correctamente y comparte gran cantidad de ejercicios par" +
    "a practicar.";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(79, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 18);
            this.lblUsuario.TabIndex = 46;
            this.lblUsuario.Text = "Lana Rita";
            // 
            // picUsuario
            // 
            this.picUsuario.Image = global::LP2Soft.Properties.Resources.images;
            this.picUsuario.Location = new System.Drawing.Point(35, 29);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(40, 40);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 44;
            this.picUsuario.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(81, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 13);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "01/10/2021 - 10:53";
            // 
            // lblAsesor
            // 
            this.lblAsesor.AutoSize = true;
            this.lblAsesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsesor.Location = new System.Drawing.Point(112, 72);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(119, 18);
            this.lblAsesor.TabIndex = 47;
            this.lblAsesor.Text = "Oscar Navarro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Asesor:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::LP2Soft.Properties.Resources.cross;
            this.btnEliminar.Location = new System.Drawing.Point(628, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(20, 18);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar mi resenia");
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // calificacion
            // 
            this.calificacion.AutoSize = true;
            this.calificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calificacion.Location = new System.Drawing.Point(464, 60);
            this.calificacion.Name = "calificacion";
            this.calificacion.Size = new System.Drawing.Size(40, 18);
            this.calificacion.TabIndex = 57;
            this.calificacion.Text = "4.00";
            // 
            // imgEstrellas
            // 
            this.imgEstrellas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgEstrellas.ImageStream")));
            this.imgEstrellas.TransparentColor = System.Drawing.Color.Transparent;
            this.imgEstrellas.Images.SetKeyName(0, "star-regular-24.png");
            this.imgEstrellas.Images.SetKeyName(1, "star-solid-24.png");
            this.imgEstrellas.Images.SetKeyName(2, "star-half-solid-24.png");
            // 
            // estrella5
            // 
            this.estrella5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella5.ImageIndex = 0;
            this.estrella5.ImageList = this.imgEstrellas;
            this.estrella5.Location = new System.Drawing.Point(524, 34);
            this.estrella5.Name = "estrella5";
            this.estrella5.Size = new System.Drawing.Size(20, 20);
            this.estrella5.TabIndex = 73;
            // 
            // estrella4
            // 
            this.estrella4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella4.ImageIndex = 0;
            this.estrella4.ImageList = this.imgEstrellas;
            this.estrella4.Location = new System.Drawing.Point(498, 33);
            this.estrella4.Name = "estrella4";
            this.estrella4.Size = new System.Drawing.Size(20, 20);
            this.estrella4.TabIndex = 72;
            // 
            // estrella3
            // 
            this.estrella3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella3.ImageIndex = 0;
            this.estrella3.ImageList = this.imgEstrellas;
            this.estrella3.Location = new System.Drawing.Point(472, 33);
            this.estrella3.Name = "estrella3";
            this.estrella3.Size = new System.Drawing.Size(20, 20);
            this.estrella3.TabIndex = 71;
            // 
            // estrella2
            // 
            this.estrella2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella2.ImageIndex = 0;
            this.estrella2.ImageList = this.imgEstrellas;
            this.estrella2.Location = new System.Drawing.Point(446, 33);
            this.estrella2.Name = "estrella2";
            this.estrella2.Size = new System.Drawing.Size(20, 20);
            this.estrella2.TabIndex = 70;
            // 
            // estrella1
            // 
            this.estrella1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estrella1.ImageIndex = 0;
            this.estrella1.ImageList = this.imgEstrellas;
            this.estrella1.Location = new System.Drawing.Point(420, 33);
            this.estrella1.Name = "estrella1";
            this.estrella1.Size = new System.Drawing.Size(20, 20);
            this.estrella1.TabIndex = 69;
            // 
            // tarjResenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(660, 150);
            this.Controls.Add(this.estrella5);
            this.Controls.Add(this.estrella4);
            this.Controls.Add(this.estrella3);
            this.Controls.Add(this.estrella2);
            this.Controls.Add(this.estrella1);
            this.Controls.Add(this.calificacion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAsesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjResenia";
            this.Text = "tarjResenia";
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAsesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label calificacion;
        private System.Windows.Forms.ImageList imgEstrellas;
        private System.Windows.Forms.Label estrella5;
        private System.Windows.Forms.Label estrella4;
        private System.Windows.Forms.Label estrella3;
        private System.Windows.Forms.Label estrella2;
        private System.Windows.Forms.Label estrella1;
    }
}