namespace PrimesosPasos
{
    partial class ventanaEmergente
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPersona = new System.Windows.Forms.Label();
            this.ckbPrimeraVez = new System.Windows.Forms.CheckBox();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.gpxOpciones = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDescripcionadd = new System.Windows.Forms.Label();
            this.txtPreferencias = new System.Windows.Forms.TextBox();
            this.lblDiasLibres = new System.Windows.Forms.Label();
            this.cbxDiasLibres = new System.Windows.Forms.ComboBox();
            this.lblCantidadHoras = new System.Windows.Forms.Label();
            this.cantHoras = new System.Windows.Forms.NumericUpDown();
            this.bntPerfil = new System.Windows.Forms.Button();
            this.Martes = new System.Windows.Forms.CheckBox();
            this.gpxOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(252, 64);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(305, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.Location = new System.Drawing.Point(16, 11);
            this.lblPersona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(420, 41);
            this.lblPersona.TabIndex = 3;
            this.lblPersona.Text = "Sos nuevo/a? Completa los datos!";
            // 
            // ckbPrimeraVez
            // 
            this.ckbPrimeraVez.AutoSize = true;
            this.ckbPrimeraVez.Location = new System.Drawing.Point(61, 193);
            this.ckbPrimeraVez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbPrimeraVez.Name = "ckbPrimeraVez";
            this.ckbPrimeraVez.Size = new System.Drawing.Size(107, 20);
            this.ckbPrimeraVez.TabIndex = 3;
            this.ckbPrimeraVez.Text = "Primera vez?";
            this.ckbPrimeraVez.UseVisualStyleBackColor = true;
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(12, 23);
            this.rbt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(98, 20);
            this.rbt1.TabIndex = 1;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Principiante";
            this.rbt1.UseVisualStyleBackColor = true;
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Location = new System.Drawing.Point(412, 23);
            this.rbt3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(86, 20);
            this.rbt3.TabIndex = 2;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "Experto/a";
            this.rbt3.UseVisualStyleBackColor = true;
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Location = new System.Drawing.Point(193, 21);
            this.rbt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(101, 20);
            this.rbt2.TabIndex = 2;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "Avanzado/a";
            this.rbt2.UseVisualStyleBackColor = true;
            // 
            // gpxOpciones
            // 
            this.gpxOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxOpciones.Controls.Add(this.rbt1);
            this.gpxOpciones.Controls.Add(this.rbt3);
            this.gpxOpciones.Controls.Add(this.rbt2);
            this.gpxOpciones.Location = new System.Drawing.Point(137, 244);
            this.gpxOpciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpxOpciones.Name = "gpxOpciones";
            this.gpxOpciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpxOpciones.Size = new System.Drawing.Size(628, 68);
            this.gpxOpciones.TabIndex = 4;
            this.gpxOpciones.TabStop = false;
            this.gpxOpciones.Text = "Opciones";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 64);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(180, 16);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre y Apellido Completo";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(57, 142);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(138, 16);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNac.Location = new System.Drawing.Point(236, 142);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(259, 22);
            this.dtpFechaNac.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(116, 110);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(47, 16);
            this.lblDni.TabIndex = 13;
            this.lblDni.Text = "DNI N°";
            // 
            // txtDni
            // 
            this.txtDni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDni.Location = new System.Drawing.Point(252, 101);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(305, 22);
            this.txtDni.TabIndex = 1;
            // 
            // lblDescripcionadd
            // 
            this.lblDescripcionadd.AutoSize = true;
            this.lblDescripcionadd.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionadd.Location = new System.Drawing.Point(55, 489);
            this.lblDescripcionadd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionadd.Name = "lblDescripcionadd";
            this.lblDescripcionadd.Size = new System.Drawing.Size(328, 38);
            this.lblDescripcionadd.TabIndex = 9;
            this.lblDescripcionadd.Text = "Preferencias adicionales";
            // 
            // txtPreferencias
            // 
            this.txtPreferencias.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreferencias.Location = new System.Drawing.Point(24, 529);
            this.txtPreferencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreferencias.Name = "txtPreferencias";
            this.txtPreferencias.Size = new System.Drawing.Size(352, 31);
            this.txtPreferencias.TabIndex = 7;
            // 
            // lblDiasLibres
            // 
            this.lblDiasLibres.AutoSize = true;
            this.lblDiasLibres.Location = new System.Drawing.Point(44, 330);
            this.lblDiasLibres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasLibres.Name = "lblDiasLibres";
            this.lblDiasLibres.Size = new System.Drawing.Size(78, 16);
            this.lblDiasLibres.TabIndex = 5;
            this.lblDiasLibres.Text = "Días  Libres";
            // 
            // cbxDiasLibres
            // 
            this.cbxDiasLibres.AllowDrop = true;
            this.cbxDiasLibres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDiasLibres.FormattingEnabled = true;
            this.cbxDiasLibres.Location = new System.Drawing.Point(252, 411);
            this.cbxDiasLibres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDiasLibres.Name = "cbxDiasLibres";
            this.cbxDiasLibres.Size = new System.Drawing.Size(160, 24);
            this.cbxDiasLibres.TabIndex = 5;
            // 
            // lblCantidadHoras
            // 
            this.lblCantidadHoras.AutoSize = true;
            this.lblCantidadHoras.Location = new System.Drawing.Point(44, 415);
            this.lblCantidadHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadHoras.Name = "lblCantidadHoras";
            this.lblCantidadHoras.Size = new System.Drawing.Size(162, 16);
            this.lblCantidadHoras.TabIndex = 7;
            this.lblCantidadHoras.Text = "Seleccionar rango horario";
            // 
            // cantHoras
            // 
            this.cantHoras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cantHoras.Location = new System.Drawing.Point(149, 330);
            this.cantHoras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantHoras.Name = "cantHoras";
            this.cantHoras.Size = new System.Drawing.Size(160, 22);
            this.cantHoras.TabIndex = 6;
            // 
            // bntPerfil
            // 
            this.bntPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntPerfil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bntPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bntPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.bntPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntPerfil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntPerfil.Location = new System.Drawing.Point(591, 508);
            this.bntPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntPerfil.Name = "bntPerfil";
            this.bntPerfil.Size = new System.Drawing.Size(263, 54);
            this.bntPerfil.TabIndex = 8;
            this.bntPerfil.Text = "Imprimir por Pantalla Perfil Completo";
            this.bntPerfil.UseVisualStyleBackColor = false;
            this.bntPerfil.Click += new System.EventHandler(this.bntPerfil_Click);
            // 
            // Martes
            // 
            this.Martes.AutoSize = true;
            this.Martes.Location = new System.Drawing.Point(631, 341);
            this.Martes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Martes.Name = "Martes";
            this.Martes.Size = new System.Drawing.Size(70, 20);
            this.Martes.TabIndex = 15;
            this.Martes.Text = "Martes";
            this.Martes.UseVisualStyleBackColor = true;
            // 
            // ventanaEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 613);
            this.Controls.Add(this.Martes);
            this.Controls.Add(this.bntPerfil);
            this.Controls.Add(this.cantHoras);
            this.Controls.Add(this.lblCantidadHoras);
            this.Controls.Add(this.cbxDiasLibres);
            this.Controls.Add(this.lblDiasLibres);
            this.Controls.Add(this.txtPreferencias);
            this.Controls.Add(this.lblDescripcionadd);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gpxOpciones);
            this.Controls.Add(this.ckbPrimeraVez);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1082, 650);
            this.Name = "ventanaEmergente";
            this.Text = "ventaEmergente";
            this.Load += new System.EventHandler(this.ControlesVarios_OperadorTernario_Load);
            this.gpxOpciones.ResumeLayout(false);
            this.gpxOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.CheckBox ckbPrimeraVez;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.GroupBox gpxOpciones;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDescripcionadd;
        private System.Windows.Forms.TextBox txtPreferencias;
        private System.Windows.Forms.Label lblDiasLibres;
        private System.Windows.Forms.ComboBox cbxDiasLibres;
        private System.Windows.Forms.Label lblCantidadHoras;
        private System.Windows.Forms.NumericUpDown cantHoras;
        private System.Windows.Forms.Button bntPerfil;
        private System.Windows.Forms.CheckBox Martes;
    }
}