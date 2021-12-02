
namespace LP2Soft.Cursos.AgregarMaterial
{
    partial class frmAgregarMaterial
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.checkbSi = new System.Windows.Forms.CheckBox();
            this.checkBNo = new System.Windows.Forms.CheckBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.flpCargarMaterial = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPDF = new System.Windows.Forms.Label();
            this.btbCargarDocs = new System.Windows.Forms.Button();
            this.lblProfesorMsj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProfesores = new System.Windows.Forms.ComboBox();
            this.cboCiclo = new System.Windows.Forms.ComboBox();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.btnRCancelar = new LP2Soft.Asesor.BotonChevere();
            this.btnRSubir = new LP2Soft.Asesor.BotonChevere();
            this.cboProfesores.SelectedIndex = -1;
            this.flpCargarMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(27, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Datos del Material";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.Location = new System.Drawing.Point(29, 123);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(70, 18);
            this.lblProfesor.TabIndex = 1;
            this.lblProfesor.Text = "Profesor:";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.Location = new System.Drawing.Point(29, 84);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(76, 18);
            this.lblSemestre.TabIndex = 2;
            this.lblSemestre.Text = "Semestre:";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(29, 161);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(88, 18);
            this.lblCalificacion.TabIndex = 3;
            this.lblCalificacion.Text = "Calificación:";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(29, 193);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(44, 18);
            this.lblNota.TabIndex = 4;
            this.lblNota.Text = "Nota:";
            // 
            // checkbSi
            // 
            this.checkbSi.AutoSize = true;
            this.checkbSi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkbSi.Location = new System.Drawing.Point(134, 161);
            this.checkbSi.Name = "checkbSi";
            this.checkbSi.Size = new System.Drawing.Size(35, 17);
            this.checkbSi.TabIndex = 8;
            this.checkbSi.Text = "Si";
            this.checkbSi.UseVisualStyleBackColor = true;
            this.checkbSi.CheckedChanged += new System.EventHandler(this.checkbSi_CheckedChanged);
            // 
            // checkBNo
            // 
            this.checkBNo.AutoSize = true;
            this.checkBNo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBNo.Location = new System.Drawing.Point(200, 161);
            this.checkBNo.Name = "checkBNo";
            this.checkBNo.Size = new System.Drawing.Size(40, 17);
            this.checkBNo.TabIndex = 9;
            this.checkBNo.Text = "No";
            this.checkBNo.UseVisualStyleBackColor = true;
            this.checkBNo.CheckedChanged += new System.EventHandler(this.checkBNo_CheckedChanged);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(139, 194);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(122, 20);
            this.txtNota.TabIndex = 10;
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclo.Location = new System.Drawing.Point(231, 84);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(46, 18);
            this.lblCiclo.TabIndex = 13;
            this.lblCiclo.Text = "Ciclo:";
            // 
            // flpCargarMaterial
            // 
            this.flpCargarMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCargarMaterial.Controls.Add(this.lblPDF);
            this.flpCargarMaterial.Controls.Add(this.btbCargarDocs);
            this.flpCargarMaterial.Location = new System.Drawing.Point(388, 81);
            this.flpCargarMaterial.Name = "flpCargarMaterial";
            this.flpCargarMaterial.Size = new System.Drawing.Size(221, 130);
            this.flpCargarMaterial.TabIndex = 15;
            // 
            // lblPDF
            // 
            this.lblPDF.AutoSize = true;
            this.lblPDF.Location = new System.Drawing.Point(3, 0);
            this.lblPDF.Name = "lblPDF";
            this.lblPDF.Size = new System.Drawing.Size(166, 13);
            this.lblPDF.TabIndex = 16;
            this.lblPDF.Text = "Adjunte su PDF aquí -->               ";
            // 
            // btbCargarDocs
            // 
            this.btbCargarDocs.Image = global::LP2Soft.Properties.Resources.upload_regular_24;
            this.btbCargarDocs.Location = new System.Drawing.Point(175, 3);
            this.btbCargarDocs.Name = "btbCargarDocs";
            this.btbCargarDocs.Size = new System.Drawing.Size(35, 33);
            this.btbCargarDocs.TabIndex = 16;
            this.btbCargarDocs.UseVisualStyleBackColor = true;
            this.btbCargarDocs.Click += new System.EventHandler(this.btbCargarDocs_Click);
            // 
            // lblProfesorMsj
            // 
            this.lblProfesorMsj.AutoSize = true;
            this.lblProfesorMsj.ForeColor = System.Drawing.Color.Red;
            this.lblProfesorMsj.Location = new System.Drawing.Point(133, 105);
            this.lblProfesorMsj.Name = "lblProfesorMsj";
            this.lblProfesorMsj.Size = new System.Drawing.Size(0, 13);
            this.lblProfesorMsj.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(307, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // cboProfesores
            // 
            this.cboProfesores.FormattingEnabled = true;
            this.cboProfesores.Items.AddRange(new object[] {
            "       "});
            this.cboProfesores.Location = new System.Drawing.Point(139, 120);
            this.cboProfesores.Name = "cboProfesores";
            this.cboProfesores.Size = new System.Drawing.Size(228, 21);
            this.cboProfesores.TabIndex = 19;
            // 
            // cboCiclo
            // 
            this.cboCiclo.FormattingEnabled = true;
            this.cboCiclo.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cboCiclo.Location = new System.Drawing.Point(283, 81);
            this.cboCiclo.Name = "cboCiclo";
            this.cboCiclo.Size = new System.Drawing.Size(84, 21);
            this.cboCiclo.TabIndex = 20;
            // 
            // cboSemestre
            // 
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.cboSemestre.Location = new System.Drawing.Point(139, 80);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(79, 21);
            this.cboSemestre.TabIndex = 21;
            // 
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "openFileDialog1";
            // 
            // btnRCancelar
            // 
            this.btnRCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnRCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnRCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnRCancelar.BorderRadius = 6;
            this.btnRCancelar.BorderSize = 0;
            this.btnRCancelar.FlatAppearance.BorderSize = 0;
            this.btnRCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRCancelar.ForeColor = System.Drawing.Color.White;
            this.btnRCancelar.Location = new System.Drawing.Point(344, 252);
            this.btnRCancelar.Name = "btnRCancelar";
            this.btnRCancelar.Size = new System.Drawing.Size(143, 36);
            this.btnRCancelar.TabIndex = 56;
            this.btnRCancelar.Text = "Cancelar";
            this.btnRCancelar.TextColor = System.Drawing.Color.White;
            this.btnRCancelar.UseVisualStyleBackColor = false;
            this.btnRCancelar.Click += new System.EventHandler(this.btnRCancelar_Click);
            // 
            // btnRSubir
            // 
            this.btnRSubir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnRSubir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnRSubir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnRSubir.BorderRadius = 6;
            this.btnRSubir.BorderSize = 0;
            this.btnRSubir.FlatAppearance.BorderSize = 0;
            this.btnRSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSubir.ForeColor = System.Drawing.Color.White;
            this.btnRSubir.Location = new System.Drawing.Point(129, 250);
            this.btnRSubir.Name = "btnRSubir";
            this.btnRSubir.Size = new System.Drawing.Size(143, 36);
            this.btnRSubir.TabIndex = 55;
            this.btnRSubir.Text = "Subir";
            this.btnRSubir.TextColor = System.Drawing.Color.White;
            this.btnRSubir.UseVisualStyleBackColor = false;
            this.btnRSubir.Click += new System.EventHandler(this.botonChevere1_Click);
            // 
            // frmAgregarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 324);
            this.Controls.Add(this.btnRCancelar);
            this.Controls.Add(this.btnRSubir);
            this.Controls.Add(this.cboSemestre);
            this.Controls.Add(this.cboCiclo);
            this.Controls.Add(this.cboProfesores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProfesorMsj);
            this.Controls.Add(this.flpCargarMaterial);
            this.Controls.Add(this.lblCiclo);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.checkBNo);
            this.Controls.Add(this.checkbSi);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.lblSemestre);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAgregarMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Material";
            this.flpCargarMaterial.ResumeLayout(false);
            this.flpCargarMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.CheckBox checkbSi;
        private System.Windows.Forms.CheckBox checkBNo;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.FlowLayoutPanel flpCargarMaterial;
        private System.Windows.Forms.Label lblPDF;
        private System.Windows.Forms.Button btbCargarDocs;
        private System.Windows.Forms.Label lblProfesorMsj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProfesores;
        private System.Windows.Forms.ComboBox cboCiclo;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private Asesor.BotonChevere btnRSubir;
        private Asesor.BotonChevere btnRCancelar;
    }
}