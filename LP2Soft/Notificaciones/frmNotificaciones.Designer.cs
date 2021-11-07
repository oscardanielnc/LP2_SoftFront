
namespace LP2Soft.Notificaciones
{
    partial class frmNotificaciones
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
            this.lblChat = new System.Windows.Forms.Label();
            this.panelNotificaciones = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelNotificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.BackColor = System.Drawing.SystemColors.Control;
            this.lblChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChat.Location = new System.Drawing.Point(12, 22);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(199, 31);
            this.lblChat.TabIndex = 5;
            this.lblChat.Text = "Notificaciones";
            // 
            // panelNotificaciones
            // 
            this.panelNotificaciones.AutoScroll = true;
            this.panelNotificaciones.BackColor = System.Drawing.SystemColors.Window;
            this.panelNotificaciones.Controls.Add(this.lblInfo);
            this.panelNotificaciones.Location = new System.Drawing.Point(12, 67);
            this.panelNotificaciones.Name = "panelNotificaciones";
            this.panelNotificaciones.Size = new System.Drawing.Size(799, 421);
            this.panelNotificaciones.TabIndex = 7;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(310, 16);
            this.lblInfo.TabIndex = 20;
            this.lblInfo.Text = "Se han encontrado 15 mensajes con este usuario...";
            // 
            // frmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 505);
            this.Controls.Add(this.panelNotificaciones);
            this.Controls.Add(this.lblChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotificaciones";
            this.Text = "frmNotificaciones";
            this.panelNotificaciones.ResumeLayout(false);
            this.panelNotificaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Panel panelNotificaciones;
        private System.Windows.Forms.Label lblInfo;
    }
}