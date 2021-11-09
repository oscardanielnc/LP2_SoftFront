
namespace LP2Soft.Mensajes
{
    partial class frmMensajes
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
            this.panelMensajes = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelMensajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.BackColor = System.Drawing.SystemColors.Control;
            this.lblChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChat.Location = new System.Drawing.Point(12, 22);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(138, 31);
            this.lblChat.TabIndex = 9;
            this.lblChat.Text = "Mensajes";
            // 
            // panelMensajes
            // 
            this.panelMensajes.AutoScroll = true;
            this.panelMensajes.BackColor = System.Drawing.SystemColors.Control;
            this.panelMensajes.Controls.Add(this.lblInfo);
            this.panelMensajes.Location = new System.Drawing.Point(12, 70);
            this.panelMensajes.Name = "panelMensajes";
            this.panelMensajes.Size = new System.Drawing.Size(799, 421);
            this.panelMensajes.TabIndex = 14;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(310, 16);
            this.lblInfo.TabIndex = 21;
            this.lblInfo.Text = "Se han encontrado 15 mensajes con este usuario...";
            // 
            // frmMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(823, 505);
            this.Controls.Add(this.panelMensajes);
            this.Controls.Add(this.lblChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMensajes";
            this.Text = "frmMensajes";
            this.panelMensajes.ResumeLayout(false);
            this.panelMensajes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Panel panelMensajes;
        private System.Windows.Forms.Label lblInfo;
    }
}