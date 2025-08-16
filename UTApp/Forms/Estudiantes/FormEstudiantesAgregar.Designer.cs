namespace UTApp.Forms.Estudiantes
{
    partial class FormEstudiantesAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudiantesAgregar));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.botonOpciones = new System.Windows.Forms.PictureBox();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.labelCatálogoMaterias = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstudianteGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstudianteNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtEstudianteMatricula = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstudianteCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstudiantePass = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHeader.Controls.Add(this.botonOpciones);
            this.panelHeader.Controls.Add(this.pbRegresar);
            this.panelHeader.Controls.Add(this.labelMaterias);
            this.panelHeader.Location = new System.Drawing.Point(1, -2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(343, 94);
            this.panelHeader.TabIndex = 14;
            // 
            // botonOpciones
            // 
            this.botonOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonOpciones.Location = new System.Drawing.Point(293, 46);
            this.botonOpciones.Name = "botonOpciones";
            this.botonOpciones.Size = new System.Drawing.Size(23, 24);
            this.botonOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonOpciones.TabIndex = 2;
            this.botonOpciones.TabStop = false;
            // 
            // pbRegresar
            // 
            this.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRegresar.Image = global::UTApp.Properties.Resources.left_chevron;
            this.pbRegresar.Location = new System.Drawing.Point(25, 30);
            this.pbRegresar.Name = "pbRegresar";
            this.pbRegresar.Size = new System.Drawing.Size(25, 40);
            this.pbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegresar.TabIndex = 1;
            this.pbRegresar.TabStop = false;
            // 
            // labelMaterias
            // 
            this.labelMaterias.AutoSize = true;
            this.labelMaterias.BackColor = System.Drawing.Color.Transparent;
            this.labelMaterias.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterias.ForeColor = System.Drawing.Color.White;
            this.labelMaterias.Location = new System.Drawing.Point(110, 45);
            this.labelMaterias.Name = "labelMaterias";
            this.labelMaterias.Size = new System.Drawing.Size(134, 25);
            this.labelMaterias.TabIndex = 0;
            this.labelMaterias.Text = "Estudiantes";
            // 
            // labelCatálogoMaterias
            // 
            this.labelCatálogoMaterias.AutoSize = true;
            this.labelCatálogoMaterias.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatálogoMaterias.ForeColor = System.Drawing.Color.Black;
            this.labelCatálogoMaterias.Location = new System.Drawing.Point(20, 120);
            this.labelCatálogoMaterias.Name = "labelCatálogoMaterias";
            this.labelCatálogoMaterias.Size = new System.Drawing.Size(95, 23);
            this.labelCatálogoMaterias.TabIndex = 15;
            this.labelCatálogoMaterias.Text = "Agregar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Grupo";
            // 
            // txtEstudianteGrupo
            // 
            this.txtEstudianteGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudianteGrupo.Location = new System.Drawing.Point(192, 182);
            this.txtEstudianteGrupo.Name = "txtEstudianteGrupo";
            this.txtEstudianteGrupo.Size = new System.Drawing.Size(93, 20);
            this.txtEstudianteGrupo.TabIndex = 83;
            this.txtEstudianteGrupo.Leave += new System.EventHandler(this.txtEstudianteGrupo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 82;
            this.label4.Text = "Nombre";
            // 
            // txtEstudianteNombre
            // 
            this.txtEstudianteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudianteNombre.Location = new System.Drawing.Point(60, 239);
            this.txtEstudianteNombre.Name = "txtEstudianteNombre";
            this.txtEstudianteNombre.Size = new System.Drawing.Size(225, 20);
            this.txtEstudianteNombre.TabIndex = 81;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(60, 203);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(61, 16);
            this.Nombre.TabIndex = 78;
            this.Nombre.Text = "Matricula";
            // 
            // txtEstudianteMatricula
            // 
            this.txtEstudianteMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudianteMatricula.Location = new System.Drawing.Point(60, 182);
            this.txtEstudianteMatricula.Name = "txtEstudianteMatricula";
            this.txtEstudianteMatricula.Size = new System.Drawing.Size(98, 20);
            this.txtEstudianteMatricula.TabIndex = 77;
            this.txtEstudianteMatricula.Leave += new System.EventHandler(this.txtEstudianteMatricula_Leave);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(60, 450);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(225, 50);
            this.btnGuardar.TabIndex = 76;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 88;
            this.label1.Text = "Correo";
            // 
            // txtEstudianteCorreo
            // 
            this.txtEstudianteCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudianteCorreo.Location = new System.Drawing.Point(60, 295);
            this.txtEstudianteCorreo.Name = "txtEstudianteCorreo";
            this.txtEstudianteCorreo.Size = new System.Drawing.Size(225, 20);
            this.txtEstudianteCorreo.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Contraseña";
            // 
            // txtEstudiantePass
            // 
            this.txtEstudiantePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudiantePass.Location = new System.Drawing.Point(63, 355);
            this.txtEstudiantePass.Name = "txtEstudiantePass";
            this.txtEstudiantePass.PasswordChar = '•';
            this.txtEstudiantePass.Size = new System.Drawing.Size(225, 20);
            this.txtEstudiantePass.TabIndex = 85;
            // 
            // FormEstudiantesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstudianteCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstudiantePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstudianteGrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstudianteNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtEstudianteMatricula);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelCatálogoMaterias);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstudiantesAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar estudiante";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEstudiantesAgregar_FormClosed);
            this.Load += new System.EventHandler(this.FormEstudiantesAgregar_Load);
            this.Click += new System.EventHandler(this.FormEstudiantesAgregar_Click);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox botonOpciones;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.Label labelMaterias;
        private System.Windows.Forms.Label labelCatálogoMaterias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstudianteGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstudianteNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtEstudianteMatricula;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstudianteCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstudiantePass;
    }
}