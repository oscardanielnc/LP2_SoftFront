
namespace LP2Soft.Eventos
{
    partial class frmVerEventos
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelPublicacionesEventos = new System.Windows.Forms.Panel();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.btnCrearEvento = new System.Windows.Forms.Button();
            this.lblPublicacionesEventos = new System.Windows.Forms.Label();
            this.lblCalendarioPersonal = new System.Windows.Forms.Label();
            this.panelPublicacionesEventos.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(467, 50);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // panelPublicacionesEventos
            // 
            this.panelPublicacionesEventos.Controls.Add(this.btnFiltros);
            this.panelPublicacionesEventos.Controls.Add(this.btnCrearEvento);
            this.panelPublicacionesEventos.Controls.Add(this.lblPublicacionesEventos);
            this.panelPublicacionesEventos.Location = new System.Drawing.Point(2, 3);
            this.panelPublicacionesEventos.Name = "panelPublicacionesEventos";
            this.panelPublicacionesEventos.Size = new System.Drawing.Size(439, 445);
            this.panelPublicacionesEventos.TabIndex = 6;
            // 
            // btnFiltros
            // 
            this.btnFiltros.Image = global::LP2Soft.Properties.Resources.filtrar__1_;
            this.btnFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltros.Location = new System.Drawing.Point(236, 12);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(86, 23);
            this.btnFiltros.TabIndex = 8;
            this.btnFiltros.Text = "Filtros";
            this.btnFiltros.UseVisualStyleBackColor = true;
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.Location = new System.Drawing.Point(339, 12);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(86, 23);
            this.btnCrearEvento.TabIndex = 7;
            this.btnCrearEvento.Text = "Crear Evento";
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            // 
            // lblPublicacionesEventos
            // 
            this.lblPublicacionesEventos.AutoSize = true;
            this.lblPublicacionesEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicacionesEventos.Location = new System.Drawing.Point(3, 12);
            this.lblPublicacionesEventos.Name = "lblPublicacionesEventos";
            this.lblPublicacionesEventos.Size = new System.Drawing.Size(214, 20);
            this.lblPublicacionesEventos.TabIndex = 6;
            this.lblPublicacionesEventos.Text = "Publicaciones de Eventos";
            // 
            // lblCalendarioPersonal
            // 
            this.lblCalendarioPersonal.AutoSize = true;
            this.lblCalendarioPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarioPersonal.Location = new System.Drawing.Point(464, 18);
            this.lblCalendarioPersonal.Name = "lblCalendarioPersonal";
            this.lblCalendarioPersonal.Size = new System.Drawing.Size(150, 16);
            this.lblCalendarioPersonal.TabIndex = 9;
            this.lblCalendarioPersonal.Text = "Calendario Personal";
            // 
            // frmVerEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.lblCalendarioPersonal);
            this.Controls.Add(this.panelPublicacionesEventos);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerEventos";
            this.Text = "frmEventos";
            this.panelPublicacionesEventos.ResumeLayout(false);
            this.panelPublicacionesEventos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panelPublicacionesEventos;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Button btnCrearEvento;
        private System.Windows.Forms.Label lblPublicacionesEventos;
        private System.Windows.Forms.Label lblCalendarioPersonal;
    }
}