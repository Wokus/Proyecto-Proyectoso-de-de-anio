﻿namespace Presentacionn
{
    partial class frmAltaEquipo
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
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.mtxtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaIgreso = new System.Windows.Forms.Label();
            this.lblAsegurado = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cbxMoneda = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtAsegurado = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Location = new System.Drawing.Point(100, 140);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroSerie.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(305, 145);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtAsegurado
            // 
            this.txtAsegurado.Location = new System.Drawing.Point(305, 104);
            this.txtAsegurado.Name = "txtAsegurado";
            this.txtAsegurado.Size = new System.Drawing.Size(100, 20);
            this.txtAsegurado.TabIndex = 6;
            this.txtAsegurado.TextChanged += new System.EventHandler(this.txtAsegurado_TextChanged);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(305, 223);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(100, 20);
            this.txtObservaciones.TabIndex = 9;
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Location = new System.Drawing.Point(179, 336);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(144, 55);
            this.btnAgregarEquipo.TabIndex = 10;
            this.btnAgregarEquipo.Text = "Agregar";
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            this.btnAgregarEquipo.Click += new System.EventHandler(this.btnAgregarEquipo_Click);
            // 
            // mtxtFechaIngreso
            // 
            this.mtxtFechaIngreso.Location = new System.Drawing.Point(100, 222);
            this.mtxtFechaIngreso.Mask = "00/00/0000";
            this.mtxtFechaIngreso.Name = "mtxtFechaIngreso";
            this.mtxtFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaIngreso.TabIndex = 12;
            this.mtxtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(40, 111);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(54, 13);
            this.Nombre.TabIndex = 15;
            this.Nombre.Text = "lblNombre";
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(8, 147);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(86, 13);
            this.lblNumeroSerie.TabIndex = 16;
            this.lblNumeroSerie.Text = "Numero de Serie";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(54, 187);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado";
            // 
            // lblFechaIgreso
            // 
            this.lblFechaIgreso.AutoSize = true;
            this.lblFechaIgreso.Location = new System.Drawing.Point(4, 230);
            this.lblFechaIgreso.Name = "lblFechaIgreso";
            this.lblFechaIgreso.Size = new System.Drawing.Size(90, 13);
            this.lblFechaIgreso.TabIndex = 18;
            this.lblFechaIgreso.Text = "Fecha de Ingreso";
            // 
            // lblAsegurado
            // 
            this.lblAsegurado.AutoSize = true;
            this.lblAsegurado.Location = new System.Drawing.Point(241, 111);
            this.lblAsegurado.Name = "lblAsegurado";
            this.lblAsegurado.Size = new System.Drawing.Size(58, 13);
            this.lblAsegurado.TabIndex = 19;
            this.lblAsegurado.Text = "Asegurado";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(271, 187);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 21;
            this.lblTipo.Text = "Tipo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Fotografia",
            "Sonido",
            "Informatica",
            "Otros"});
            this.cbxTipo.Location = new System.Drawing.Point(305, 179);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxTipo.TabIndex = 14;
            this.cbxTipo.Text = "Fotografia";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(305, 145);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // cbxMoneda
            // 
            this.cbxMoneda.FormattingEnabled = true;
            this.cbxMoneda.Location = new System.Drawing.Point(411, 145);
            this.cbxMoneda.Name = "cbxMoneda";
            this.cbxMoneda.Size = new System.Drawing.Size(38, 21);
            this.cbxMoneda.TabIndex = 13;
            this.cbxMoneda.Text = "$";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(262, 153);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 20;
            this.lblPrecio.Text = "Precio";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(305, 223);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(100, 20);
            this.txtObservaciones.TabIndex = 9;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(227, 230);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(72, 13);
            this.lblObservaciones.TabIndex = 22;
            this.lblObservaciones.Text = "Observacioes";
            // 
            // txtAsegurado
            // 
            this.txtAsegurado.Location = new System.Drawing.Point(305, 104);
            this.txtAsegurado.Name = "txtAsegurado";
            this.txtAsegurado.Size = new System.Drawing.Size(100, 20);
            this.txtAsegurado.TabIndex = 6;
            this.txtAsegurado.TextChanged += new System.EventHandler(this.txtAsegurado_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(100, 180);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // frmAltaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblAsegurado);
            this.Controls.Add(this.lblFechaIgreso);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxMoneda);
            this.Controls.Add(this.mtxtFechaIngreso);
            this.Controls.Add(this.btnAgregarEquipo);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtAsegurado);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.txtNombre);
            this.MinimumSize = new System.Drawing.Size(510, 39);
            this.Name = "frmAltaEquipo";
            this.Text = "frmAgregarEquipo";
            this.Load += new System.EventHandler(this.frmAgregarEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.MaskedTextBox mtxtFechaIngreso;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaIgreso;
        private System.Windows.Forms.Label lblAsegurado;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbxMoneda;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtAsegurado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNombre;
    }
}