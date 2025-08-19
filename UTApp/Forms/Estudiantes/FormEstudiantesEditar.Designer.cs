namespace UTApp.Forms.Estudiantes
{
    partial class FormEstudiantesEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudiantesEditar));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.botonOpciones = new System.Windows.Forms.PictureBox();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.labelCatálogoMaterias = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstudianteNombre = new System.Windows.Forms.TextBox();
            this.labelIIngresarValores = new System.Windows.Forms.Label();
            this.txtEstudianteMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstudianteCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstudiantePass = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
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
            this.botonOpciones.Image = global::UTApp.Properties.Resources.dots;
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
            this.pbRegresar.Click += new System.EventHandler(this.pbRegresar_Click);
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
            this.labelCatálogoMaterias.Size = new System.Drawing.Size(74, 23);
            this.labelCatálogoMaterias.TabIndex = 15;
            this.labelCatálogoMaterias.Text = "Editar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "Grupo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 98;
            this.label4.Text = "Nombre:";
            // 
            // txtEstudianteNombre
            // 
            this.txtEstudianteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudianteNombre.Location = new System.Drawing.Point(126, 320);
            this.txtEstudianteNombre.Name = "txtEstudianteNombre";
            this.txtEstudianteNombre.Size = new System.Drawing.Size(190, 20);
            this.txtEstudianteNombre.TabIndex = 97;
            // 
            // labelIIngresarValores
            // 
            this.labelIIngresarValores.AutoSize = true;
            this.labelIIngresarValores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIIngresarValores.Location = new System.Drawing.Point(25, 225);
            this.labelIIngresarValores.Name = "labelIIngresarValores";
            this.labelIIngresarValores.Size = new System.Drawing.Size(251, 16);
            this.labelIIngresarValores.TabIndex = 94;
            this.labelIIngresarValores.Text = " Nuevos datos para el estudiante:\r\n";
            // 
            // txtEstudianteMatricula
            // 
            this.txtEstudianteMatricula.Location = new System.Drawing.Point(126, 174);
            this.txtEstudianteMatricula.Name = "txtEstudianteMatricula";
            this.txtEstudianteMatricula.Size = new System.Drawing.Size(90, 20);
            this.txtEstudianteMatricula.TabIndex = 93;
            this.txtEstudianteMatricula.TextChanged += new System.EventHandler(this.txtEstudianteMatricula_TextChanged);
            this.txtEstudianteMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstudianteMatricula_KeyPress);
            this.txtEstudianteMatricula.Leave += new System.EventHandler(this.txtEstudianteMatricula_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 92;
            this.label1.Text = "Matrícula :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(60, 510);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(225, 50);
            this.btnGuardar.TabIndex = 101;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "Correo:";
            // 
            // txtEstudianteCorreo
            // 
            this.txtEstudianteCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudianteCorreo.Location = new System.Drawing.Point(126, 360);
            this.txtEstudianteCorreo.Name = "txtEstudianteCorreo";
            this.txtEstudianteCorreo.Size = new System.Drawing.Size(190, 20);
            this.txtEstudianteCorreo.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 103;
            this.label5.Text = "Contraseña:";
            // 
            // txtEstudiantePass
            // 
            this.txtEstudiantePass.Enabled = false;
            this.txtEstudiantePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudiantePass.Location = new System.Drawing.Point(126, 401);
            this.txtEstudiantePass.Name = "txtEstudiantePass";
            this.txtEstudiantePass.PasswordChar = '•';
            this.txtEstudiantePass.Size = new System.Drawing.Size(190, 20);
            this.txtEstudiantePass.TabIndex = 102;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(222, 172);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 25);
            this.btnBuscar.TabIndex = 106;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbGrupo
            // 
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(126, 279);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(95, 21);
            this.cbGrupo.TabIndex = 107;
            // 
            // FormEstudiantesEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstudianteCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstudiantePass);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstudianteNombre);
            this.Controls.Add(this.labelIIngresarValores);
            this.Controls.Add(this.txtEstudianteMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCatálogoMaterias);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstudiantesEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar estudiante";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEstudiantesEditar_FormClosed);
            this.Load += new System.EventHandler(this.FormEstudiantesEditar_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstudianteNombre;
        private System.Windows.Forms.Label labelIIngresarValores;
        private System.Windows.Forms.TextBox txtEstudianteMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstudianteCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstudiantePass;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbGrupo;
    }
}