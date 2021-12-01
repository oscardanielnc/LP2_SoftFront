
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
            this.dTIni = new System.Windows.Forms.DateTimePicker();
            this.dTFin = new System.Windows.Forms.DateTimePicker();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.btnFiltros = new LP2Soft.Asesor.BotonChevere();
            this.btnCancelars = new LP2Soft.Asesor.BotonChevere();
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
            // btnFiltros
            // 
            this.btnFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnFiltros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnFiltros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnFiltros.BorderRadius = 6;
            this.btnFiltros.BorderSize = 0;
            this.btnFiltros.FlatAppearance.BorderSize = 0;
            this.btnFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltros.ForeColor = System.Drawing.Color.White;
            this.btnFiltros.Location = new System.Drawing.Point(58, 288);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(147, 39);
            this.btnFiltros.TabIndex = 35;
            this.btnFiltros.Text = "Filtrar";
            this.btnFiltros.TextColor = System.Drawing.Color.White;
            this.btnFiltros.UseVisualStyleBackColor = false;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // btnCancelars
            // 
            this.btnCancelars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnCancelars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnCancelars.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(84)))));
            this.btnCancelars.BorderRadius = 6;
            this.btnCancelars.BorderSize = 0;
            this.btnCancelars.FlatAppearance.BorderSize = 0;
            this.btnCancelars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelars.ForeColor = System.Drawing.Color.White;
            this.btnCancelars.Location = new System.Drawing.Point(244, 288);
            this.btnCancelars.Name = "btnCancelars";
            this.btnCancelars.Size = new System.Drawing.Size(147, 39);
            this.btnCancelars.TabIndex = 36;
            this.btnCancelars.Text = "Cancelar";
            this.btnCancelars.TextColor = System.Drawing.Color.White;
            this.btnCancelars.UseVisualStyleBackColor = false;
            this.btnCancelars.Click += new System.EventHandler(this.btnCancelars_Click);
            // 
            // frmFiltrarPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 356);
            this.Controls.Add(this.btnCancelars);
            this.Controls.Add(this.btnFiltros);
            this.Controls.Add(this.dTFin);
            this.Controls.Add(this.dTIni);
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
        private System.Windows.Forms.CheckBox checkbSi;
        private System.Windows.Forms.CheckBox checkBNo;
        private System.Windows.Forms.DateTimePicker dTIni;
        private System.Windows.Forms.DateTimePicker dTFin;
        private System.Windows.Forms.ComboBox cboCurso;
        private Asesor.BotonChevere btnFiltros;
        private Asesor.BotonChevere btnCancelars;
    }
}