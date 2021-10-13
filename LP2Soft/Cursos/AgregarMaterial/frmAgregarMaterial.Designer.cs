
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
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.checkbSi = new System.Windows.Forms.CheckBox();
            this.checkBNo = new System.Windows.Forms.CheckBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.flpCargarMaterial = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTituloPanel = new System.Windows.Forms.Label();
            this.btbCargarDocs = new System.Windows.Forms.Button();
            this.lblProfesorMsj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
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
            this.lblProfesor.Location = new System.Drawing.Point(29, 128);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(70, 18);
            this.lblProfesor.TabIndex = 1;
            this.lblProfesor.Text = "Profesor:";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.Location = new System.Drawing.Point(29, 89);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(76, 18);
            this.lblSemestre.TabIndex = 2;
            this.lblSemestre.Text = "Semestre:";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(29, 166);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(88, 18);
            this.lblCalificacion.TabIndex = 3;
            this.lblCalificacion.Text = "Calificación:";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(29, 202);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(44, 18);
            this.lblNota.TabIndex = 4;
            this.lblNota.Text = "Nota:";
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(136, 324);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(147, 39);
            this.btnSubir.TabIndex = 5;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(335, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(33, 244);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(334, 56);
            this.txtComentario.TabIndex = 7;
            // 
            // checkbSi
            // 
            this.checkbSi.AutoSize = true;
            this.checkbSi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkbSi.Location = new System.Drawing.Point(134, 166);
            this.checkbSi.Name = "checkbSi";
            this.checkbSi.Size = new System.Drawing.Size(35, 17);
            this.checkbSi.TabIndex = 8;
            this.checkbSi.Text = "Si";
            this.checkbSi.UseVisualStyleBackColor = true;
            // 
            // checkBNo
            // 
            this.checkBNo.AutoSize = true;
            this.checkBNo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBNo.Location = new System.Drawing.Point(200, 166);
            this.checkBNo.Name = "checkBNo";
            this.checkBNo.Size = new System.Drawing.Size(40, 17);
            this.checkBNo.TabIndex = 9;
            this.checkBNo.Text = "No";
            this.checkBNo.UseVisualStyleBackColor = true;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(134, 202);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(122, 20);
            this.txtNota.TabIndex = 10;
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclo.Location = new System.Drawing.Point(231, 89);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(46, 18);
            this.lblCiclo.TabIndex = 13;
            this.lblCiclo.Text = "Ciclo:";
            // 
            // flpCargarMaterial
            // 
            this.flpCargarMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCargarMaterial.Controls.Add(this.lblTituloPanel);
            this.flpCargarMaterial.Controls.Add(this.btbCargarDocs);
            this.flpCargarMaterial.Location = new System.Drawing.Point(388, 81);
            this.flpCargarMaterial.Name = "flpCargarMaterial";
            this.flpCargarMaterial.Size = new System.Drawing.Size(221, 219);
            this.flpCargarMaterial.TabIndex = 15;
            // 
            // lblTituloPanel
            // 
            this.lblTituloPanel.AutoSize = true;
            this.lblTituloPanel.Location = new System.Drawing.Point(3, 0);
            this.lblTituloPanel.Name = "lblTituloPanel";
            this.lblTituloPanel.Size = new System.Drawing.Size(169, 13);
            this.lblTituloPanel.TabIndex = 16;
            this.lblTituloPanel.Text = "Arrastar aquí los documentos        ";
            // 
            // btbCargarDocs
            // 
            this.btbCargarDocs.Image = global::LP2Soft.Properties.Resources.upload_regular_24;
            this.btbCargarDocs.Location = new System.Drawing.Point(178, 3);
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
            this.lblProfesorMsj.Location = new System.Drawing.Point(133, 110);
            this.lblProfesorMsj.Name = "lblProfesorMsj";
            this.lblProfesorMsj.Size = new System.Drawing.Size(0, 13);
            this.lblProfesorMsj.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(307, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(283, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(84, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(139, 85);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(79, 21);
            this.comboBox3.TabIndex = 21;
            // 
            // frmAgregarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 375);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProfesorMsj);
            this.Controls.Add(this.flpCargarMaterial);
            this.Controls.Add(this.lblCiclo);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.checkBNo);
            this.Controls.Add(this.checkbSi);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.lblSemestre);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAgregarMaterial";
            this.Text = "frmAgregarMaterial";
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
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.CheckBox checkbSi;
        private System.Windows.Forms.CheckBox checkBNo;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.FlowLayoutPanel flpCargarMaterial;
        private System.Windows.Forms.Label lblTituloPanel;
        private System.Windows.Forms.Button btbCargarDocs;
        private System.Windows.Forms.Label lblProfesorMsj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}