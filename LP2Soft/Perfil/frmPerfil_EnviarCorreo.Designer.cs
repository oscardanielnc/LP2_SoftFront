
namespace LP2Soft.Perfil
{
    partial class frmPerfil_EnviarCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil_EnviarCorreo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReceiverMail = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblSenderMail = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnviarCorreo = new LP2Soft.Asesor.BotonChevere();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.btbCargarDocs = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSender.Location = new System.Drawing.Point(23, 86);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(139, 18);
            this.lblSender.TabIndex = 1;
            this.lblSender.Text = "Correo destinatario:";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(104, 117);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(58, 18);
            this.lblAsunto.TabIndex = 2;
            this.lblAsunto.Text = "Asunto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mensaje:";
            // 
            // lblReceiverMail
            // 
            this.lblReceiverMail.AutoSize = true;
            this.lblReceiverMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMail.Location = new System.Drawing.Point(168, 86);
            this.lblReceiverMail.Name = "lblReceiverMail";
            this.lblReceiverMail.Size = new System.Drawing.Size(91, 18);
            this.lblReceiverMail.TabIndex = 4;
            this.lblReceiverMail.Text = "receiver mail";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(171, 117);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(410, 20);
            this.txtAsunto.TabIndex = 5;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(171, 150);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensaje.Size = new System.Drawing.Size(410, 113);
            this.txtMensaje.TabIndex = 6;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(59, 360);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(103, 18);
            this.lblSource.TabIndex = 7;
            this.lblSource.Text = "Correo fuente:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(73, 392);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(89, 18);
            this.lblContraseña.TabIndex = 8;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblSenderMail
            // 
            this.lblSenderMail.AutoSize = true;
            this.lblSenderMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMail.Location = new System.Drawing.Point(168, 360);
            this.lblSenderMail.Name = "lblSenderMail";
            this.lblSenderMail.Size = new System.Drawing.Size(84, 18);
            this.lblSenderMail.TabIndex = 9;
            this.lblSenderMail.Text = "sender mail";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(171, 393);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(186, 20);
            this.txtContraseña.TabIndex = 10;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnviarCorreo);
            this.groupBox1.Location = new System.Drawing.Point(26, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 108);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mi Correo";
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnEnviarCorreo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnEnviarCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnEnviarCorreo.BorderRadius = 6;
            this.btnEnviarCorreo.BorderSize = 0;
            this.btnEnviarCorreo.FlatAppearance.BorderSize = 0;
            this.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCorreo.ForeColor = System.Drawing.Color.White;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(385, 56);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(150, 33);
            this.btnEnviarCorreo.TabIndex = 33;
            this.btnEnviarCorreo.Text = "Enviar";
            this.btnEnviarCorreo.TextColor = System.Drawing.Color.White;
            this.btnEnviarCorreo.UseVisualStyleBackColor = false;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo.Location = new System.Drawing.Point(45, 285);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(117, 18);
            this.lblArchivo.TabIndex = 12;
            this.lblArchivo.Text = "Adjuntar archivo:";
            // 
            // btbCargarDocs
            // 
            this.btbCargarDocs.Image = global::LP2Soft.Properties.Resources.upload_regular_24;
            this.btbCargarDocs.Location = new System.Drawing.Point(486, 279);
            this.btbCargarDocs.Name = "btbCargarDocs";
            this.btbCargarDocs.Size = new System.Drawing.Size(35, 33);
            this.btbCargarDocs.TabIndex = 17;
            this.btbCargarDocs.UseVisualStyleBackColor = true;
            this.btbCargarDocs.Click += new System.EventHandler(this.btbCargarDocs_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(171, 285);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(309, 20);
            this.txtArchivo.TabIndex = 18;
            // 
            // frmPerfil_EnviarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.btbCargarDocs);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblSenderMail);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.lblReceiverMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPerfil_EnviarCorreo";
            this.Text = "frmPerfil_EnviarCorreo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReceiverMail;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblSenderMail;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.GroupBox groupBox1;
        private Asesor.BotonChevere btnEnviarCorreo;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Button btbCargarDocs;
        private System.Windows.Forms.TextBox txtArchivo;
    }
}