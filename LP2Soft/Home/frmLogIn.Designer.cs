
namespace LP2Soft.Home
{
    partial class frmLogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNuevaCuentaInfo = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblCorreoCodigo = new System.Windows.Forms.Label();
            this.txtCorreoCodigo = new System.Windows.Forms.TextBox();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.btnNuevoUsuario = new System.Windows.Forms.PictureBox();
            this.lblOlvide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registrar";
            // 
            // lblNuevaCuentaInfo
            // 
            this.lblNuevaCuentaInfo.AutoSize = true;
            this.lblNuevaCuentaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCuentaInfo.Location = new System.Drawing.Point(73, 278);
            this.lblNuevaCuentaInfo.Name = "lblNuevaCuentaInfo";
            this.lblNuevaCuentaInfo.Size = new System.Drawing.Size(265, 15);
            this.lblNuevaCuentaInfo.TabIndex = 6;
            this.lblNuevaCuentaInfo.Text = "Si aún no tiene una cuenta. Créala aquí.";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresar.Location = new System.Drawing.Point(157, 187);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(92, 35);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(47, 121);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(80, 16);
            this.lblContrasenia.TabIndex = 4;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(50, 150);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(294, 21);
            this.txtContrasenia.TabIndex = 3;
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasenia_KeyDown);
            // 
            // lblCorreoCodigo
            // 
            this.lblCorreoCodigo.AutoSize = true;
            this.lblCorreoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoCodigo.Location = new System.Drawing.Point(47, 58);
            this.lblCorreoCodigo.Name = "lblCorreoCodigo";
            this.lblCorreoCodigo.Size = new System.Drawing.Size(148, 16);
            this.lblCorreoCodigo.TabIndex = 2;
            this.lblCorreoCodigo.Text = "Correo o código PUCP:";
            // 
            // txtCorreoCodigo
            // 
            this.txtCorreoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCodigo.Location = new System.Drawing.Point(50, 85);
            this.txtCorreoCodigo.Name = "txtCorreoCodigo";
            this.txtCorreoCodigo.Size = new System.Drawing.Size(294, 21);
            this.txtCorreoCodigo.TabIndex = 1;
            this.txtCorreoCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCorreoCodigo_KeyDown);
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesion.Location = new System.Drawing.Point(46, 18);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(134, 20);
            this.lblInicioSesion.TabIndex = 0;
            this.lblInicioSesion.Text = "Inicio de sesión";
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUsuario.Image = global::LP2Soft.Properties.Resources.customers_icon_3;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(161, 306);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(80, 80);
            this.btnNuevoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNuevoUsuario.TabIndex = 3;
            this.btnNuevoUsuario.TabStop = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // lblOlvide
            // 
            this.lblOlvide.AutoSize = true;
            this.lblOlvide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvide.Location = new System.Drawing.Point(130, 235);
            this.lblOlvide.Name = "lblOlvide";
            this.lblOlvide.Size = new System.Drawing.Size(142, 15);
            this.lblOlvide.TabIndex = 8;
            this.lblOlvide.Text = "Olvidé mi contraseña";
            this.lblOlvide.Click += new System.EventHandler(this.lblOlvide_Click);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(400, 440);
            this.Controls.Add(this.lblOlvide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.lblNuevaCuentaInfo);
            this.Controls.Add(this.lblInicioSesion);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCorreoCodigo);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblCorreoCodigo);
            this.Controls.Add(this.txtContrasenia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogIn";
            this.Text = "Home_LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnNuevoUsuario;
        private System.Windows.Forms.Label lblNuevaCuentaInfo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblCorreoCodigo;
        private System.Windows.Forms.TextBox txtCorreoCodigo;
        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOlvide;
    }
}