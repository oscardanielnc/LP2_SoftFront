
namespace LP2Soft.Perfil
{
    partial class frmFiltrarPublicaciones
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
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.checkbSi = new System.Windows.Forms.CheckBox();
            this.checkBNo = new System.Windows.Forms.CheckBox();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dTIni = new System.Windows.Forms.DateTimePicker();
            this.dTFin = new System.Windows.Forms.DateTimePicker();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(106, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Filtrar Publicaciones";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(55, 139);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(100, 18);
            this.lblFechaFin.TabIndex = 3;
            this.lblFechaFin.Text = "Fecha Final  : ";
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIni.Location = new System.Drawing.Point(55, 96);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(95, 18);
            this.lblFechaIni.TabIndex = 4;
            this.lblFechaIni.Text = "Fecha Inicio :";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(57, 182);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(93, 18);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso          :";
            // 
            // checkbSi
            // 
            this.checkbSi.AutoSize = true;
            this.checkbSi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkbSi.Location = new System.Drawing.Point(170, 185);
            this.checkbSi.Name = "checkbSi";
            this.checkbSi.Size = new System.Drawing.Size(35, 17);
            this.checkbSi.TabIndex = 9;
            this.checkbSi.Text = "Si";
            this.checkbSi.UseVisualStyleBackColor = true;
            this.checkbSi.CheckedChanged += new System.EventHandler(this.checkbSi_CheckedChanged_1);
            // 
            // checkBNo
            // 
            this.checkBNo.AutoSize = true;
            this.checkBNo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBNo.Location = new System.Drawing.Point(244, 185);
            this.checkBNo.Name = "checkBNo";
            this.checkBNo.Size = new System.Drawing.Size(40, 17);
            this.checkBNo.TabIndex = 10;
            this.checkBNo.Text = "No";
            this.checkBNo.UseVisualStyleBackColor = true;
            this.checkBNo.CheckedChanged += new System.EventHandler(this.checkBNo_CheckedChanged_1);
            // 
            // btnFiltra
            // 
            this.btnFiltra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnFiltra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltra.Location = new System.Drawing.Point(58, 273);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(147, 39);
            this.btnFiltra.TabIndex = 22;
            this.btnFiltra.Text = "Filtrar";
            this.btnFiltra.UseVisualStyleBackColor = false;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(244, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 39);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dTIni
            // 
            this.dTIni.Location = new System.Drawing.Point(170, 96);
            this.dTIni.Name = "dTIni";
            this.dTIni.Size = new System.Drawing.Size(205, 20);
            this.dTIni.TabIndex = 24;
            // 
            // dTFin
            // 
            this.dTFin.Location = new System.Drawing.Point(170, 139);
            this.dTFin.Name = "dTFin";
            this.dTFin.Size = new System.Drawing.Size(205, 20);
            this.dTFin.TabIndex = 25;
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cboCurso.Location = new System.Drawing.Point(170, 217);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(205, 21);
            this.cboCurso.TabIndex = 21;
            // 
            // frmFiltrarPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 356);
            this.Controls.Add(this.dTFin);
            this.Controls.Add(this.dTIni);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFiltra);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.checkBNo);
            this.Controls.Add(this.checkbSi);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblFechaIni);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmFiltrarPublicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar Publicaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox checkbSi;
        private System.Windows.Forms.CheckBox checkBNo;
        private System.Windows.Forms.DateTimePicker dTIni;
        private System.Windows.Forms.DateTimePicker dTFin;
        private System.Windows.Forms.ComboBox cboCurso;
    }
}