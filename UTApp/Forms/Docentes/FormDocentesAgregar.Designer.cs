namespace UTApp.Forms.Docentes
{
    partial class FormDocentesAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocentesAgregar));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocenteCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDocenteTitulo = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelCatálogoMaterias = new System.Windows.Forms.Label();
            this.txtDocenteNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocentePass = new System.Windows.Forms.TextBox();
            this.txtDocenteEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 100;
            this.label2.Text = "Correo";
            // 
            // txtDocenteCorreo
            // 
            this.txtDocenteCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteCorreo.Location = new System.Drawing.Point(60, 325);
            this.txtDocenteCorreo.Name = "txtDocenteCorreo";
            this.txtDocenteCorreo.Size = new System.Drawing.Size(225, 20);
            this.txtDocenteCorreo.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 94;
            this.label6.Text = "Título académico";
            // 
            // txtDocenteTitulo
            // 
            this.txtDocenteTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteTitulo.Location = new System.Drawing.Point(60, 274);
            this.txtDocenteTitulo.Name = "txtDocenteTitulo";
            this.txtDocenteTitulo.Size = new System.Drawing.Size(225, 20);
            this.txtDocenteTitulo.TabIndex = 93;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(60, 248);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 92;
            this.Nombre.Text = "Nombre";
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
            this.btnGuardar.TabIndex = 90;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelCatálogoMaterias
            // 
            this.labelCatálogoMaterias.AutoSize = true;
            this.labelCatálogoMaterias.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatálogoMaterias.ForeColor = System.Drawing.Color.Black;
            this.labelCatálogoMaterias.Location = new System.Drawing.Point(20, 120);
            this.labelCatálogoMaterias.Name = "labelCatálogoMaterias";
            this.labelCatálogoMaterias.Size = new System.Drawing.Size(95, 23);
            this.labelCatálogoMaterias.TabIndex = 89;
            this.labelCatálogoMaterias.Text = "Agregar";
            // 
            // txtDocenteNombre
            // 
            this.txtDocenteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteNombre.Location = new System.Drawing.Point(60, 227);
            this.txtDocenteNombre.Name = "txtDocenteNombre";
            this.txtDocenteNombre.Size = new System.Drawing.Size(225, 20);
            this.txtDocenteNombre.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 104;
            this.label3.Text = "Contraseña";
            // 
            // txtDocentePass
            // 
            this.txtDocentePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocentePass.Location = new System.Drawing.Point(60, 377);
            this.txtDocentePass.Name = "txtDocentePass";
            this.txtDocentePass.Size = new System.Drawing.Size(225, 20);
            this.txtDocentePass.TabIndex = 103;
            // 
            // txtDocenteEmpleado
            // 
            this.txtDocenteEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteEmpleado.Location = new System.Drawing.Point(60, 176);
            this.txtDocenteEmpleado.Name = "txtDocenteEmpleado";
            this.txtDocenteEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtDocenteEmpleado.TabIndex = 101;
            this.txtDocenteEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocenteEmpleado_KeyPress);
            this.txtDocenteEmpleado.Leave += new System.EventHandler(this.txtDocenteEmpleado_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 102;
            this.label1.Text = "No. Empleado";
            // 
            // FormDocentesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocentePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocenteEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocenteCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDocenteTitulo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtDocenteNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelCatálogoMaterias);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDocentesAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Docente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDocentesAgregar_FormClosed);
            this.Load += new System.EventHandler(this.FormDocentesAgregar_Load);
            this.Click += new System.EventHandler(this.FormDocentesAgregar_Click);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocenteCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDocenteTitulo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelCatálogoMaterias;
        private System.Windows.Forms.TextBox txtDocenteNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocentePass;
        private System.Windows.Forms.TextBox txtDocenteEmpleado;
        private System.Windows.Forms.Label label1;
    }
}