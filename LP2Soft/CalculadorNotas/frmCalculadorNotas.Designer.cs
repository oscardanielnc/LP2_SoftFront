
namespace LP2Soft.CalculadorNotas
{
    partial class frmCalculadorNotas
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
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.checkBoxEliminarNotaBaja = new System.Windows.Forms.CheckBox();
            this.lblNotaMinima = new System.Windows.Forms.Label();
            this.lblNotaMin = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblProm = new System.Windows.Forms.Label();
            this.lblElimina = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCalculadorNotas = new System.Windows.Forms.Label();
            this.panelNotas = new System.Windows.Forms.Panel();
            this.btnCalcular = new LP2Soft.Asesor.BotonChevere();
            this.btnAgregar = new LP2Soft.Asesor.BotonChevere();
            this.panelDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetalles
            // 
            this.panelDetalles.AutoScroll = true;
            this.panelDetalles.BackColor = System.Drawing.SystemColors.Control;
            this.panelDetalles.Controls.Add(this.checkBoxEliminarNotaBaja);
            this.panelDetalles.Controls.Add(this.btnCalcular);
            this.panelDetalles.Controls.Add(this.btnAgregar);
            this.panelDetalles.Controls.Add(this.lblNotaMinima);
            this.panelDetalles.Controls.Add(this.lblNotaMin);
            this.panelDetalles.Controls.Add(this.lblPromedio);
            this.panelDetalles.Controls.Add(this.lblProm);
            this.panelDetalles.Controls.Add(this.lblElimina);
            this.panelDetalles.Controls.Add(this.lblCantidad);
            this.panelDetalles.Controls.Add(this.txtCantidad);
            this.panelDetalles.Controls.Add(this.lblPeso);
            this.panelDetalles.Controls.Add(this.txtPeso);
            this.panelDetalles.Controls.Add(this.lblNombre);
            this.panelDetalles.Controls.Add(this.txtNombre);
            this.panelDetalles.Location = new System.Drawing.Point(44, 43);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(720, 142);
            this.panelDetalles.TabIndex = 16;
            // 
            // checkBoxEliminarNotaBaja
            // 
            this.checkBoxEliminarNotaBaja.AutoSize = true;
            this.checkBoxEliminarNotaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEliminarNotaBaja.Location = new System.Drawing.Point(628, 45);
            this.checkBoxEliminarNotaBaja.Name = "checkBoxEliminarNotaBaja";
            this.checkBoxEliminarNotaBaja.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEliminarNotaBaja.TabIndex = 33;
            this.checkBoxEliminarNotaBaja.UseVisualStyleBackColor = true;
            // 
            // lblNotaMinima
            // 
            this.lblNotaMinima.AutoSize = true;
            this.lblNotaMinima.BackColor = System.Drawing.SystemColors.Control;
            this.lblNotaMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaMinima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNotaMinima.Location = new System.Drawing.Point(663, 106);
            this.lblNotaMinima.Name = "lblNotaMinima";
            this.lblNotaMinima.Size = new System.Drawing.Size(44, 20);
            this.lblNotaMinima.TabIndex = 27;
            this.lblNotaMinima.Text = "0.00";
            // 
            // lblNotaMin
            // 
            this.lblNotaMin.AutoSize = true;
            this.lblNotaMin.BackColor = System.Drawing.SystemColors.Control;
            this.lblNotaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaMin.Location = new System.Drawing.Point(410, 106);
            this.lblNotaMin.Name = "lblNotaMin";
            this.lblNotaMin.Size = new System.Drawing.Size(233, 16);
            this.lblNotaMin.TabIndex = 26;
            this.lblNotaMin.Text = "Nota mínima en el Examen Final:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.BackColor = System.Drawing.SystemColors.Control;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(321, 103);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(44, 20);
            this.lblPromedio.TabIndex = 25;
            this.lblPromedio.Text = "0.00";
            // 
            // lblProm
            // 
            this.lblProm.AutoSize = true;
            this.lblProm.BackColor = System.Drawing.SystemColors.Control;
            this.lblProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProm.Location = new System.Drawing.Point(188, 106);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(117, 16);
            this.lblProm.TabIndex = 24;
            this.lblProm.Text = "Promedio Final:";
            // 
            // lblElimina
            // 
            this.lblElimina.AutoSize = true;
            this.lblElimina.BackColor = System.Drawing.SystemColors.Control;
            this.lblElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElimina.Location = new System.Drawing.Point(550, 18);
            this.lblElimina.Name = "lblElimina";
            this.lblElimina.Size = new System.Drawing.Size(160, 16);
            this.lblElimina.TabIndex = 23;
            this.lblElimina.Text = "¿Elimina la más baja?";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.Control;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(410, 18);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(134, 16);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad de notas";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(433, 41);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(87, 24);
            this.txtCantidad.TabIndex = 22;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.SystemColors.Control;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(272, 18);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(127, 16);
            this.lblPeso.TabIndex = 19;
            this.lblPeso.Text = "Peso del registro";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(291, 41);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(87, 24);
            this.txtPeso.TabIndex = 20;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(146, 16);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre del registro";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(15, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 24);
            this.txtNombre.TabIndex = 18;
            // 
            // lblCalculadorNotas
            // 
            this.lblCalculadorNotas.AutoSize = true;
            this.lblCalculadorNotas.BackColor = System.Drawing.SystemColors.Control;
            this.lblCalculadorNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadorNotas.Location = new System.Drawing.Point(35, 9);
            this.lblCalculadorNotas.Name = "lblCalculadorNotas";
            this.lblCalculadorNotas.Size = new System.Drawing.Size(274, 31);
            this.lblCalculadorNotas.TabIndex = 15;
            this.lblCalculadorNotas.Text = "Calculador de notas";
            // 
            // panelNotas
            // 
            this.panelNotas.AutoScroll = true;
            this.panelNotas.BackColor = System.Drawing.SystemColors.Control;
            this.panelNotas.Location = new System.Drawing.Point(44, 191);
            this.panelNotas.Name = "panelNotas";
            this.panelNotas.Size = new System.Drawing.Size(720, 238);
            this.panelNotas.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.BackgroundColor = System.Drawing.Color.White;
            this.btnCalcular.BorderColor = System.Drawing.Color.White;
            this.btnCalcular.BorderRadius = 6;
            this.btnCalcular.BorderSize = 0;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(90, 100);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(69, 30);
            this.btnCalcular.TabIndex = 32;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextColor = System.Drawing.Color.Black;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.btnAgregar.BorderRadius = 6;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(15, 99);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 30);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmCalculadorNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelNotas);
            this.Controls.Add(this.panelDetalles);
            this.Controls.Add(this.lblCalculadorNotas);
            this.Name = "frmCalculadorNotas";
            this.Text = "frmCalculadorNotas";
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Label lblCalculadorNotas;
        private System.Windows.Forms.Panel panelNotas;
        private System.Windows.Forms.Label lblElimina;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNotaMinima;
        private System.Windows.Forms.Label lblNotaMin;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblProm;
        private Asesor.BotonChevere btnAgregar;
        private Asesor.BotonChevere btnCalcular;
        private System.Windows.Forms.CheckBox checkBoxEliminarNotaBaja;
    }
}