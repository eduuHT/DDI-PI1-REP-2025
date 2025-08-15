namespace UTApp.Forms.Asignaciones
{
    partial class EditarAsignacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarAsignacion));
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblAsignaciones = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.DTEntrega = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.CBPlataforma = new System.Windows.Forms.ComboBox();
            this.CBDocente = new System.Windows.Forms.ComboBox();
            this.CBMateria = new System.Windows.Forms.ComboBox();
            this.CBGrupo = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlBanner.Controls.Add(this.btnBack);
            this.pnlBanner.Controls.Add(this.lblAsignaciones);
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(356, 90);
            this.pnlBanner.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::UTApp.Properties.Resources.left_chevron;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 58);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAsignaciones
            // 
            this.lblAsignaciones.AutoSize = true;
            this.lblAsignaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignaciones.ForeColor = System.Drawing.Color.White;
            this.lblAsignaciones.Location = new System.Drawing.Point(105, 24);
            this.lblAsignaciones.Name = "lblAsignaciones";
            this.lblAsignaciones.Size = new System.Drawing.Size(134, 37);
            this.lblAsignaciones.TabIndex = 0;
            this.lblAsignaciones.Text = "Modificar";
            this.lblAsignaciones.Click += new System.EventHandler(this.lblAsignaciones_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(84, 527);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(181, 61);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Editar Asignacion";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // DTEntrega
            // 
            this.DTEntrega.CustomFormat = "";
            this.DTEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTEntrega.Location = new System.Drawing.Point(122, 256);
            this.DTEntrega.MinDate = new System.DateTime(2025, 8, 13, 0, 0, 0, 0);
            this.DTEntrega.Name = "DTEntrega";
            this.DTEntrega.Size = new System.Drawing.Size(210, 20);
            this.DTEntrega.TabIndex = 35;
            this.DTEntrega.Value = new System.DateTime(2025, 8, 14, 16, 35, 36, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Plataforma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Materia:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(5, 297);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(327, 211);
            this.txtDescripcion.TabIndex = 32;
            // 
            // CBPlataforma
            // 
            this.CBPlataforma.FormattingEnabled = true;
            this.CBPlataforma.Location = new System.Drawing.Point(71, 225);
            this.CBPlataforma.Name = "CBPlataforma";
            this.CBPlataforma.Size = new System.Drawing.Size(261, 21);
            this.CBPlataforma.TabIndex = 31;
            // 
            // CBDocente
            // 
            this.CBDocente.FormattingEnabled = true;
            this.CBDocente.Location = new System.Drawing.Point(59, 187);
            this.CBDocente.Name = "CBDocente";
            this.CBDocente.Size = new System.Drawing.Size(273, 21);
            this.CBDocente.TabIndex = 30;
            // 
            // CBMateria
            // 
            this.CBMateria.FormattingEnabled = true;
            this.CBMateria.Location = new System.Drawing.Point(211, 149);
            this.CBMateria.Name = "CBMateria";
            this.CBMateria.Size = new System.Drawing.Size(121, 21);
            this.CBMateria.TabIndex = 29;
            // 
            // CBGrupo
            // 
            this.CBGrupo.FormattingEnabled = true;
            this.CBGrupo.Location = new System.Drawing.Point(59, 149);
            this.CBGrupo.Name = "CBGrupo";
            this.CBGrupo.Size = new System.Drawing.Size(95, 21);
            this.CBGrupo.TabIndex = 28;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(59, 111);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(273, 20);
            this.txtTitulo.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Grupo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fecha de entrega:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Docente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Titulo:";
            // 
            // EditarAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.DTEntrega);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.CBPlataforma);
            this.Controls.Add(this.CBDocente);
            this.Controls.Add(this.CBMateria);
            this.Controls.Add(this.CBGrupo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarAsignacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarAsignacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarAsignacion_FormClosed);
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblAsignaciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker DTEntrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox CBPlataforma;
        private System.Windows.Forms.ComboBox CBDocente;
        private System.Windows.Forms.ComboBox CBMateria;
        private System.Windows.Forms.ComboBox CBGrupo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}