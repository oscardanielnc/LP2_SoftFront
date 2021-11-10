
namespace LP2Soft.Eventos
{
    partial class frmFiltro
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
            this.lblFiltros = new System.Windows.Forms.Label();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblActivo = new System.Windows.Forms.Label();
            this.chkbSi = new System.Windows.Forms.CheckBox();
            this.chkbNo = new System.Windows.Forms.CheckBox();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(12, 9);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(129, 20);
            this.lblFiltros.TabIndex = 7;
            this.lblFiltros.Text = "Filtros Eventos";
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltros.Location = new System.Drawing.Point(106, 191);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(156, 31);
            this.btnAplicarFiltros.TabIndex = 24;
            this.btnAplicarFiltros.Text = "Aplicar Filtros";
            this.btnAplicarFiltros.UseVisualStyleBackColor = true;
            // 
            // cboHorario
            // 
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Location = new System.Drawing.Point(153, 103);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(200, 21);
            this.cboHorario.TabIndex = 22;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(57, 103);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(62, 20);
            this.lblGrupo.TabIndex = 19;
            this.lblGrupo.Text = "Grupo :";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(57, 63);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 20);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha :";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(153, 63);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 25;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(57, 145);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(60, 20);
            this.lblActivo.TabIndex = 26;
            this.lblActivo.Text = "Activo :";
            // 
            // chkbSi
            // 
            this.chkbSi.AutoSize = true;
            this.chkbSi.Location = new System.Drawing.Point(182, 145);
            this.chkbSi.Name = "chkbSi";
            this.chkbSi.Size = new System.Drawing.Size(37, 17);
            this.chkbSi.TabIndex = 27;
            this.chkbSi.Text = "Sí";
            this.chkbSi.UseVisualStyleBackColor = true;
            // 
            // chkbNo
            // 
            this.chkbNo.AutoSize = true;
            this.chkbNo.Location = new System.Drawing.Point(283, 145);
            this.chkbNo.Name = "chkbNo";
            this.chkbNo.Size = new System.Drawing.Size(40, 17);
            this.chkbNo.TabIndex = 28;
            this.chkbNo.Text = "No";
            this.chkbNo.UseVisualStyleBackColor = true;
            // 
            // btnFiltros
            // 
            this.btnFiltros.Image = global::LP2Soft.Properties.Resources.filtrar__1_;
            this.btnFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltros.Location = new System.Drawing.Point(283, 191);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(86, 23);
            this.btnFiltros.TabIndex = 29;
            this.btnFiltros.Text = "Filtros";
            this.btnFiltros.UseVisualStyleBackColor = true;
            // 
            // frmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 245);
            this.Controls.Add(this.btnFiltros);
            this.Controls.Add(this.chkbNo);
            this.Controls.Add(this.chkbSi);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnAplicarFiltros);
            this.Controls.Add(this.cboHorario);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFiltros);
            this.Name = "frmFiltro";
            this.Text = "frmFiltro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.ComboBox cboHorario;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.CheckBox chkbSi;
        private System.Windows.Forms.CheckBox chkbNo;
        private System.Windows.Forms.Button btnFiltros;
    }
}