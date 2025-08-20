namespace UTApp.Forms.Docentes
{
    partial class FormDocentesEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocentesEditar));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.labelCatálogoMaterias = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocenteCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocenteNombre = new System.Windows.Forms.TextBox();
            this.labelIIngresarValores = new System.Windows.Forms.Label();
            this.txtDocenteEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocentePass = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocenteTitulo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHeader.Controls.Add(this.pbRegresar);
            this.panelHeader.Controls.Add(this.labelMaterias);
            this.panelHeader.Location = new System.Drawing.Point(1, -2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(343, 94);
            this.panelHeader.TabIndex = 21;
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
            this.labelMaterias.Location = new System.Drawing.Point(119, 45);
            this.labelMaterias.Name = "labelMaterias";
            this.labelMaterias.Size = new System.Drawing.Size(110, 25);
            this.labelMaterias.TabIndex = 0;
            this.labelMaterias.Text = "Docentes";
            // 
            // labelCatálogoMaterias
            // 
            this.labelCatálogoMaterias.AutoSize = true;
            this.labelCatálogoMaterias.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatálogoMaterias.ForeColor = System.Drawing.Color.Black;
            this.labelCatálogoMaterias.Location = new System.Drawing.Point(20, 120);
            this.labelCatálogoMaterias.Name = "labelCatálogoMaterias";
            this.labelCatálogoMaterias.Size = new System.Drawing.Size(74, 23);
            this.labelCatálogoMaterias.TabIndex = 16;
            this.labelCatálogoMaterias.Text = "Editar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 116;
            this.label5.Text = "Correo:";
            // 
            // txtDocenteCorreo
            // 
            this.txtDocenteCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteCorreo.Location = new System.Drawing.Point(135, 343);
            this.txtDocenteCorreo.Name = "txtDocenteCorreo";
            this.txtDocenteCorreo.Size = new System.Drawing.Size(190, 20);
            this.txtDocenteCorreo.TabIndex = 115;
            this.txtDocenteCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocenteCorreo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 114;
            this.label3.Text = "Nombre:";
            // 
            // txtDocenteNombre
            // 
            this.txtDocenteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteNombre.Location = new System.Drawing.Point(135, 262);
            this.txtDocenteNombre.Name = "txtDocenteNombre";
            this.txtDocenteNombre.Size = new System.Drawing.Size(190, 20);
            this.txtDocenteNombre.TabIndex = 113;
            this.txtDocenteNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocenteNombre_KeyPress);
            // 
            // labelIIngresarValores
            // 
            this.labelIIngresarValores.AutoSize = true;
            this.labelIIngresarValores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIIngresarValores.Location = new System.Drawing.Point(25, 218);
            this.labelIIngresarValores.Name = "labelIIngresarValores";
            this.labelIIngresarValores.Size = new System.Drawing.Size(232, 16);
            this.labelIIngresarValores.TabIndex = 108;
            this.labelIIngresarValores.Text = " Nuevos datos para el docente:";
            // 
            // txtDocenteEmpleado
            // 
            this.txtDocenteEmpleado.Location = new System.Drawing.Point(135, 167);
            this.txtDocenteEmpleado.Name = "txtDocenteEmpleado";
            this.txtDocenteEmpleado.Size = new System.Drawing.Size(90, 20);
            this.txtDocenteEmpleado.TabIndex = 107;
            this.txtDocenteEmpleado.TextChanged += new System.EventHandler(this.txtDocenteEmpleado_TextChanged);
            this.txtDocenteEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocenteEmpleado_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "No. Empleado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 120;
            this.label7.Text = "Contraseña:";
            // 
            // txtDocentePass
            // 
            this.txtDocentePass.Enabled = false;
            this.txtDocentePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocentePass.Location = new System.Drawing.Point(134, 382);
            this.txtDocentePass.Name = "txtDocentePass";
            this.txtDocentePass.PasswordChar = '•';
            this.txtDocentePass.Size = new System.Drawing.Size(190, 20);
            this.txtDocentePass.TabIndex = 119;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(60, 460);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(225, 50);
            this.btnGuardar.TabIndex = 121;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 123;
            this.label2.Text = "Título académico:";
            // 
            // txtDocenteTitulo
            // 
            this.txtDocenteTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteTitulo.Location = new System.Drawing.Point(135, 303);
            this.txtDocenteTitulo.Name = "txtDocenteTitulo";
            this.txtDocenteTitulo.Size = new System.Drawing.Size(190, 20);
            this.txtDocenteTitulo.TabIndex = 122;
            this.txtDocenteTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocenteTitulo_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(232, 165);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 25);
            this.btnBuscar.TabIndex = 124;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormDocentesEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocenteTitulo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDocentePass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDocenteCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocenteNombre);
            this.Controls.Add(this.labelIIngresarValores);
            this.Controls.Add(this.txtDocenteEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCatálogoMaterias);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDocentesEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDocentesEditar_FormClosed);
            this.Load += new System.EventHandler(this.FormDocentesEditar_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.Label labelMaterias;
        private System.Windows.Forms.Label labelCatálogoMaterias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocenteCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocenteNombre;
        private System.Windows.Forms.Label labelIIngresarValores;
        private System.Windows.Forms.TextBox txtDocenteEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDocentePass;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocenteTitulo;
        private System.Windows.Forms.Button btnBuscar;
    }
}