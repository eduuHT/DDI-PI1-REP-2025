namespace UTApp.Forms.Docentes
{
    partial class FormDocentesEliminar
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocenteCorreo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocenteNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDocenteTitulo = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelCatálogoMaterias = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.botonOpciones = new System.Windows.Forms.PictureBox();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.txtDocenteEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 132;
            this.label5.Text = "Correo:";
            // 
            // txtDocenteCorreo
            // 
            this.txtDocenteCorreo.Enabled = false;
            this.txtDocenteCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteCorreo.Location = new System.Drawing.Point(133, 340);
            this.txtDocenteCorreo.Name = "txtDocenteCorreo";
            this.txtDocenteCorreo.Size = new System.Drawing.Size(190, 20);
            this.txtDocenteCorreo.TabIndex = 131;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(60, 420);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(225, 50);
            this.btnEliminar.TabIndex = 130;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 129;
            this.label3.Text = "Nombre:";
            // 
            // txtDocenteNombre
            // 
            this.txtDocenteNombre.Enabled = false;
            this.txtDocenteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteNombre.Location = new System.Drawing.Point(133, 260);
            this.txtDocenteNombre.Name = "txtDocenteNombre";
            this.txtDocenteNombre.Size = new System.Drawing.Size(190, 20);
            this.txtDocenteNombre.TabIndex = 128;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 125;
            this.label6.Text = "Título académico:";
            // 
            // txtDocenteTitulo
            // 
            this.txtDocenteTitulo.Enabled = false;
            this.txtDocenteTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteTitulo.Location = new System.Drawing.Point(133, 301);
            this.txtDocenteTitulo.Name = "txtDocenteTitulo";
            this.txtDocenteTitulo.Size = new System.Drawing.Size(190, 20);
            this.txtDocenteTitulo.TabIndex = 124;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(23, 221);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(223, 16);
            this.label.TabIndex = 123;
            this.label.Text = "Confirmar docente a eliminar:";
            // 
            // labelCatálogoMaterias
            // 
            this.labelCatálogoMaterias.AutoSize = true;
            this.labelCatálogoMaterias.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatálogoMaterias.ForeColor = System.Drawing.Color.Black;
            this.labelCatálogoMaterias.Location = new System.Drawing.Point(20, 120);
            this.labelCatálogoMaterias.Name = "labelCatálogoMaterias";
            this.labelCatálogoMaterias.Size = new System.Drawing.Size(100, 23);
            this.labelCatálogoMaterias.TabIndex = 120;
            this.labelCatálogoMaterias.Text = "Eliminar";
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
            this.panelHeader.TabIndex = 135;
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
            this.labelMaterias.Location = new System.Drawing.Point(119, 45);
            this.labelMaterias.Name = "labelMaterias";
            this.labelMaterias.Size = new System.Drawing.Size(110, 25);
            this.labelMaterias.TabIndex = 0;
            this.labelMaterias.Text = "Docentes";
            // 
            // txtDocenteEmpleado
            // 
            this.txtDocenteEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenteEmpleado.Location = new System.Drawing.Point(126, 170);
            this.txtDocenteEmpleado.Name = "txtDocenteEmpleado";
            this.txtDocenteEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtDocenteEmpleado.TabIndex = 133;
            this.txtDocenteEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocenteEmpleado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 134;
            this.label2.Text = "No. Empleado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(231, 168);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 25);
            this.btnBuscar.TabIndex = 136;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormDocentesEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocenteEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDocenteCorreo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocenteNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDocenteTitulo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelCatálogoMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDocentesEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDocentesEliminar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDocentesEliminar_FormClosed);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocenteCorreo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocenteNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDocenteTitulo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelCatálogoMaterias;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox botonOpciones;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.Label labelMaterias;
        private System.Windows.Forms.TextBox txtDocenteEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
    }
}