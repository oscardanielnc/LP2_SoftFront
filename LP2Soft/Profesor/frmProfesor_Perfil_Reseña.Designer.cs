﻿
namespace LP2Soft.Profesor
{
    partial class frmProfesor_Perfil_Reseña
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
            this.panelResenias = new System.Windows.Forms.Panel();
            this.btnReseniar = new LP2Soft.Asesor.BotonChevere();
            this.SuspendLayout();
            // 
            // panelResenias
            // 
            this.panelResenias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelResenias.Location = new System.Drawing.Point(68, 69);
            this.panelResenias.Name = "panelResenias";
            this.panelResenias.Size = new System.Drawing.Size(660, 150);
            this.panelResenias.TabIndex = 42;
            this.panelResenias.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnReseniar
            // 
            this.btnReseniar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnReseniar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnReseniar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnReseniar.BorderRadius = 6;
            this.btnReseniar.BorderSize = 0;
            this.btnReseniar.FlatAppearance.BorderSize = 0;
            this.btnReseniar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReseniar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReseniar.ForeColor = System.Drawing.Color.White;
            this.btnReseniar.Location = new System.Drawing.Point(91, 21);
            this.btnReseniar.Name = "btnReseniar";
            this.btnReseniar.Size = new System.Drawing.Size(122, 30);
            this.btnReseniar.TabIndex = 43;
            this.btnReseniar.Text = "Crear Reseña";
            this.btnReseniar.TextColor = System.Drawing.Color.White;
            this.btnReseniar.UseVisualStyleBackColor = false;
            this.btnReseniar.Click += new System.EventHandler(this.btnReseniar_Click);
            // 
            // frmProfesor_Perfil_Reseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this.btnReseniar);
            this.Controls.Add(this.panelResenias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfesor_Perfil_Reseña";
            this.Text = "frmProfesor_Perfil_Reseña";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelResenias;
        private Asesor.BotonChevere btnReseniar;
    }
}