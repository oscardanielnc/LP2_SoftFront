
namespace LP2Soft.Eventos
{
    partial class frmEventosAgendados
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
            this.lblCalendarioPersonal = new System.Windows.Forms.Label();
            this.panelPublicacionesEventos = new System.Windows.Forms.Panel();
            this.lblEventosAgendados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.monthCalendar1.Location = new System.Drawing.Point(65, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // lblCalendarioPersonal
            // 
            this.lblCalendarioPersonal.AutoSize = true;
            this.lblCalendarioPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarioPersonal.Location = new System.Drawing.Point(12, 14);
            this.lblCalendarioPersonal.Name = "lblCalendarioPersonal";
            this.lblCalendarioPersonal.Size = new System.Drawing.Size(170, 20);
            this.lblCalendarioPersonal.TabIndex = 9;
            this.lblCalendarioPersonal.Text = "Calendario Personal";
            // 
            // panelPublicacionesEventos
            // 
            this.panelPublicacionesEventos.AutoScroll = true;
            this.panelPublicacionesEventos.Location = new System.Drawing.Point(362, 51);
            this.panelPublicacionesEventos.Name = "panelPublicacionesEventos";
            this.panelPublicacionesEventos.Size = new System.Drawing.Size(408, 442);
            this.panelPublicacionesEventos.TabIndex = 12;
            // 
            // lblEventosAgendados
            // 
            this.lblEventosAgendados.AutoSize = true;
            this.lblEventosAgendados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosAgendados.Location = new System.Drawing.Point(358, 14);
            this.lblEventosAgendados.Name = "lblEventosAgendados";
            this.lblEventosAgendados.Size = new System.Drawing.Size(284, 20);
            this.lblEventosAgendados.TabIndex = 6;
            this.lblEventosAgendados.Text = "Eventos Agendados el 23/11/2021";
            // 
            // frmEventosAgendados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 495);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblEventosAgendados);
            this.Controls.Add(this.panelPublicacionesEventos);
            this.Controls.Add(this.lblCalendarioPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventosAgendados";
            this.Text = "frmEventosAgendados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblCalendarioPersonal;
        private System.Windows.Forms.Panel panelPublicacionesEventos;
        private System.Windows.Forms.Label lblEventosAgendados;
    }
}