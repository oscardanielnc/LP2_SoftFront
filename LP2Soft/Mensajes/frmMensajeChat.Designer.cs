
namespace LP2Soft.Mensajes
{
    partial class frmMensajeChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensajeChat));
            this.imgAmigo = new System.Windows.Forms.PictureBox();
            this.panelMensajes = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnEnviarMensaje = new System.Windows.Forms.PictureBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblNombreAmigo = new System.Windows.Forms.Label();
            this.toolTipMensajes = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgAmigo)).BeginInit();
            this.panelMensajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviarMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAmigo
            // 
            this.imgAmigo.Image = global::LP2Soft.Properties.Resources.images;
            this.imgAmigo.Location = new System.Drawing.Point(12, 12);
            this.imgAmigo.Name = "imgAmigo";
            this.imgAmigo.Size = new System.Drawing.Size(70, 70);
            this.imgAmigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAmigo.TabIndex = 8;
            this.imgAmigo.TabStop = false;
            // 
            // panelMensajes
            // 
            this.panelMensajes.AutoScroll = true;
            this.panelMensajes.Controls.Add(this.lblInfo);
            this.panelMensajes.Location = new System.Drawing.Point(12, 98);
            this.panelMensajes.Name = "panelMensajes";
            this.panelMensajes.Size = new System.Drawing.Size(799, 353);
            this.panelMensajes.TabIndex = 11;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(310, 16);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "Se han encontrado 15 mensajes con este usuario...";
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarMensaje.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarMensaje.Image")));
            this.btnEnviarMensaje.Location = new System.Drawing.Point(728, 457);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(30, 30);
            this.btnEnviarMensaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEnviarMensaje.TabIndex = 18;
            this.btnEnviarMensaje.TabStop = false;
            this.toolTipMensajes.SetToolTip(this.btnEnviarMensaje, "Enviar mensaje");
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.ForeColor = System.Drawing.Color.Gray;
            this.txtMensaje.Location = new System.Drawing.Point(85, 460);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(637, 20);
            this.txtMensaje.TabIndex = 0;
            this.txtMensaje.Text = "Escribe aquí tu mensaje";
            this.txtMensaje.Enter += new System.EventHandler(this.txtMensaje_Enter);
            this.txtMensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMensaje_KeyDown);
            this.txtMensaje.Leave += new System.EventHandler(this.txtMensaje_Leave);
            // 
            // lblNombreAmigo
            // 
            this.lblNombreAmigo.AutoSize = true;
            this.lblNombreAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAmigo.Location = new System.Drawing.Point(88, 30);
            this.lblNombreAmigo.Name = "lblNombreAmigo";
            this.lblNombreAmigo.Size = new System.Drawing.Size(145, 29);
            this.lblNombreAmigo.TabIndex = 12;
            this.lblNombreAmigo.Text = "Freddy Paz";
            // 
            // frmMensajeChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(823, 492);
            this.Controls.Add(this.lblNombreAmigo);
            this.Controls.Add(this.panelMensajes);
            this.Controls.Add(this.imgAmigo);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnEnviarMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMensajeChat";
            this.Text = "frmMensajeChat";
            ((System.ComponentModel.ISupportInitialize)(this.imgAmigo)).EndInit();
            this.panelMensajes.ResumeLayout(false);
            this.panelMensajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviarMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgAmigo;
        private System.Windows.Forms.Panel panelMensajes;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.PictureBox btnEnviarMensaje;
        private System.Windows.Forms.Label lblNombreAmigo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolTip toolTipMensajes;
    }
}