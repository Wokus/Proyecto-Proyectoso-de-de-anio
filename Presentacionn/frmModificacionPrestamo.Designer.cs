﻿namespace Presentacionn
{
    partial class frmModificacionPrestamo
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
            this.btnModificarPrestamo = new System.Windows.Forms.Button();
            this.cbxModificacionPrestamo = new System.Windows.Forms.ComboBox();
            this.lblIDSalon = new System.Windows.Forms.Label();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.lblLocacion = new System.Windows.Forms.Label();
            this.txtLocacion = new System.Windows.Forms.TextBox();
            this.lblEquipoID = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.mtxtFechaDevolucion = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFechaRetiro = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFechaSolicitud = new System.Windows.Forms.MaskedTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaDev = new System.Windows.Forms.Label();
            this.lblFechaIgreso = new System.Windows.Forms.Label();
            this.lblFechaRe = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblFechaSoli = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.mtxtHoraRetiro = new System.Windows.Forms.MaskedTextBox();
            this.lblIdPrestamo = new System.Windows.Forms.Label();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.mtxtIDSalon = new System.Windows.Forms.MaskedTextBox();
            this.mtxtProfesor = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEquipoID = new System.Windows.Forms.MaskedTextBox();
            this.mtxtAlumno = new System.Windows.Forms.MaskedTextBox();
            this.mtxtIdPrestamo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnModificarPrestamo
            // 
            this.btnModificarPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarPrestamo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificarPrestamo.Location = new System.Drawing.Point(170, 423);
            this.btnModificarPrestamo.Name = "btnModificarPrestamo";
            this.btnModificarPrestamo.Size = new System.Drawing.Size(144, 55);
            this.btnModificarPrestamo.TabIndex = 8;
            this.btnModificarPrestamo.Text = "Modificar";
            this.btnModificarPrestamo.UseVisualStyleBackColor = false;
            this.btnModificarPrestamo.Click += new System.EventHandler(this.btnModificarPrestamo_Click);
            // 
            // cbxModificacionPrestamo
            // 
            this.cbxModificacionPrestamo.FormattingEnabled = true;
            this.cbxModificacionPrestamo.Items.AddRange(new object[] {
            "Prestamo de Equipo",
            "Prestamo de Espacio",
            "Prestamo Espontaneo"});
            this.cbxModificacionPrestamo.Location = new System.Drawing.Point(361, 28);
            this.cbxModificacionPrestamo.Name = "cbxModificacionPrestamo";
            this.cbxModificacionPrestamo.Size = new System.Drawing.Size(121, 21);
            this.cbxModificacionPrestamo.TabIndex = 9;
            this.cbxModificacionPrestamo.Text = "Prestamo a Modificar";
            this.cbxModificacionPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbxModificacionPrestamo_SelectedIndexChanged);
            // 
            // lblIDSalon
            // 
            this.lblIDSalon.AutoSize = true;
            this.lblIDSalon.Location = new System.Drawing.Point(382, 163);
            this.lblIDSalon.Name = "lblIDSalon";
            this.lblIDSalon.Size = new System.Drawing.Size(48, 13);
            this.lblIDSalon.TabIndex = 100;
            this.lblIDSalon.Text = "ID Salon";
            this.lblIDSalon.Visible = false;
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.AutoSize = true;
            this.lblEjercicio.Location = new System.Drawing.Point(379, 228);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(47, 13);
            this.lblEjercicio.TabIndex = 96;
            this.lblEjercicio.Text = "Ejercicio";
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.Location = new System.Drawing.Point(382, 244);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(100, 20);
            this.txtEjercicio.TabIndex = 95;
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(382, 179);
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(100, 20);
            this.txtTransporte.TabIndex = 93;
            // 
            // lblLocacion
            // 
            this.lblLocacion.AutoSize = true;
            this.lblLocacion.Location = new System.Drawing.Point(379, 102);
            this.lblLocacion.Name = "lblLocacion";
            this.lblLocacion.Size = new System.Drawing.Size(51, 13);
            this.lblLocacion.TabIndex = 92;
            this.lblLocacion.Text = "Locacion";
            // 
            // txtLocacion
            // 
            this.txtLocacion.Location = new System.Drawing.Point(382, 118);
            this.txtLocacion.Name = "txtLocacion";
            this.txtLocacion.Size = new System.Drawing.Size(100, 20);
            this.txtLocacion.TabIndex = 91;
            // 
            // lblEquipoID
            // 
            this.lblEquipoID.AutoSize = true;
            this.lblEquipoID.Location = new System.Drawing.Point(264, 228);
            this.lblEquipoID.Name = "lblEquipoID";
            this.lblEquipoID.Size = new System.Drawing.Size(57, 13);
            this.lblEquipoID.TabIndex = 90;
            this.lblEquipoID.Text = "Equipo(ID)";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(262, 162);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(106, 13);
            this.lblProfesor.TabIndex = 88;
            this.lblProfesor.Text = "Profesor responsable";
            // 
            // mtxtFechaDevolucion
            // 
            this.mtxtFechaDevolucion.Location = new System.Drawing.Point(29, 244);
            this.mtxtFechaDevolucion.Mask = "00/00/0000";
            this.mtxtFechaDevolucion.Name = "mtxtFechaDevolucion";
            this.mtxtFechaDevolucion.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaDevolucion.TabIndex = 86;
            this.mtxtFechaDevolucion.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtFechaRetiro
            // 
            this.mtxtFechaRetiro.Location = new System.Drawing.Point(29, 179);
            this.mtxtFechaRetiro.Mask = "00/00/0000";
            this.mtxtFechaRetiro.Name = "mtxtFechaRetiro";
            this.mtxtFechaRetiro.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaRetiro.TabIndex = 85;
            this.mtxtFechaRetiro.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtFechaSolicitud
            // 
            this.mtxtFechaSolicitud.Location = new System.Drawing.Point(29, 119);
            this.mtxtFechaSolicitud.Mask = "00/00/0000";
            this.mtxtFechaSolicitud.Name = "mtxtFechaSolicitud";
            this.mtxtFechaSolicitud.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaSolicitud.TabIndex = 84;
            this.mtxtFechaSolicitud.ValidatingType = typeof(System.DateTime);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(26, 289);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 83;
            this.lblEstado.Text = "Estado";
            // 
            // lblFechaDev
            // 
            this.lblFechaDev.AutoSize = true;
            this.lblFechaDev.Location = new System.Drawing.Point(26, 228);
            this.lblFechaDev.Name = "lblFechaDev";
            this.lblFechaDev.Size = new System.Drawing.Size(107, 13);
            this.lblFechaDev.TabIndex = 82;
            this.lblFechaDev.Text = "Fecha de devolucion";
            // 
            // lblFechaIgreso
            // 
            this.lblFechaIgreso.AutoSize = true;
            this.lblFechaIgreso.Location = new System.Drawing.Point(132, 163);
            this.lblFechaIgreso.Name = "lblFechaIgreso";
            this.lblFechaIgreso.Size = new System.Drawing.Size(71, 13);
            this.lblFechaIgreso.TabIndex = 81;
            this.lblFechaIgreso.Text = "Hora de retiro";
            // 
            // lblFechaRe
            // 
            this.lblFechaRe.AutoSize = true;
            this.lblFechaRe.Location = new System.Drawing.Point(26, 163);
            this.lblFechaRe.Name = "lblFechaRe";
            this.lblFechaRe.Size = new System.Drawing.Size(78, 13);
            this.lblFechaRe.TabIndex = 80;
            this.lblFechaRe.Text = "Fecha de retiro";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(262, 102);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(107, 13);
            this.lblResponsable.TabIndex = 79;
            this.lblResponsable.Text = "Alumno Responsable";
            // 
            // lblFechaSoli
            // 
            this.lblFechaSoli.AutoSize = true;
            this.lblFechaSoli.Location = new System.Drawing.Point(26, 103);
            this.lblFechaSoli.Name = "lblFechaSoli";
            this.lblFechaSoli.Size = new System.Drawing.Size(93, 13);
            this.lblFechaSoli.TabIndex = 78;
            this.lblFechaSoli.Text = "Fecha de solicitud";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Armado",
            "Levantado",
            "Devuelto",
            "Cancelado"});
            this.cbxEstado.Location = new System.Drawing.Point(29, 305);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(100, 21);
            this.cbxEstado.TabIndex = 77;
            this.cbxEstado.Text = "Armado";
            // 
            // mtxtHoraRetiro
            // 
            this.mtxtHoraRetiro.Location = new System.Drawing.Point(135, 179);
            this.mtxtHoraRetiro.Mask = "00:00";
            this.mtxtHoraRetiro.Name = "mtxtHoraRetiro";
            this.mtxtHoraRetiro.Size = new System.Drawing.Size(100, 20);
            this.mtxtHoraRetiro.TabIndex = 76;
            this.mtxtHoraRetiro.ValidatingType = typeof(System.DateTime);
            // 
            // lblIdPrestamo
            // 
            this.lblIdPrestamo.AutoSize = true;
            this.lblIdPrestamo.Location = new System.Drawing.Point(26, 43);
            this.lblIdPrestamo.Name = "lblIdPrestamo";
            this.lblIdPrestamo.Size = new System.Drawing.Size(63, 13);
            this.lblIdPrestamo.TabIndex = 102;
            this.lblIdPrestamo.Text = "Id Prestamo";
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Location = new System.Drawing.Point(379, 163);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(58, 13);
            this.lblTransporte.TabIndex = 103;
            this.lblTransporte.Text = "Transporte";
            this.lblTransporte.Visible = false;
            // 
            // mtxtIDSalon
            // 
            this.mtxtIDSalon.HidePromptOnLeave = true;
            this.mtxtIDSalon.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtIDSalon.Location = new System.Drawing.Point(382, 179);
            this.mtxtIDSalon.Mask = "999999999999999999999999999999999999999";
            this.mtxtIDSalon.Name = "mtxtIDSalon";
            this.mtxtIDSalon.Size = new System.Drawing.Size(100, 20);
            this.mtxtIDSalon.TabIndex = 104;
            // 
            // mtxtProfesor
            // 
            this.mtxtProfesor.Location = new System.Drawing.Point(265, 179);
            this.mtxtProfesor.Mask = "9.999.999-9";
            this.mtxtProfesor.Name = "mtxtProfesor";
            this.mtxtProfesor.Size = new System.Drawing.Size(100, 20);
            this.mtxtProfesor.TabIndex = 105;
            // 
            // mtxtEquipoID
            // 
            this.mtxtEquipoID.HidePromptOnLeave = true;
            this.mtxtEquipoID.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtEquipoID.Location = new System.Drawing.Point(265, 244);
            this.mtxtEquipoID.Mask = "999999999999999999999999999999999999999";
            this.mtxtEquipoID.Name = "mtxtEquipoID";
            this.mtxtEquipoID.Size = new System.Drawing.Size(100, 20);
            this.mtxtEquipoID.TabIndex = 106;
            // 
            // mtxtAlumno
            // 
            this.mtxtAlumno.Location = new System.Drawing.Point(265, 119);
            this.mtxtAlumno.Mask = "9.999.999-9";
            this.mtxtAlumno.Name = "mtxtAlumno";
            this.mtxtAlumno.Size = new System.Drawing.Size(100, 20);
            this.mtxtAlumno.TabIndex = 107;
            // 
            // mtxtIdPrestamo
            // 
            this.mtxtIdPrestamo.HidePromptOnLeave = true;
            this.mtxtIdPrestamo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtIdPrestamo.Location = new System.Drawing.Point(29, 59);
            this.mtxtIdPrestamo.Mask = "999999999999999999999999999999999999999";
            this.mtxtIdPrestamo.Name = "mtxtIdPrestamo";
            this.mtxtIdPrestamo.Size = new System.Drawing.Size(100, 20);
            this.mtxtIdPrestamo.TabIndex = 108;
            // 
            // frmModificacionPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.mtxtIdPrestamo);
            this.Controls.Add(this.mtxtAlumno);
            this.Controls.Add(this.mtxtEquipoID);
            this.Controls.Add(this.mtxtProfesor);
            this.Controls.Add(this.mtxtIDSalon);
            this.Controls.Add(this.lblTransporte);
            this.Controls.Add(this.lblIdPrestamo);
            this.Controls.Add(this.lblIDSalon);
            this.Controls.Add(this.lblEjercicio);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.txtTransporte);
            this.Controls.Add(this.lblLocacion);
            this.Controls.Add(this.txtLocacion);
            this.Controls.Add(this.lblEquipoID);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.mtxtFechaDevolucion);
            this.Controls.Add(this.mtxtFechaRetiro);
            this.Controls.Add(this.mtxtFechaSolicitud);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaDev);
            this.Controls.Add(this.lblFechaIgreso);
            this.Controls.Add(this.lblFechaRe);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblFechaSoli);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.mtxtHoraRetiro);
            this.Controls.Add(this.cbxModificacionPrestamo);
            this.Controls.Add(this.btnModificarPrestamo);
            this.Name = "frmModificacionPrestamo";
            this.Text = "frmModificacionPrestamo";
            this.Load += new System.EventHandler(this.frmModificacionPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarPrestamo;
        private System.Windows.Forms.ComboBox cbxModificacionPrestamo;
        private System.Windows.Forms.Label lblIDSalon;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.TextBox txtEjercicio;
        private System.Windows.Forms.TextBox txtTransporte;
        private System.Windows.Forms.Label lblLocacion;
        private System.Windows.Forms.TextBox txtLocacion;
        private System.Windows.Forms.Label lblEquipoID;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.MaskedTextBox mtxtFechaDevolucion;
        private System.Windows.Forms.MaskedTextBox mtxtFechaRetiro;
        private System.Windows.Forms.MaskedTextBox mtxtFechaSolicitud;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaDev;
        private System.Windows.Forms.Label lblFechaIgreso;
        private System.Windows.Forms.Label lblFechaRe;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblFechaSoli;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.MaskedTextBox mtxtHoraRetiro;
        private System.Windows.Forms.Label lblIdPrestamo;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.MaskedTextBox mtxtIDSalon;
        private System.Windows.Forms.MaskedTextBox mtxtProfesor;
        private System.Windows.Forms.MaskedTextBox mtxtEquipoID;
        private System.Windows.Forms.MaskedTextBox mtxtAlumno;
        private System.Windows.Forms.MaskedTextBox mtxtIdPrestamo;
    }
}