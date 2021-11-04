namespace LP2Soft.Asesor
{
    partial class frmPostularAsesor
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
            this.lblPostular = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.lblSol = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboCursos = new LP2Soft.Asesor.RJComboBox();
            this.SuspendLayout();
            // 
            // lblPostular
            // 
            this.lblPostular.AutoSize = true;
            this.lblPostular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostular.Location = new System.Drawing.Point(18, 25);
            this.lblPostular.Name = "lblPostular";
            this.lblPostular.Size = new System.Drawing.Size(296, 31);
            this.lblPostular.TabIndex = 10;
            this.lblPostular.Text = "Postular como asesor";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(100, 106);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(65, 24);
            this.lblCurso.TabIndex = 16;
            this.lblCurso.Text = "Curso:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(212, 181);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(82, 20);
            this.textBoxPrecio.TabIndex = 21;
            // 
            // lblSol
            // 
            this.lblSol.AutoSize = true;
            this.lblSol.BackColor = System.Drawing.SystemColors.Control;
            this.lblSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol.Location = new System.Drawing.Point(174, 177);
            this.lblSol.Name = "lblSol";
            this.lblSol.Size = new System.Drawing.Size(32, 24);
            this.lblSol.TabIndex = 20;
            this.lblSol.Text = "S/.";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(20, 173);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(145, 24);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio por hora:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(201, 257);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 42);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboCursos
            // 
            this.cboCursos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCursos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.cboCursos.BorderSize = 1;
            this.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCursos.ForeColor = System.Drawing.Color.DimGray;
            this.cboCursos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.cboCursos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboCursos.ListTextColor = System.Drawing.Color.DimGray;
            this.cboCursos.Location = new System.Drawing.Point(178, 106);
            this.cboCursos.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Padding = new System.Windows.Forms.Padding(1);
            this.cboCursos.Size = new System.Drawing.Size(329, 41);
            this.cboCursos.TabIndex = 23;
            this.cboCursos.Texts = "Elegir curso";
            this.cboCursos.Enter += new System.EventHandler(this.cboCursos_Enter);
            this.cboCursos.Leave += new System.EventHandler(this.cboCursos_Leave);
            // 
            // frmPostularAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 311);
            this.Controls.Add(this.cboCursos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.lblSol);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblPostular);
            this.Name = "frmPostularAsesor";
            this.Text = "frmPostularAsesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPostular;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label lblSol;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnGuardar;
        private RJComboBox cboCursos;
    }
}