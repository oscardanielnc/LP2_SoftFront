
namespace LP2Soft.Asesor
{
    partial class frmAsesorPostular
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
            this.lblPostularCurso = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboHoraFin = new System.Windows.Forms.ComboBox();
            this.cboHoraIni = new System.Windows.Forms.ComboBox();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblHoraIni = new System.Windows.Forms.Label();
            this.lblElegirDia = new System.Windows.Forms.Label();
            this.lblElegirHorario = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.lblSol = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblInfoAsesoría = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cboCiclo = new System.Windows.Forms.ComboBox();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblSelectCiclo = new System.Windows.Forms.Label();
            this.lblSelectCurso = new System.Windows.Forms.Label();
            this.lblSelectEspecialidad = new System.Windows.Forms.Label();
            this.lblAddDatos = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPostularCurso
            // 
            this.lblPostularCurso.AutoSize = true;
            this.lblPostularCurso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPostularCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostularCurso.Location = new System.Drawing.Point(13, 10);
            this.lblPostularCurso.Name = "lblPostularCurso";
            this.lblPostularCurso.Size = new System.Drawing.Size(436, 31);
            this.lblPostularCurso.TabIndex = 3;
            this.lblPostularCurso.Text = "Postular a nuevo curso u horario";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.cboHoraFin);
            this.panel2.Controls.Add(this.cboHoraIni);
            this.panel2.Controls.Add(this.cboDia);
            this.panel2.Controls.Add(this.lblHoraFin);
            this.panel2.Controls.Add(this.lblHoraIni);
            this.panel2.Controls.Add(this.lblElegirDia);
            this.panel2.Controls.Add(this.lblElegirHorario);
            this.panel2.Controls.Add(this.textBoxDescripcion);
            this.panel2.Controls.Add(this.textBoxPrecio);
            this.panel2.Controls.Add(this.lblSol);
            this.panel2.Controls.Add(this.lblPrecio);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.lblInfoAsesoría);
            this.panel2.Controls.Add(this.cboCurso);
            this.panel2.Controls.Add(this.cboCiclo);
            this.panel2.Controls.Add(this.cboEspecialidad);
            this.panel2.Controls.Add(this.lblSelectCiclo);
            this.panel2.Controls.Add(this.lblSelectCurso);
            this.panel2.Controls.Add(this.lblSelectEspecialidad);
            this.panel2.Controls.Add(this.lblAddDatos);
            this.panel2.Location = new System.Drawing.Point(10, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 405);
            this.panel2.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(249, 667);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 35);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(415, 667);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 35);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboHoraFin
            // 
            this.cboHoraFin.FormattingEnabled = true;
            this.cboHoraFin.Location = new System.Drawing.Point(348, 586);
            this.cboHoraFin.Name = "cboHoraFin";
            this.cboHoraFin.Size = new System.Drawing.Size(112, 21);
            this.cboHoraFin.TabIndex = 24;
            // 
            // cboHoraIni
            // 
            this.cboHoraIni.FormattingEnabled = true;
            this.cboHoraIni.Location = new System.Drawing.Point(173, 586);
            this.cboHoraIni.Name = "cboHoraIni";
            this.cboHoraIni.Size = new System.Drawing.Size(112, 21);
            this.cboHoraIni.TabIndex = 23;
            // 
            // cboDia
            // 
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Location = new System.Drawing.Point(66, 586);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(61, 21);
            this.cboDia.TabIndex = 22;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(353, 559);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(102, 24);
            this.lblHoraFin.TabIndex = 21;
            this.lblHoraFin.Text = "Hora de fin";
            // 
            // lblHoraIni
            // 
            this.lblHoraIni.AutoSize = true;
            this.lblHoraIni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHoraIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraIni.Location = new System.Drawing.Point(169, 559);
            this.lblHoraIni.Name = "lblHoraIni";
            this.lblHoraIni.Size = new System.Drawing.Size(127, 24);
            this.lblHoraIni.TabIndex = 20;
            this.lblHoraIni.Text = "Hora de inicio";
            // 
            // lblElegirDia
            // 
            this.lblElegirDia.AutoSize = true;
            this.lblElegirDia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblElegirDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirDia.Location = new System.Drawing.Point(78, 559);
            this.lblElegirDia.Name = "lblElegirDia";
            this.lblElegirDia.Size = new System.Drawing.Size(37, 24);
            this.lblElegirDia.TabIndex = 19;
            this.lblElegirDia.Text = "Dia";
            // 
            // lblElegirHorario
            // 
            this.lblElegirHorario.AutoSize = true;
            this.lblElegirHorario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblElegirHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirHorario.Location = new System.Drawing.Point(36, 522);
            this.lblElegirHorario.Name = "lblElegirHorario";
            this.lblElegirHorario.Size = new System.Drawing.Size(128, 24);
            this.lblElegirHorario.TabIndex = 18;
            this.lblElegirHorario.Text = "Elegir horario:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(157, 422);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(559, 83);
            this.textBoxDescripcion.TabIndex = 17;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(222, 371);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(42, 20);
            this.textBoxPrecio.TabIndex = 16;
            // 
            // lblSol
            // 
            this.lblSol.AutoSize = true;
            this.lblSol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol.Location = new System.Drawing.Point(190, 368);
            this.lblSol.Name = "lblSol";
            this.lblSol.Size = new System.Drawing.Size(32, 24);
            this.lblSol.TabIndex = 15;
            this.lblSol.Text = "S/.";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(36, 368);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(145, 24);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio por hora:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(36, 418);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(115, 24);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblInfoAsesoría
            // 
            this.lblInfoAsesoría.AutoSize = true;
            this.lblInfoAsesoría.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoAsesoría.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoAsesoría.Location = new System.Drawing.Point(12, 325);
            this.lblInfoAsesoría.Name = "lblInfoAsesoría";
            this.lblInfoAsesoría.Size = new System.Drawing.Size(276, 29);
            this.lblInfoAsesoría.TabIndex = 12;
            this.lblInfoAsesoría.Text = "Información del Curso:";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(40, 276);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(224, 21);
            this.cboCurso.TabIndex = 11;
            // 
            // cboCiclo
            // 
            this.cboCiclo.FormattingEnabled = true;
            this.cboCiclo.Location = new System.Drawing.Point(40, 183);
            this.cboCiclo.Name = "cboCiclo";
            this.cboCiclo.Size = new System.Drawing.Size(224, 21);
            this.cboCiclo.TabIndex = 10;
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(40, 94);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(224, 21);
            this.cboEspecialidad.TabIndex = 9;
            // 
            // lblSelectCiclo
            // 
            this.lblSelectCiclo.AutoSize = true;
            this.lblSelectCiclo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSelectCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCiclo.Location = new System.Drawing.Point(36, 143);
            this.lblSelectCiclo.Name = "lblSelectCiclo";
            this.lblSelectCiclo.Size = new System.Drawing.Size(162, 24);
            this.lblSelectCiclo.TabIndex = 8;
            this.lblSelectCiclo.Text = "Seleccionar Ciclo:";
            // 
            // lblSelectCurso
            // 
            this.lblSelectCurso.AutoSize = true;
            this.lblSelectCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSelectCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCurso.Location = new System.Drawing.Point(36, 236);
            this.lblSelectCurso.Name = "lblSelectCurso";
            this.lblSelectCurso.Size = new System.Drawing.Size(170, 24);
            this.lblSelectCurso.TabIndex = 7;
            this.lblSelectCurso.Text = "Seleccionar Curso:";
            // 
            // lblSelectEspecialidad
            // 
            this.lblSelectEspecialidad.AutoSize = true;
            this.lblSelectEspecialidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSelectEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectEspecialidad.Location = new System.Drawing.Point(36, 54);
            this.lblSelectEspecialidad.Name = "lblSelectEspecialidad";
            this.lblSelectEspecialidad.Size = new System.Drawing.Size(228, 24);
            this.lblSelectEspecialidad.TabIndex = 6;
            this.lblSelectEspecialidad.Text = "Seleccionar Especialidad:";
            // 
            // lblAddDatos
            // 
            this.lblAddDatos.AutoSize = true;
            this.lblAddDatos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDatos.Location = new System.Drawing.Point(12, 11);
            this.lblAddDatos.Name = "lblAddDatos";
            this.lblAddDatos.Size = new System.Drawing.Size(276, 29);
            this.lblAddDatos.TabIndex = 5;
            this.lblAddDatos.Text = "Información del Curso:";
            // 
            // panelBackground
            // 
            this.panelBackground.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelBackground.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBackground.Controls.Add(this.panel2);
            this.panelBackground.Controls.Add(this.lblPostularCurso);
            this.panelBackground.Location = new System.Drawing.Point(12, 12);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(799, 468);
            this.panelBackground.TabIndex = 0;
            // 
            // frmAsesorPostular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(823, 492);
            this.Controls.Add(this.panelBackground);
            this.Name = "frmAsesorPostular";
            this.Text = "frmAsesorPostular";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPostularCurso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboHoraFin;
        private System.Windows.Forms.ComboBox cboHoraIni;
        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblHoraIni;
        private System.Windows.Forms.Label lblElegirDia;
        private System.Windows.Forms.Label lblElegirHorario;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label lblSol;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblInfoAsesoría;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboCiclo;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Label lblSelectCiclo;
        private System.Windows.Forms.Label lblSelectCurso;
        private System.Windows.Forms.Label lblSelectEspecialidad;
        private System.Windows.Forms.Label lblAddDatos;
        private System.Windows.Forms.Panel panelBackground;
    }
}